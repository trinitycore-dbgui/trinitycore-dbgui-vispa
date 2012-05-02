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
using System.Collections.Specialized;

using TrinityCore_DBGUI_Library;

namespace TrinityCore_DBGUI
{
    public partial class frmEdit : Form
    {

        EditorConfiguration iEditConfig;

        public frmEdit()
        {
            InitializeComponent();
       }

        public void iEditConfig_EditorButtonClicked(String EditorButtonFunction)
        {
            if (EditorButtonFunction == "closeeditor")
                this.Close();
        }

        public void ConfigureEditor(String EditorCfgFile)
        {

            if (!File.Exists(EditorCfgFile))
            {
                MessageBox.Show("Cannot locate search configuration file: " + EditorCfgFile, "Editor Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }

            frmMain fMain = (frmMain)this.MdiParent;
            this.iEditConfig = new EditorConfiguration(fMain.trinityCoreController);

            this.iEditConfig.LoadSearchConfig(EditorCfgFile);

            /* add criterias */

            if (this.iEditConfig.EditorTabs.Count > 0)
            {
                foreach (DictionaryEntry dTab in this.iEditConfig.EditorTabs)
                {
                    this.tabMain.TabPages.Add((TabPage)dTab.Value);
                }
            }

            /* set editor title */
            this.Text = "Edit - [" + this.iEditConfig.EditorTitle + "]";
            this.Width = this.iEditConfig.EditorWidth;
            this.Height = this.iEditConfig.EditorHeight;

            this.tabMain.Width = this.Width - 30;
            this.tabMain.Height = this.Height - 50;

            this.iEditConfig.EditorButtonClicked += new EditorConfiguration.ButtonClicked(iEditConfig_EditorButtonClicked);
 
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
