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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameItemSearch));
            this.tViewType = new System.Windows.Forms.TreeView();
            this.lstItemSearchResults = new System.Windows.Forms.ListView();
            this.colEntryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucSearchCriteriaSet1 = new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaSet();
            this.ucSearchCriteriaInput1 = new TrinityCore_DBGUI_ControlLib.ucSearchCriteriaInput();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tViewType
            // 
            this.tViewType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tViewType.Location = new System.Drawing.Point(13, 13);
            this.tViewType.Name = "tViewType";
            this.tViewType.Size = new System.Drawing.Size(230, 505);
            this.tViewType.TabIndex = 0;
            // 
            // lstItemSearchResults
            // 
            this.lstItemSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEntryID,
            this.colName});
            this.lstItemSearchResults.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemSearchResults.Location = new System.Drawing.Point(250, 174);
            this.lstItemSearchResults.Name = "lstItemSearchResults";
            this.lstItemSearchResults.Size = new System.Drawing.Size(673, 344);
            this.lstItemSearchResults.TabIndex = 1;
            this.lstItemSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstItemSearchResults.View = System.Windows.Forms.View.Details;
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
            this.groupBox1.Controls.Add(this.ucSearchCriteriaSet1);
            this.groupBox1.Controls.Add(this.ucSearchCriteriaInput1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(250, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // frmGameItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 557);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
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
    }
}