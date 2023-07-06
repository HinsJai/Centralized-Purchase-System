namespace UI
{
    partial class InventoryStockUpdate
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.tbStockQty = new System.Windows.Forms.TextBox();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbStockStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(22, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 41);
            this.btnCancel.TabIndex = 1057;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(412, 205);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 41);
            this.btnConfirm.TabIndex = 1056;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(212, 9);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(249, 29);
            this.lblStock.TabIndex = 1055;
            this.lblStock.Text = "Inventory Item Stock";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdateStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStock.Location = new System.Drawing.Point(21, 206);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(135, 41);
            this.btnUpdateStock.TabIndex = 1054;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // tbStockQty
            // 
            this.tbStockQty.AcceptsReturn = true;
            this.tbStockQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbStockQty.Location = new System.Drawing.Point(130, 163);
            this.tbStockQty.Name = "tbStockQty";
            this.tbStockQty.ReadOnly = true;
            this.tbStockQty.Size = new System.Drawing.Size(123, 26);
            this.tbStockQty.TabIndex = 1050;
            this.tbStockQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStockQty_KeyPress);
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQty.Location = new System.Drawing.Point(12, 169);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(83, 19);
            this.lblStockQty.TabIndex = 1053;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Arial", 12F);
            this.tbUnit.Location = new System.Drawing.Point(390, 162);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(157, 26);
            this.tbUnit.TabIndex = 1052;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(278, 168);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 1051;
            this.lblUnit.Text = "Unit";
            // 
            // tbStockStatus
            // 
            this.tbStockStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbStockStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.tbStockStatus.Location = new System.Drawing.Point(130, 114);
            this.tbStockStatus.Name = "tbStockStatus";
            this.tbStockStatus.ReadOnly = true;
            this.tbStockStatus.Size = new System.Drawing.Size(121, 26);
            this.tbStockStatus.TabIndex = 1043;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 19);
            this.lblStatus.TabIndex = 1048;
            this.lblStatus.Text = "Stock Status";
            // 
            // tbItemID
            // 
            this.tbItemID.AcceptsReturn = true;
            this.tbItemID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemID.Location = new System.Drawing.Point(130, 69);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.ReadOnly = true;
            this.tbItemID.Size = new System.Drawing.Size(123, 26);
            this.tbItemID.TabIndex = 1042;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(15, 75);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(61, 19);
            this.lblItemID.TabIndex = 1047;
            this.lblItemID.Text = "Item ID";
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbItemName.Location = new System.Drawing.Point(390, 74);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(157, 26);
            this.tbItemName.TabIndex = 1046;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(278, 80);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 1045;
            this.lblItemName.Text = "Item Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 49);
            this.panel1.TabIndex = 1058;
            // 
            // InventoryStockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.tbStockQty);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.tbStockStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.MaximumSize = new System.Drawing.Size(667, 297);
            this.Name = "InventoryStockUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryStockUpdate";
            this.Load += new System.EventHandler(this.InventoryStockUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox tbStockQty;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbStockStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel panel1;
    }
}