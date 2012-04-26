using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace TrinityCore_DBGUI_ControlLib
{
    public partial class ucSearchCriteriaInput : UserControl
    {

        /* events */

        public delegate void AddCriteria(ucSearchCriteriaItem uCriteriaItem);
        public event AddCriteria RequestedAddCriteria;

        public HybridDictionary CriteriaList = new HybridDictionary(); //   CriteriaList = new ArrayList();
        public object CurrentInputObject;
        public object CurrentInputObject2;

        public ucSearchCriteriaInput()
        {
            InitializeComponent();

            this.cboLogic.Items.Add("=");
            this.cboLogic.Items.Add(">");
            this.cboLogic.Items.Add("<");
            this.cboLogic.Items.Add(">=");
            this.cboLogic.Items.Add("<=");
            this.cboLogic.Items.Add("!=");
            this.cboLogic.Items.Add("!<");
            this.cboLogic.Items.Add("!>");

            this.cboLogic.Items.Add("LIKE");
            this.cboLogic.Items.Add("NOT LIKE");

            this.cboLogic.Items.Add("BETWEEN");

            this.cboLogic.SelectedIndex = 0;
        
        }

        public void AddCriteriaType(String ID, CriteriaRequester.CriteriaType cType)
        {
            this.CriteriaList.Add(ID, new CriteriaRequester(cType, ID));
            this.cboCriteriaID.Items.Add(ID);
        }

        public void AddCriteriaType(CriteriaRequester cRequester)
        {
            this.CriteriaList.Add(cRequester.ID, cRequester);
            this.cboCriteriaID.Items.Add(cRequester.ID);
        }

        private void cboCriteriaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblID.Text = cboCriteriaID.Text;

            CriteriaRequester cReq = (CriteriaRequester)this.CriteriaList[this.cboCriteriaID.Text];

            this.pnlCriteriaInput.Controls.Clear();

            if (cReq.CritType == CriteriaRequester.CriteriaType.Text)
            {
                TextBox txtSearchCriteriaInput = new TextBox();
                this.pnlCriteriaInput.Controls.Add(txtSearchCriteriaInput);
                txtSearchCriteriaInput.Width = this.pnlCriteriaInput.Width - 10;
                txtSearchCriteriaInput.Show();
                this.CurrentInputObject = txtSearchCriteriaInput;
            }
            else if (cReq.CritType == CriteriaRequester.CriteriaType.DropDown)
            {
                ComboBox cBox = new ComboBox();
                this.pnlCriteriaInput.Controls.Add(cBox);
                cBox.Width = this.pnlCriteriaInput.Width - 10;
                cBox.DropDownStyle = ComboBoxStyle.DropDownList;

                foreach (String ID in cReq.DropDownContent)
                {
                    cBox.Items.Add(ID);
                }

                cBox.Show();
                this.CurrentInputObject = cBox;
            }

            this.cboLogic_SelectedIndexChanged(this, new EventArgs());

        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            ucSearchCriteriaItem uItem = new ucSearchCriteriaItem();

            String SearchCrit = "";
            String SearchCrit2 = "";
            String ActualSQL = "";

            if (this.CurrentInputObject == null)
                return;

            if (this.CurrentInputObject.GetType() == typeof(TextBox))
            {
                TextBox tBox = (TextBox)this.CurrentInputObject;
                SearchCrit = tBox.Text;

                if (this.cboLogic.Text == "BETWEEN")
                {
                    TextBox tBox2 = (TextBox)this.CurrentInputObject2;
                    SearchCrit2 = tBox2.Text;
                    ActualSQL = this.cboCriteriaID.Text + " " + this.cboLogic.Text + " '" + SearchCrit + "' AND '" + SearchCrit2 + "'";
                }
                else
                {
                    ActualSQL = this.cboCriteriaID.Text + " " + this.cboLogic.Text + " '" + SearchCrit + "'";
                }

            }
            else if (this.CurrentInputObject.GetType() == typeof(ComboBox))
            {
                ComboBox cBox = (ComboBox)this.CurrentInputObject;
                SearchCrit = cBox.Text;

                if (this.cboLogic.Text == "BETWEEN")
                {
                    ComboBox cBox2 = (ComboBox)this.CurrentInputObject2;
                    SearchCrit2 = cBox2.Text;

                    string[] id = SearchCrit.Split(':');
                    string[] id2 = SearchCrit2.Split(':');

                    ActualSQL = this.cboCriteriaID.Text + " " + this.cboLogic.Text + " '" + id[0] + "' AND '" + id2[0] + "'";
                }
                else
                {
                    string[] id = SearchCrit.Split(':');
                    ActualSQL = this.cboCriteriaID.Text + " " + this.cboLogic.Text + " '" + id[0] + "'";
                }

            }

            if (this.cboLogic.Text == "BETWEEN")
            {
                uItem.SetCriteriaText(this.cboCriteriaID.Text + " " + this.cboLogic.Text + " " + SearchCrit + " AND " + SearchCrit2);
            }
            else
            {
                uItem.SetCriteriaText(this.cboCriteriaID.Text + " " + this.cboLogic.Text + " " + SearchCrit);
            }

            uItem.ActualCriteriaSQL = ActualSQL;

            if (this.RequestedAddCriteria != null)
                this.RequestedAddCriteria(uItem);
        }

        private void cboLogic_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cboLogic.Text == "BETWEEN")
            {
                /* make an exact copy of the current input control and place it next to the other */

                if (this.CurrentInputObject.GetType() == typeof(TextBox))
                {
                    TextBox tBox1 = (TextBox)this.CurrentInputObject;
                    TextBox tBox2 = new TextBox();

                    tBox1.Width = (this.pnlCriteriaInput.Width - 10) / 2;
                    tBox2.Width = (this.pnlCriteriaInput.Width - 10) / 2;

                    tBox2.Left = tBox1.Left + tBox1.Width + 5;

                    this.CurrentInputObject2 = tBox2;

                    this.pnlCriteriaInput.Controls.Add(tBox2);
                    tBox2.Show();
                }
                else if (this.CurrentInputObject.GetType() == typeof(ComboBox))
                {
                    ComboBox cBox1 = (ComboBox)this.CurrentInputObject;
                    ComboBox cBox2 = new ComboBox();

                    cBox1.Width = (this.pnlCriteriaInput.Width - 10) / 2;
                    cBox2.Width = (this.pnlCriteriaInput.Width - 10) / 2;

                    cBox2.Left = cBox2.Left + cBox2.Width + 5;

                    cBox2.DropDownStyle = cBox1.DropDownStyle;

                    this.CurrentInputObject2 = cBox2;

                    foreach (String cboItem in cBox1.Items)
                    {
                        cBox2.Items.Add(cboItem);
                    }

                    cBox2.SelectedIndex = cBox1.SelectedIndex;

                    this.pnlCriteriaInput.Controls.Add(cBox2);
                    cBox2.Show();
                }
            }
            else
            {
                /* not between */
                if (this.CurrentInputObject2 != null)
                {
                    /* this implies that the inputcriteria was setup for between/range, but now does not need to be */
                    this.pnlCriteriaInput.Controls.Clear();
                    // now call the initial combobox selector setup 

                    this.CurrentInputObject2 = null;
                    this.cboCriteriaID_SelectedIndexChanged(this, new EventArgs());

                }
            }

        }

    }
}
