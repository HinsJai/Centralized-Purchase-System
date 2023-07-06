namespace UI
{
    partial class MappingItem
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
            this.lblMappedItem = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModifyConfirm = new System.Windows.Forms.Button();
            this.btnModifyItem = new System.Windows.Forms.Button();
            this.tbVID = new System.Windows.Forms.TextBox();
            this.lblVID = new System.Windows.Forms.Label();
            this.lblAID = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblItemRemark = new System.Windows.Forms.Label();
            this.tbItemRemark = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.tbCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbStockQty = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.tbTypeID = new System.Windows.Forms.TextBox();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbVName = new System.Windows.Forms.TextBox();
            this.lblVName = new System.Windows.Forms.Label();
            this.btnAssignVID = new System.Windows.Forms.Button();
            this.btnAssignConfirm = new System.Windows.Forms.Button();
            this.lblAcutalItemName = new System.Windows.Forms.Label();
            this.cbMappedAID = new System.Windows.Forms.ComboBox();
            this.cbMappedIAName = new System.Windows.Forms.ComboBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbAID = new System.Windows.Forms.TextBox();
            this.btnDeleteVID = new System.Windows.Forms.Button();
            this.cbVID = new System.Windows.Forms.ComboBox();
            this.cbVName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMappedItem
            // 
            this.lblMappedItem.AutoSize = true;
            this.lblMappedItem.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblMappedItem.Location = new System.Drawing.Point(372, 9);
            this.lblMappedItem.Name = "lblMappedItem";
            this.lblMappedItem.Size = new System.Drawing.Size(161, 29);
            this.lblMappedItem.TabIndex = 79;
            this.lblMappedItem.Text = "Mapped Item";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(34, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 41);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModifyConfirm
            // 
            this.btnModifyConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModifyConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifyConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifyConfirm.Location = new System.Drawing.Point(678, 551);
            this.btnModifyConfirm.Name = "btnModifyConfirm";
            this.btnModifyConfirm.Size = new System.Drawing.Size(135, 41);
            this.btnModifyConfirm.TabIndex = 77;
            this.btnModifyConfirm.Text = "Confirm";
            this.btnModifyConfirm.UseVisualStyleBackColor = false;
            this.btnModifyConfirm.Visible = false;
            this.btnModifyConfirm.Click += new System.EventHandler(this.btnModifyConfirm_Click);
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifyItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyItem.Location = new System.Drawing.Point(34, 553);
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.Size = new System.Drawing.Size(135, 41);
            this.btnModifyItem.TabIndex = 74;
            this.btnModifyItem.Text = "Modify";
            this.btnModifyItem.UseVisualStyleBackColor = false;
            this.btnModifyItem.Click += new System.EventHandler(this.btnModifyItem_Click);
            // 
            // tbVID
            // 
            this.tbVID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbVID.Location = new System.Drawing.Point(220, 72);
            this.tbVID.Name = "tbVID";
            this.tbVID.ReadOnly = true;
            this.tbVID.Size = new System.Drawing.Size(168, 26);
            this.tbVID.TabIndex = 65;
            this.tbVID.TextChanged += new System.EventHandler(this.tbVID_TextChanged);
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblVID.Location = new System.Drawing.Point(29, 74);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(118, 19);
            this.lblVID.TabIndex = 64;
            this.lblVID.Text = "Virtual  Item ID";
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAID.Location = new System.Drawing.Point(29, 120);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(113, 19);
            this.lblAID.TabIndex = 57;
            this.lblAID.Text = "Actual Item ID";
            // 
            // tbBrand
            // 
            this.tbBrand.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBrand.Location = new System.Drawing.Point(220, 352);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.Size = new System.Drawing.Size(168, 26);
            this.tbBrand.TabIndex = 1027;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(29, 359);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 19);
            this.lblBrand.TabIndex = 1038;
            this.lblBrand.Text = "Brand";
            // 
            // lblItemRemark
            // 
            this.lblItemRemark.AutoSize = true;
            this.lblItemRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemRemark.Location = new System.Drawing.Point(30, 400);
            this.lblItemRemark.Name = "lblItemRemark";
            this.lblItemRemark.Size = new System.Drawing.Size(104, 19);
            this.lblItemRemark.TabIndex = 1037;
            this.lblItemRemark.Text = "Item Remark";
            // 
            // tbItemRemark
            // 
            this.tbItemRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemRemark.Location = new System.Drawing.Point(34, 435);
            this.tbItemRemark.Multiline = true;
            this.tbItemRemark.Name = "tbItemRemark";
            this.tbItemRemark.ReadOnly = true;
            this.tbItemRemark.Size = new System.Drawing.Size(354, 98);
            this.tbItemRemark.TabIndex = 1028;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierName.Location = new System.Drawing.Point(637, 251);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(176, 26);
            this.tbSupplierName.TabIndex = 1036;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierName.Location = new System.Drawing.Point(446, 251);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(121, 19);
            this.lblSupplierName.TabIndex = 1035;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierID.Location = new System.Drawing.Point(220, 251);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(168, 26);
            this.tbSupplierID.TabIndex = 1024;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(29, 254);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblSupplierID.TabIndex = 1034;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // tbCategoryID
            // 
            this.tbCategoryID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCategoryID.Location = new System.Drawing.Point(220, 206);
            this.tbCategoryID.Name = "tbCategoryID";
            this.tbCategoryID.ReadOnly = true;
            this.tbCategoryID.Size = new System.Drawing.Size(168, 26);
            this.tbCategoryID.TabIndex = 1023;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.Location = new System.Drawing.Point(29, 213);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(99, 19);
            this.lblCategoryID.TabIndex = 1033;
            this.lblCategoryID.Text = "Category ID";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCategoryName.Location = new System.Drawing.Point(637, 206);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.ReadOnly = true;
            this.tbCategoryName.Size = new System.Drawing.Size(176, 26);
            this.tbCategoryName.TabIndex = 1032;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(446, 209);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 19);
            this.lblCategory.TabIndex = 1031;
            this.lblCategory.Text = "Category Name";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Arial", 12F);
            this.tbUnit.Location = new System.Drawing.Point(637, 296);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(176, 26);
            this.tbUnit.TabIndex = 1026;
            // 
            // tbStockQty
            // 
            this.tbStockQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbStockQty.Location = new System.Drawing.Point(220, 299);
            this.tbStockQty.Name = "tbStockQty";
            this.tbStockQty.ReadOnly = true;
            this.tbStockQty.Size = new System.Drawing.Size(168, 26);
            this.tbStockQty.TabIndex = 1025;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(446, 302);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 1030;
            this.lblUnit.Text = "Unit";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStockQty.Location = new System.Drawing.Point(29, 302);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(83, 19);
            this.lblStockQty.TabIndex = 1029;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // tbTypeID
            // 
            this.tbTypeID.AcceptsReturn = true;
            this.tbTypeID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTypeID.Location = new System.Drawing.Point(220, 162);
            this.tbTypeID.Name = "tbTypeID";
            this.tbTypeID.ReadOnly = true;
            this.tbTypeID.Size = new System.Drawing.Size(168, 26);
            this.tbTypeID.TabIndex = 1039;
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeID.Location = new System.Drawing.Point(29, 165);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(66, 19);
            this.lblTypeID.TabIndex = 1042;
            this.lblTypeID.Text = "Type ID";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTypeName.Location = new System.Drawing.Point(637, 162);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.ReadOnly = true;
            this.tbTypeName.Size = new System.Drawing.Size(176, 26);
            this.tbTypeName.TabIndex = 1041;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(446, 165);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(94, 19);
            this.lblType.TabIndex = 1040;
            this.lblType.Text = "Type Name";
            // 
            // tbVName
            // 
            this.tbVName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbVName.Location = new System.Drawing.Point(637, 71);
            this.tbVName.Name = "tbVName";
            this.tbVName.ReadOnly = true;
            this.tbVName.Size = new System.Drawing.Size(176, 26);
            this.tbVName.TabIndex = 1044;
            // 
            // lblVName
            // 
            this.lblVName.AutoSize = true;
            this.lblVName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblVName.Location = new System.Drawing.Point(446, 74);
            this.lblVName.Name = "lblVName";
            this.lblVName.Size = new System.Drawing.Size(142, 19);
            this.lblVName.TabIndex = 1043;
            this.lblVName.Text = "Virtual Item Name";
            // 
            // btnAssignVID
            // 
            this.btnAssignVID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAssignVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssignVID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAssignVID.Location = new System.Drawing.Point(34, 553);
            this.btnAssignVID.Name = "btnAssignVID";
            this.btnAssignVID.Size = new System.Drawing.Size(135, 41);
            this.btnAssignVID.TabIndex = 1045;
            this.btnAssignVID.Text = "Assign VID";
            this.btnAssignVID.UseVisualStyleBackColor = false;
            this.btnAssignVID.Visible = false;
            this.btnAssignVID.Click += new System.EventHandler(this.btnAssignVID_Click);
            // 
            // btnAssignConfirm
            // 
            this.btnAssignConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAssignConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssignConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAssignConfirm.Location = new System.Drawing.Point(678, 551);
            this.btnAssignConfirm.Name = "btnAssignConfirm";
            this.btnAssignConfirm.Size = new System.Drawing.Size(135, 41);
            this.btnAssignConfirm.TabIndex = 1046;
            this.btnAssignConfirm.Text = "Confirm";
            this.btnAssignConfirm.UseVisualStyleBackColor = false;
            this.btnAssignConfirm.Visible = false;
            this.btnAssignConfirm.Click += new System.EventHandler(this.btnAssignConfirm_Click);
            // 
            // lblAcutalItemName
            // 
            this.lblAcutalItemName.AutoSize = true;
            this.lblAcutalItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAcutalItemName.Location = new System.Drawing.Point(446, 120);
            this.lblAcutalItemName.Name = "lblAcutalItemName";
            this.lblAcutalItemName.Size = new System.Drawing.Size(141, 19);
            this.lblAcutalItemName.TabIndex = 63;
            this.lblAcutalItemName.Text = "Actual Item Name";
            // 
            // cbMappedAID
            // 
            this.cbMappedAID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMappedAID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMappedAID.FormattingEnabled = true;
            this.cbMappedAID.Location = new System.Drawing.Point(220, 120);
            this.cbMappedAID.Name = "cbMappedAID";
            this.cbMappedAID.Size = new System.Drawing.Size(168, 27);
            this.cbMappedAID.TabIndex = 1082;
            this.cbMappedAID.Visible = false;
            this.cbMappedAID.SelectedIndexChanged += new System.EventHandler(this.cbMappedAID_SelectedIndexChanged);
            // 
            // cbMappedIAName
            // 
            this.cbMappedIAName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMappedIAName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMappedIAName.FormattingEnabled = true;
            this.cbMappedIAName.Location = new System.Drawing.Point(637, 120);
            this.cbMappedIAName.Name = "cbMappedIAName";
            this.cbMappedIAName.Size = new System.Drawing.Size(176, 27);
            this.cbMappedIAName.TabIndex = 1083;
            this.cbMappedIAName.Visible = false;
            this.cbMappedIAName.SelectedIndexChanged += new System.EventHandler(this.cbMappedIAName_SelectedIndexChanged);
            // 
            // tbItemName
            // 
            this.tbItemName.AcceptsReturn = true;
            this.tbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemName.Location = new System.Drawing.Point(637, 121);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(176, 26);
            this.tbItemName.TabIndex = 1084;
            // 
            // tbAID
            // 
            this.tbAID.AcceptsReturn = true;
            this.tbAID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbAID.Location = new System.Drawing.Point(220, 120);
            this.tbAID.Name = "tbAID";
            this.tbAID.ReadOnly = true;
            this.tbAID.Size = new System.Drawing.Size(168, 26);
            this.tbAID.TabIndex = 1085;
            this.tbAID.TextChanged += new System.EventHandler(this.tbAID_TextChanged);
            this.tbAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAID_KeyPress);
            // 
            // btnDeleteVID
            // 
            this.btnDeleteVID.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVID.Location = new System.Drawing.Point(192, 551);
            this.btnDeleteVID.Name = "btnDeleteVID";
            this.btnDeleteVID.Size = new System.Drawing.Size(135, 41);
            this.btnDeleteVID.TabIndex = 1047;
            this.btnDeleteVID.Text = "Delete VID";
            this.btnDeleteVID.UseVisualStyleBackColor = false;
            this.btnDeleteVID.Click += new System.EventHandler(this.btnDeleteVID_Click);
            // 
            // cbVID
            // 
            this.cbVID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbVID.FormattingEnabled = true;
            this.cbVID.Location = new System.Drawing.Point(220, 72);
            this.cbVID.Name = "cbVID";
            this.cbVID.Size = new System.Drawing.Size(168, 27);
            this.cbVID.TabIndex = 1086;
            this.cbVID.Visible = false;
            this.cbVID.SelectedIndexChanged += new System.EventHandler(this.cbVID_SelectedIndexChanged);
            // 
            // cbVName
            // 
            this.cbVName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbVName.FormattingEnabled = true;
            this.cbVName.Location = new System.Drawing.Point(637, 70);
            this.cbVName.Name = "cbVName";
            this.cbVName.Size = new System.Drawing.Size(176, 27);
            this.cbVName.TabIndex = 1087;
            this.cbVName.Visible = false;
            this.cbVName.SelectedIndexChanged += new System.EventHandler(this.cbVName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblMappedItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 54);
            this.panel1.TabIndex = 1088;
            // 
            // MappingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbVName);
            this.Controls.Add(this.cbVID);
            this.Controls.Add(this.tbAID);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.cbMappedIAName);
            this.Controls.Add(this.cbMappedAID);
            this.Controls.Add(this.btnDeleteVID);
            this.Controls.Add(this.btnAssignConfirm);
            this.Controls.Add(this.btnAssignVID);
            this.Controls.Add(this.tbVName);
            this.Controls.Add(this.lblVName);
            this.Controls.Add(this.tbTypeID);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblItemRemark);
            this.Controls.Add(this.tbItemRemark);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.tbSupplierID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.tbCategoryID);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.tbStockQty);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyConfirm);
            this.Controls.Add(this.btnModifyItem);
            this.Controls.Add(this.tbVID);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.lblAcutalItemName);
            this.Controls.Add(this.lblAID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MappingItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MappedItem";
            this.Load += new System.EventHandler(this.MappedItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMappedItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModifyConfirm;
        private System.Windows.Forms.Button btnModifyItem;
        private System.Windows.Forms.TextBox tbVID;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblItemRemark;
        private System.Windows.Forms.TextBox tbItemRemark;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox tbCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.TextBox tbStockQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.TextBox tbTypeID;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbVName;
        private System.Windows.Forms.Label lblVName;
        private System.Windows.Forms.Button btnAssignVID;
        private System.Windows.Forms.Button btnAssignConfirm;
        private System.Windows.Forms.Label lblAcutalItemName;
        private System.Windows.Forms.ComboBox cbMappedAID;
        private System.Windows.Forms.ComboBox cbMappedIAName;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbAID;
        private System.Windows.Forms.Button btnDeleteVID;
        private System.Windows.Forms.ComboBox cbVID;
        private System.Windows.Forms.ComboBox cbVName;
        private System.Windows.Forms.Panel panel1;
    }
}