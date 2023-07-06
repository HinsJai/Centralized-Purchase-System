namespace UI
{
    partial class CPAOrderListDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDisplayStatus = new System.Windows.Forms.Label();
            this.lblCPAOrderDetail = new System.Windows.Forms.Label();
            this.lblStatusDisplay = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.tbAgreementID = new System.Windows.Forms.TextBox();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblAgreementID = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblCPAItemList = new System.Windows.Forms.Label();
            this.dgvCPARequestList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPARequestList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplayStatus
            // 
            this.lblDisplayStatus.AutoSize = true;
            this.lblDisplayStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayStatus.Location = new System.Drawing.Point(170, 287);
            this.lblDisplayStatus.Name = "lblDisplayStatus";
            this.lblDisplayStatus.Size = new System.Drawing.Size(58, 19);
            this.lblDisplayStatus.TabIndex = 94;
            this.lblDisplayStatus.Text = "Status";
            // 
            // lblCPAOrderDetail
            // 
            this.lblCPAOrderDetail.AutoSize = true;
            this.lblCPAOrderDetail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCPAOrderDetail.Location = new System.Drawing.Point(275, 9);
            this.lblCPAOrderDetail.Name = "lblCPAOrderDetail";
            this.lblCPAOrderDetail.Size = new System.Drawing.Size(216, 29);
            this.lblCPAOrderDetail.TabIndex = 88;
            this.lblCPAOrderDetail.Text = "CPA Order Details";
            // 
            // lblStatusDisplay
            // 
            this.lblStatusDisplay.AutoSize = true;
            this.lblStatusDisplay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDisplay.Location = new System.Drawing.Point(19, 237);
            this.lblStatusDisplay.Name = "lblStatusDisplay";
            this.lblStatusDisplay.Size = new System.Drawing.Size(0, 22);
            this.lblStatusDisplay.TabIndex = 86;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Enabled = false;
            this.dtpCreateDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreateDate.Location = new System.Drawing.Point(536, 412);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(172, 29);
            this.dtpCreateDate.TabIndex = 85;
            // 
            // tbAgreementID
            // 
            this.tbAgreementID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbAgreementID.Location = new System.Drawing.Point(174, 163);
            this.tbAgreementID.Name = "tbAgreementID";
            this.tbAgreementID.ReadOnly = true;
            this.tbAgreementID.Size = new System.Drawing.Size(176, 26);
            this.tbAgreementID.TabIndex = 83;
            // 
            // tbOrderType
            // 
            this.tbOrderType.Font = new System.Drawing.Font("Arial", 12F);
            this.tbOrderType.Location = new System.Drawing.Point(550, 102);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.ReadOnly = true;
            this.tbOrderType.Size = new System.Drawing.Size(158, 26);
            this.tbOrderType.TabIndex = 81;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbOrderID.Location = new System.Drawing.Point(170, 99);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(176, 26);
            this.tbOrderID.TabIndex = 80;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(18, 287);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 79;
            this.lblStatus.Text = "Status";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreateDate.Location = new System.Drawing.Point(371, 412);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(98, 19);
            this.lblCreateDate.TabIndex = 78;
            this.lblCreateDate.Text = "Create Date";
            // 
            // lblAgreementID
            // 
            this.lblAgreementID.AutoSize = true;
            this.lblAgreementID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAgreementID.Location = new System.Drawing.Point(20, 166);
            this.lblAgreementID.Name = "lblAgreementID";
            this.lblAgreementID.Size = new System.Drawing.Size(112, 19);
            this.lblAgreementID.TabIndex = 76;
            this.lblAgreementID.Text = "Agreement ID";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderType.Location = new System.Drawing.Point(385, 102);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(93, 19);
            this.lblOrderType.TabIndex = 75;
            this.lblOrderType.Text = "Order Type";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.Location = new System.Drawing.Point(18, 102);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(72, 19);
            this.lblOrderID.TabIndex = 72;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblCPAItemList
            // 
            this.lblCPAItemList.AutoSize = true;
            this.lblCPAItemList.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCPAItemList.Location = new System.Drawing.Point(21, 515);
            this.lblCPAItemList.Name = "lblCPAItemList";
            this.lblCPAItemList.Size = new System.Drawing.Size(88, 22);
            this.lblCPAItemList.TabIndex = 96;
            this.lblCPAItemList.Text = "Item List";
            this.lblCPAItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCPARequestList
            // 
            this.dgvCPARequestList.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCPARequestList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCPARequestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCPARequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCPARequestList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCPARequestList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCPARequestList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCPARequestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCPARequestList.ColumnHeadersHeight = 50;
            this.dgvCPARequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCPARequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCPARequestList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCPARequestList.EnableHeadersVisualStyles = false;
            this.dgvCPARequestList.Location = new System.Drawing.Point(25, 544);
            this.dgvCPARequestList.Name = "dgvCPARequestList";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCPARequestList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCPARequestList.RowHeadersVisible = false;
            this.dgvCPARequestList.RowHeadersWidth = 5;
            this.dgvCPARequestList.RowTemplate.Height = 24;
            this.dgvCPARequestList.Size = new System.Drawing.Size(697, 230);
            this.dgvCPARequestList.TabIndex = 95;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10.57336F;
            this.Column1.HeaderText = "Item ID";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 24.57669F;
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 11.52686F;
            this.Column6.HeaderText = "Total Qty";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 11.76809F;
            this.Column7.HeaderText = "Unit";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.Location = new System.Drawing.Point(385, 236);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(131, 19);
            this.lblCompanyName.TabIndex = 1080;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(19, 236);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblSupplierID.TabIndex = 1081;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierID.Location = new System.Drawing.Point(174, 229);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(176, 26);
            this.tbSupplierID.TabIndex = 1082;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierName.Location = new System.Drawing.Point(550, 229);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(158, 26);
            this.tbSupplierName.TabIndex = 1083;
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipAddress.Location = new System.Drawing.Point(25, 382);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.ReadOnly = true;
            this.tbShipAddress.Size = new System.Drawing.Size(325, 111);
            this.tbShipAddress.TabIndex = 1084;
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblShipAddress.Location = new System.Drawing.Point(21, 344);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(111, 19);
            this.lblShipAddress.TabIndex = 1085;
            this.lblShipAddress.Text = "Ship Address";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.Enabled = false;
            this.dtpPickUpDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUpDate.Location = new System.Drawing.Point(536, 329);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(172, 29);
            this.dtpPickUpDate.TabIndex = 1087;
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPickUpDate.Location = new System.Drawing.Point(371, 329);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(107, 19);
            this.lblPickUpDate.TabIndex = 1086;
            this.lblPickUpDate.Text = "Pick Up Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblCPAOrderDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 55);
            this.panel1.TabIndex = 1088;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(608, 795);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 50);
            this.btnClose.TabIndex = 1089;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CPAOrderListDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 857);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpPickUpDate);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblShipAddress);
            this.Controls.Add(this.tbShipAddress);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.tbSupplierID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCPAItemList);
            this.Controls.Add(this.dgvCPARequestList);
            this.Controls.Add(this.lblDisplayStatus);
            this.Controls.Add(this.lblStatusDisplay);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.tbAgreementID);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblAgreementID);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CPAOrderListDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPAOrderListDetails";
            this.Load += new System.EventHandler(this.CPAOrderListDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPARequestList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayStatus;
        private System.Windows.Forms.Label lblCPAOrderDetail;
        private System.Windows.Forms.Label lblStatusDisplay;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.TextBox tbAgreementID;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblAgreementID;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblCPAItemList;
        private System.Windows.Forms.DataGridView dgvCPARequestList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}