using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.Collections.Specialized;

using TrinityCore_DBGUI_Library;
using TrinityCore_DBGUI_ControlLib;

using System.IO;

namespace TrinityCore_DBGUI
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        SearchConfiguration iSearchConfig;
        DataSet Results;

        private void FormatResultColumns()
        {
            this.lstItemSearchResults.Clear();

            if (this.iSearchConfig.DisplayColumns.Count < 1)
                return;

            foreach (ColumnHeader cHeader in this.iSearchConfig.DisplayColumns)
            {
                this.lstItemSearchResults.Columns.Add(cHeader);
            }
        }

        public void ConfigureSearch(String SearchCfgFile)
        {

            if (!File.Exists(SearchCfgFile))
            {
                MessageBox.Show("Cannot locate search configuration file: " + SearchCfgFile, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }
          
            frmMain fMain = (frmMain)this.MdiParent;
            this.iSearchConfig = new SearchConfiguration(fMain.trinityCoreController);

            this.iSearchConfig.LoadSearchConfig(SearchCfgFile);

            /* add criterias */

            if (this.iSearchConfig.SearchCriterias.Count > 0)
            {
                foreach (DictionaryEntry dCriteria in this.iSearchConfig.SearchCriterias)
                {
                    this.ucSearchCriteriaInput1.AddCriteriaType((CriteriaRequester)dCriteria.Value);
                }
            }

            /* set search title */
            this.Text = "Search - [" + this.iSearchConfig.SearchTitle + "]";

            /* add categories */
            TreeNode tRootNode = (TreeNode)this.iSearchConfig.SearchCategories["root"];

            if (tRootNode == null)
                return;

            this.tViewType.Nodes.Add(tRootNode);

            this.tViewType.Nodes[0].Expand();

            /* configure display columns once initially */
            this.FormatResultColumns();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
        }

        private void ucSearchCriteriaInput1_RequestedAddCriteria(ucSearchCriteriaItem uCriteriaItem)
        {
            this.ucSearchCriteriaSet1.AddCriteria(uCriteriaItem);
        }

        private void ApplyFormatRules(DataColumnCollection DCols, DataRow dRow, ListViewItem lvItem)
        {
            if (this.iSearchConfig.ResultFormatRules.Count < 1)
                return;

                object[] colvalues = dRow.ItemArray;

                for (int i = 0; i < DCols.Count; i++)
                {

                   foreach (SearchResultFormatRule srFormatRule in this.iSearchConfig.ResultFormatRules)
                   {

                       if ((DCols[i].ColumnName == srFormatRule.MatchField) && (colvalues[i].ToString() == srFormatRule.MatchValue))
                       {
                           /* rules match ! */
                           if (srFormatRule.Type == SearchResultFormatRule.RuleType.Colour)
                           {
                               /* Colour means to change the colour of text only */
                               lvItem.ForeColor = Color.FromName(srFormatRule.Colour); //( srFormatRule.Colour;
                           }

                       }
                   }
                }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMain fMain = (frmMain)this.MdiParent;

            if (this.tViewType.SelectedNode.Tag == null)
                return;

            this.lstItemSearchResults.Clear();
            this.FormatResultColumns();

            /* concat all actualSQLs */
            FlowLayoutPanel flpItems = this.ucSearchCriteriaSet1.GetAllCriteria();

            String SpecificCriteriaSQL = "";

            if (flpItems.Controls.Count > 0)
            {
                foreach (ucSearchCriteriaItem uItem in flpItems.Controls)
                {
                    if (SpecificCriteriaSQL != "")
                    {
                        SpecificCriteriaSQL = SpecificCriteriaSQL + " AND " + uItem.ActualCriteriaSQL;
                    }
                    else
                    {
                        SpecificCriteriaSQL = uItem.ActualCriteriaSQL;
                    }
                }
            }

            TrinityCore_DBGUI_Library.ItemSearchCriteria iSrchCriteria = (TrinityCore_DBGUI_Library.ItemSearchCriteria)this.tViewType.SelectedNode.Tag;

            iSrchCriteria.ExtraSQL = SpecificCriteriaSQL;

            try
            {
                iSrchCriteria.LIMIT_RESULTS = int.Parse(this.txtLimitBy.Text);
            }
            catch (Exception ex)
            {
                iSrchCriteria.LIMIT_RESULTS = 500;
                this.txtLimitBy.Text = "500";
            }

            this.Cursor = Cursors.WaitCursor;

            iSrchCriteria.SelectorCommand = "SELECT " + this.iSearchConfig.PrimaryFields + " FROM " + this.iSearchConfig.PrimaryTable;

            this.Results = fMain.trinityCoreController.worldDb.PerformDataSearch(iSrchCriteria); 
            
            this.Cursor = Cursors.Default;

            if (this.Results.Tables[0].Rows.Count < 1)
                return;

            foreach (DataRow dRowResult in this.Results.Tables[0].Rows)
            {

                ListViewItem lviResult = new ListViewItem(dRowResult[this.lstItemSearchResults.Columns[0].Name].ToString());

                int tID = 0;

                foreach (ColumnHeader cHeader in this.iSearchConfig.DisplayColumns)
                {
                    tID++;

                    if (tID != 1)
                    {
                        lviResult.SubItems.Add(dRowResult[cHeader.Name].ToString());
                    }
                }

                this.ApplyFormatRules(this.Results.Tables[0].Columns, dRowResult, lviResult);
                this.lstItemSearchResults.Items.Add(lviResult);
            }


                this.lblSQLQuery.Text = fMain.trinityCoreController.worldDb.LastSQLQuery;
                this.lblResults.Text = this.Results.Tables[0].Rows.Count.ToString() + " Results";

        }


        private void viewOnWowHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //

            if (this.lstItemSearchResults.SelectedItems.Count < 1)
                return;

            foreach (ListViewItem lvi in this.lstItemSearchResults.SelectedItems)
            {
                System.Diagnostics.Process.Start("http://www.wowhead.com/item=" + lvi.Text);
            }
        }



   }

}
