namespace UI
{
    partial class ContractPurchaseAgreement
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbBuyInfo = new System.Windows.Forms.GroupBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.tbChargeAccount = new System.Windows.Forms.TextBox();
            this.lblChargeAccount = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.gbSupplierInfo = new System.Windows.Forms.GroupBox();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.cbSupplierName = new System.Windows.Forms.ComboBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbSupplierAddress = new System.Windows.Forms.TextBox();
            this.tbContactPerson = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblContractPerson = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblsupplierID = new System.Windows.Forms.Label();
            this.gbTermsCondition = new System.Windows.Forms.GroupBox();
            this.tbTermsCondition = new System.Windows.Forms.TextBox();
            this.gbContractDetails = new System.Windows.Forms.GroupBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDisplayEffectDate = new System.Windows.Forms.Label();
            this.lblEffectDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbCNumber = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCNumber = new System.Windows.Forms.Label();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.lblSignatures = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBuyInfo.SuspendLayout();
            this.gbSupplierInfo.SuspendLayout();
            this.gbTermsCondition.SuspendLayout();
            this.gbContractDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(646, 730);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 50);
            this.btnCreate.TabIndex = 121;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbBuyInfo
            // 
            this.gbBuyInfo.Controls.Add(this.tbBuyerName);
            this.gbBuyInfo.Controls.Add(this.lblBuyerName);
            this.gbBuyInfo.Controls.Add(this.tbChargeAccount);
            this.gbBuyInfo.Controls.Add(this.lblChargeAccount);
            this.gbBuyInfo.Controls.Add(this.tbShipAddress);
            this.gbBuyInfo.Controls.Add(this.lblShipAddress);
            this.gbBuyInfo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gbBuyInfo.Location = new System.Drawing.Point(6, 195);
            this.gbBuyInfo.Name = "gbBuyInfo";
            this.gbBuyInfo.Size = new System.Drawing.Size(764, 154);
            this.gbBuyInfo.TabIndex = 128;
            this.gbBuyInfo.TabStop = false;
            this.gbBuyInfo.Text = "Buyer Information";
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBuyerName.Location = new System.Drawing.Point(192, 27);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.ReadOnly = true;
            this.tbBuyerName.Size = new System.Drawing.Size(189, 26);
            this.tbBuyerName.TabIndex = 58;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuyerName.Location = new System.Drawing.Point(14, 27);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(103, 19);
            this.lblBuyerName.TabIndex = 57;
            this.lblBuyerName.Text = "Buyer Name";
            // 
            // tbChargeAccount
            // 
            this.tbChargeAccount.Font = new System.Drawing.Font("Arial", 12F);
            this.tbChargeAccount.Location = new System.Drawing.Point(566, 27);
            this.tbChargeAccount.Name = "tbChargeAccount";
            this.tbChargeAccount.ReadOnly = true;
            this.tbChargeAccount.Size = new System.Drawing.Size(179, 26);
            this.tbChargeAccount.TabIndex = 39;
            // 
            // lblChargeAccount
            // 
            this.lblChargeAccount.AutoSize = true;
            this.lblChargeAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChargeAccount.Location = new System.Drawing.Point(401, 30);
            this.lblChargeAccount.Name = "lblChargeAccount";
            this.lblChargeAccount.Size = new System.Drawing.Size(132, 19);
            this.lblChargeAccount.TabIndex = 40;
            this.lblChargeAccount.Text = "Charge Account";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.tbShipAddress.Location = new System.Drawing.Point(15, 88);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.ReadOnly = true;
            this.tbShipAddress.Size = new System.Drawing.Size(730, 55);
            this.tbShipAddress.TabIndex = 34;
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblShipAddress.Location = new System.Drawing.Point(14, 63);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(145, 19);
            this.lblShipAddress.TabIndex = 38;
            this.lblShipAddress.Text = "Shipping Address";
            // 
            // gbSupplierInfo
            // 
            this.gbSupplierInfo.Controls.Add(this.cbSupplierID);
            this.gbSupplierInfo.Controls.Add(this.cbSupplierName);
            this.gbSupplierInfo.Controls.Add(this.tbContactNumber);
            this.gbSupplierInfo.Controls.Add(this.tbSupplierAddress);
            this.gbSupplierInfo.Controls.Add(this.tbContactPerson);
            this.gbSupplierInfo.Controls.Add(this.lblSupplierAddress);
            this.gbSupplierInfo.Controls.Add(this.lblContactNumber);
            this.gbSupplierInfo.Controls.Add(this.lblContractPerson);
            this.gbSupplierInfo.Controls.Add(this.lblSupplierName);
            this.gbSupplierInfo.Controls.Add(this.lblsupplierID);
            this.gbSupplierInfo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gbSupplierInfo.Location = new System.Drawing.Point(6, 355);
            this.gbSupplierInfo.Name = "gbSupplierInfo";
            this.gbSupplierInfo.Size = new System.Drawing.Size(764, 209);
            this.gbSupplierInfo.TabIndex = 127;
            this.gbSupplierInfo.TabStop = false;
            this.gbSupplierInfo.Text = "Supplier Information";
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(575, 27);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(170, 26);
            this.cbSupplierID.TabIndex = 57;
            this.cbSupplierID.SelectedIndexChanged += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            // 
            // cbSupplierName
            // 
            this.cbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSupplierName.FormattingEnabled = true;
            this.cbSupplierName.Location = new System.Drawing.Point(189, 27);
            this.cbSupplierName.Name = "cbSupplierName";
            this.cbSupplierName.Size = new System.Drawing.Size(159, 26);
            this.cbSupplierName.TabIndex = 56;
            this.cbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cbSupplierName_SelectedIndexChanged);
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.tbContactNumber.Location = new System.Drawing.Point(576, 63);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.ReadOnly = true;
            this.tbContactNumber.Size = new System.Drawing.Size(169, 26);
            this.tbContactNumber.TabIndex = 54;
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierAddress.Location = new System.Drawing.Point(15, 122);
            this.tbSupplierAddress.Multiline = true;
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.ReadOnly = true;
            this.tbSupplierAddress.Size = new System.Drawing.Size(730, 76);
            this.tbSupplierAddress.TabIndex = 53;
            // 
            // tbContactPerson
            // 
            this.tbContactPerson.Font = new System.Drawing.Font("Arial", 12F);
            this.tbContactPerson.Location = new System.Drawing.Point(189, 63);
            this.tbContactPerson.Name = "tbContactPerson";
            this.tbContactPerson.ReadOnly = true;
            this.tbContactPerson.Size = new System.Drawing.Size(159, 26);
            this.tbContactPerson.TabIndex = 52;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierAddress.Location = new System.Drawing.Point(14, 97);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(140, 19);
            this.lblSupplierAddress.TabIndex = 51;
            this.lblSupplierAddress.Text = "Supplier Address";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactNumber.Location = new System.Drawing.Point(393, 66);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(134, 19);
            this.lblContactNumber.TabIndex = 50;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblContractPerson
            // 
            this.lblContractPerson.AutoSize = true;
            this.lblContractPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContractPerson.Location = new System.Drawing.Point(14, 66);
            this.lblContractPerson.Name = "lblContractPerson";
            this.lblContractPerson.Size = new System.Drawing.Size(128, 19);
            this.lblContractPerson.TabIndex = 49;
            this.lblContractPerson.Text = "Contact Person";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierName.Location = new System.Drawing.Point(14, 30);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(121, 19);
            this.lblSupplierName.TabIndex = 48;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblsupplierID
            // 
            this.lblsupplierID.AutoSize = true;
            this.lblsupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblsupplierID.Location = new System.Drawing.Point(393, 30);
            this.lblsupplierID.Name = "lblsupplierID";
            this.lblsupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblsupplierID.TabIndex = 4;
            this.lblsupplierID.Text = "Supplier ID";
            // 
            // gbTermsCondition
            // 
            this.gbTermsCondition.Controls.Add(this.tbTermsCondition);
            this.gbTermsCondition.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gbTermsCondition.Location = new System.Drawing.Point(6, 570);
            this.gbTermsCondition.Name = "gbTermsCondition";
            this.gbTermsCondition.Size = new System.Drawing.Size(764, 140);
            this.gbTermsCondition.TabIndex = 125;
            this.gbTermsCondition.TabStop = false;
            this.gbTermsCondition.Text = "Terms and Condition";
            // 
            // tbTermsCondition
            // 
            this.tbTermsCondition.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTermsCondition.Location = new System.Drawing.Point(22, 28);
            this.tbTermsCondition.Multiline = true;
            this.tbTermsCondition.Name = "tbTermsCondition";
            this.tbTermsCondition.Size = new System.Drawing.Size(723, 99);
            this.tbTermsCondition.TabIndex = 23;
            // 
            // gbContractDetails
            // 
            this.gbContractDetails.Controls.Add(this.lblDay);
            this.gbContractDetails.Controls.Add(this.lblDisplayEffectDate);
            this.gbContractDetails.Controls.Add(this.lblEffectDate);
            this.gbContractDetails.Controls.Add(this.dtpEndDate);
            this.gbContractDetails.Controls.Add(this.dtpStartDate);
            this.gbContractDetails.Controls.Add(this.tbCNumber);
            this.gbContractDetails.Controls.Add(this.lblEndDate);
            this.gbContractDetails.Controls.Add(this.lblStartDate);
            this.gbContractDetails.Controls.Add(this.lblCNumber);
            this.gbContractDetails.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gbContractDetails.Location = new System.Drawing.Point(6, 86);
            this.gbContractDetails.Name = "gbContractDetails";
            this.gbContractDetails.Size = new System.Drawing.Size(764, 103);
            this.gbContractDetails.TabIndex = 126;
            this.gbContractDetails.TabStop = false;
            this.gbContractDetails.Text = "Contract Details";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDay.Location = new System.Drawing.Point(615, 30);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 19);
            this.lblDay.TabIndex = 67;
            this.lblDay.Text = "day";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayEffectDate
            // 
            this.lblDisplayEffectDate.AutoSize = true;
            this.lblDisplayEffectDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayEffectDate.Location = new System.Drawing.Point(566, 30);
            this.lblDisplayEffectDate.Name = "lblDisplayEffectDate";
            this.lblDisplayEffectDate.Size = new System.Drawing.Size(36, 19);
            this.lblDisplayEffectDate.TabIndex = 66;
            this.lblDisplayEffectDate.Text = "999";
            this.lblDisplayEffectDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEffectDate
            // 
            this.lblEffectDate.AutoSize = true;
            this.lblEffectDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEffectDate.Location = new System.Drawing.Point(404, 30);
            this.lblEffectDate.Name = "lblEffectDate";
            this.lblEffectDate.Size = new System.Drawing.Size(109, 19);
            this.lblEffectDate.TabIndex = 65;
            this.lblEffectDate.Text = "Effective Day";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Arial", 14F);
            this.dtpEndDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpEndDate.Location = new System.Drawing.Point(566, 62);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(169, 26);
            this.dtpEndDate.TabIndex = 38;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Arial", 14F);
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpStartDate.Location = new System.Drawing.Point(189, 62);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(169, 26);
            this.dtpStartDate.TabIndex = 37;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // tbCNumber
            // 
            this.tbCNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCNumber.Location = new System.Drawing.Point(189, 27);
            this.tbCNumber.Name = "tbCNumber";
            this.tbCNumber.ReadOnly = true;
            this.tbCNumber.Size = new System.Drawing.Size(172, 26);
            this.tbCNumber.TabIndex = 15;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(404, 67);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 19);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(14, 67);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 19);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblCNumber
            // 
            this.lblCNumber.AutoSize = true;
            this.lblCNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCNumber.Location = new System.Drawing.Point(14, 30);
            this.lblCNumber.Name = "lblCNumber";
            this.lblCNumber.Size = new System.Drawing.Size(140, 19);
            this.lblCNumber.TabIndex = 1;
            this.lblCNumber.Text = "Contract Number";
            // 
            // tbSignature
            // 
            this.tbSignature.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSignature.Location = new System.Drawing.Point(154, 730);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(172, 26);
            this.tbSignature.TabIndex = 123;
            // 
            // lblSignatures
            // 
            this.lblSignatures.AutoSize = true;
            this.lblSignatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSignatures.Location = new System.Drawing.Point(25, 733);
            this.lblSignatures.Name = "lblSignatures";
            this.lblSignatures.Size = new System.Drawing.Size(102, 19);
            this.lblSignatures.TabIndex = 122;
            this.lblSignatures.Text = "Signatures: ";
            this.lblSignatures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 55);
            this.panel1.TabIndex = 1084;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Contract Purchase Agreement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContractPurchaseAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 796);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuyInfo);
            this.Controls.Add(this.gbSupplierInfo);
            this.Controls.Add(this.gbTermsCondition);
            this.Controls.Add(this.gbContractDetails);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblSignatures);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ContractPurchaseAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractPurchaseAgreement";
            this.Load += new System.EventHandler(this.ContractPurchaseAgreement_Load);
            this.gbBuyInfo.ResumeLayout(false);
            this.gbBuyInfo.PerformLayout();
            this.gbSupplierInfo.ResumeLayout(false);
            this.gbSupplierInfo.PerformLayout();
            this.gbTermsCondition.ResumeLayout(false);
            this.gbTermsCondition.PerformLayout();
            this.gbContractDetails.ResumeLayout(false);
            this.gbContractDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbBuyInfo;
        private System.Windows.Forms.TextBox tbBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.TextBox tbChargeAccount;
        private System.Windows.Forms.Label lblChargeAccount;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.GroupBox gbSupplierInfo;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.ComboBox cbSupplierName;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbSupplierAddress;
        private System.Windows.Forms.TextBox tbContactPerson;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblContractPerson;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblsupplierID;
        private System.Windows.Forms.GroupBox gbTermsCondition;
        private System.Windows.Forms.TextBox tbTermsCondition;
        private System.Windows.Forms.GroupBox gbContractDetails;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDisplayEffectDate;
        private System.Windows.Forms.Label lblEffectDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbCNumber;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCNumber;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblSignatures;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}