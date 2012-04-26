namespace TrinityCore_DBGUI_ControlLib
{
    partial class ucSearchCriteriaInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCriteriaSelector = new System.Windows.Forms.Panel();
            this.cboCriteriaID = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlCriteriaInput = new System.Windows.Forms.Panel();
            this.pnlCriteriaOperation = new System.Windows.Forms.Panel();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.pnlLogicalSelector = new System.Windows.Forms.Panel();
            this.cboLogic = new System.Windows.Forms.ComboBox();
            this.pnlCriteriaSelector.SuspendLayout();
            this.pnlCriteriaOperation.SuspendLayout();
            this.pnlLogicalSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCriteriaSelector
            // 
            this.pnlCriteriaSelector.Controls.Add(this.cboCriteriaID);
            this.pnlCriteriaSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCriteriaSelector.Location = new System.Drawing.Point(0, 0);
            this.pnlCriteriaSelector.Name = "pnlCriteriaSelector";
            this.pnlCriteriaSelector.Size = new System.Drawing.Size(145, 23);
            this.pnlCriteriaSelector.TabIndex = 0;
            // 
            // cboCriteriaID
            // 
            this.cboCriteriaID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCriteriaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteriaID.FormattingEnabled = true;
            this.cboCriteriaID.Location = new System.Drawing.Point(0, 0);
            this.cboCriteriaID.Name = "cboCriteriaID";
            this.cboCriteriaID.Size = new System.Drawing.Size(145, 21);
            this.cboCriteriaID.TabIndex = 0;
            this.cboCriteriaID.SelectedIndexChanged += new System.EventHandler(this.cboCriteriaID_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(228, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(117, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "[No ID]";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Visible = false;
            // 
            // pnlCriteriaInput
            // 
            this.pnlCriteriaInput.Location = new System.Drawing.Point(247, 0);
            this.pnlCriteriaInput.Name = "pnlCriteriaInput";
            this.pnlCriteriaInput.Size = new System.Drawing.Size(309, 22);
            this.pnlCriteriaInput.TabIndex = 2;
            // 
            // pnlCriteriaOperation
            // 
            this.pnlCriteriaOperation.Controls.Add(this.btnAddCriteria);
            this.pnlCriteriaOperation.Location = new System.Drawing.Point(559, 1);
            this.pnlCriteriaOperation.Name = "pnlCriteriaOperation";
            this.pnlCriteriaOperation.Size = new System.Drawing.Size(38, 21);
            this.pnlCriteriaOperation.TabIndex = 3;
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCriteria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.Location = new System.Drawing.Point(0, 0);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(38, 21);
            this.btnAddCriteria.TabIndex = 0;
            this.btnAddCriteria.Text = "Add";
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // pnlLogicalSelector
            // 
            this.pnlLogicalSelector.Controls.Add(this.cboLogic);
            this.pnlLogicalSelector.Location = new System.Drawing.Point(146, 0);
            this.pnlLogicalSelector.Name = "pnlLogicalSelector";
            this.pnlLogicalSelector.Size = new System.Drawing.Size(100, 22);
            this.pnlLogicalSelector.TabIndex = 4;
            // 
            // cboLogic
            // 
            this.cboLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLogic.FormattingEnabled = true;
            this.cboLogic.Location = new System.Drawing.Point(0, 0);
            this.cboLogic.Name = "cboLogic";
            this.cboLogic.Size = new System.Drawing.Size(100, 21);
            this.cboLogic.TabIndex = 2;
            this.cboLogic.SelectedIndexChanged += new System.EventHandler(this.cboLogic_SelectedIndexChanged);
            // 
            // ucSearchCriteriaInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pnlLogicalSelector);
            this.Controls.Add(this.pnlCriteriaOperation);
            this.Controls.Add(this.pnlCriteriaInput);
            this.Controls.Add(this.pnlCriteriaSelector);
            this.Name = "ucSearchCriteriaInput";
            this.Size = new System.Drawing.Size(599, 23);
            this.pnlCriteriaSelector.ResumeLayout(false);
            this.pnlCriteriaOperation.ResumeLayout(false);
            this.pnlLogicalSelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCriteriaSelector;
        private System.Windows.Forms.ComboBox cboCriteriaID;
        private System.Windows.Forms.Panel pnlCriteriaInput;
        private System.Windows.Forms.Panel pnlCriteriaOperation;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlLogicalSelector;
        private System.Windows.Forms.ComboBox cboLogic;
    }
}
