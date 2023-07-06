namespace UI
{
    partial class CreateItem
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.tbStockQty = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblItemRemark = new System.Windows.Forms.Label();
            this.tbItemRemark = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCreateItemTitle = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbTypeID = new System.Windows.Forms.ComboBox();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.cbTypeName = new System.Windows.Forms.ComboBox();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.cbSupplierName = new System.Windows.Forms.ComboBox();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(358, 90);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 40;
            this.lblItemName.Text = "Item Name";
            // 
            // tbItemID
            // 
            this.tbItemID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemID.Location = new System.Drawing.Point(167, 91);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.ReadOnly = true;
            this.tbItemID.Size = new System.Drawing.Size(160, 26);
            this.tbItemID.TabIndex = 999;
            // 
            // tbStockQty
            // 
            this.tbStockQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbStockQty.Location = new System.Drawing.Point(167, 296);
            this.tbStockQty.Name = "tbStockQty";
            this.tbStockQty.Size = new System.Drawing.Size(160, 26);
            this.tbStockQty.TabIndex = 5;
            this.tbStockQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStockQty_KeyPress);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(358, 295);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 34;
            this.lblUnit.Text = "Unit";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStockQty.Location = new System.Drawing.Point(19, 299);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(83, 19);
            this.lblStockQty.TabIndex = 33;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(358, 140);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(94, 19);
            this.lblType.TabIndex = 32;
            this.lblType.Text = "Type Name";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemID.Location = new System.Drawing.Point(19, 94);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(61, 19);
            this.lblItemID.TabIndex = 31;
            this.lblItemID.Text = "Item ID";
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemName.Location = new System.Drawing.Point(516, 87);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(171, 26);
            this.tbItemName.TabIndex = 1;
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Arial", 12F);
            this.tbUnit.Location = new System.Drawing.Point(516, 292);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(171, 26);
            this.tbUnit.TabIndex = 6;
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeID.Location = new System.Drawing.Point(19, 144);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(66, 19);
            this.lblTypeID.TabIndex = 43;
            this.lblTypeID.Text = "Type ID";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(358, 190);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 19);
            this.lblCategory.TabIndex = 45;
            this.lblCategory.Text = "Category Name";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.Location = new System.Drawing.Point(19, 197);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(99, 19);
            this.lblCategoryID.TabIndex = 47;
            this.lblCategoryID.Text = "Category ID";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(19, 250);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblSupplierID.TabIndex = 49;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierName.Location = new System.Drawing.Point(358, 249);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(121, 19);
            this.lblSupplierName.TabIndex = 51;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblItemRemark
            // 
            this.lblItemRemark.AutoSize = true;
            this.lblItemRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemRemark.Location = new System.Drawing.Point(19, 405);
            this.lblItemRemark.Name = "lblItemRemark";
            this.lblItemRemark.Size = new System.Drawing.Size(104, 19);
            this.lblItemRemark.TabIndex = 54;
            this.lblItemRemark.Text = "Item Remark";
            // 
            // tbItemRemark
            // 
            this.tbItemRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemRemark.Location = new System.Drawing.Point(23, 427);
            this.tbItemRemark.Multiline = true;
            this.tbItemRemark.Name = "tbItemRemark";
            this.tbItemRemark.Size = new System.Drawing.Size(310, 162);
            this.tbItemRemark.TabIndex = 8;
            // 
            // tbBrand
            // 
            this.tbBrand.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBrand.Location = new System.Drawing.Point(167, 351);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(160, 26);
            this.tbBrand.TabIndex = 7;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(19, 354);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 19);
            this.lblBrand.TabIndex = 55;
            this.lblBrand.Text = "Brand";
            // 
            // lblCreateItemTitle
            // 
            this.lblCreateItemTitle.AutoSize = true;
            this.lblCreateItemTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCreateItemTitle.Location = new System.Drawing.Point(351, 9);
            this.lblCreateItemTitle.Name = "lblCreateItemTitle";
            this.lblCreateItemTitle.Size = new System.Drawing.Size(142, 29);
            this.lblCreateItemTitle.TabIndex = 57;
            this.lblCreateItemTitle.Text = "Create Item";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Arial", 11F);
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(20, 58);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(239, 17);
            this.lblHint.TabIndex = 58;
            this.lblHint.Text = "*Item ID is auto generate by system";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(23, 608);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 52);
            this.btnReset.TabIndex = 59;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(563, 608);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 52);
            this.btnCreate.TabIndex = 60;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbTypeID
            // 
            this.cbTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeID.Font = new System.Drawing.Font("Arial", 12F);
            this.cbTypeID.FormattingEnabled = true;
            this.cbTypeID.Location = new System.Drawing.Point(167, 141);
            this.cbTypeID.Name = "cbTypeID";
            this.cbTypeID.Size = new System.Drawing.Size(160, 26);
            this.cbTypeID.TabIndex = 1028;
            this.cbTypeID.SelectedIndexChanged += new System.EventHandler(this.cbTypeID_SelectedIndexChanged);
            // 
            // cbCategoryID
            // 
            this.cbCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryID.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCategoryID.FormattingEnabled = true;
            this.cbCategoryID.Location = new System.Drawing.Point(167, 194);
            this.cbCategoryID.Name = "cbCategoryID";
            this.cbCategoryID.Size = new System.Drawing.Size(160, 26);
            this.cbCategoryID.TabIndex = 1029;
            this.cbCategoryID.SelectedIndexChanged += new System.EventHandler(this.cbCategoryID_SelectedIndexChanged);
            // 
            // cbTypeName
            // 
            this.cbTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbTypeName.FormattingEnabled = true;
            this.cbTypeName.Location = new System.Drawing.Point(516, 137);
            this.cbTypeName.Name = "cbTypeName";
            this.cbTypeName.Size = new System.Drawing.Size(171, 26);
            this.cbTypeName.TabIndex = 1030;
            this.cbTypeName.SelectedIndexChanged += new System.EventHandler(this.cbTypeName_SelectedIndexChanged);
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(516, 187);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(171, 26);
            this.cbCategoryName.TabIndex = 1031;
            this.cbCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbCategoryName_SelectedIndexChanged);
            // 
            // cbSupplierName
            // 
            this.cbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSupplierName.FormattingEnabled = true;
            this.cbSupplierName.Location = new System.Drawing.Point(516, 243);
            this.cbSupplierName.Name = "cbSupplierName";
            this.cbSupplierName.Size = new System.Drawing.Size(171, 26);
            this.cbSupplierName.TabIndex = 1032;
            this.cbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cbSupplierName_SelectedIndexChanged);
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(167, 250);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(160, 26);
            this.cbSupplierID.TabIndex = 1033;
            this.cbSupplierID.SelectedIndexChanged += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblCreateItemTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 55);
            this.panel1.TabIndex = 1084;
            // 
            // CreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbSupplierID);
            this.Controls.Add(this.cbSupplierName);
            this.Controls.Add(this.cbCategoryName);
            this.Controls.Add(this.cbTypeName);
            this.Controls.Add(this.cbCategoryID);
            this.Controls.Add(this.cbTypeID);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblItemRemark);
            this.Controls.Add(this.tbItemRemark);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.tbItemID);
            this.Controls.Add(this.tbStockQty);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblItemID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateItem";
            this.Load += new System.EventHandler(this.CreateItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.TextBox tbStockQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblItemRemark;
        private System.Windows.Forms.TextBox tbItemRemark;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCreateItemTitle;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbTypeID;
        private System.Windows.Forms.ComboBox cbCategoryID;
        private System.Windows.Forms.ComboBox cbTypeName;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.ComboBox cbSupplierName;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.Panel panel1;
    }
}