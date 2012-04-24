using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



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
            this.Text = "TrinityCore-DBGUI [Build " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version + "]";

            this.IsDisconnected();
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
            this.mnuEdit.Enabled = false;
            this.connectToServerToolStripMenuItem.Text = "Connect to Server";

            this.lblAuthDB.Text = "Auth DB: Disconnected";
            this.lblCharacterDB.Text = "Char DB: Disconnected";
            this.lblWorldDB.Text = "World DB: Disconnected";
        }

        public void IsConnected()
        {
            this.mnuSearch.Enabled = true;
            this.mnuEdit.Enabled = true;
            this.connectToServerToolStripMenuItem.Text = "Disconnect";

            this.lblAuthDB.Text = "Auth DB: Connected";
            this.lblCharacterDB.Text = "Char DB: Connected";
            this.lblWorldDB.Text = "World DB: Connected";

        }
               

        private void gameItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGameItemSearch gSearch = new frmGameItemSearch();
            gSearch.MdiParent = this;
            gSearch.Show();
        }
    }
}
