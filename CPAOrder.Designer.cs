namespace UI
{
    partial class CPAOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCPARequestList = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRequestItem = new System.Windows.Forms.Label();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cbSupplierName = new System.Windows.Forms.ComboBox();
            this.lblAgreementID = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbAgreementID = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShipTo = new System.Windows.Forms.Label();
            this.cbShippToChoice = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPARequestList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCPARequestList
            // 
            this.dgvCPARequestList.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCPARequestList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCPARequestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCPARequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCPARequestList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCPARequestList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCPARequestList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCPARequestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCPARequestList.ColumnHeadersHeight = 50;
            this.dgvCPARequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCPARequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCPARequestList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCPARequestList.EnableHeadersVisualStyles = false;
            this.dgvCPARequestList.Location = new System.Drawing.Point(23, 551);
            this.dgvCPARequestList.Name = "dgvCPARequestList";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCPARequestList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCPARequestList.RowHeadersVisible = false;
            this.dgvCPARequestList.RowHeadersWidth = 5;
            this.dgvCPARequestList.RowTemplate.Height = 24;
            this.dgvCPARequestList.Size = new System.Drawing.Size(759, 230);
            this.dgvCPARequestList.TabIndex = 54;
            this.dgvCPARequestList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCPARequestList_EditingControlShowing);
            // 
            // Column5
            // 
            this.Column5.FillWeight = 8.317287F;
            this.Column5.HeaderText = "Select";
            this.Column5.Name = "Column5";
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
            // Column3
            // 
            this.Column3.FillWeight = 24.57669F;
            this.Column3.HeaderText = "Supplier ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 24.57669F;
            this.Column4.HeaderText = "Supplier Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // lblRequestItem
            // 
            this.lblRequestItem.AutoSize = true;
            this.lblRequestItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblRequestItem.Location = new System.Drawing.Point(28, 507);
            this.lblRequestItem.Name = "lblRequestItem";
            this.lblRequestItem.Size = new System.Drawing.Size(130, 22);
            this.lblRequestItem.TabIndex = 55;
            this.lblRequestItem.Text = "Request Item";
            this.lblRequestItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(185, 221);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(193, 31);
            this.cbSupplierID.TabIndex = 56;
            this.cbSupplierID.SelectedIndexChanged += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            // 
            // tbOrderType
            // 
            this.tbOrderType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOrderType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderType.Location = new System.Drawing.Point(587, 85);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.ReadOnly = true;
            this.tbOrderType.Size = new System.Drawing.Size(184, 29);
            this.tbOrderType.TabIndex = 1071;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(26, 229);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblSupplierID.TabIndex = 1073;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.Location = new System.Drawing.Point(428, 228);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(131, 19);
            this.lblCompanyName.TabIndex = 1072;
            this.lblCompanyName.Text = "Company Name";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderID.Location = new System.Drawing.Point(185, 84);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(193, 29);
            this.tbOrderID.TabIndex = 1076;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.Location = new System.Drawing.Point(21, 84);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(72, 19);
            this.lblOrderID.TabIndex = 1075;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderType.Location = new System.Drawing.Point(428, 88);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(93, 19);
            this.lblOrderType.TabIndex = 1077;
            this.lblOrderType.Text = "Order Type";
            // 
            // cbSupplierName
            // 
            this.cbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplierName.FormattingEnabled = true;
            this.cbSupplierName.Location = new System.Drawing.Point(587, 221);
            this.cbSupplierName.Name = "cbSupplierName";
            this.cbSupplierName.Size = new System.Drawing.Size(184, 31);
            this.cbSupplierName.TabIndex = 1078;
            this.cbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cbSupplierName_SelectedIndexChanged);
            // 
            // lblAgreementID
            // 
            this.lblAgreementID.AutoSize = true;
            this.lblAgreementID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAgreementID.Location = new System.Drawing.Point(24, 151);
            this.lblAgreementID.Name = "lblAgreementID";
            this.lblAgreementID.Size = new System.Drawing.Size(112, 19);
            this.lblAgreementID.TabIndex = 1080;
            this.lblAgreementID.Text = "Agreement ID";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(638, 804);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 44);
            this.btnCreate.TabIndex = 1081;
            this.btnCreate.Text = "Creat";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbAgreementID
            // 
            this.cbAgreementID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgreementID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgreementID.FormattingEnabled = true;
            this.cbAgreementID.Location = new System.Drawing.Point(185, 142);
            this.cbAgreementID.Name = "cbAgreementID";
            this.cbAgreementID.Size = new System.Drawing.Size(193, 31);
            this.cbAgreementID.TabIndex = 1082;
            this.cbAgreementID.SelectedIndexChanged += new System.EventHandler(this.cbAgreementID_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(310, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 29);
            this.lblTitle.TabIndex = 1083;
            this.lblTitle.Text = "Create CPA Order";
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblShipTo.Location = new System.Drawing.Point(29, 317);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(67, 19);
            this.lblShipTo.TabIndex = 1084;
            this.lblShipTo.Text = "Ship To";
            // 
            // cbShippToChoice
            // 
            this.cbShippToChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShippToChoice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShippToChoice.FormattingEnabled = true;
            this.cbShippToChoice.Items.AddRange(new object[] {
            "Warehouse",
            "Restaurant"});
            this.cbShippToChoice.Location = new System.Drawing.Point(185, 308);
            this.cbShippToChoice.Name = "cbShippToChoice";
            this.cbShippToChoice.Size = new System.Drawing.Size(193, 31);
            this.cbShippToChoice.TabIndex = 1085;
            this.cbShippToChoice.SelectedIndexChanged += new System.EventHandler(this.cbShippToChoice_SelectedIndexChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(185, 367);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(237, 96);
            this.tbAddress.TabIndex = 1086;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(28, 367);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 19);
            this.lblAddress.TabIndex = 1087;
            this.lblAddress.Text = "Adress";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUpDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUpDate.Location = new System.Drawing.Point(587, 147);
            this.dtpPickUpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 82);
            this.dtpPickUpDate.MinDate = new System.DateTime(2023, 5, 24, 0, 0, 0, 0);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(184, 29);
            this.dtpPickUpDate.TabIndex = 1089;
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPickUpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPickUpDate.Location = new System.Drawing.Point(427, 150);
            this.lblPickUpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(104, 19);
            this.lblPickUpDate.TabIndex = 1088;
            this.lblPickUpDate.Text = "Pick-up date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 55);
            this.panel1.TabIndex = 1090;
            // 
            // CPAOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpPickUpDate);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.cbShippToChoice);
            this.Controls.Add(this.lblShipTo);
            this.Controls.Add(this.cbAgreementID);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblAgreementID);
            this.Controls.Add(this.cbSupplierName);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.cbSupplierID);
            this.Controls.Add(this.lblRequestItem);
            this.Controls.Add(this.dgvCPARequestList);
            this.Name = "CPAOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPAOrder";
            this.Load += new System.EventHandler(this.CPAOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPARequestList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCPARequestList;
        private System.Windows.Forms.Label lblRequestItem;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.ComboBox cbSupplierName;
        private System.Windows.Forms.Label lblAgreementID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbAgreementID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblShipTo;
        private System.Windows.Forms.ComboBox cbShippToChoice;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Panel panel1;
    }
}