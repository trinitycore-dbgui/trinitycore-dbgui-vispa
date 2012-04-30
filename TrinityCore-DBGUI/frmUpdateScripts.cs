using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using System.Net;

namespace TrinityCore_DBGUI
{
    public partial class frmUpdateScripts : Form
    {

        public frmUpdateScripts()
        {
            InitializeComponent();
        }

        private void frmUpdateScripts_Load(object sender, EventArgs e)
        {
        }

        public void PopulateUpdateList()
        {
            WebClient wcListScripts = new WebClient();
            wcListScripts.DownloadFile("http://updates.trinitycore-dbgui.info/scripts.lst", @"conf\scripts.lst");


            using (StreamReader sr = new StreamReader(@"conf\scripts.lst"))
            {
                String line;
                int cLine = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    cLine++;

                    if ((cLine == 1) && (line != "script.list.begin"))
                        return; /* invalid or corrupt config file */

                    string[] cfgLine = line.Split(':');

                    if (cfgLine[0] == "script.add")
                    {
                        lstUpdateResults.Items.Add(cfgLine[1] + " : " + cfgLine[2]);
                    }

                }
            }

            if (this.lstUpdateResults.Items.Count < 1)
            {
                MessageBox.Show("There are no scripts to update.", "No Updates Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (this.lstUpdateResults.Items.Count < 1)
                return;

            int iupdcount = this.lstUpdateResults.Items.Count;

            for (int i = 0; i < iupdcount; i++)
            {

                String ScriptFile = this.lstUpdateResults.Items[i].ToString();

                String[] FileStrs = ScriptFile.Split(':');

                String LocalFileName = FileStrs[0];
                String FileVersion = FileStrs[1];

                WebClient wcUpdater = new WebClient();

                String LocalFileWithPath = Application.StartupPath + @"\conf\" + LocalFileName;

                if (File.Exists(LocalFileWithPath))
                {

                    try
                    {
                        File.Delete(Application.StartupPath + @"\conf\" + LocalFileName + ".bak");
                    }
                    catch (Exception ex)
                    {

                    }

                    File.Move(Application.StartupPath + @"\conf\" + LocalFileName, Application.StartupPath + @"\conf\" + LocalFileName + ".bak");
                }

                wcUpdater.DownloadFile("http://updates.trinitycore-dbgui.info/" + LocalFileName, Application.StartupPath + @"\conf\" + LocalFileName);

            }

            MessageBox.Show("All scripts have been updated.  Please restart your GUI for configuration to reload successfully.", "Update Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
