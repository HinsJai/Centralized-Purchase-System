namespace UI
{
    partial class BPAOrderDetails
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
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBPAOrder = new System.Windows.Forms.Label();
            this.lblUnitDisplay = new System.Windows.Forms.Label();
            this.lblStatusDisplay = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.tbItemAID = new System.Windows.Forms.TextBox();
            this.tbAgreementID = new System.Windows.Forms.TextBox();
            this.tbitemType = new System.Windows.Forms.TextBox();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblAgreementID = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblRequestItemAID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbOrderQty = new System.Windows.Forms.TextBox();
            this.lblOrderQty = new System.Windows.Forms.Label();
            this.lblDisplayStatus = new System.Windows.Forms.Label();
            this.tbOrderRemark = new System.Windows.Forms.TextBox();
            this.lblOrderRemark = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancelOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.Location = new System.Drawing.Point(29, 7);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(119, 45);
            this.btnCancelOrder.TabIndex = 66;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelItem.Location = new System.Drawing.Point(454, 536);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(0, 0);
            this.btnCancelItem.TabIndex = 65;
            this.btnCancelItem.Text = "Cancel Item";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(177, 536);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(0, 0);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(582, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 41);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBPAOrder
            // 
            this.lblBPAOrder.AutoSize = true;
            this.lblBPAOrder.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblBPAOrder.Location = new System.Drawing.Point(355, 9);
            this.lblBPAOrder.Name = "lblBPAOrder";
            this.lblBPAOrder.Size = new System.Drawing.Size(131, 29);
            this.lblBPAOrder.TabIndex = 54;
            this.lblBPAOrder.Text = "BPA Order";
            // 
            // lblUnitDisplay
            // 
            this.lblUnitDisplay.AutoSize = true;
            this.lblUnitDisplay.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUnitDisplay.Location = new System.Drawing.Point(547, 252);
            this.lblUnitDisplay.Name = "lblUnitDisplay";
            this.lblUnitDisplay.Size = new System.Drawing.Size(0, 18);
            this.lblUnitDisplay.TabIndex = 53;
            // 
            // lblStatusDisplay
            // 
            this.lblStatusDisplay.AutoSize = true;
            this.lblStatusDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusDisplay.Location = new System.Drawing.Point(384, 314);
            this.lblStatusDisplay.Name = "lblStatusDisplay";
            this.lblStatusDisplay.Size = new System.Drawing.Size(0, 19);
            this.lblStatusDisplay.TabIndex = 52;
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.Enabled = false;
            this.dtpPickUpDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpPickUpDate.Location = new System.Drawing.Point(551, 314);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(162, 26);
            this.dtpPickUpDate.TabIndex = 51;
            // 
            // tbItemAID
            // 
            this.tbItemAID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemAID.Location = new System.Drawing.Point(177, 123);
            this.tbItemAID.Name = "tbItemAID";
            this.tbItemAID.ReadOnly = true;
            this.tbItemAID.Size = new System.Drawing.Size(168, 26);
            this.tbItemAID.TabIndex = 50;
            // 
            // tbAgreementID
            // 
            this.tbAgreementID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbAgreementID.Location = new System.Drawing.Point(551, 125);
            this.tbAgreementID.Name = "tbAgreementID";
            this.tbAgreementID.ReadOnly = true;
            this.tbAgreementID.Size = new System.Drawing.Size(162, 26);
            this.tbAgreementID.TabIndex = 49;
            // 
            // tbitemType
            // 
            this.tbitemType.Font = new System.Drawing.Font("Arial", 12F);
            this.tbitemType.Location = new System.Drawing.Point(551, 194);
            this.tbitemType.Name = "tbitemType";
            this.tbitemType.ReadOnly = true;
            this.tbitemType.Size = new System.Drawing.Size(162, 26);
            this.tbitemType.TabIndex = 48;
            // 
            // tbOrderType
            // 
            this.tbOrderType.Font = new System.Drawing.Font("Arial", 12F);
            this.tbOrderType.Location = new System.Drawing.Point(551, 72);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.ReadOnly = true;
            this.tbOrderType.Size = new System.Drawing.Size(162, 26);
            this.tbOrderType.TabIndex = 47;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbOrderID.Location = new System.Drawing.Point(177, 71);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(168, 26);
            this.tbOrderID.TabIndex = 46;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(29, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Status";
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPickUpDate.Location = new System.Drawing.Point(386, 319);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(107, 19);
            this.lblPickUpDate.TabIndex = 43;
            this.lblPickUpDate.Text = "Pick Up Date";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(386, 255);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 42;
            this.lblUnit.Text = "Unit";
            // 
            // lblAgreementID
            // 
            this.lblAgreementID.AutoSize = true;
            this.lblAgreementID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAgreementID.Location = new System.Drawing.Point(386, 128);
            this.lblAgreementID.Name = "lblAgreementID";
            this.lblAgreementID.Size = new System.Drawing.Size(112, 19);
            this.lblAgreementID.TabIndex = 41;
            this.lblAgreementID.Text = "Agreement ID";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderType.Location = new System.Drawing.Point(386, 72);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(93, 19);
            this.lblOrderType.TabIndex = 40;
            this.lblOrderType.Text = "Order Type";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemType.Location = new System.Drawing.Point(386, 197);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(82, 19);
            this.lblItemType.TabIndex = 39;
            this.lblItemType.Text = "Item Type";
            // 
            // lblRequestItemAID
            // 
            this.lblRequestItemAID.AutoSize = true;
            this.lblRequestItemAID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestItemAID.Location = new System.Drawing.Point(25, 126);
            this.lblRequestItemAID.Name = "lblRequestItemAID";
            this.lblRequestItemAID.Size = new System.Drawing.Size(61, 19);
            this.lblRequestItemAID.TabIndex = 38;
            this.lblRequestItemAID.Text = "Item ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.Location = new System.Drawing.Point(25, 74);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(72, 19);
            this.lblOrderID.TabIndex = 37;
            this.lblOrderID.Text = "Order ID";
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemName.Location = new System.Drawing.Point(177, 193);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(168, 26);
            this.tbItemName.TabIndex = 68;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(25, 196);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 67;
            this.lblItemName.Text = "Item Name";
            // 
            // tbOrderQty
            // 
            this.tbOrderQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbOrderQty.Location = new System.Drawing.Point(181, 254);
            this.tbOrderQty.Name = "tbOrderQty";
            this.tbOrderQty.ReadOnly = true;
            this.tbOrderQty.Size = new System.Drawing.Size(168, 26);
            this.tbOrderQty.TabIndex = 70;
            // 
            // lblOrderQty
            // 
            this.lblOrderQty.AutoSize = true;
            this.lblOrderQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderQty.Location = new System.Drawing.Point(30, 260);
            this.lblOrderQty.Name = "lblOrderQty";
            this.lblOrderQty.Size = new System.Drawing.Size(82, 19);
            this.lblOrderQty.TabIndex = 69;
            this.lblOrderQty.Text = "Order Qty";
            // 
            // lblDisplayStatus
            // 
            this.lblDisplayStatus.AutoSize = true;
            this.lblDisplayStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayStatus.Location = new System.Drawing.Point(177, 321);
            this.lblDisplayStatus.Name = "lblDisplayStatus";
            this.lblDisplayStatus.Size = new System.Drawing.Size(58, 19);
            this.lblDisplayStatus.TabIndex = 71;
            this.lblDisplayStatus.Text = "Status";
            // 
            // tbOrderRemark
            // 
            this.tbOrderRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderRemark.Location = new System.Drawing.Point(29, 417);
            this.tbOrderRemark.Multiline = true;
            this.tbOrderRemark.Name = "tbOrderRemark";
            this.tbOrderRemark.ReadOnly = true;
            this.tbOrderRemark.Size = new System.Drawing.Size(320, 130);
            this.tbOrderRemark.TabIndex = 80;
            // 
            // lblOrderRemark
            // 
            this.lblOrderRemark.AutoSize = true;
            this.lblOrderRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderRemark.Location = new System.Drawing.Point(29, 383);
            this.lblOrderRemark.Name = "lblOrderRemark";
            this.lblOrderRemark.Size = new System.Drawing.Size(115, 19);
            this.lblOrderRemark.TabIndex = 81;
            this.lblOrderRemark.Text = "Order Remark";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblBPAOrder);
            this.panel1.Controls.Add(this.btnCancelOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 55);
            this.panel1.TabIndex = 1084;
            // 
            // BPAOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderRemark);
            this.Controls.Add(this.tbOrderRemark);
            this.Controls.Add(this.lblDisplayStatus);
            this.Controls.Add(this.tbOrderQty);
            this.Controls.Add(this.lblOrderQty);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUnitDisplay);
            this.Controls.Add(this.lblStatusDisplay);
            this.Controls.Add(this.dtpPickUpDate);
            this.Controls.Add(this.tbItemAID);
            this.Controls.Add(this.tbAgreementID);
            this.Controls.Add(this.tbitemType);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblAgreementID);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblRequestItemAID);
            this.Controls.Add(this.lblOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BPAOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BPAOrderDetails";
            this.Load += new System.EventHandler(this.BPAOrderDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBPAOrder;
        private System.Windows.Forms.Label lblUnitDisplay;
        private System.Windows.Forms.Label lblStatusDisplay;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.TextBox tbItemAID;
        private System.Windows.Forms.TextBox tbAgreementID;
        private System.Windows.Forms.TextBox tbitemType;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblAgreementID;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblRequestItemAID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbOrderQty;
        private System.Windows.Forms.Label lblOrderQty;
        private System.Windows.Forms.Label lblDisplayStatus;
        private System.Windows.Forms.TextBox tbOrderRemark;
        private System.Windows.Forms.Label lblOrderRemark;
        private System.Windows.Forms.Panel panel1;
    }
}