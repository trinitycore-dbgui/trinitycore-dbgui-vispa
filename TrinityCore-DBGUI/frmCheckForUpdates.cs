using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;

using TrinityCore_DBGUI_Library;

namespace TrinityCore_DBGUI
{
    public partial class frmCheckForUpdates : Form
    {

        AutoUpdater aUpdater = new AutoUpdater();

        public frmCheckForUpdates()
        {
            InitializeComponent();
            this.aUpdater.UpdateCheckComplete +=new AutoUpdater.UpdateCheckDone(aUpdater_UpdateCheckComplete);
            this.aUpdater.UpdateDownloadProgressed += new AutoUpdater.UpdateDownloadProgressChanged(aUpdater_UpdateDownloadProgressed);
            this.aUpdater.UpdateFileDownloaded += new AutoUpdater.DownloadFileDone(aUpdater_UpdateFileDownloaded);
        }

        private void aUpdater_UpdateDownloadProgressed(DownloadProgressChangedEventArgs DPArgs)
        {
            this.pBarDownload.Value = DPArgs.ProgressPercentage;
            this.lblStatus.Text = "Downloading update file, please wait ... (" + DPArgs.ProgressPercentage.ToString() + "%)";
        }

        private void aUpdater_UpdateFileDownloaded(String newFileName)
        {
            System.Diagnostics.Process.Start(newFileName);
            Application.Exit();
        }

        private void aUpdater_UpdateCheckComplete()
        {
            this.lblLatestVersion.Text = this.aUpdater.LatestVersionMajor + "." + this.aUpdater.LatestVersionMinor + "." + this.aUpdater.LatestVersionRevision;
            this.lblReleasedDate.Text = "(Released: " + this.aUpdater.LatestVersionReleaseDay + "/" + this.aUpdater.LatestVersionReleaseMonth + "/" + this.aUpdater.LatestVersionReleaseYear + ")";

            if (this.aUpdater.IsUpdateAvailable == true)
            {
                this.btnDownloadInstallLatest.Visible = true;
                this.lblStatus.Text = "A newer version of TrinityCore-DBGUI is available than your installed version.  Click to install now!";
            }
            else
            {
                this.btnDownloadInstallLatest.Visible = false;
                this.lblStatus.Text = "You are currently using the latest version of TrinityCore-DBGUI";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCheckForUpdates_Load(object sender, EventArgs e)
        {
            Version curVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            this.lblInstalledVersion.Text = curVer.Major + "." + curVer.Minor + "." + curVer.Revision;
        }

        public void PerformUpdateCheck()
        {
            this.aUpdater.BeginUpdateCheck(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void btnDownloadInstallLatest_Click(object sender, EventArgs e)
        {
            this.btnDownloadInstallLatest.Visible = false;
            this.pBarDownload.Visible = true;
            this.lblStatus.Text = "Downloading update file, please wait ...";

            this.aUpdater.BeginUpdateDownload();
        }
    }
}
