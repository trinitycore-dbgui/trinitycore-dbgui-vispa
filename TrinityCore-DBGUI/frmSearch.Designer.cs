namespace TrinityCore_DBGUI
{
    partial class frmSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimitBy = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tViewType = new System.Windows.Forms.TreeView();
            this.viewOnWowHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSQLQuery = new System.Windows.Forms.Label();
            this.cMenuRightClickResultAddtoItemSetItemList = new System.Windows.Forms.ToolStripComboBox();
            this.createItemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.lstItemSearchResults = new System.Windows.Forms.ListView();
            this.cMenuRightClickResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResults = new System.Windows.Forms.Label();
            this.ucSearchCriteriaSet1 = new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaSet();
            this.ucSearchCriteriaInput1 = new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput();
            this.groupBox1.SuspendLayout();
            this.cMenuRightClickResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLimitBy);
            this.groupBox1.Controls.Add(this.ucSearchCriteriaSet1);
            this.groupBox1.Controls.Add(this.ucSearchCriteriaInput1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(249, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
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
            // tViewType
            // 
            this.tViewType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tViewType.HideSelection = false;
            this.tViewType.Location = new System.Drawing.Point(12, 12);
            this.tViewType.Name = "tViewType";
            this.tViewType.Size = new System.Drawing.Size(230, 525);
            this.tViewType.TabIndex = 6;
            // 
            // viewOnWowHeadToolStripMenuItem
            // 
            this.viewOnWowHeadToolStripMenuItem.Name = "viewOnWowHeadToolStripMenuItem";
            this.viewOnWowHeadToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewOnWowHeadToolStripMenuItem.Text = "View on WowHead ...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // lblSQLQuery
            // 
            this.lblSQLQuery.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQLQuery.Location = new System.Drawing.Point(23, 550);
            this.lblSQLQuery.Name = "lblSQLQuery";
            this.lblSQLQuery.Size = new System.Drawing.Size(809, 48);
            this.lblSQLQuery.TabIndex = 9;
            this.lblSQLQuery.Text = "(No Query)";
            this.lblSQLQuery.Visible = false;
            // 
            // cMenuRightClickResultAddtoItemSetItemList
            // 
            this.cMenuRightClickResultAddtoItemSetItemList.Name = "cMenuRightClickResultAddtoItemSetItemList";
            this.cMenuRightClickResultAddtoItemSetItemList.Size = new System.Drawing.Size(121, 23);
            // 
            // createItemSetToolStripMenuItem
            // 
            this.createItemSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuRightClickResultAddtoItemSetItemList});
            this.createItemSetToolStripMenuItem.Name = "createItemSetToolStripMenuItem";
            this.createItemSetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.createItemSetToolStripMenuItem.Text = "Add to Item Set ...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // lstItemSearchResults
            // 
            this.lstItemSearchResults.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstItemSearchResults.ContextMenuStrip = this.cMenuRightClickResult;
            this.lstItemSearchResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemSearchResults.FullRowSelect = true;
            this.lstItemSearchResults.HideSelection = false;
            this.lstItemSearchResults.LabelEdit = true;
            this.lstItemSearchResults.Location = new System.Drawing.Point(249, 193);
            this.lstItemSearchResults.Name = "lstItemSearchResults";
            this.lstItemSearchResults.ShowItemToolTips = true;
            this.lstItemSearchResults.Size = new System.Drawing.Size(673, 344);
            this.lstItemSearchResults.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstItemSearchResults.TabIndex = 7;
            this.lstItemSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstItemSearchResults.View = System.Windows.Forms.View.Details;
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
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteItemToolStripMenuItem.Text = "Copy Item";
            // 
            // deleteItemToolStripMenuItem1
            // 
            this.deleteItemToolStripMenuItem1.Name = "deleteItemToolStripMenuItem1";
            this.deleteItemToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.deleteItemToolStripMenuItem1.Text = "Delete Item";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(840, 544);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(82, 15);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "0 Results";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucSearchCriteriaSet1
            // 
            this.ucSearchCriteriaSet1.BackColor = System.Drawing.Color.Lavender;
            this.ucSearchCriteriaSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSearchCriteriaSet1.Location = new System.Drawing.Point(6, 46);
            this.ucSearchCriteriaSet1.Name = "ucSearchCriteriaSet1";
            this.ucSearchCriteriaSet1.Size = new System.Drawing.Size(657, 105);
            this.ucSearchCriteriaSet1.TabIndex = 4;
            // 
            // ucSearchCriteriaInput1
            // 
            this.ucSearchCriteriaInput1.Location = new System.Drawing.Point(6, 17);
            this.ucSearchCriteriaInput1.Name = "ucSearchCriteriaInput1";
            this.ucSearchCriteriaInput1.Size = new System.Drawing.Size(599, 23);
            this.ucSearchCriteriaInput1.TabIndex = 3;
            this.ucSearchCriteriaInput1.RequestedAddCriteria += new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput.AddCriteria(this.ucSearchCriteriaInput1_RequestedAddCriteria);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tViewType);
            this.Controls.Add(this.lblSQLQuery);
            this.Controls.Add(this.lstItemSearchResults);
            this.Controls.Add(this.lblResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.Text = "Search []";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cMenuRightClickResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLimitBy;
        private TrinityCore_DBGUI_ControlLib.ucSearchCriteriaSet ucSearchCriteriaSet1;
        private TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput ucSearchCriteriaInput1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TreeView tViewType;
        private System.Windows.Forms.ToolStripMenuItem viewOnWowHeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label lblSQLQuery;
        private System.Windows.Forms.ToolStripComboBox cMenuRightClickResultAddtoItemSetItemList;
        private System.Windows.Forms.ToolStripMenuItem createItemSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ListView lstItemSearchResults;
        private System.Windows.Forms.ContextMenuStrip cMenuRightClickResult;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem1;
        private System.Windows.Forms.Label lblResults;
    }
}