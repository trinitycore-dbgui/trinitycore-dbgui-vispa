using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;

namespace TrinityCore_DBGUI_Library
{
    public class AutoUpdater
    {

        public WebClient wcChecker = new WebClient();
        public WebClient wcDownloader = new WebClient();

        public String LatestVersionMajor;
        public String LatestVersionMinor;
        public String LatestVersionRevision;

        public String LatestVersionReleaseDay;
        public String LatestVersionReleaseMonth;
        public String LatestVersionReleaseYear;

        public Version InstalledVersion;

        public String LatestVersionDownloadURL;

        public Boolean IsUpdateAvailable = false;
        

        public delegate void UpdateCheckDone();
        public event UpdateCheckDone UpdateCheckComplete;

        public delegate void UpdateCheckProgressChanged(DownloadProgressChangedEventArgs DPArgs);
        public event UpdateCheckProgressChanged UpdateCheckProgressed;

        public delegate void DownloadFileDone(String DownloadedFileName);
        public event DownloadFileDone UpdateFileDownloaded;

        public delegate void UpdateDownloadProgressChanged(DownloadProgressChangedEventArgs DPArgs);
        public event UpdateDownloadProgressChanged UpdateDownloadProgressed;


        public AutoUpdater()
        {
            this.wcChecker.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(UpdateCheckCompleted);
            this.wcChecker.DownloadProgressChanged += new DownloadProgressChangedEventHandler(UpdateCheckProgressHasChanged);
            this.wcDownloader.DownloadFileCompleted +=new System.ComponentModel.AsyncCompletedEventHandler(DownloaderFileCompleted);
            this.wcDownloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloaderProgressChanged);
        }

        public void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs eArgs)
        {
            if (this.UpdateDownloadProgressed != null)
                this.UpdateDownloadProgressed(eArgs);
        }

        public void DownloaderFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs eArgs)
        {
            if (this.UpdateFileDownloaded != null)
                this.UpdateFileDownloaded("newver.msi");
        }

        public void UpdateCheckProgressHasChanged(object sender, DownloadProgressChangedEventArgs eArgs)
        {
            if (this.UpdateCheckProgressed != null)
                this.UpdateCheckProgressed(eArgs);
        }

        public void UpdateCheckCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs eArgs)
        {

            if (!(File.Exists("updchk.txt")))
            {
                if (this.UpdateCheckComplete != null)
                    this.UpdateCheckComplete();

                return;
            }

            using (StreamReader sr = new StreamReader("updchk.txt"))
            {
                String line;
                int cLine = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    cLine++;

                    if ((cLine == 1) && (line != "update.check.begin"))
                    {
                        if (this.UpdateCheckComplete != null)
                            this.UpdateCheckComplete();

                        return; /* invalid or corrupt update chk file */
                    }

                    string[] cfgLine = line.Split('^');

                    if (cfgLine[0] == "latest.version.major")
                    {
                        this.LatestVersionMajor = cfgLine[1];
                    }

                    if (cfgLine[0] == "latest.version.minor")
                    {
                        this.LatestVersionMinor = cfgLine[1];
                    }

                    if (cfgLine[0] == "latest.version.revision")
                    {
                        this.LatestVersionRevision = cfgLine[1];
                    }

                    if (cfgLine[0] == "latest.version.release.day")
                    {
                        this.LatestVersionReleaseDay = cfgLine[1];
                    }

                    if (cfgLine[0] == "latest.version.release.month")
                    {
                        this.LatestVersionReleaseMonth = cfgLine[1];
                    }

                    if (cfgLine[0] == "latest.version.release.year")
                    {
                        this.LatestVersionReleaseYear = cfgLine[1];
                    }

                    if (cfgLine[0] == "latest.version.release.file")
                    {
                        this.LatestVersionDownloadURL = cfgLine[1];
                    }

                    if (cfgLine[0] == "update.check.finish")
                    {
                        sr.Close();

                        /* here we need to check if the latest version is newer than the installed version .. */
                        /* installed ver = curVer */

                        /* cur version:  1.0.39658 */
                        /* lat version:  1.0.40122 */

                        /* step 1, check if version major is higher than current version major, if yes, update avail */
                        /* step 2, if version major is the same as current version major, check current version minor, if newer, update avail */
                        /* step 3, if version minor is the same as current version minor, check current version revision, if newer, update avail */

                        if (int.Parse(this.LatestVersionMajor) > this.InstalledVersion.Major)
                            this.IsUpdateAvailable = true;

                        if ((int.Parse(this.LatestVersionMajor) <= this.InstalledVersion.Major) && (int.Parse(this.LatestVersionMinor) > this.InstalledVersion.Minor))
                            this.IsUpdateAvailable = true;

                        if ((int.Parse(this.LatestVersionMajor) <= this.InstalledVersion.Major) && (int.Parse(this.LatestVersionMinor) <= this.InstalledVersion.Minor) && ((int.Parse(this.LatestVersionRevision) > this.InstalledVersion.Revision)))
                            this.IsUpdateAvailable = true;

                        if (this.UpdateCheckComplete != null)
                            this.UpdateCheckComplete();

                        return;
                    }
                }

                sr.Close();
            }

            if (this.UpdateCheckComplete != null)
                this.UpdateCheckComplete();
        }

        public void BeginUpdateCheck(Version InstalledVersion)
        {
            this.InstalledVersion = InstalledVersion;
            this.wcChecker.DownloadFileAsync(new Uri("http://updates.trinitycore-dbgui.info/updchk.txt"), "updchk.txt");
        }

        public void BeginUpdateDownload()
        {
            if (this.IsUpdateAvailable == true)
            {

                if (this.LatestVersionDownloadURL != "")
                {

                    try
                    {
                        File.Delete("newver.msi");
                    }
                    catch (Exception ex)
                    {}

                    
                    this.wcDownloader.DownloadFileAsync(new Uri(this.LatestVersionDownloadURL), "newver.msi");

                }


            }
        }
    }
}
