namespace UI
{
    partial class CPADetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbBuyInfo = new System.Windows.Forms.GroupBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.tbChargeAccount = new System.Windows.Forms.TextBox();
            this.lblChargeAccount = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbSupplierInfo = new System.Windows.Forms.GroupBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
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
            this.lblDay = new System.Windows.Forms.Label();
            this.gbTermsCondition = new System.Windows.Forms.GroupBox();
            this.tbTermsCondition = new System.Windows.Forms.TextBox();
            this.lblDisplayEffectDate = new System.Windows.Forms.Label();
            this.lblEffectDate = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDisplatStatus = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCNumber = new System.Windows.Forms.Label();
            this.gbContractDetails = new System.Windows.Forms.GroupBox();
            this.tbCNumber = new System.Windows.Forms.TextBox();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.lblSignatures = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbBuyInfo.SuspendLayout();
            this.gbSupplierInfo.SuspendLayout();
            this.gbTermsCondition.SuspendLayout();
            this.gbContractDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(12, 701);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 45);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(657, 701);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 45);
            this.btnEdit.TabIndex = 96;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.gbBuyInfo.Location = new System.Drawing.Point(21, 163);
            this.gbBuyInfo.Name = "gbBuyInfo";
            this.gbBuyInfo.Size = new System.Drawing.Size(757, 142);
            this.gbBuyInfo.TabIndex = 104;
            this.gbBuyInfo.TabStop = false;
            this.gbBuyInfo.Text = "Buyer Information";
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBuyerName.Location = new System.Drawing.Point(176, 22);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.ReadOnly = true;
            this.tbBuyerName.Size = new System.Drawing.Size(194, 26);
            this.tbBuyerName.TabIndex = 58;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuyerName.Location = new System.Drawing.Point(9, 25);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(103, 19);
            this.lblBuyerName.TabIndex = 57;
            this.lblBuyerName.Text = "Buyer Name";
            // 
            // tbChargeAccount
            // 
            this.tbChargeAccount.Font = new System.Drawing.Font("Arial", 12F);
            this.tbChargeAccount.Location = new System.Drawing.Point(555, 22);
            this.tbChargeAccount.Name = "tbChargeAccount";
            this.tbChargeAccount.ReadOnly = true;
            this.tbChargeAccount.Size = new System.Drawing.Size(187, 26);
            this.tbChargeAccount.TabIndex = 39;
            // 
            // lblChargeAccount
            // 
            this.lblChargeAccount.AutoSize = true;
            this.lblChargeAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChargeAccount.Location = new System.Drawing.Point(390, 25);
            this.lblChargeAccount.Name = "lblChargeAccount";
            this.lblChargeAccount.Size = new System.Drawing.Size(132, 19);
            this.lblChargeAccount.TabIndex = 40;
            this.lblChargeAccount.Text = "Charge Account";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.tbShipAddress.Location = new System.Drawing.Point(8, 76);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.ReadOnly = true;
            this.tbShipAddress.Size = new System.Drawing.Size(734, 55);
            this.tbShipAddress.TabIndex = 34;
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblShipAddress.Location = new System.Drawing.Point(6, 51);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(145, 19);
            this.lblShipAddress.TabIndex = 38;
            this.lblShipAddress.Text = "Shipping Address";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Arial", 14F);
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpEndDate.Location = new System.Drawing.Point(555, 57);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(187, 26);
            this.dtpEndDate.TabIndex = 38;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // gbSupplierInfo
            // 
            this.gbSupplierInfo.Controls.Add(this.tbSupplierID);
            this.gbSupplierInfo.Controls.Add(this.tbSupplierName);
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
            this.gbSupplierInfo.Location = new System.Drawing.Point(22, 311);
            this.gbSupplierInfo.Name = "gbSupplierInfo";
            this.gbSupplierInfo.Size = new System.Drawing.Size(756, 185);
            this.gbSupplierInfo.TabIndex = 103;
            this.gbSupplierInfo.TabStop = false;
            this.gbSupplierInfo.Text = "Supplier Information";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierID.Location = new System.Drawing.Point(555, 22);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(187, 26);
            this.tbSupplierID.TabIndex = 59;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierName.Location = new System.Drawing.Point(189, 22);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(195, 26);
            this.tbSupplierName.TabIndex = 58;
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(554, 22);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(187, 26);
            this.cbSupplierID.TabIndex = 57;
            this.cbSupplierID.SelectedIndexChanged += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            // 
            // cbSupplierName
            // 
            this.cbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSupplierName.FormattingEnabled = true;
            this.cbSupplierName.Location = new System.Drawing.Point(189, 22);
            this.cbSupplierName.Name = "cbSupplierName";
            this.cbSupplierName.Size = new System.Drawing.Size(195, 26);
            this.cbSupplierName.TabIndex = 56;
            this.cbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cbSupplierName_SelectedIndexChanged);
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.tbContactNumber.Location = new System.Drawing.Point(554, 57);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.ReadOnly = true;
            this.tbContactNumber.Size = new System.Drawing.Size(187, 26);
            this.tbContactNumber.TabIndex = 54;
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierAddress.Location = new System.Drawing.Point(10, 116);
            this.tbSupplierAddress.Multiline = true;
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.ReadOnly = true;
            this.tbSupplierAddress.Size = new System.Drawing.Size(731, 61);
            this.tbSupplierAddress.TabIndex = 53;
            // 
            // tbContactPerson
            // 
            this.tbContactPerson.Font = new System.Drawing.Font("Arial", 12F);
            this.tbContactPerson.Location = new System.Drawing.Point(189, 57);
            this.tbContactPerson.Name = "tbContactPerson";
            this.tbContactPerson.ReadOnly = true;
            this.tbContactPerson.Size = new System.Drawing.Size(195, 26);
            this.tbContactPerson.TabIndex = 52;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierAddress.Location = new System.Drawing.Point(4, 91);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(140, 19);
            this.lblSupplierAddress.TabIndex = 51;
            this.lblSupplierAddress.Text = "Supplier Address";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactNumber.Location = new System.Drawing.Point(390, 60);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(134, 19);
            this.lblContactNumber.TabIndex = 50;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblContractPerson
            // 
            this.lblContractPerson.AutoSize = true;
            this.lblContractPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContractPerson.Location = new System.Drawing.Point(4, 60);
            this.lblContractPerson.Name = "lblContractPerson";
            this.lblContractPerson.Size = new System.Drawing.Size(128, 19);
            this.lblContractPerson.TabIndex = 49;
            this.lblContractPerson.Text = "Contact Person";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierName.Location = new System.Drawing.Point(6, 25);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(121, 19);
            this.lblSupplierName.TabIndex = 48;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblsupplierID
            // 
            this.lblsupplierID.AutoSize = true;
            this.lblsupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblsupplierID.Location = new System.Drawing.Point(390, 25);
            this.lblsupplierID.Name = "lblsupplierID";
            this.lblsupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblsupplierID.TabIndex = 4;
            this.lblsupplierID.Text = "Supplier ID";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDay.Location = new System.Drawing.Point(647, 22);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 19);
            this.lblDay.TabIndex = 67;
            this.lblDay.Text = "day";
            // 
            // gbTermsCondition
            // 
            this.gbTermsCondition.Controls.Add(this.tbTermsCondition);
            this.gbTermsCondition.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gbTermsCondition.Location = new System.Drawing.Point(22, 502);
            this.gbTermsCondition.Name = "gbTermsCondition";
            this.gbTermsCondition.Size = new System.Drawing.Size(756, 140);
            this.gbTermsCondition.TabIndex = 101;
            this.gbTermsCondition.TabStop = false;
            this.gbTermsCondition.Text = "Terms and Condition";
            // 
            // tbTermsCondition
            // 
            this.tbTermsCondition.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTermsCondition.Location = new System.Drawing.Point(22, 28);
            this.tbTermsCondition.Multiline = true;
            this.tbTermsCondition.Name = "tbTermsCondition";
            this.tbTermsCondition.ReadOnly = true;
            this.tbTermsCondition.Size = new System.Drawing.Size(719, 99);
            this.tbTermsCondition.TabIndex = 23;
            // 
            // lblDisplayEffectDate
            // 
            this.lblDisplayEffectDate.AutoSize = true;
            this.lblDisplayEffectDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayEffectDate.Location = new System.Drawing.Point(552, 22);
            this.lblDisplayEffectDate.Name = "lblDisplayEffectDate";
            this.lblDisplayEffectDate.Size = new System.Drawing.Size(36, 19);
            this.lblDisplayEffectDate.TabIndex = 66;
            this.lblDisplayEffectDate.Text = "999";
            // 
            // lblEffectDate
            // 
            this.lblEffectDate.AutoSize = true;
            this.lblEffectDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEffectDate.Location = new System.Drawing.Point(390, 25);
            this.lblEffectDate.Name = "lblEffectDate";
            this.lblEffectDate.Size = new System.Drawing.Size(109, 19);
            this.lblEffectDate.TabIndex = 65;
            this.lblEffectDate.Text = "Effective Day";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(657, 701);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 45);
            this.btnConfirm.TabIndex = 107;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(205, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 29);
            this.lblTitle.TabIndex = 94;
            this.lblTitle.Text = "Contract Purchase Agreement Details";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(18, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 97;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDisplatStatus
            // 
            this.lblDisplatStatus.AutoSize = true;
            this.lblDisplatStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplatStatus.Location = new System.Drawing.Point(204, 648);
            this.lblDisplatStatus.Name = "lblDisplatStatus";
            this.lblDisplatStatus.Size = new System.Drawing.Size(58, 19);
            this.lblDisplatStatus.TabIndex = 106;
            this.lblDisplatStatus.Text = "Status";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Arial", 14F);
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpStartDate.Location = new System.Drawing.Point(189, 57);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(195, 26);
            this.dtpStartDate.TabIndex = 37;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(390, 62);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 19);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(11, 62);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 19);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblCNumber
            // 
            this.lblCNumber.AutoSize = true;
            this.lblCNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCNumber.Location = new System.Drawing.Point(11, 25);
            this.lblCNumber.Name = "lblCNumber";
            this.lblCNumber.Size = new System.Drawing.Size(140, 19);
            this.lblCNumber.TabIndex = 1;
            this.lblCNumber.Text = "Contract Number";
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
            this.gbContractDetails.Location = new System.Drawing.Point(21, 55);
            this.gbContractDetails.Name = "gbContractDetails";
            this.gbContractDetails.Size = new System.Drawing.Size(757, 102);
            this.gbContractDetails.TabIndex = 102;
            this.gbContractDetails.TabStop = false;
            this.gbContractDetails.Text = "Contract Details";
            // 
            // tbCNumber
            // 
            this.tbCNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCNumber.Location = new System.Drawing.Point(189, 22);
            this.tbCNumber.Name = "tbCNumber";
            this.tbCNumber.ReadOnly = true;
            this.tbCNumber.Size = new System.Drawing.Size(195, 26);
            this.tbCNumber.TabIndex = 15;
            // 
            // tbSignature
            // 
            this.tbSignature.Font = new System.Drawing.Font("Arial", 14.25F);
            this.tbSignature.Location = new System.Drawing.Point(606, 648);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.ReadOnly = true;
            this.tbSignature.Size = new System.Drawing.Size(172, 29);
            this.tbSignature.TabIndex = 99;
            // 
            // lblSignatures
            // 
            this.lblSignatures.AutoSize = true;
            this.lblSignatures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSignatures.Location = new System.Drawing.Point(455, 654);
            this.lblSignatures.Name = "lblSignatures";
            this.lblSignatures.Size = new System.Drawing.Size(102, 19);
            this.lblSignatures.TabIndex = 98;
            this.lblSignatures.Text = "Signatures: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(19, 648);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 105;
            this.lblStatus.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 49);
            this.panel1.TabIndex = 1084;
            // 
            // CPADetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbBuyInfo);
            this.Controls.Add(this.gbSupplierInfo);
            this.Controls.Add(this.gbTermsCondition);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDisplatStatus);
            this.Controls.Add(this.gbContractDetails);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblSignatures);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CPADetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPADetails";
            this.Load += new System.EventHandler(this.CPADetails_Load);
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

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbBuyInfo;
        private System.Windows.Forms.TextBox tbBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.TextBox tbChargeAccount;
        private System.Windows.Forms.Label lblChargeAccount;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox gbSupplierInfo;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.TextBox tbSupplierName;
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
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.GroupBox gbTermsCondition;
        private System.Windows.Forms.TextBox tbTermsCondition;
        private System.Windows.Forms.Label lblDisplayEffectDate;
        private System.Windows.Forms.Label lblEffectDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDisplatStatus;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCNumber;
        private System.Windows.Forms.GroupBox gbContractDetails;
        private System.Windows.Forms.TextBox tbCNumber;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblSignatures;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
    }
}