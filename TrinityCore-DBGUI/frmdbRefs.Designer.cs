namespace TrinityCore_DBGUI
{
    partial class frmdbRefs
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
            this.lvDbRefs = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDbRefs
            // 
            this.lvDbRefs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colValue});
            this.lvDbRefs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDbRefs.Location = new System.Drawing.Point(5, 5);
            this.lvDbRefs.Name = "lvDbRefs";
            this.lvDbRefs.Size = new System.Drawing.Size(288, 402);
            this.lvDbRefs.TabIndex = 0;
            this.lvDbRefs.UseCompatibleStateImageBehavior = false;
            this.lvDbRefs.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 160;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colValue.Width = 100;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(211, 413);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(76, 24);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmdbRefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 440);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lvDbRefs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmdbRefs";
            this.Text = "Database References";
            this.Load += new System.EventHandler(this.frmdbRefs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDbRefs;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Button btnDone;
    }
}