﻿namespace SmtpTester
{
	partial class SmtpTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmtpTester));
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.chkEnableTLS = new System.Windows.Forms.CheckBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtBCC = new System.Windows.Forms.TextBox();
            this.lblBCC = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnTestEmail = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.chkDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.chkEnableSSL = new System.Windows.Forms.CheckBox();
            this.chkUserAuthentication = new System.Windows.Forms.CheckBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ClearLogs = new System.Windows.Forms.Button();
            this.cmb_preconfig = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(13, 48);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(77, 45);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(140, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "smtp-pulse.com";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(227, 48);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(262, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "2525";
            // 
            // chkEnableTLS
            // 
            this.chkEnableTLS.AutoSize = true;
            this.chkEnableTLS.Location = new System.Drawing.Point(408, 47);
            this.chkEnableTLS.Name = "chkEnableTLS";
            this.chkEnableTLS.Size = new System.Drawing.Size(46, 17);
            this.chkEnableTLS.TabIndex = 4;
            this.chkEnableTLS.Text = "TLS";
            this.chkEnableTLS.UseVisualStyleBackColor = true;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(13, 175);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 10;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(77, 172);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(140, 20);
            this.txtFrom.TabIndex = 11;
            this.txtFrom.Text = "sbrakl@gmail.com";
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(262, 172);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(202, 20);
            this.txtTo.TabIndex = 13;
            this.txtTo.Text = "sakolawala@webuy.com";
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(227, 175);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "To:";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // txtBCC
            // 
            this.txtBCC.Location = new System.Drawing.Point(77, 198);
            this.txtBCC.Name = "txtBCC";
            this.txtBCC.Size = new System.Drawing.Size(140, 20);
            this.txtBCC.TabIndex = 17;
            this.txtBCC.TextChanged += new System.EventHandler(this.txtBCC_TextChanged);
            // 
            // lblBCC
            // 
            this.lblBCC.AutoSize = true;
            this.lblBCC.Location = new System.Drawing.Point(13, 201);
            this.lblBCC.Name = "lblBCC";
            this.lblBCC.Size = new System.Drawing.Size(31, 13);
            this.lblBCC.TabIndex = 16;
            this.lblBCC.Text = "BCC:";
            this.lblBCC.Click += new System.EventHandler(this.lblBCC_Click);
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(262, 198);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(202, 20);
            this.txtCC.TabIndex = 15;
            this.txtCC.TextChanged += new System.EventHandler(this.txtCC_TextChanged);
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(227, 201);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(24, 13);
            this.lblCC.TabIndex = 14;
            this.lblCC.Text = "CC:";
            this.lblCC.Click += new System.EventHandler(this.lblCC_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(470, 64);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(448, 345);
            this.txtOutput.TabIndex = 24;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(328, 130);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(136, 23);
            this.btnTestConnection.TabIndex = 22;
            this.btnTestConnection.Text = "&Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnTestEmail
            // 
            this.btnTestEmail.Location = new System.Drawing.Point(328, 379);
            this.btnTestEmail.Name = "btnTestEmail";
            this.btnTestEmail.Size = new System.Drawing.Size(136, 23);
            this.btnTestEmail.TabIndex = 23;
            this.btnTestEmail.Text = "&Send Email";
            this.btnTestEmail.UseVisualStyleBackColor = true;
            this.btnTestEmail.Click += new System.EventHandler(this.btnTestEmail_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(77, 224);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(387, 20);
            this.txtSubject.TabIndex = 19;
            this.txtSubject.Text = "Test email from client";
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(13, 227);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Subject:";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(13, 253);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 13);
            this.lblBody.TabIndex = 20;
            this.lblBody.Text = "Body:";
            this.lblBody.Click += new System.EventHandler(this.lblBody_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(77, 250);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(387, 123);
            this.txtBody.TabIndex = 21;
            this.txtBody.Text = "test email from client";
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // chkDefaultCredentials
            // 
            this.chkDefaultCredentials.AutoSize = true;
            this.chkDefaultCredentials.Location = new System.Drawing.Point(408, 73);
            this.chkDefaultCredentials.Name = "chkDefaultCredentials";
            this.chkDefaultCredentials.Size = new System.Drawing.Size(60, 17);
            this.chkDefaultCredentials.TabIndex = 9;
            this.chkDefaultCredentials.Text = "Default";
            this.chkDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(262, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(227, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Pwd:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(77, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 74);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(571, 13);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(220, 20);
            this.pbLoading.TabIndex = 25;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Location = new System.Drawing.Point(356, 97);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(46, 17);
            this.chkEnableSSL.TabIndex = 26;
            this.chkEnableSSL.Text = "SSL";
            this.chkEnableSSL.UseVisualStyleBackColor = true;
            // 
            // chkUserAuthentication
            // 
            this.chkUserAuthentication.AutoSize = true;
            this.chkUserAuthentication.Checked = true;
            this.chkUserAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserAuthentication.Location = new System.Drawing.Point(273, 97);
            this.chkUserAuthentication.Name = "chkUserAuthentication";
            this.chkUserAuthentication.Size = new System.Drawing.Size(77, 17);
            this.chkUserAuthentication.TabIndex = 27;
            this.chkUserAuthentication.Text = "Auth Req?";
            this.chkUserAuthentication.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(801, 22);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 13);
            this.lblTimer.TabIndex = 28;
            this.lblTimer.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Elapse Time";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(77, 98);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(75, 20);
            this.txtTimer.TabIndex = 31;
            this.txtTimer.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Timeout:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "secs";
            // 
            // btn_ClearLogs
            // 
            this.btn_ClearLogs.Location = new System.Drawing.Point(470, 38);
            this.btn_ClearLogs.Name = "btn_ClearLogs";
            this.btn_ClearLogs.Size = new System.Drawing.Size(136, 23);
            this.btn_ClearLogs.TabIndex = 33;
            this.btn_ClearLogs.Text = "&Clear Logs";
            this.btn_ClearLogs.UseVisualStyleBackColor = true;
            this.btn_ClearLogs.Click += new System.EventHandler(this.btn_ClearLogs_Click);
            // 
            // cmb_preconfig
            // 
            this.cmb_preconfig.FormattingEnabled = true;
            this.cmb_preconfig.Items.AddRange(new object[] {
            "localhost",
            "sendpulse",
            "smtp2go"});
            this.cmb_preconfig.Location = new System.Drawing.Point(90, 18);
            this.cmb_preconfig.Name = "cmb_preconfig";
            this.cmb_preconfig.Size = new System.Drawing.Size(121, 21);
            this.cmb_preconfig.TabIndex = 34;
            this.cmb_preconfig.SelectedIndexChanged += new System.EventHandler(this.cmb_preconfig_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "PreConfigure:";
            // 
            // SmtpTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_preconfig);
            this.Controls.Add(this.btn_ClearLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.chkUserAuthentication);
            this.Controls.Add(this.chkEnableSSL);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.chkDefaultCredentials);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnTestEmail);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtBCC);
            this.Controls.Add(this.lblBCC);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.chkEnableTLS);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Name = "SmtpTester";
            this.Text = "SMTP Tester";
            this.Load += new System.EventHandler(this.SmtpTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.CheckBox chkEnableTLS;
		private System.Windows.Forms.Label lblFrom;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.TextBox txtBCC;
		private System.Windows.Forms.Label lblBCC;
		private System.Windows.Forms.TextBox txtCC;
		private System.Windows.Forms.Label lblCC;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnTestConnection;
		private System.Windows.Forms.Button btnTestEmail;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblBody;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.CheckBox chkDefaultCredentials;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.CheckBox chkEnableSSL;
        private System.Windows.Forms.CheckBox chkUserAuthentication;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ClearLogs;
        private System.Windows.Forms.ComboBox cmb_preconfig;
        private System.Windows.Forms.Label label4;
    }
}

