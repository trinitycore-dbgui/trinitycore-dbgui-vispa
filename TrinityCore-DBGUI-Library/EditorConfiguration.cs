using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Collections;
using System.Collections.Specialized;

using System.Windows.Forms;

using TrinityCore_DBGUI_ControlLib;

namespace TrinityCore_DBGUI_Library
{
    public class EditorConfiguration
    {

        public String EditorTitle;
        public TrinityCoreDBGUI_Controller tController;
        public String ConfigFile;

        public int EditorWidth;
        public int EditorHeight;

        public HybridDictionary EditorTabs = new HybridDictionary();

        public delegate void ButtonClicked(String DoFunction);
        public event ButtonClicked EditorButtonClicked;

        public EditorConfiguration(TrinityCoreDBGUI_Controller tController)
        {
            this.tController = tController;
        }


        void cmdButton_Click(object sender, EventArgs e)
        {
            Button btnClicked = (Button)sender;

            if (btnClicked.Tag == null)
                return;

            String btnFunction = (String)btnClicked.Tag;

            if (this.EditorButtonClicked != null)
                this.EditorButtonClicked(btnFunction);
        }

        public void LoadSearchConfig(String EditConfigFile)
        {

            this.ConfigFile = EditConfigFile;


            if (!File.Exists(this.ConfigFile))
                return;


            using (StreamReader sr = new StreamReader(this.ConfigFile))
            {
                String line;
                int cLine = 0;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    cLine++;

                    if ((cLine == 1) && (line != "editor.config.begin"))
                        return; /* invalid or corrupt config file */

                    string[] cfgLine = line.Split('^');

                    if (cfgLine[0] == "set.editor.title")
                    {
                        this.EditorTitle = cfgLine[1];
                    }

                    //configure.editor.window^636^458
                    if (cfgLine[0] == "configure.editor.window")
                    {
                        this.EditorWidth = int.Parse(cfgLine[1]);
                        this.EditorHeight = int.Parse(cfgLine[2]);
                    }

                    if (cfgLine[0] == "add.tab")
                    {
                        // add.tab^TabTitle^canselect yes or no
                        //cfgLine[1];
                        TabPage tPage = new TabPage(cfgLine[1]);
                        this.EditorTabs.Add(cfgLine[1], tPage);
                    }

                    if (cfgLine[0] == "add.button")
                    {
                        //# add.button^id^tabpage^width^height^top^left^value^function
                        //# function can be -   savetodb ,  or closeeditor

                        //add.button^close^General^25^20^100^100^Close^closeeditor
                        TabPage tPage = (TabPage)this.EditorTabs[cfgLine[2]];

                        if (tPage == null)
                            return;

                        Button cmdButton = new Button();

                        cmdButton.Width = int.Parse(cfgLine[3]);
                        cmdButton.Height = int.Parse(cfgLine[4]);

                        cmdButton.Name = cfgLine[1];

                        tPage.Controls.Add(cmdButton);

                        cmdButton.Top = int.Parse(cfgLine[5]);
                        cmdButton.Left = int.Parse(cfgLine[6]);

                        cmdButton.Text = cfgLine[7];

                        cmdButton.Tag = cfgLine[8];

                        cmdButton.Show();

                        cmdButton.Click += new EventHandler(cmdButton_Click);
                    
                    }
                    if (cfgLine[0] == "add.label")
                    {
                        // add.label^id^tabpage^width^height^top^left^value
                        TabPage tPage = (TabPage)this.EditorTabs[cfgLine[2]];

                        if (tPage == null)
                            return;

                        Label lblNew = new Label();

                        lblNew.Width = int.Parse(cfgLine[3]);
                        lblNew.Height = int.Parse(cfgLine[4]);

                        lblNew.Name = cfgLine[1];

                        tPage.Controls.Add(lblNew);

                        lblNew.Top = int.Parse(cfgLine[5]);
                        lblNew.Left = int.Parse(cfgLine[6]);

                        lblNew.Text = cfgLine[7];

                        lblNew.Show();

                    }
                    if (cfgLine[0] == "add.input.control")
                    {
                        // add.input.control^type^id^tabpage^width^height^top^left^dbfield^default value

                        TabPage tPage = (TabPage)this.EditorTabs[cfgLine[3]];

                        if (tPage == null)
                            return;

                        if (cfgLine[1] == "text")
                        {
                            TextBox tBox = new TextBox();

                            tBox.Width = int.Parse(cfgLine[4]);
                            tBox.Height = int.Parse(cfgLine[5]);

                            tBox.Tag = cfgLine[8];
                            tBox.Name = cfgLine[2];

                            tPage.Controls.Add(tBox);

                            tBox.Top = int.Parse(cfgLine[6]);
                            tBox.Left = int.Parse(cfgLine[7]);

                            tBox.Text = cfgLine[9];

                            tBox.Show();

                        }
                        else if (cfgLine[1] == "dropdown")
                        {

                        }
                        else if (cfgLine[1] == "checkbox")
                        {

                        }


                    }


                }
            }

        }
    }
}
