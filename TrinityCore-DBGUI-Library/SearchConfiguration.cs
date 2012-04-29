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
    public class SearchConfiguration
    {

        public String SearchTitle;

        public String ConfigFile;
        public String PrimaryTable;
        public String PrimaryFields;

        public HybridDictionary SearchCategories = new HybridDictionary(); /* TreeNode collection */
        public HybridDictionary Variables = new HybridDictionary();
        public HybridDictionary SearchCriterias = new HybridDictionary();
        public ArrayList DisplayColumns = new ArrayList();

        public ArrayList ResultFormatRules = new ArrayList();

        public TrinityCoreDBGUI_Controller tController;

        public SearchConfiguration(TrinityCoreDBGUI_Controller tController)
        {
            this.tController = tController;
        }

        public void LoadSearchConfig(String SearchConfigFile)
        {

            this.ConfigFile = SearchConfigFile;


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

                    if ((cLine == 1) && (line != "search.config.begin"))
                        return; /* invalid or corrupt config file */

                    string[] cfgLine = line.Split('^');

                    if (cfgLine[0] == "set.search.title")
                    {
                        this.SearchTitle = cfgLine[1];
                    }

                    if (cfgLine[0] == "set.primary.table")
                    {
                        this.PrimaryTable = cfgLine[1];
                    }

                    if (cfgLine[0] == "set.primary.fields")
                    {
                        this.PrimaryFields = cfgLine[1];
                    }

                    //set.display.fields^entry:Entry ID!name:Name!ItemLevel:Item Level!RequiredLevel:Req Level
                    if (cfgLine[0] == "set.display.fields")
                    {
                        String[] ConfigOptions = cfgLine[1].Split('!');

                        foreach (String cfgCriteriaType in ConfigOptions)
                        {
                            String[] ival = cfgCriteriaType.Split(':');

                            ColumnHeader cHeader = new ColumnHeader();

                            cHeader.Name = ival[0];
                            cHeader.Text = ival[1];
                            cHeader.Width = int.Parse(ival[2]);

                            this.DisplayColumns.Add(cHeader);
                        }

                    }

                    if (cfgLine[0] == "result.format.rule")
                    {

                        if (cfgLine[1] == "colour")
                        {
                            SearchResultFormatRule srFormatRule = new SearchResultFormatRule();

                            srFormatRule.Type = SearchResultFormatRule.RuleType.Colour;
                            srFormatRule.MatchField = cfgLine[2];
                            srFormatRule.MatchValue = this.tController.dbRef.GetIntVal(cfgLine[3]).ToString(); //cfgLine[3];
                            srFormatRule.Colour = cfgLine[4];

                            this.ResultFormatRules.Add(srFormatRule);

                        }


                    }

                    if (cfgLine[0] == "criteria.add")
                    {
                        //criteria.add^entry^Entry ID^text
                        CriteriaRequester cReq;

                        if (cfgLine[3] == "text")
                        {
                            cReq = new CriteriaRequester(CriteriaRequester.CriteriaType.Text, cfgLine[1]);
                            this.SearchCriterias.Add(cfgLine[1], cReq);
                        }
                        else if (cfgLine[3] == "dropdown")
                        {
                            cReq = new CriteriaRequester(CriteriaRequester.CriteriaType.DropDown, cfgLine[1]);
                            this.SearchCriterias.Add(cfgLine[1], cReq);
                        }
                        else if (cfgLine[3] == "checkbox")
                        {
                            cReq = new CriteriaRequester(CriteriaRequester.CriteriaType.CheckBox, cfgLine[1]);
                            this.SearchCriterias.Add(cfgLine[1], cReq);
                        }

                    }

                    if (cfgLine[0] == "criteria.dropdown.additem")
                    {
                        //criteria.dropdown.additem^Quality^0 : Poor
                        CriteriaRequester cReq = (CriteriaRequester)this.SearchCriterias[cfgLine[1]];

                        if (cReq == null)
                            return;

                        cReq.DropDownContent.Add(cfgLine[2]);
                    }

                    if (cfgLine[0] == "define.var")
                    {
                        this.Variables.Add(cfgLine[1], cfgLine[2]);
                    }

                    if (cfgLine[0] == "categories.add")
                    {
                        //categories.add^rootid^id^name
                        //this.PrimaryFields = cfgLine[1];
                        //category.configure^id^class:1,subclass:2,InventoryType:3

                        TreeNode tnCat;

                        if (cfgLine[2] != "root")
                        {
                            /* find root node requested (as cfgLine[1]) */
                            TreeNode tnRoot = (TreeNode)this.SearchCategories[cfgLine[1]];

                            if (tnRoot == null)
                                throw new Exception("Root node does not exist - check your configuration and try again");

                            tnCat = tnRoot.Nodes.Add(cfgLine[3]);
                            tnCat.Name = cfgLine[2];
                        }
                        else
                        {
                            tnCat = new TreeNode(cfgLine[3]);
                            tnCat.Name = cfgLine[2];
                        }

                        this.SearchCategories.Add(cfgLine[2], tnCat);

                    }

                    if (cfgLine[0] == "category.configure")
                    {

                        TreeNode tnFind = (TreeNode)this.SearchCategories[cfgLine[1]];

                        if (tnFind == null)
                            throw new Exception("Could not find node to configure - please check your configuration and try again");

                        //class:wildcard!subclass:wildcard

                        String [] ConfigOptions = cfgLine[2].Split('!');


                        ItemSearchCriteria iSrchCriteria = new ItemSearchCriteria();

                        foreach (String cfgCriteriaType in ConfigOptions)
                        {
                            String [] ival = cfgCriteriaType.Split(':');


                            if (ival[0] == "subclass")
                                iSrchCriteria.SUBCLASS = this.tController.dbRef.GetIntVal(ival[1]);

                            if (ival[0] == "class")
                                iSrchCriteria.ICLASS = this.tController.dbRef.GetIntVal(ival[1]);

                            if (ival[0] == "inventorytype")
                                iSrchCriteria.INVENTORY_TYPE = this.tController.dbRef.GetIntVal(ival[1]);

                        }

                        tnFind.Tag = iSrchCriteria;

                    }
                    

                    if (cfgLine[0] == "search.config.end")
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
