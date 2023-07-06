namespace UI
{
    partial class ItemDetails
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
            this.tbTypeID = new System.Windows.Forms.TextBox();
            this.tbItemType = new System.Windows.Forms.TextBox();
            this.tbAID = new System.Windows.Forms.TextBox();
            this.lblItaemType = new System.Windows.Forms.Label();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.lblAID = new System.Windows.Forms.Label();
            this.tbVID = new System.Windows.Forms.TextBox();
            this.lblVID = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbStockQty = new System.Windows.Forms.TextBox();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblItemRemark = new System.Windows.Forms.Label();
            this.tbItemRemark = new System.Windows.Forms.TextBox();
            this.btnUpdateStockQty = new System.Windows.Forms.Button();
            this.btnModifyItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnConfirmStock = new System.Windows.Forms.Button();
            this.btnModifyConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblManageItem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(28, 126);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 39;
            this.lblItemName.Text = "Item Name";
            // 
            // tbTypeID
            // 
            this.tbTypeID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTypeID.Location = new System.Drawing.Point(170, 173);
            this.tbTypeID.Name = "tbTypeID";
            this.tbTypeID.ReadOnly = true;
            this.tbTypeID.Size = new System.Drawing.Size(200, 26);
            this.tbTypeID.TabIndex = 36;
            this.tbTypeID.TextChanged += new System.EventHandler(this.tbTypeID_TextChanged);
            this.tbTypeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTypeID_KeyPress);
            // 
            // tbItemType
            // 
            this.tbItemType.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemType.Location = new System.Drawing.Point(550, 123);
            this.tbItemType.Name = "tbItemType";
            this.tbItemType.ReadOnly = true;
            this.tbItemType.Size = new System.Drawing.Size(154, 26);
            this.tbItemType.TabIndex = 35;
            // 
            // tbAID
            // 
            this.tbAID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbAID.Location = new System.Drawing.Point(170, 72);
            this.tbAID.Name = "tbAID";
            this.tbAID.ReadOnly = true;
            this.tbAID.Size = new System.Drawing.Size(200, 26);
            this.tbAID.TabIndex = 34;
            // 
            // lblItaemType
            // 
            this.lblItaemType.AutoSize = true;
            this.lblItaemType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItaemType.Location = new System.Drawing.Point(401, 126);
            this.lblItaemType.Name = "lblItaemType";
            this.lblItaemType.Size = new System.Drawing.Size(82, 19);
            this.lblItaemType.TabIndex = 32;
            this.lblItaemType.Text = "Item Type";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeID.Location = new System.Drawing.Point(28, 176);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(66, 19);
            this.lblTypeID.TabIndex = 31;
            this.lblTypeID.Text = "Type ID";
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAID.Location = new System.Drawing.Point(28, 79);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(113, 19);
            this.lblAID.TabIndex = 30;
            this.lblAID.Text = "Actual Item ID";
            // 
            // tbVID
            // 
            this.tbVID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbVID.Location = new System.Drawing.Point(550, 76);
            this.tbVID.Name = "tbVID";
            this.tbVID.ReadOnly = true;
            this.tbVID.Size = new System.Drawing.Size(154, 26);
            this.tbVID.TabIndex = 42;
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblVID.Location = new System.Drawing.Point(401, 79);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(118, 19);
            this.lblVID.TabIndex = 41;
            this.lblVID.Text = "Virtual  Item ID";
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemName.Location = new System.Drawing.Point(170, 123);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(200, 26);
            this.tbItemName.TabIndex = 43;
            // 
            // tbStockQty
            // 
            this.tbStockQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbStockQty.Location = new System.Drawing.Point(170, 223);
            this.tbStockQty.Name = "tbStockQty";
            this.tbStockQty.ReadOnly = true;
            this.tbStockQty.Size = new System.Drawing.Size(200, 26);
            this.tbStockQty.TabIndex = 45;
            this.tbStockQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStockQty_KeyPress);
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStockQty.Location = new System.Drawing.Point(28, 226);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(83, 19);
            this.lblStockQty.TabIndex = 44;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Arial", 12F);
            this.tbUnit.Location = new System.Drawing.Point(550, 173);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(154, 26);
            this.tbUnit.TabIndex = 47;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(401, 176);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 46;
            this.lblUnit.Text = "Unit";
            // 
            // lblItemRemark
            // 
            this.lblItemRemark.AutoSize = true;
            this.lblItemRemark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemRemark.Location = new System.Drawing.Point(28, 271);
            this.lblItemRemark.Name = "lblItemRemark";
            this.lblItemRemark.Size = new System.Drawing.Size(104, 19);
            this.lblItemRemark.TabIndex = 49;
            this.lblItemRemark.Text = "Item Remark";
            // 
            // tbItemRemark
            // 
            this.tbItemRemark.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemRemark.Location = new System.Drawing.Point(32, 303);
            this.tbItemRemark.Multiline = true;
            this.tbItemRemark.Name = "tbItemRemark";
            this.tbItemRemark.ReadOnly = true;
            this.tbItemRemark.Size = new System.Drawing.Size(338, 98);
            this.tbItemRemark.TabIndex = 48;
            // 
            // btnUpdateStockQty
            // 
            this.btnUpdateStockQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStockQty.Location = new System.Drawing.Point(33, 432);
            this.btnUpdateStockQty.Name = "btnUpdateStockQty";
            this.btnUpdateStockQty.Size = new System.Drawing.Size(124, 43);
            this.btnUpdateStockQty.TabIndex = 50;
            this.btnUpdateStockQty.Text = "Update Stock";
            this.btnUpdateStockQty.UseVisualStyleBackColor = false;
            this.btnUpdateStockQty.Click += new System.EventHandler(this.btnUpdateStockQty_Click);
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifyItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifyItem.Location = new System.Drawing.Point(190, 432);
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.Size = new System.Drawing.Size(111, 43);
            this.btnModifyItem.TabIndex = 51;
            this.btnModifyItem.Text = "Modify";
            this.btnModifyItem.UseVisualStyleBackColor = false;
            this.btnModifyItem.Click += new System.EventHandler(this.btnModifyItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.Location = new System.Drawing.Point(20, 8);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(121, 43);
            this.btnDeleteItem.TabIndex = 52;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnConfirmStock
            // 
            this.btnConfirmStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmStock.Location = new System.Drawing.Point(584, 432);
            this.btnConfirmStock.Name = "btnConfirmStock";
            this.btnConfirmStock.Size = new System.Drawing.Size(120, 43);
            this.btnConfirmStock.TabIndex = 53;
            this.btnConfirmStock.Text = "Confirm";
            this.btnConfirmStock.UseVisualStyleBackColor = false;
            this.btnConfirmStock.Visible = false;
            this.btnConfirmStock.Click += new System.EventHandler(this.btnStockQtyConfirm_Click);
            // 
            // btnModifyConfirm
            // 
            this.btnModifyConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModifyConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifyConfirm.Location = new System.Drawing.Point(584, 432);
            this.btnModifyConfirm.Name = "btnModifyConfirm";
            this.btnModifyConfirm.Size = new System.Drawing.Size(120, 43);
            this.btnModifyConfirm.TabIndex = 54;
            this.btnModifyConfirm.Text = "Confirm";
            this.btnModifyConfirm.UseVisualStyleBackColor = false;
            this.btnModifyConfirm.Visible = false;
            this.btnModifyConfirm.Click += new System.EventHandler(this.btnModifyConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(33, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 43);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblManageItem
            // 
            this.lblManageItem.AutoSize = true;
            this.lblManageItem.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageItem.Location = new System.Drawing.Point(286, 8);
            this.lblManageItem.Name = "lblManageItem";
            this.lblManageItem.Size = new System.Drawing.Size(210, 37);
            this.lblManageItem.TabIndex = 56;
            this.lblManageItem.Text = "Manage Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblManageItem);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 54);
            this.panel1.TabIndex = 57;
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyConfirm);
            this.Controls.Add(this.btnConfirmStock);
            this.Controls.Add(this.btnModifyItem);
            this.Controls.Add(this.btnUpdateStockQty);
            this.Controls.Add(this.lblItemRemark);
            this.Controls.Add(this.tbItemRemark);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.tbStockQty);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.tbVID);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.tbTypeID);
            this.Controls.Add(this.tbItemType);
            this.Controls.Add(this.tbAID);
            this.Controls.Add(this.lblItaemType);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.lblAID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemDetails";
            this.Load += new System.EventHandler(this.ItemDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbTypeID;
        private System.Windows.Forms.TextBox tbItemType;
        private System.Windows.Forms.TextBox tbAID;
        private System.Windows.Forms.Label lblItaemType;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.TextBox tbVID;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbStockQty;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblItemRemark;
        private System.Windows.Forms.TextBox tbItemRemark;
        private System.Windows.Forms.Button btnUpdateStockQty;
        private System.Windows.Forms.Button btnModifyItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnConfirmStock;
        private System.Windows.Forms.Button btnModifyConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblManageItem;
        private System.Windows.Forms.Panel panel1;
    }
}