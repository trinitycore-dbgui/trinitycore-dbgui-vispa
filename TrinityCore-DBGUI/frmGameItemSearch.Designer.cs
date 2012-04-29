namespace TrinityCore_DBGUI
{
    partial class frmGameItemSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameItemSearch));
            this.tViewType = new System.Windows.Forms.TreeView();
            this.lstItemSearchResults = new System.Windows.Forms.ListView();
            this.colEntryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRequiredLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMenuRightClickResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.createItemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuRightClickResultAddtoItemSetItemList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewOnWowHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimitBy = new System.Windows.Forms.TextBox();
            this.ucSearchCriteriaSet1 = new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaSet();
            this.ucSearchCriteriaInput1 = new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput();
            this.lblSQLQuery = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.cMenuRightClickResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tViewType
            // 
            this.tViewType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tViewType.HideSelection = false;
            this.tViewType.Location = new System.Drawing.Point(13, 12);
            this.tViewType.Name = "tViewType";
            this.tViewType.Size = new System.Drawing.Size(230, 525);
            this.tViewType.TabIndex = 0;
            this.tViewType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tViewType_AfterSelect);
            // 
            // lstItemSearchResults
            // 
            this.lstItemSearchResults.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstItemSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEntryID,
            this.colName,
            this.colItemLevel,
            this.colRequiredLevel});
            this.lstItemSearchResults.ContextMenuStrip = this.cMenuRightClickResult;
            this.lstItemSearchResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemSearchResults.FullRowSelect = true;
            this.lstItemSearchResults.HideSelection = false;
            this.lstItemSearchResults.LabelEdit = true;
            this.lstItemSearchResults.Location = new System.Drawing.Point(250, 193);
            this.lstItemSearchResults.Name = "lstItemSearchResults";
            this.lstItemSearchResults.ShowItemToolTips = true;
            this.lstItemSearchResults.Size = new System.Drawing.Size(673, 344);
            this.lstItemSearchResults.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstItemSearchResults.TabIndex = 1;
            this.lstItemSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstItemSearchResults.View = System.Windows.Forms.View.Details;
            this.lstItemSearchResults.SelectedIndexChanged += new System.EventHandler(this.lstItemSearchResults_SelectedIndexChanged);
            // 
            // colEntryID
            // 
            this.colEntryID.Text = "Entry ID";
            this.colEntryID.Width = 80;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 350;
            // 
            // colItemLevel
            // 
            this.colItemLevel.Text = "Item Level";
            this.colItemLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colItemLevel.Width = 80;
            // 
            // colRequiredLevel
            // 
            this.colRequiredLevel.Text = "Req Level";
            this.colRequiredLevel.Width = 80;
            // 
            // cMenuRightClickResult
            // 
            this.cMenuRightClickResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.createItemSetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewOnWowHeadToolStripMenuItem});
            this.cMenuRightClickResult.Name = "contextMenuStrip1";
            this.cMenuRightClickResult.Size = new System.Drawing.Size(187, 126);
            this.cMenuRightClickResult.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuRightClickResult_Opening);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteItemToolStripMenuItem.Text = "Copy Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem1
            // 
            this.deleteItemToolStripMenuItem1.Name = "deleteItemToolStripMenuItem1";
            this.deleteItemToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.deleteItemToolStripMenuItem1.Text = "Delete Item";
            this.deleteItemToolStripMenuItem1.Click += new System.EventHandler(this.deleteItemToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // createItemSetToolStripMenuItem
            // 
            this.createItemSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuRightClickResultAddtoItemSetItemList});
            this.createItemSetToolStripMenuItem.Name = "createItemSetToolStripMenuItem";
            this.createItemSetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.createItemSetToolStripMenuItem.Text = "Add to Item Set ...";
            this.createItemSetToolStripMenuItem.Click += new System.EventHandler(this.createItemSetToolStripMenuItem_Click);
            this.createItemSetToolStripMenuItem.MouseHover += new System.EventHandler(this.createItemSetToolStripMenuItem_MouseHover);
            // 
            // cMenuRightClickResultAddtoItemSetItemList
            // 
            this.cMenuRightClickResultAddtoItemSetItemList.Name = "cMenuRightClickResultAddtoItemSetItemList";
            this.cMenuRightClickResultAddtoItemSetItemList.Size = new System.Drawing.Size(121, 23);
            this.cMenuRightClickResultAddtoItemSetItemList.Click += new System.EventHandler(this.cMenuRightClickResultAddtoItemSetItemList_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // viewOnWowHeadToolStripMenuItem
            // 
            this.viewOnWowHeadToolStripMenuItem.Name = "viewOnWowHeadToolStripMenuItem";
            this.viewOnWowHeadToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewOnWowHeadToolStripMenuItem.Text = "View on WowHead ...";
            this.viewOnWowHeadToolStripMenuItem.Click += new System.EventHandler(this.viewOnWowHeadToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(605, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLimitBy);
            this.groupBox1.Controls.Add(this.ucSearchCriteriaSet1);
            this.groupBox1.Controls.Add(this.ucSearchCriteriaInput1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(250, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Limit Results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLimitBy
            // 
            this.txtLimitBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLimitBy.Location = new System.Drawing.Point(617, 154);
            this.txtLimitBy.Name = "txtLimitBy";
            this.txtLimitBy.Size = new System.Drawing.Size(46, 21);
            this.txtLimitBy.TabIndex = 5;
            this.txtLimitBy.Text = "500";
            this.txtLimitBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLimitBy.TextChanged += new System.EventHandler(this.txtLimitBy_TextChanged);
            // 
            // ucSearchCriteriaSet1
            // 
            this.ucSearchCriteriaSet1.BackColor = System.Drawing.Color.Lavender;
            this.ucSearchCriteriaSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSearchCriteriaSet1.Location = new System.Drawing.Point(6, 46);
            this.ucSearchCriteriaSet1.Name = "ucSearchCriteriaSet1";
            this.ucSearchCriteriaSet1.Size = new System.Drawing.Size(657, 105);
            this.ucSearchCriteriaSet1.TabIndex = 4;
            this.ucSearchCriteriaSet1.Load += new System.EventHandler(this.ucSearchCriteriaSet1_Load);
            // 
            // ucSearchCriteriaInput1
            // 
            this.ucSearchCriteriaInput1.Location = new System.Drawing.Point(6, 17);
            this.ucSearchCriteriaInput1.Name = "ucSearchCriteriaInput1";
            this.ucSearchCriteriaInput1.Size = new System.Drawing.Size(599, 23);
            this.ucSearchCriteriaInput1.TabIndex = 3;
            this.ucSearchCriteriaInput1.RequestedAddCriteria += new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput.AddCriteria(this.ucSearchCriteriaInput1_RequestedAddCriteria);
            this.ucSearchCriteriaInput1.Load += new System.EventHandler(this.ucSearchCriteriaInput1_Load);
            // 
            // lblSQLQuery
            // 
            this.lblSQLQuery.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQLQuery.Location = new System.Drawing.Point(24, 540);
            this.lblSQLQuery.Name = "lblSQLQuery";
            this.lblSQLQuery.Size = new System.Drawing.Size(809, 49);
            this.lblSQLQuery.TabIndex = 4;
            this.lblSQLQuery.Text = "(No Query)";
            this.lblSQLQuery.Click += new System.EventHandler(this.lblSQLQuery_Click);
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(841, 544);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(82, 15);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "0 Results";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResults.Click += new System.EventHandler(this.lblResults_Click);
            // 
            // frmGameItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblSQLQuery);
            this.Controls.Add(this.lstItemSearchResults);
            this.Controls.Add(this.tViewType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGameItemSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Item Search";
            this.Load += new System.EventHandler(this.frmGameItemSearch_Load);
            this.cMenuRightClickResult.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tViewType;
        private System.Windows.Forms.ListView lstItemSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader colEntryID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.GroupBox groupBox1;
        private TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput ucSearchCriteriaInput1;
        private TrinityCore_DBGUI_ControlLib.ucSearchCriteriaSet ucSearchCriteriaSet1;
        private System.Windows.Forms.ColumnHeader colItemLevel;
        private System.Windows.Forms.ColumnHeader colRequiredLevel;
        private System.Windows.Forms.ContextMenuStrip cMenuRightClickResult;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createItemSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cMenuRightClickResultAddtoItemSetItemList;
        private System.Windows.Forms.Label lblSQLQuery;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewOnWowHeadToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLimitBy;
        private System.Windows.Forms.Label label1;
    }
}