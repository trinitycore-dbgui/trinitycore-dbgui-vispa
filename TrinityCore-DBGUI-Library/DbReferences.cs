using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.Specialized;
using System.Collections;

using System.IO;

namespace TrinityCore_DBGUI_Library
{
    public class DbReferences
    {

        public HybridDictionary Reference = new HybridDictionary();
        public String ConfigFile;

        public int GetIntVal(String CfgID)
        {
            return (int)int.Parse(this.Reference[CfgID].ToString()); 
        }

        public String GetStringVal(String CfgID)
        {
            return (String)this.Reference[CfgID];
        }

        public Boolean GetBoolVal(String CfgID)
        {
            return (Boolean)this.Reference[CfgID];
        }

        public void LoadDBRefConfig(String CfgFile)
        {
            
            this.ConfigFile = CfgFile;

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

                    if ((cLine == 1) && (line != "dbref.config.begin"))
                        return; /* invalid or corrupt config file */

                    string[] cfgLine = line.Split('^');

                    if (cfgLine[0] == "dbref.add")
                    {
                        this.Reference.Add(cfgLine[1], (String)cfgLine[2]);
                    }

                    if (cfgLine[0] == "dbref.config.end")
                    {
                        sr.Close();
                        return;
                    }
                }

                sr.Close();

            }

            
        }
    }
}
