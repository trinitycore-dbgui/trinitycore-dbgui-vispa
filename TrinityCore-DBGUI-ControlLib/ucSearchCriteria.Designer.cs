namespace TrinityCore_DBGUI_ControlLib
{
    partial class ucSearchCriteriaItem
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
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.pnlRemoveEdit = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlLabel.SuspendLayout();
            this.pnlRemoveEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabel
            // 
            this.pnlLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLabel.Controls.Add(this.lblCriteria);
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLabel.Location = new System.Drawing.Point(0, 0);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(84, 18);
            this.pnlLabel.TabIndex = 0;
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCriteria.Location = new System.Drawing.Point(2, 1);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(64, 13);
            this.lblCriteria.TabIndex = 0;
            this.lblCriteria.Text = "ucSCLabel";
            // 
            // pnlRemoveEdit
            // 
            this.pnlRemoveEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRemoveEdit.Controls.Add(this.btnRemove);
            this.pnlRemoveEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRemoveEdit.Location = new System.Drawing.Point(67, 0);
            this.pnlRemoveEdit.Name = "pnlRemoveEdit";
            this.pnlRemoveEdit.Size = new System.Drawing.Size(17, 18);
            this.pnlRemoveEdit.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(17, 18);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ucSearchCriteriaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRemoveEdit);
            this.Controls.Add(this.pnlLabel);
            this.Name = "ucSearchCriteriaItem";
            this.Size = new System.Drawing.Size(84, 18);
            this.pnlLabel.ResumeLayout(false);
            this.pnlLabel.PerformLayout();
            this.pnlRemoveEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Panel pnlRemoveEdit;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.Button btnRemove;
    }
}
