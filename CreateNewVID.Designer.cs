namespace UI
{
    partial class CreateNewVID
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
            this.tbVName = new System.Windows.Forms.TextBox();
            this.lblVName = new System.Windows.Forms.Label();
            this.lblCreateViD = new System.Windows.Forms.Label();
            this.tbVID = new System.Windows.Forms.TextBox();
            this.lblVID = new System.Windows.Forms.Label();
            this.lblAID = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.btnCreateVID = new System.Windows.Forms.Button();
            this.lblIVIDReminder = new System.Windows.Forms.Label();
            this.lblAssignAIDReminder = new System.Windows.Forms.Label();
            this.cbAssignAID = new System.Windows.Forms.ComboBox();
            this.cbAssignAName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVName
            // 
            this.tbVName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbVName.Location = new System.Drawing.Point(509, 77);
            this.tbVName.Name = "tbVName";
            this.tbVName.Size = new System.Drawing.Size(159, 26);
            this.tbVName.TabIndex = 1049;
            // 
            // lblVName
            // 
            this.lblVName.AutoSize = true;
            this.lblVName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblVName.Location = new System.Drawing.Point(351, 87);
            this.lblVName.Name = "lblVName";
            this.lblVName.Size = new System.Drawing.Size(142, 19);
            this.lblVName.TabIndex = 1048;
            this.lblVName.Text = "Virtual Item Name";
            // 
            // lblCreateViD
            // 
            this.lblCreateViD.AutoSize = true;
            this.lblCreateViD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCreateViD.Location = new System.Drawing.Point(307, 9);
            this.lblCreateViD.Name = "lblCreateViD";
            this.lblCreateViD.Size = new System.Drawing.Size(133, 29);
            this.lblCreateViD.TabIndex = 1047;
            this.lblCreateViD.Text = "Create VID";
            // 
            // tbVID
            // 
            this.tbVID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbVID.Location = new System.Drawing.Point(170, 73);
            this.tbVID.Name = "tbVID";
            this.tbVID.ReadOnly = true;
            this.tbVID.Size = new System.Drawing.Size(159, 26);
            this.tbVID.TabIndex = 1046;
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblVID.Location = new System.Drawing.Point(22, 84);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(118, 19);
            this.lblVID.TabIndex = 1045;
            this.lblVID.Text = "Virtual  Item ID";
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAID.Location = new System.Drawing.Point(22, 175);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(113, 19);
            this.lblAID.TabIndex = 1047;
            this.lblAID.Text = "Actual Item ID";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAName.Location = new System.Drawing.Point(351, 175);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(141, 19);
            this.lblAName.TabIndex = 63;
            this.lblAName.Text = "Actual Item Name";
            // 
            // btnCreateVID
            // 
            this.btnCreateVID.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCreateVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateVID.Location = new System.Drawing.Point(525, 231);
            this.btnCreateVID.Name = "btnCreateVID";
            this.btnCreateVID.Size = new System.Drawing.Size(143, 43);
            this.btnCreateVID.TabIndex = 1050;
            this.btnCreateVID.Text = "Create";
            this.btnCreateVID.UseVisualStyleBackColor = false;
            this.btnCreateVID.Click += new System.EventHandler(this.btnCreateVID_Click);
            // 
            // lblIVIDReminder
            // 
            this.lblIVIDReminder.AutoSize = true;
            this.lblIVIDReminder.Font = new System.Drawing.Font("Arial", 11F);
            this.lblIVIDReminder.ForeColor = System.Drawing.Color.Red;
            this.lblIVIDReminder.Location = new System.Drawing.Point(78, 114);
            this.lblIVIDReminder.Name = "lblIVIDReminder";
            this.lblIVIDReminder.Size = new System.Drawing.Size(251, 17);
            this.lblIVIDReminder.TabIndex = 1051;
            this.lblIVIDReminder.Text = "*Virtual ID is auto generate by system";
            // 
            // lblAssignAIDReminder
            // 
            this.lblAssignAIDReminder.AutoSize = true;
            this.lblAssignAIDReminder.Font = new System.Drawing.Font("Arial", 11F);
            this.lblAssignAIDReminder.ForeColor = System.Drawing.Color.Red;
            this.lblAssignAIDReminder.Location = new System.Drawing.Point(158, 214);
            this.lblAssignAIDReminder.Name = "lblAssignAIDReminder";
            this.lblAssignAIDReminder.Size = new System.Drawing.Size(171, 17);
            this.lblAssignAIDReminder.TabIndex = 1052;
            this.lblAssignAIDReminder.Text = "*You can assign AID later";
            // 
            // cbAssignAID
            // 
            this.cbAssignAID.Font = new System.Drawing.Font("Arial", 12F);
            this.cbAssignAID.FormattingEnabled = true;
            this.cbAssignAID.Location = new System.Drawing.Point(170, 168);
            this.cbAssignAID.Name = "cbAssignAID";
            this.cbAssignAID.Size = new System.Drawing.Size(159, 26);
            this.cbAssignAID.TabIndex = 1053;
            this.cbAssignAID.SelectedIndexChanged += new System.EventHandler(this.cbAssignAID_SelectedIndexChanged);
            // 
            // cbAssignAName
            // 
            this.cbAssignAName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbAssignAName.FormattingEnabled = true;
            this.cbAssignAName.Location = new System.Drawing.Point(509, 172);
            this.cbAssignAName.Name = "cbAssignAName";
            this.cbAssignAName.Size = new System.Drawing.Size(159, 26);
            this.cbAssignAName.TabIndex = 1054;
            this.cbAssignAName.SelectedIndexChanged += new System.EventHandler(this.cbAssignAName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblCreateViD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 55);
            this.panel1.TabIndex = 1084;
            // 
            // CreateNewVID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbAssignAName);
            this.Controls.Add(this.cbAssignAID);
            this.Controls.Add(this.lblAssignAIDReminder);
            this.Controls.Add(this.lblIVIDReminder);
            this.Controls.Add(this.btnCreateVID);
            this.Controls.Add(this.tbVName);
            this.Controls.Add(this.lblAID);
            this.Controls.Add(this.lblVName);
            this.Controls.Add(this.tbVID);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.lblAName);
            this.Name = "CreateNewVID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewVID";
            this.Load += new System.EventHandler(this.CreateNewVID_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVName;
        private System.Windows.Forms.Label lblVName;
        private System.Windows.Forms.Label lblCreateViD;
        private System.Windows.Forms.TextBox tbVID;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Button btnCreateVID;
        private System.Windows.Forms.Label lblIVIDReminder;
        private System.Windows.Forms.Label lblAssignAIDReminder;
        private System.Windows.Forms.ComboBox cbAssignAID;
        private System.Windows.Forms.ComboBox cbAssignAName;
        private System.Windows.Forms.Panel panel1;
    }
}