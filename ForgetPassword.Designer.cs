
namespace UI
{
    partial class ForgetPassword
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtForgetEmail = new System.Windows.Forms.TextBox();
            this.btnForgetPasswordSendMail = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tbtforgetUserID = new System.Windows.Forms.TextBox();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.lblCodeTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.lblCreateNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblVerifyMessage = new System.Windows.Forms.Label();
            this.lblVerifyPassword = new System.Windows.Forms.Label();
            this.btnReturnLgoin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(66, 177);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 19);
            this.lblEmail.TabIndex = 70;
            this.lblEmail.Text = "Enter your Email";
            // 
            // txtForgetEmail
            // 
            this.txtForgetEmail.Location = new System.Drawing.Point(230, 170);
            this.txtForgetEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtForgetEmail.Name = "txtForgetEmail";
            this.txtForgetEmail.Size = new System.Drawing.Size(236, 26);
            this.txtForgetEmail.TabIndex = 2;
            // 
            // btnForgetPasswordSendMail
            // 
            this.btnForgetPasswordSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnForgetPasswordSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgetPasswordSendMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPasswordSendMail.Location = new System.Drawing.Point(255, 215);
            this.btnForgetPasswordSendMail.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgetPasswordSendMail.Name = "btnForgetPasswordSendMail";
            this.btnForgetPasswordSendMail.Size = new System.Drawing.Size(169, 58);
            this.btnForgetPasswordSendMail.TabIndex = 3;
            this.btnForgetPasswordSendMail.Text = "Send email";
            this.btnForgetPasswordSendMail.UseVisualStyleBackColor = false;
            this.btnForgetPasswordSendMail.Click += new System.EventHandler(this.btnForgetPasswordSendMail_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(66, 103);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(149, 19);
            this.lblUserID.TabIndex = 99;
            this.lblUserID.Text = "Enter your User ID";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tbtforgetUserID
            // 
            this.tbtforgetUserID.Location = new System.Drawing.Point(230, 96);
            this.tbtforgetUserID.Margin = new System.Windows.Forms.Padding(5);
            this.tbtforgetUserID.Name = "tbtforgetUserID";
            this.tbtforgetUserID.Size = new System.Drawing.Size(236, 26);
            this.tbtforgetUserID.TabIndex = 1;
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Location = new System.Drawing.Point(61, 288);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(494, 19);
            this.lblLine1.TabIndex = 88;
            this.lblLine1.Text = "---------------------------------------------------------------------------------" +
    "----------------";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // lblCodeTitle
            // 
            this.lblCodeTitle.AutoSize = true;
            this.lblCodeTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeTitle.Location = new System.Drawing.Point(265, 323);
            this.lblCodeTitle.Name = "lblCodeTitle";
            this.lblCodeTitle.Size = new System.Drawing.Size(129, 26);
            this.lblCodeTitle.TabIndex = 55;
            this.lblCodeTitle.Text = "Verify Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(239, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Forget Password";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(84, 375);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(117, 19);
            this.lblCode.TabIndex = 66;
            this.lblCode.Text = "Six Digit Code";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(232, 372);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(234, 26);
            this.tbCode.TabIndex = 4;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Location = new System.Drawing.Point(54, 520);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(494, 19);
            this.lblLine2.TabIndex = 44;
            this.lblLine2.Text = "---------------------------------------------------------------------------------" +
    "----------------";
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerifyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyCode.Location = new System.Drawing.Point(255, 448);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(169, 48);
            this.btnVerifyCode.TabIndex = 5;
            this.btnVerifyCode.Text = "Verify";
            this.btnVerifyCode.UseVisualStyleBackColor = false;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // lblCreateNewPassword
            // 
            this.lblCreateNewPassword.AutoSize = true;
            this.lblCreateNewPassword.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewPassword.Location = new System.Drawing.Point(205, 556);
            this.lblCreateNewPassword.Name = "lblCreateNewPassword";
            this.lblCreateNewPassword.Size = new System.Drawing.Size(242, 26);
            this.lblCreateNewPassword.TabIndex = 12;
            this.lblCreateNewPassword.Text = "Create New Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(66, 604);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(124, 19);
            this.lblNewPassword.TabIndex = 33;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(61, 674);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(151, 19);
            this.lblConfirmPassword.TabIndex = 68;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txConfirmPassword
            // 
            this.txConfirmPassword.Location = new System.Drawing.Point(232, 674);
            this.txConfirmPassword.Name = "txConfirmPassword";
            this.txConfirmPassword.ReadOnly = true;
            this.txConfirmPassword.Size = new System.Drawing.Size(234, 26);
            this.txConfirmPassword.TabIndex = 7;
            this.txConfirmPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(232, 604);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.ReadOnly = true;
            this.tbNewPassword.Size = new System.Drawing.Size(236, 26);
            this.tbNewPassword.TabIndex = 6;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.TextChanged += new System.EventHandler(this.tbNewPassword_TextChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Location = new System.Drawing.Point(255, 755);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(169, 48);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Submit";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblVerifyMessage
            // 
            this.lblVerifyMessage.AutoSize = true;
            this.lblVerifyMessage.Location = new System.Drawing.Point(101, 411);
            this.lblVerifyMessage.Name = "lblVerifyMessage";
            this.lblVerifyMessage.Size = new System.Drawing.Size(0, 19);
            this.lblVerifyMessage.TabIndex = 18;
            // 
            // lblVerifyPassword
            // 
            this.lblVerifyPassword.AutoSize = true;
            this.lblVerifyPassword.Location = new System.Drawing.Point(240, 721);
            this.lblVerifyPassword.Name = "lblVerifyPassword";
            this.lblVerifyPassword.Size = new System.Drawing.Size(0, 19);
            this.lblVerifyPassword.TabIndex = 19;
            // 
            // btnReturnLgoin
            // 
            this.btnReturnLgoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnLgoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnLgoin.Location = new System.Drawing.Point(12, 17);
            this.btnReturnLgoin.Name = "btnReturnLgoin";
            this.btnReturnLgoin.Size = new System.Drawing.Size(120, 42);
            this.btnReturnLgoin.TabIndex = 10;
            this.btnReturnLgoin.Tag = "";
            this.btnReturnLgoin.Text = "Login";
            this.btnReturnLgoin.UseVisualStyleBackColor = false;
            this.btnReturnLgoin.Click += new System.EventHandler(this.btnReturnLgoin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(67, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "*Upper letter at first, include lower case and integer and at least 8 length";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReturnLgoin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 71);
            this.panel1.TabIndex = 101;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVerifyPassword);
            this.Controls.Add(this.lblVerifyMessage);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.txConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCreateNewPassword);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblCodeTitle);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.tbtforgetUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnForgetPasswordSendMail);
            this.Controls.Add(this.txtForgetEmail);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgetPassword_FormClosed);
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtForgetEmail;
        private System.Windows.Forms.Button btnForgetPasswordSendMail;
        private System.Windows.Forms.Label lblUserID;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox tbtforgetUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodeTitle;
        private System.Windows.Forms.Label lblLine1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox txConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCreateNewPassword;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblVerifyMessage;
        private System.Windows.Forms.Label lblVerifyPassword;
        private System.Windows.Forms.Button btnReturnLgoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}