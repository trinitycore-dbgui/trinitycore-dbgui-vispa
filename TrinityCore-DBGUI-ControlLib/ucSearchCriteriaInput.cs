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

            

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            ucSearchCriteriaItem uItem = new ucSearchCriteriaItem();

            String SearchCrit = "";
            String ActualSQL = "";

            if (this.CurrentInputObject == null)
                return;

            if (this.CurrentInputObject.GetType() == typeof(TextBox))
            {
                TextBox tBox = (TextBox)this.CurrentInputObject;
                SearchCrit = tBox.Text;
                //ActualSQL = this.cboCriteriaID.Text + " LIKE '" + SearchCrit + "'";
                ActualSQL = this.cboCriteriaID.Text + " " + this.cboLogic.Text + " '" + SearchCrit + "'";
            }
            else if (this.CurrentInputObject.GetType() == typeof(ComboBox))
            {
                ComboBox cBox = (ComboBox)this.CurrentInputObject;
                SearchCrit = cBox.Text;

                //string[] words = s.Split(' ');
                string[] id = SearchCrit.Split(':');
                //ActualSQL = this.cboCriteriaID.Text + "='" + id[0] + "'";
                ActualSQL = this.cboCriteriaID.Text + " " + this.cboLogic.Text + " '" + id[0] + "'";

            }

            uItem.SetCriteriaText(this.cboCriteriaID.Text + " " + this.cboLogic.Text + " " + SearchCrit);
            uItem.ActualCriteriaSQL = ActualSQL;

            if (this.RequestedAddCriteria != null)
                this.RequestedAddCriteria(uItem);
        }

    }
}
