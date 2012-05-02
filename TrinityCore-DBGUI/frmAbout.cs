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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        String[] Creds = new String[9];
        int curIdxStart = 0;

        private void frmAbout_Load(object sender, EventArgs e)
        {

            /* set ver */
            Version CurVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            this.lblVersion.Text = "v" + CurVer.Major + "." + CurVer.Minor + "." + CurVer.Revision;

            Creds[0] = "*** TrinityCore-DBGUI ***";
            Creds[1] = Environment.NewLine;
            Creds[2] = "Core Team";
            Creds[3] = "anthonym ... founder/core engineer";
            Creds[4] = "anthonym@trinitycore-dbgui.info";
            Creds[5] = Environment.NewLine;
            Creds[6] = "Discovered ... database advisor";
            Creds[7] = "Discovered@trinitycore-dbgui.info";
            Creds[8] = Environment.NewLine;

            this.ScrollCredits();
        }


        private void ScrollCredits()
        {

            this.lblCredits.Text = "";

            this.curIdxStart++;

            if (this.curIdxStart > (Creds.Length-1))
                this.curIdxStart = 0;

            this.lblCredits.Text = Creds[this.curIdxStart];


            // now, add the remaining lines

            int remainID = this.curIdxStart;

            for (int z = 0; z < (Creds.Length - 1); z++)
            {

                remainID++;

                if (remainID > (Creds.Length-1))
                    remainID=0;

                this.lblCredits.Text += Environment.NewLine + Creds[remainID];

            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrScrollCredits_Tick(object sender, EventArgs e)
        {
            this.ScrollCredits();
        }

        private void lnkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.lnkLabelSite.Text);
        }

    }
}
