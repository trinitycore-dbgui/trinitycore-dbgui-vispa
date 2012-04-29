using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace TrinityCore_DBGUI
{
    public partial class frmMain : Form
    {

        public TrinityCore_DBGUI_Library.TrinityCoreDBGUI_Controller trinityCoreController = new TrinityCore_DBGUI_Library.TrinityCoreDBGUI_Controller();
            
        public frmMain()
        {
            InitializeComponent();
            this.menuStrip1.MdiWindowListItem = mnuWindow;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /* Display version number in application window title */
            Version CurVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "TrinityCore-DBGUI [Build " + CurVer.Major + "." + CurVer.Minor + "." + CurVer.Revision + "]";

            this.lblStatus.Text = "Loading DB References ...";

            String dbrefFile = Application.StartupPath + @"\conf\dbrefs.cfg";

            this.trinityCoreController.dbRef.LoadDBRefConfig(dbrefFile);
            this.lblStatus.Text = "Idle.";

            this.IsDisconnected();
        }

        private void LoadGUIConfig()
        {

            if (!File.Exists(@"conf\gui.cfg"))
                return;


            using (StreamReader sr = new StreamReader(@"conf\gui.cfg"))
            {
                String line;
                int cLine = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    cLine++;

                    if ((cLine == 1) && (line != "gui.config.begin"))
                        return; /* invalid or corrupt config file */

                    string[] cfgLine = line.Split('^');
                    //search.add^Game Items^conf\search_gameitem.cfg
                    if (cfgLine[0] == "search.add")
                    {
                        MenuItem mItem = new MenuItem(cfgLine[1]);

                        mItem.Tag = cfgLine[2];
                    }

                }
            }
        }

        private void connectToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectToServerToolStripMenuItem.Text == "Connect to Server")
            {
                frmConnect fConnect = new frmConnect();
                fConnect.MdiParent = this;
                fConnect.Show();
            }
            else
            {
                if (this.trinityCoreController.authDb.Disconnect() == true && this.trinityCoreController.worldDb.Disconnect() == true && this.trinityCoreController.characterDb.Disconnect() == true && this.trinityCoreController.dbLister.Disconnect() == true)
                {
                    this.IsDisconnected();
                }
                else
                {
                    MessageBox.Show("Error occured trying to disconnect, please close and reopen TrinityCore-DBGUI", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


        }

        public void IsDisconnected()
        {
            this.mnuSearch.Enabled = false;
            //this.mnuEdit.Enabled = false;
            this.connectToServerToolStripMenuItem.Text = "Connect to Server";

            this.lblAuthDB.Text = "Auth DB: Disconnected";
            this.lblCharacterDB.Text = "Char DB: Disconnected";
            this.lblWorldDB.Text = "World DB: Disconnected";
        }

        public void IsConnected()
        {
            this.mnuSearch.Enabled = true;
            //this.mnuEdit.Enabled = true;
            this.connectToServerToolStripMenuItem.Text = "Disconnect";

            this.lblAuthDB.Text = "Auth DB: Connected";
            this.lblCharacterDB.Text = "Char DB: Connected";
            this.lblWorldDB.Text = "World DB: Connected";

        }
               

        private void gameItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fSearch = new frmSearch();
            fSearch.MdiParent = this;
            fSearch.ConfigureSearch(@"conf\search_gameitem.cfg");
            fSearch.Show();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckForUpdates fChkUpd = new frmCheckForUpdates();
            fChkUpd.MdiParent = this;
            fChkUpd.Show();
            fChkUpd.PerformUpdateCheck();
        }

        private void databaseReferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdbRefs fdbRef = new frmdbRefs();
            fdbRef.MdiParent = this;
            fdbRef.Show();
        }

        private void nPCsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fSearch = new frmSearch();
            fSearch.MdiParent = this;
            fSearch.ConfigureSearch(@"conf\search_npc.cfg");

            try
            {
                fSearch.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void questsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch fSearch = new frmSearch();
            fSearch.MdiParent = this;
            fSearch.ConfigureSearch(@"conf\search_quest.cfg");

            try
            {
                fSearch.Show();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
