
namespace UI
{
    partial class fmLogoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogoin));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lklForgotPswd = new System.Windows.Forms.LinkLabel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnShowPswd = new System.Windows.Forms.Button();
            this.btnHidePswd = new System.Windows.Forms.Button();
            this.ptbDepartment = new System.Windows.Forms.PictureBox();
            this.ptbPassword = new System.Windows.Forms.PictureBox();
            this.ptbId = new System.Windows.Forms.PictureBox();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblId.Location = new System.Drawing.Point(140, 343);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "User ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(140, 457);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDepartment.Location = new System.Drawing.Point(140, 592);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(110, 25);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Department";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(144, 374);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(268, 33);
            this.tbId.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(144, 488);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(268, 32);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "--Select--",
            "Restaurant",
            "Category",
            "Purchasement",
            "Inventory",
            "Accounting",
            "Administrator"});
            this.cbDepartment.Location = new System.Drawing.Point(144, 622);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(268, 30);
            this.cbDepartment.TabIndex = 3;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(181, 698);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lklForgotPswd
            // 
            this.lklForgotPswd.AutoSize = true;
            this.lklForgotPswd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklForgotPswd.LinkColor = System.Drawing.Color.MediumBlue;
            this.lklForgotPswd.Location = new System.Drawing.Point(299, 534);
            this.lklForgotPswd.Name = "lklForgotPswd";
            this.lklForgotPswd.Size = new System.Drawing.Size(112, 16);
            this.lklForgotPswd.TabIndex = 11;
            this.lklForgotPswd.TabStop = true;
            this.lklForgotPswd.Text = "Forgot Password?";
            this.lklForgotPswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklForgotPswd_LinkClicked);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnShowPswd
            // 
            this.btnShowPswd.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPswd.Image")));
            this.btnShowPswd.Location = new System.Drawing.Point(418, 488);
            this.btnShowPswd.Name = "btnShowPswd";
            this.btnShowPswd.Size = new System.Drawing.Size(37, 32);
            this.btnShowPswd.TabIndex = 13;
            this.btnShowPswd.UseVisualStyleBackColor = true;
            this.btnShowPswd.Click += new System.EventHandler(this.btnShowPswd_Click);
            // 
            // btnHidePswd
            // 
            this.btnHidePswd.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePswd.Image")));
            this.btnHidePswd.Location = new System.Drawing.Point(418, 488);
            this.btnHidePswd.Name = "btnHidePswd";
            this.btnHidePswd.Size = new System.Drawing.Size(37, 32);
            this.btnHidePswd.TabIndex = 12;
            this.btnHidePswd.UseVisualStyleBackColor = true;
            this.btnHidePswd.Visible = false;
            this.btnHidePswd.Click += new System.EventHandler(this.btnHidePswd_Click);
            // 
            // ptbDepartment
            // 
            this.ptbDepartment.Image = global::UI.Properties.Resources.department_icon;
            this.ptbDepartment.Location = new System.Drawing.Point(54, 592);
            this.ptbDepartment.Name = "ptbDepartment";
            this.ptbDepartment.Size = new System.Drawing.Size(60, 61);
            this.ptbDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDepartment.TabIndex = 3;
            this.ptbDepartment.TabStop = false;
            // 
            // ptbPassword
            // 
            this.ptbPassword.Image = global::UI.Properties.Resources.password_icon;
            this.ptbPassword.Location = new System.Drawing.Point(54, 457);
            this.ptbPassword.Name = "ptbPassword";
            this.ptbPassword.Size = new System.Drawing.Size(60, 60);
            this.ptbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbPassword.TabIndex = 2;
            this.ptbPassword.TabStop = false;
            // 
            // ptbId
            // 
            this.ptbId.Image = global::UI.Properties.Resources.uID_icon;
            this.ptbId.Location = new System.Drawing.Point(54, 343);
            this.ptbId.Name = "ptbId";
            this.ptbId.Size = new System.Drawing.Size(64, 64);
            this.ptbId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbId.TabIndex = 1;
            this.ptbId.TabStop = false;
            // 
            // loginIcon
            // 
            this.loginIcon.Image = ((System.Drawing.Image)(resources.GetObject("loginIcon.Image")));
            this.loginIcon.Location = new System.Drawing.Point(181, 116);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(143, 145);
            this.loginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginIcon.TabIndex = 0;
            this.loginIcon.TabStop = false;
            this.loginIcon.WaitOnLoad = true;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblLoginTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 66);
            this.panel1.TabIndex = 14;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoginTitle.Location = new System.Drawing.Point(206, 9);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(88, 37);
            this.lblLoginTitle.TabIndex = 5;
            this.lblLoginTitle.Text = "Login";
            // 
            // fmLogoin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 789);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowPswd);
            this.Controls.Add(this.btnHidePswd);
            this.Controls.Add(this.lklForgotPswd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.ptbDepartment);
            this.Controls.Add(this.ptbPassword);
            this.Controls.Add(this.ptbId);
            this.Controls.Add(this.loginIcon);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fmLogoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Logoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginIcon;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox ptbId;
        private System.Windows.Forms.PictureBox ptbPassword;
        private System.Windows.Forms.PictureBox ptbDepartment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lklForgotPswd;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnHidePswd;
        private System.Windows.Forms.Button btnShowPswd;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginTitle;
    }
}

