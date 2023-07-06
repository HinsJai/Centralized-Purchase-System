namespace UI
{
    partial class RequestQueueDetails
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
            this.cbAggreement = new System.Windows.Forms.ComboBox();
            this.lblAsignAgreement = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.displayItemStatus = new System.Windows.Forms.Label();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModifyReason = new System.Windows.Forms.Label();
            this.tbModifyReason = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblDisplayRequestDateTime = new System.Windows.Forms.Label();
            this.tbRequestRemark = new System.Windows.Forms.TextBox();
            this.lblRequestRemark = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRequestQueue = new System.Windows.Forms.Label();
            this.lblUnitDisplay = new System.Windows.Forms.Label();
            this.lblStatusDisplay = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.tbRequestItemVID = new System.Windows.Forms.TextBox();
            this.tbRequestQty = new System.Windows.Forms.TextBox();
            this.tbRequestItemTypeName = new System.Windows.Forms.TextBox();
            this.tbRequestItemCategory = new System.Windows.Forms.TextBox();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRequestDateTime = new System.Windows.Forms.Label();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRequestItemCategory = new System.Windows.Forms.Label();
            this.lblRequestItemTypeName = new System.Windows.Forms.Label();
            this.lblRequestItemVID = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.btnConfirmReject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOrderRemark = new System.Windows.Forms.Label();
            this.tbOrderRemark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAggreement
            // 
            this.cbAggreement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAggreement.Font = new System.Drawing.Font("Arial", 12F);
            this.cbAggreement.FormattingEnabled = true;
            this.cbAggreement.Location = new System.Drawing.Point(645, 134);
            this.cbAggreement.Name = "cbAggreement";
            this.cbAggreement.Size = new System.Drawing.Size(200, 26);
            this.cbAggreement.TabIndex = 75;
            this.cbAggreement.SelectedIndexChanged += new System.EventHandler(this.cbAggreement_SelectedIndexChanged);
            // 
            // lblAsignAgreement
            // 
            this.lblAsignAgreement.AutoSize = true;
            this.lblAsignAgreement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAsignAgreement.Location = new System.Drawing.Point(443, 137);
            this.lblAsignAgreement.Name = "lblAsignAgreement";
            this.lblAsignAgreement.Size = new System.Drawing.Size(148, 19);
            this.lblAsignAgreement.TabIndex = 74;
            this.lblAsignAgreement.Text = "Assign Agreement";
            // 
            // tbBrand
            // 
            this.tbBrand.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBrand.Location = new System.Drawing.Point(207, 335);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.Size = new System.Drawing.Size(200, 26);
            this.tbBrand.TabIndex = 73;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(16, 338);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 19);
            this.lblBrand.TabIndex = 72;
            this.lblBrand.Text = "Brand";
            // 
            // displayItemStatus
            // 
            this.displayItemStatus.AutoSize = true;
            this.displayItemStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.displayItemStatus.Location = new System.Drawing.Point(637, 384);
            this.displayItemStatus.Name = "displayItemStatus";
            this.displayItemStatus.Size = new System.Drawing.Size(0, 19);
            this.displayItemStatus.TabIndex = 70;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.AutoSize = true;
            this.lblItemStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemStatus.Location = new System.Drawing.Point(442, 384);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(94, 19);
            this.lblItemStatus.TabIndex = 69;
            this.lblItemStatus.Text = "Item Status";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.MistyRose;
            this.btnReject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReject.Location = new System.Drawing.Point(20, 9);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(150, 32);
            this.btnReject.TabIndex = 68;
            this.btnReject.Text = "Reject Request";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // cbItemName
            // 
            this.cbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Location = new System.Drawing.Point(207, 134);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(200, 26);
            this.cbItemName.TabIndex = 66;
            this.cbItemName.SelectedIndexChanged += new System.EventHandler(this.cbItemName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Item Name";
            // 
            // lblModifyReason
            // 
            this.lblModifyReason.AutoSize = true;
            this.lblModifyReason.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblModifyReason.Location = new System.Drawing.Point(16, 384);
            this.lblModifyReason.Name = "lblModifyReason";
            this.lblModifyReason.Size = new System.Drawing.Size(123, 19);
            this.lblModifyReason.TabIndex = 64;
            this.lblModifyReason.Text = "Modify Reason";
            // 
            // tbModifyReason
            // 
            this.tbModifyReason.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModifyReason.Location = new System.Drawing.Point(20, 418);
            this.tbModifyReason.Multiline = true;
            this.tbModifyReason.Name = "tbModifyReason";
            this.tbModifyReason.ReadOnly = true;
            this.tbModifyReason.Size = new System.Drawing.Size(387, 177);
            this.tbModifyReason.TabIndex = 63;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateOrder.Enabled = false;
            this.btnCreateOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.Location = new System.Drawing.Point(20, 601);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(155, 41);
            this.btnCreateOrder.TabIndex = 62;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblDisplayRequestDateTime
            // 
            this.lblDisplayRequestDateTime.AutoSize = true;
            this.lblDisplayRequestDateTime.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDisplayRequestDateTime.Location = new System.Drawing.Point(635, 288);
            this.lblDisplayRequestDateTime.Name = "lblDisplayRequestDateTime";
            this.lblDisplayRequestDateTime.Size = new System.Drawing.Size(0, 18);
            this.lblDisplayRequestDateTime.TabIndex = 61;
            // 
            // tbRequestRemark
            // 
            this.tbRequestRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestRemark.Location = new System.Drawing.Point(446, 465);
            this.tbRequestRemark.Multiline = true;
            this.tbRequestRemark.Name = "tbRequestRemark";
            this.tbRequestRemark.ReadOnly = true;
            this.tbRequestRemark.Size = new System.Drawing.Size(387, 130);
            this.tbRequestRemark.TabIndex = 60;
            // 
            // lblRequestRemark
            // 
            this.lblRequestRemark.AutoSize = true;
            this.lblRequestRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestRemark.Location = new System.Drawing.Point(442, 426);
            this.lblRequestRemark.Name = "lblRequestRemark";
            this.lblRequestRemark.Size = new System.Drawing.Size(130, 19);
            this.lblRequestRemark.TabIndex = 59;
            this.lblRequestRemark.Text = "Request remark";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(698, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 41);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRequestQueue
            // 
            this.lblRequestQueue.AutoSize = true;
            this.lblRequestQueue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestQueue.Location = new System.Drawing.Point(340, 9);
            this.lblRequestQueue.Name = "lblRequestQueue";
            this.lblRequestQueue.Size = new System.Drawing.Size(215, 32);
            this.lblRequestQueue.TabIndex = 56;
            this.lblRequestQueue.Text = "Request Queue";
            // 
            // lblUnitDisplay
            // 
            this.lblUnitDisplay.AutoSize = true;
            this.lblUnitDisplay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitDisplay.Location = new System.Drawing.Point(637, 229);
            this.lblUnitDisplay.Name = "lblUnitDisplay";
            this.lblUnitDisplay.Size = new System.Drawing.Size(0, 22);
            this.lblUnitDisplay.TabIndex = 55;
            // 
            // lblStatusDisplay
            // 
            this.lblStatusDisplay.AutoSize = true;
            this.lblStatusDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusDisplay.Location = new System.Drawing.Point(637, 338);
            this.lblStatusDisplay.Name = "lblStatusDisplay";
            this.lblStatusDisplay.Size = new System.Drawing.Size(0, 19);
            this.lblStatusDisplay.TabIndex = 54;
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.Enabled = false;
            this.dtpPickUpDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpPickUpDate.Location = new System.Drawing.Point(207, 235);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpPickUpDate.TabIndex = 53;
            // 
            // tbRequestItemVID
            // 
            this.tbRequestItemVID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRequestItemVID.Location = new System.Drawing.Point(207, 185);
            this.tbRequestItemVID.Name = "tbRequestItemVID";
            this.tbRequestItemVID.ReadOnly = true;
            this.tbRequestItemVID.Size = new System.Drawing.Size(200, 26);
            this.tbRequestItemVID.TabIndex = 52;
            // 
            // tbRequestQty
            // 
            this.tbRequestQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRequestQty.Location = new System.Drawing.Point(645, 185);
            this.tbRequestQty.Name = "tbRequestQty";
            this.tbRequestQty.ReadOnly = true;
            this.tbRequestQty.Size = new System.Drawing.Size(200, 26);
            this.tbRequestQty.TabIndex = 51;
            // 
            // tbRequestItemTypeName
            // 
            this.tbRequestItemTypeName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRequestItemTypeName.Location = new System.Drawing.Point(207, 285);
            this.tbRequestItemTypeName.Name = "tbRequestItemTypeName";
            this.tbRequestItemTypeName.ReadOnly = true;
            this.tbRequestItemTypeName.Size = new System.Drawing.Size(200, 26);
            this.tbRequestItemTypeName.TabIndex = 50;
            // 
            // tbRequestItemCategory
            // 
            this.tbRequestItemCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRequestItemCategory.Location = new System.Drawing.Point(645, 84);
            this.tbRequestItemCategory.Name = "tbRequestItemCategory";
            this.tbRequestItemCategory.ReadOnly = true;
            this.tbRequestItemCategory.Size = new System.Drawing.Size(200, 26);
            this.tbRequestItemCategory.TabIndex = 49;
            // 
            // tbRequestID
            // 
            this.tbRequestID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRequestID.Location = new System.Drawing.Point(207, 84);
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(200, 26);
            this.tbRequestID.TabIndex = 48;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(442, 338);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // lblRequestDateTime
            // 
            this.lblRequestDateTime.AutoSize = true;
            this.lblRequestDateTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestDateTime.Location = new System.Drawing.Point(442, 288);
            this.lblRequestDateTime.Name = "lblRequestDateTime";
            this.lblRequestDateTime.Size = new System.Drawing.Size(153, 19);
            this.lblRequestDateTime.TabIndex = 46;
            this.lblRequestDateTime.Text = "Request Date Time";
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPickUpDate.Location = new System.Drawing.Point(16, 240);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(107, 19);
            this.lblPickUpDate.TabIndex = 45;
            this.lblPickUpDate.Text = "Pick Up Date";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(443, 240);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 44;
            this.lblUnit.Text = "Unit";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblQty.Location = new System.Drawing.Point(442, 188);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(35, 19);
            this.lblQty.TabIndex = 43;
            this.lblQty.Text = "Qty";
            // 
            // lblRequestItemCategory
            // 
            this.lblRequestItemCategory.AutoSize = true;
            this.lblRequestItemCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestItemCategory.Location = new System.Drawing.Point(442, 87);
            this.lblRequestItemCategory.Name = "lblRequestItemCategory";
            this.lblRequestItemCategory.Size = new System.Drawing.Size(115, 19);
            this.lblRequestItemCategory.TabIndex = 42;
            this.lblRequestItemCategory.Text = "Item Category";
            // 
            // lblRequestItemTypeName
            // 
            this.lblRequestItemTypeName.AutoSize = true;
            this.lblRequestItemTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestItemTypeName.Location = new System.Drawing.Point(16, 288);
            this.lblRequestItemTypeName.Name = "lblRequestItemTypeName";
            this.lblRequestItemTypeName.Size = new System.Drawing.Size(82, 19);
            this.lblRequestItemTypeName.TabIndex = 41;
            this.lblRequestItemTypeName.Text = "Item Type";
            // 
            // lblRequestItemVID
            // 
            this.lblRequestItemVID.AutoSize = true;
            this.lblRequestItemVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestItemVID.Location = new System.Drawing.Point(16, 188);
            this.lblRequestItemVID.Name = "lblRequestItemVID";
            this.lblRequestItemVID.Size = new System.Drawing.Size(61, 19);
            this.lblRequestItemVID.TabIndex = 40;
            this.lblRequestItemVID.Text = "Item ID";
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestID.Location = new System.Drawing.Point(16, 87);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(93, 19);
            this.lblRequestID.TabIndex = 39;
            this.lblRequestID.Text = "Request ID";
            // 
            // btnConfirmReject
            // 
            this.btnConfirmReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmReject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmReject.Location = new System.Drawing.Point(192, 601);
            this.btnConfirmReject.Name = "btnConfirmReject";
            this.btnConfirmReject.Size = new System.Drawing.Size(135, 41);
            this.btnConfirmReject.TabIndex = 76;
            this.btnConfirmReject.Text = "Confirm";
            this.btnConfirmReject.UseVisualStyleBackColor = false;
            this.btnConfirmReject.Visible = false;
            this.btnConfirmReject.Click += new System.EventHandler(this.btnConfirmReject_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(557, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 41);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOrderRemark
            // 
            this.lblOrderRemark.AutoSize = true;
            this.lblOrderRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderRemark.Location = new System.Drawing.Point(443, 426);
            this.lblOrderRemark.Name = "lblOrderRemark";
            this.lblOrderRemark.Size = new System.Drawing.Size(115, 19);
            this.lblOrderRemark.TabIndex = 78;
            this.lblOrderRemark.Text = "Order Remark";
            this.lblOrderRemark.Visible = false;
            // 
            // tbOrderRemark
            // 
            this.tbOrderRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderRemark.Location = new System.Drawing.Point(447, 465);
            this.tbOrderRemark.Multiline = true;
            this.tbOrderRemark.Name = "tbOrderRemark";
            this.tbOrderRemark.Size = new System.Drawing.Size(387, 130);
            this.tbOrderRemark.TabIndex = 79;
            this.tbOrderRemark.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblRequestQueue);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 54);
            this.panel1.TabIndex = 80;
            // 
            // RequestQueueDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbOrderRemark);
            this.Controls.Add(this.lblOrderRemark);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmReject);
            this.Controls.Add(this.cbAggreement);
            this.Controls.Add(this.lblAsignAgreement);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.displayItemStatus);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.cbItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModifyReason);
            this.Controls.Add(this.tbModifyReason);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lblDisplayRequestDateTime);
            this.Controls.Add(this.tbRequestRemark);
            this.Controls.Add(this.lblRequestRemark);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUnitDisplay);
            this.Controls.Add(this.lblStatusDisplay);
            this.Controls.Add(this.dtpPickUpDate);
            this.Controls.Add(this.tbRequestItemVID);
            this.Controls.Add(this.tbRequestQty);
            this.Controls.Add(this.tbRequestItemTypeName);
            this.Controls.Add(this.tbRequestItemCategory);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRequestDateTime);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblRequestItemCategory);
            this.Controls.Add(this.lblRequestItemTypeName);
            this.Controls.Add(this.lblRequestItemVID);
            this.Controls.Add(this.lblRequestID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RequestQueueDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestQueueDetails";
            this.Load += new System.EventHandler(this.RequestQueueDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAggreement;
        private System.Windows.Forms.Label lblAsignAgreement;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label displayItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModifyReason;
        private System.Windows.Forms.TextBox tbModifyReason;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lblDisplayRequestDateTime;
        private System.Windows.Forms.TextBox tbRequestRemark;
        private System.Windows.Forms.Label lblRequestRemark;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRequestQueue;
        private System.Windows.Forms.Label lblUnitDisplay;
        private System.Windows.Forms.Label lblStatusDisplay;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.TextBox tbRequestItemVID;
        private System.Windows.Forms.TextBox tbRequestQty;
        private System.Windows.Forms.TextBox tbRequestItemTypeName;
        private System.Windows.Forms.TextBox tbRequestItemCategory;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRequestDateTime;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRequestItemCategory;
        private System.Windows.Forms.Label lblRequestItemTypeName;
        private System.Windows.Forms.Label lblRequestItemVID;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Button btnConfirmReject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOrderRemark;
        private System.Windows.Forms.TextBox tbOrderRemark;
        private System.Windows.Forms.Panel panel1;
    }
}