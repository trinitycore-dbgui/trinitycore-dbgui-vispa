using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

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

                /* check if password field */
                if (tBox.Tag != null)
                {
                    if ((String)tBox.Tag == "password.field")
                    {
                        tBox.PasswordChar = '*';
                    }
                }

            }

        }



        private void format_textbox_lostfocus(String defaultText, TextBox tBox)
        {
            if (tBox.Text == "")
            {
                tBox.Text = defaultText;
                tBox.Font = new Font(tBox.Font, FontStyle.Italic);
                tBox.ForeColor = Color.Silver;

                /* check if password field */
                if (tBox.Tag != null)
                {
                    if ((String)tBox.Tag == "password.field")
                    {
                        tBox.PasswordChar = (char)0;
                    }
                }

            }

            this.PopulateCombos();
        }


        private void frmConnect_Load(object sender, EventArgs e)
        {
            this.LoadSavedSettings();
            this.HasPopulatedDbs = true;
        }

        private void PopulateCombos()
        {

            if (this.HasPopulatedDbs == true)
                return;

            if (this.txtDatabaseHostname.Text == "database hostname" || this.txtDatabasePort.Text == "port" || this.txtDatabaseUsername.Text == "database username")
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


            this.Cursor = Cursors.WaitCursor;
            ArrayList dbList = fMain.trinityCoreController.GetDatabaseList();
            this.Cursor = Cursors.Default;

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

        private void LoadSavedSettings()
        {
            /* load saved settings into connection info */

            if (!File.Exists("tcdb.cfg"))
                return;

            this.cboAuthDB.Items.Clear();
            this.cboWorldDB.Items.Clear();
            this.cboCharDB.Items.Clear();

            frmMain fMain = (frmMain)this.MdiParent;

            using (StreamReader sr = new StreamReader("tcdb.cfg"))
            {
                String line;
                int cLine = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    cLine++;

                    if ((cLine == 1) && (line != "config.begin"))
                        return; /* invalid or corrupt config file */

                    string[] cfgLine = line.Split(':');

                    if (cfgLine[0] == "db.hostname")
                    {
                        this.txtDatabaseHostname_Enter(this.txtDatabaseUsername, new EventArgs());
                        this.txtDatabaseHostname.Text = cfgLine[1];
                        fMain.trinityCoreController.DatabaseHostname = cfgLine[1];
                    }


                    if (cfgLine[0] == "db.port")
                    {
                        this.txtDatabasePort_Enter(this.txtDatabasePort, new EventArgs());
                        this.txtDatabasePort.Text = cfgLine[1];
                        fMain.trinityCoreController.DatabasePort = int.Parse(cfgLine[1]);
                        
                    }

                    if (cfgLine[0] == "db.user")
                    {
                        this.txtDatabaseUsername_Enter(this.txtDatabaseUsername, new EventArgs());
                        this.txtDatabaseUsername.Text = cfgLine[1];
                        fMain.trinityCoreController.DatabaseUsername = cfgLine[1];
                    }

                    if (cfgLine[0] == "db.pwd")
                    {
                        this.txtDatabasePassword_Enter(this.txtDatabasePassword, new EventArgs());
                        this.txtDatabasePassword.Text = cfgLine[1];
                        fMain.trinityCoreController.DatabasePassword = cfgLine[1];
                    }

                    if (cfgLine[0] == "remember.password")
                    {
                        this.chkRememberMyPassword.Checked = bool.Parse(cfgLine[1]);
                    }

                    if (cfgLine[0] == "db.found")
                    {
                        this.cboAuthDB.Items.Add(cfgLine[1]);
                        this.cboCharDB.Items.Add(cfgLine[1]);
                        this.cboWorldDB.Items.Add(cfgLine[1]);
                    }

                    if (cfgLine[0] == "db.auth")
                        this.cboAuthDB.SelectedIndex = int.Parse(cfgLine[1]);

                    if (cfgLine[0] == "db.char")
                        this.cboCharDB.SelectedIndex = int.Parse(cfgLine[1]);

                    if (cfgLine[0] == "db.world")
                        this.cboWorldDB.SelectedIndex = int.Parse(cfgLine[1]);

                    if (cfgLine[0] == "config.end")
                    {
                        sr.Close();
                        return;
                    }
                }

                sr.Close();
            }


        }

        private void SaveCurrentSettings()
        {
            /* save current settings to file for later use (everything bar password) */

            TextWriter tw = new StreamWriter("tcdb.cfg");

            tw.WriteLine("config.begin");

            // write a line of text to the file
            tw.WriteLine("db.hostname:" + this.txtDatabaseHostname.Text);
            tw.WriteLine("db.port:" + this.txtDatabasePort.Text);
            tw.WriteLine("db.user:" + this.txtDatabaseUsername.Text);

            if (this.chkRememberMyPassword.Checked == true)
            {
                tw.WriteLine("db.pwd:" + this.txtDatabasePassword.Text);
                tw.WriteLine("remember.password:true");
            }
            else
            {
                tw.WriteLine("remember.password:false");
            }

            foreach (String dbName in this.cboAuthDB.Items)
            {
                tw.WriteLine("db.found:" + dbName);
            }

            tw.WriteLine("db.auth:" + this.cboAuthDB.SelectedIndex);
            tw.WriteLine("db.char:" + this.cboCharDB.SelectedIndex);
            tw.WriteLine("db.world:" + this.cboWorldDB.SelectedIndex);

            tw.WriteLine("config.end");

            // close the stream
            tw.Close();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            frmMain fMain = (frmMain)this.MdiParent;

            try
            {
                fMain.trinityCoreController.AuthDB = this.cboAuthDB.Text;
                fMain.trinityCoreController.CharDB = this.cboCharDB.Text;
                fMain.trinityCoreController.WorldDB = this.cboWorldDB.Text;

                fMain.trinityCoreController.DatabaseHostname = this.txtDatabaseHostname.Text;
                fMain.trinityCoreController.DatabaseUsername = this.txtDatabaseUsername.Text;
                fMain.trinityCoreController.DatabasePassword = this.txtDatabasePassword.Text;

                this.Cursor = Cursors.WaitCursor;
                fMain.trinityCoreController.ConnectToAuthDB();
                fMain.trinityCoreController.ConnectToCharacterDb();
                fMain.trinityCoreController.ConnectToWorldDB();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to one of your databases.  Please check your settings and try again." + Environment.NewLine + "Error: " + ex.Message, "Error:", MessageBoxButtons.OK);
                return;
            }

            /* save settings */
            this.SaveCurrentSettings();

            fMain.IsConnected();

            this.Close();

        }


    }
}
