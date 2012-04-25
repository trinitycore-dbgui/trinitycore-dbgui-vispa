using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace TrinityCore_DBGUI
{
    public partial class frmConnect : Form
    {

        Boolean HasPopulatedDbs = false;

        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDatabaseHostname_Enter(object sender, EventArgs e)
        {
            this.format_textbox_focus("database hostname", txtDatabaseHostname);
        }

        private void txtDatabaseHostname_Leave(object sender, EventArgs e)
        {
            this.format_textbox_lostfocus("database hostname", txtDatabaseHostname);
        }

        private void txtDatabasePort_Enter(object sender, EventArgs e)
        {
            this.format_textbox_focus("port", txtDatabasePort);
        }

        private void txtDatabasePort_Leave(object sender, EventArgs e)
        {
            this.format_textbox_lostfocus("port", txtDatabasePort);
        }

        private void txtDatabaseUsername_Enter(object sender, EventArgs e)
        {
            this.format_textbox_focus("database username", txtDatabaseUsername);
        }

        private void txtDatabaseUsername_Leave(object sender, EventArgs e)
        {
            this.format_textbox_lostfocus("database username", txtDatabaseUsername);
        }

        private void txtDatabasePassword_Enter(object sender, EventArgs e)
        {
            this.format_textbox_focus("database password", txtDatabasePassword);
        }

        private void txtDatabasePassword_Leave(object sender, EventArgs e)
        {
            this.format_textbox_lostfocus("database password", txtDatabasePassword);
        }


        private void format_textbox_focus(String defaultText, TextBox tBox)
        {
            if (tBox.Text == defaultText)
            {
                tBox.Text = "";
                tBox.Font = new Font(tBox.Font, FontStyle.Regular);
                tBox.ForeColor = Color.Black;
            }
        }



        private void format_textbox_lostfocus(String defaultText, TextBox tBox)
        {
            if (tBox.Text == "")
            {
                tBox.Text = defaultText;
                tBox.Font = new Font(tBox.Font, FontStyle.Italic);
                tBox.ForeColor = Color.Silver;
            }
        }


        private void frmConnect_Load(object sender, EventArgs e)
        {

        }

        private void PopulateCombos()
        {

            if (this.HasPopulatedDbs == true)
                return;

            frmMain fMain = (frmMain)this.MdiParent;

            fMain.trinityCoreController.DatabaseHostname = this.txtDatabaseHostname.Text;
            fMain.trinityCoreController.DatabaseUsername = this.txtDatabaseUsername.Text;
            fMain.trinityCoreController.DatabasePassword = this.txtDatabasePassword.Text;

            try
            {
                fMain.trinityCoreController.DatabasePort = Int32.Parse(this.txtDatabasePort.Text);
            }
            catch (Exception ex)
            {
                fMain.trinityCoreController.DatabasePort = 3306;
            }

            

            ArrayList dbList = fMain.trinityCoreController.GetDatabaseList();

            if (dbList.Count < 1)
                return;

            this.cboAuthDB.Items.Clear();
            this.cboCharDB.Items.Clear();
            this.cboWorldDB.Items.Clear();

            for (int i = 0; i < dbList.Count; i++)
            {
                this.cboAuthDB.Items.Add(dbList[i].ToString());
                this.cboCharDB.Items.Add(dbList[i].ToString());
                this.cboWorldDB.Items.Add(dbList[i].ToString());

            }

            HasPopulatedDbs = true;
        }

        private void cboAuthDB_Click(object sender, EventArgs e)
        {
            this.PopulateCombos();
        }

        private void cboWorldDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCharDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            this.HasPopulatedDbs = false;
            this.PopulateCombos();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            this.HasPopulatedDbs = false;
            this.PopulateCombos();
        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            this.HasPopulatedDbs = false;
            this.PopulateCombos();
        }

        private void SaveCurrentSettings()
        {
            /* save current settings to file for later use (everything bar password) */
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            frmMain fMain = (frmMain)this.MdiParent;

            try
            {
                fMain.trinityCoreController.AuthDB = this.cboAuthDB.Text;
                fMain.trinityCoreController.CharDB = this.cboCharDB.Text;
                fMain.trinityCoreController.WorldDB = this.cboWorldDB.Text;

                fMain.trinityCoreController.ConnectToAuthDB();
                fMain.trinityCoreController.ConnectToCharacterDb();
                fMain.trinityCoreController.ConnectToWorldDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to one of your databases.  Please check your settings and try again." + Environment.NewLine + "Error: " + ex.Message, "Error:", MessageBoxButtons.OK);
                return;
            }


            fMain.IsConnected();

            this.Close();

        }


    }
}
