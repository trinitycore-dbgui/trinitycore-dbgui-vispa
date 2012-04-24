namespace TrinityCore_DBGUI
{
    partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabConnectionInformation = new System.Windows.Forms.TabControl();
            this.tabServerInformation = new System.Windows.Forms.TabPage();
            this.grpDatabaseInfo = new System.Windows.Forms.GroupBox();
            this.btnRefresh3 = new System.Windows.Forms.Button();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.cboCharDB = new System.Windows.Forms.ComboBox();
            this.cboWorldDB = new System.Windows.Forms.ComboBox();
            this.cboAuthDB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpServerInfo = new System.Windows.Forms.GroupBox();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.txtDatabaseUsername = new System.Windows.Forms.TextBox();
            this.txtDatabasePort = new System.Windows.Forms.TextBox();
            this.txtDatabaseHostname = new System.Windows.Forms.TextBox();
            this.tabConnectionInformation.SuspendLayout();
            this.tabServerInformation.SuspendLayout();
            this.grpDatabaseInfo.SuspendLayout();
            this.grpServerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(200, 271);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabConnectionInformation
            // 
            this.tabConnectionInformation.Controls.Add(this.tabServerInformation);
            this.tabConnectionInformation.Location = new System.Drawing.Point(12, 12);
            this.tabConnectionInformation.Name = "tabConnectionInformation";
            this.tabConnectionInformation.SelectedIndex = 0;
            this.tabConnectionInformation.Size = new System.Drawing.Size(267, 253);
            this.tabConnectionInformation.TabIndex = 4;
            // 
            // tabServerInformation
            // 
            this.tabServerInformation.Controls.Add(this.grpDatabaseInfo);
            this.tabServerInformation.Controls.Add(this.grpServerInfo);
            this.tabServerInformation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabServerInformation.Location = new System.Drawing.Point(4, 22);
            this.tabServerInformation.Name = "tabServerInformation";
            this.tabServerInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabServerInformation.Size = new System.Drawing.Size(259, 227);
            this.tabServerInformation.TabIndex = 0;
            this.tabServerInformation.Text = "Connection Information";
            this.tabServerInformation.UseVisualStyleBackColor = true;
            // 
            // grpDatabaseInfo
            // 
            this.grpDatabaseInfo.Controls.Add(this.btnRefresh3);
            this.grpDatabaseInfo.Controls.Add(this.btnRefresh2);
            this.grpDatabaseInfo.Controls.Add(this.btnRefresh1);
            this.grpDatabaseInfo.Controls.Add(this.cboCharDB);
            this.grpDatabaseInfo.Controls.Add(this.cboWorldDB);
            this.grpDatabaseInfo.Controls.Add(this.cboAuthDB);
            this.grpDatabaseInfo.Controls.Add(this.label3);
            this.grpDatabaseInfo.Controls.Add(this.label2);
            this.grpDatabaseInfo.Controls.Add(this.label1);
            this.grpDatabaseInfo.Location = new System.Drawing.Point(6, 110);
            this.grpDatabaseInfo.Name = "grpDatabaseInfo";
            this.grpDatabaseInfo.Size = new System.Drawing.Size(245, 104);
            this.grpDatabaseInfo.TabIndex = 5;
            this.grpDatabaseInfo.TabStop = false;
            this.grpDatabaseInfo.Text = "Database Information";
            // 
            // btnRefresh3
            // 
            this.btnRefresh3.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh3.Image")));
            this.btnRefresh3.Location = new System.Drawing.Point(222, 70);
            this.btnRefresh3.Name = "btnRefresh3";
            this.btnRefresh3.Size = new System.Drawing.Size(17, 21);
            this.btnRefresh3.TabIndex = 8;
            this.btnRefresh3.UseVisualStyleBackColor = true;
            this.btnRefresh3.Click += new System.EventHandler(this.btnRefresh3_Click);
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh2.Image")));
            this.btnRefresh2.Location = new System.Drawing.Point(222, 46);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(17, 21);
            this.btnRefresh2.TabIndex = 7;
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh1.Image")));
            this.btnRefresh1.Location = new System.Drawing.Point(222, 22);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(17, 21);
            this.btnRefresh1.TabIndex = 6;
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // cboCharDB
            // 
            this.cboCharDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCharDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCharDB.FormattingEnabled = true;
            this.cboCharDB.Location = new System.Drawing.Point(120, 70);
            this.cboCharDB.Name = "cboCharDB";
            this.cboCharDB.Size = new System.Drawing.Size(101, 21);
            this.cboCharDB.TabIndex = 5;
            this.cboCharDB.SelectedIndexChanged += new System.EventHandler(this.cboCharDB_SelectedIndexChanged);
            // 
            // cboWorldDB
            // 
            this.cboWorldDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorldDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWorldDB.FormattingEnabled = true;
            this.cboWorldDB.Location = new System.Drawing.Point(120, 46);
            this.cboWorldDB.Name = "cboWorldDB";
            this.cboWorldDB.Size = new System.Drawing.Size(101, 21);
            this.cboWorldDB.TabIndex = 4;
            this.cboWorldDB.SelectedIndexChanged += new System.EventHandler(this.cboWorldDB_SelectedIndexChanged);
            // 
            // cboAuthDB
            // 
            this.cboAuthDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAuthDB.FormattingEnabled = true;
            this.cboAuthDB.Location = new System.Drawing.Point(120, 22);
            this.cboAuthDB.Name = "cboAuthDB";
            this.cboAuthDB.Size = new System.Drawing.Size(101, 21);
            this.cboAuthDB.TabIndex = 3;
            this.cboAuthDB.Click += new System.EventHandler(this.cboAuthDB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "World Database:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Character Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth Database:";
            // 
            // grpServerInfo
            // 
            this.grpServerInfo.Controls.Add(this.txtDatabasePassword);
            this.grpServerInfo.Controls.Add(this.txtDatabaseUsername);
            this.grpServerInfo.Controls.Add(this.txtDatabasePort);
            this.grpServerInfo.Controls.Add(this.txtDatabaseHostname);
            this.grpServerInfo.Location = new System.Drawing.Point(6, 6);
            this.grpServerInfo.Name = "grpServerInfo";
            this.grpServerInfo.Size = new System.Drawing.Size(245, 98);
            this.grpServerInfo.TabIndex = 3;
            this.grpServerInfo.TabStop = false;
            this.grpServerInfo.Text = "Server Information";
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasePassword.ForeColor = System.Drawing.Color.Silver;
            this.txtDatabasePassword.Location = new System.Drawing.Point(12, 65);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.Size = new System.Drawing.Size(220, 21);
            this.txtDatabasePassword.TabIndex = 3;
            this.txtDatabasePassword.Text = "database password";
            this.txtDatabasePassword.Enter += new System.EventHandler(this.txtDatabasePassword_Enter);
            this.txtDatabasePassword.Leave += new System.EventHandler(this.txtDatabasePassword_Leave);
            // 
            // txtDatabaseUsername
            // 
            this.txtDatabaseUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtDatabaseUsername.Location = new System.Drawing.Point(12, 42);
            this.txtDatabaseUsername.Name = "txtDatabaseUsername";
            this.txtDatabaseUsername.Size = new System.Drawing.Size(220, 21);
            this.txtDatabaseUsername.TabIndex = 2;
            this.txtDatabaseUsername.Text = "database username";
            this.txtDatabaseUsername.Enter += new System.EventHandler(this.txtDatabaseUsername_Enter);
            this.txtDatabaseUsername.Leave += new System.EventHandler(this.txtDatabaseUsername_Leave);
            // 
            // txtDatabasePort
            // 
            this.txtDatabasePort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasePort.ForeColor = System.Drawing.Color.Silver;
            this.txtDatabasePort.Location = new System.Drawing.Point(169, 19);
            this.txtDatabasePort.Name = "txtDatabasePort";
            this.txtDatabasePort.Size = new System.Drawing.Size(63, 21);
            this.txtDatabasePort.TabIndex = 1;
            this.txtDatabasePort.Text = "port";
            this.txtDatabasePort.Enter += new System.EventHandler(this.txtDatabasePort_Enter);
            this.txtDatabasePort.Leave += new System.EventHandler(this.txtDatabasePort_Leave);
            // 
            // txtDatabaseHostname
            // 
            this.txtDatabaseHostname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseHostname.ForeColor = System.Drawing.Color.Silver;
            this.txtDatabaseHostname.Location = new System.Drawing.Point(12, 19);
            this.txtDatabaseHostname.Name = "txtDatabaseHostname";
            this.txtDatabaseHostname.Size = new System.Drawing.Size(156, 21);
            this.txtDatabaseHostname.TabIndex = 0;
            this.txtDatabaseHostname.Text = "database hostname";
            this.txtDatabaseHostname.Enter += new System.EventHandler(this.txtDatabaseHostname_Enter);
            this.txtDatabaseHostname.Leave += new System.EventHandler(this.txtDatabaseHostname_Leave);
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 301);
            this.ControlBox = false;
            this.Controls.Add(this.tabConnectionInformation);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConnect";
            this.Text = "Connect to Database";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.tabConnectionInformation.ResumeLayout(false);
            this.tabServerInformation.ResumeLayout(false);
            this.grpDatabaseInfo.ResumeLayout(false);
            this.grpDatabaseInfo.PerformLayout();
            this.grpServerInfo.ResumeLayout(false);
            this.grpServerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabControl tabConnectionInformation;
        private System.Windows.Forms.TabPage tabServerInformation;
        private System.Windows.Forms.GroupBox grpServerInfo;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.TextBox txtDatabaseUsername;
        private System.Windows.Forms.TextBox txtDatabasePort;
        private System.Windows.Forms.TextBox txtDatabaseHostname;
        private System.Windows.Forms.GroupBox grpDatabaseInfo;
        private System.Windows.Forms.ComboBox cboCharDB;
        private System.Windows.Forms.ComboBox cboWorldDB;
        private System.Windows.Forms.ComboBox cboAuthDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh3;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button btnRefresh1;
    }
}