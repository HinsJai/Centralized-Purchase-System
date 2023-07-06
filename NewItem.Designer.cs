namespace UI
{
    partial class NewItem
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblNewItemManage = new System.Windows.Forms.Label();
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
            this.tbTypeID = new System.Windows.Forms.TextBox();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbStockQty = new System.Windows.Forms.TextBox();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.cbNewItemID = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(23, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 38);
            this.btnDelete.TabIndex = 1026;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnModify.Location = new System.Drawing.Point(23, 503);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(110, 45);
            this.btnModify.TabIndex = 1025;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblNewItemManage
            // 
            this.lblNewItemManage.AutoSize = true;
            this.lblNewItemManage.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblNewItemManage.Location = new System.Drawing.Point(366, 9);
            this.lblNewItemManage.Name = "lblNewItemManage";
            this.lblNewItemManage.Size = new System.Drawing.Size(118, 29);
            this.lblNewItemManage.TabIndex = 1023;
            this.lblNewItemManage.Text = "New Item";
            // 
            // tbBrand
            // 
            this.tbBrand.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBrand.Location = new System.Drawing.Point(170, 337);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.Size = new System.Drawing.Size(158, 26);
            this.tbBrand.TabIndex = 1006;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(19, 344);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 19);
            this.lblBrand.TabIndex = 1022;
            this.lblBrand.Text = "Brand";
            // 
            // lblItemRemark
            // 
            this.lblItemRemark.AutoSize = true;
            this.lblItemRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemRemark.Location = new System.Drawing.Point(19, 383);
            this.lblItemRemark.Name = "lblItemRemark";
            this.lblItemRemark.Size = new System.Drawing.Size(104, 19);
            this.lblItemRemark.TabIndex = 1021;
            this.lblItemRemark.Text = "Item Remark";
            // 
            // tbItemRemark
            // 
            this.tbItemRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemRemark.Location = new System.Drawing.Point(23, 408);
            this.tbItemRemark.Multiline = true;
            this.tbItemRemark.Name = "tbItemRemark";
            this.tbItemRemark.ReadOnly = true;
            this.tbItemRemark.Size = new System.Drawing.Size(697, 89);
            this.tbItemRemark.TabIndex = 1007;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierName.Location = new System.Drawing.Point(553, 232);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(167, 26);
            this.tbSupplierName.TabIndex = 1020;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierName.Location = new System.Drawing.Point(362, 239);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(121, 19);
            this.lblSupplierName.TabIndex = 1019;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierID.Location = new System.Drawing.Point(170, 237);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(158, 26);
            this.tbSupplierID.TabIndex = 1003;
            this.tbSupplierID.TextChanged += new System.EventHandler(this.tbSupplierID_TextChanged);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(19, 243);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblSupplierID.TabIndex = 1018;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // tbCategoryID
            // 
            this.tbCategoryID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCategoryID.Location = new System.Drawing.Point(170, 188);
            this.tbCategoryID.Name = "tbCategoryID";
            this.tbCategoryID.ReadOnly = true;
            this.tbCategoryID.Size = new System.Drawing.Size(158, 26);
            this.tbCategoryID.TabIndex = 1002;
            this.tbCategoryID.TextChanged += new System.EventHandler(this.tbCategoryID_TextChanged);
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.Location = new System.Drawing.Point(19, 194);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(99, 19);
            this.lblCategoryID.TabIndex = 1017;
            this.lblCategoryID.Text = "Category ID";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCategoryName.Location = new System.Drawing.Point(553, 187);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.ReadOnly = true;
            this.tbCategoryName.Size = new System.Drawing.Size(167, 26);
            this.tbCategoryName.TabIndex = 1016;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(362, 194);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 19);
            this.lblCategory.TabIndex = 1015;
            this.lblCategory.Text = "Category Name";
            // 
            // tbTypeID
            // 
            this.tbTypeID.AcceptsReturn = true;
            this.tbTypeID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTypeID.Location = new System.Drawing.Point(170, 140);
            this.tbTypeID.Name = "tbTypeID";
            this.tbTypeID.ReadOnly = true;
            this.tbTypeID.Size = new System.Drawing.Size(158, 26);
            this.tbTypeID.TabIndex = 1001;
            this.tbTypeID.TextChanged += new System.EventHandler(this.tbTypeID_TextChanged);
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeID.Location = new System.Drawing.Point(19, 146);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(66, 19);
            this.lblTypeID.TabIndex = 1014;
            this.lblTypeID.Text = "Type ID";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Arial", 12F);
            this.tbUnit.Location = new System.Drawing.Point(553, 287);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(167, 26);
            this.tbUnit.TabIndex = 1005;
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemName.Location = new System.Drawing.Point(553, 88);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(167, 26);
            this.tbItemName.TabIndex = 1000;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(362, 91);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 1013;
            this.lblItemName.Text = "Item Name";
            // 
            // tbStockQty
            // 
            this.tbStockQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbStockQty.Location = new System.Drawing.Point(170, 287);
            this.tbStockQty.Name = "tbStockQty";
            this.tbStockQty.ReadOnly = true;
            this.tbStockQty.Size = new System.Drawing.Size(158, 26);
            this.tbStockQty.TabIndex = 1004;
            // 
            // tbTypeName
            // 
            this.tbTypeName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTypeName.Location = new System.Drawing.Point(553, 139);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.ReadOnly = true;
            this.tbTypeName.Size = new System.Drawing.Size(167, 26);
            this.tbTypeName.TabIndex = 1012;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(362, 293);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 1011;
            this.lblUnit.Text = "Unit";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStockQty.Location = new System.Drawing.Point(19, 294);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(83, 19);
            this.lblStockQty.TabIndex = 1010;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(362, 146);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(94, 19);
            this.lblType.TabIndex = 1009;
            this.lblType.Text = "Type Name";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemID.Location = new System.Drawing.Point(19, 91);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(61, 19);
            this.lblItemID.TabIndex = 1008;
            this.lblItemID.Text = "Item ID";
            // 
            // cbNewItemID
            // 
            this.cbNewItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewItemID.Font = new System.Drawing.Font("Arial", 14F);
            this.cbNewItemID.FormattingEnabled = true;
            this.cbNewItemID.Location = new System.Drawing.Point(170, 89);
            this.cbNewItemID.Name = "cbNewItemID";
            this.cbNewItemID.Size = new System.Drawing.Size(158, 30);
            this.cbNewItemID.TabIndex = 1027;
            this.cbNewItemID.SelectedIndexChanged += new System.EventHandler(this.cbNewItemID_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(23, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 45);
            this.btnUpdate.TabIndex = 1028;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(569, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 40);
            this.btnCancel.TabIndex = 1029;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblNewItemManage);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 50);
            this.panel1.TabIndex = 1030;
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbNewItemID);
            this.Controls.Add(this.btnModify);
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
            this.Controls.Add(this.tbTypeID);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.tbStockQty);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblItemID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewItem";
            this.Load += new System.EventHandler(this.NewItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblNewItemManage;
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
        private System.Windows.Forms.TextBox tbTypeID;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbStockQty;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox cbNewItemID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}