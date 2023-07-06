namespace UI
{
    partial class RestaurantStock
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
            this.tbStockStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.tbRestaurantID = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblRestaurantID = new System.Windows.Forms.Label();
            this.tbStockQty = new System.Windows.Forms.TextBox();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStockStatus
            // 
            this.tbStockStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbStockStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockStatus.Location = new System.Drawing.Point(405, 62);
            this.tbStockStatus.Name = "tbStockStatus";
            this.tbStockStatus.ReadOnly = true;
            this.tbStockStatus.Size = new System.Drawing.Size(153, 29);
            this.tbStockStatus.TabIndex = 1027;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(293, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 19);
            this.lblStatus.TabIndex = 1032;
            this.lblStatus.Text = "Stock Status";
            // 
            // tbItemID
            // 
            this.tbItemID.AcceptsReturn = true;
            this.tbItemID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemID.Location = new System.Drawing.Point(130, 112);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.ReadOnly = true;
            this.tbItemID.Size = new System.Drawing.Size(121, 29);
            this.tbItemID.TabIndex = 1026;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(15, 118);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(61, 19);
            this.lblItemID.TabIndex = 1031;
            this.lblItemID.Text = "Item ID";
            // 
            // tbRestaurantID
            // 
            this.tbRestaurantID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRestaurantID.Location = new System.Drawing.Point(130, 62);
            this.tbRestaurantID.Name = "tbRestaurantID";
            this.tbRestaurantID.ReadOnly = true;
            this.tbRestaurantID.Size = new System.Drawing.Size(119, 29);
            this.tbRestaurantID.TabIndex = 1033;
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(405, 112);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(153, 29);
            this.tbItemName.TabIndex = 1030;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(293, 118);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 19);
            this.lblItemName.TabIndex = 1029;
            this.lblItemName.Text = "Item Name";
            // 
            // lblRestaurantID
            // 
            this.lblRestaurantID.AutoSize = true;
            this.lblRestaurantID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantID.Location = new System.Drawing.Point(15, 68);
            this.lblRestaurantID.Name = "lblRestaurantID";
            this.lblRestaurantID.Size = new System.Drawing.Size(109, 19);
            this.lblRestaurantID.TabIndex = 1028;
            this.lblRestaurantID.Text = "RestaurantID";
            // 
            // tbStockQty
            // 
            this.tbStockQty.AcceptsReturn = true;
            this.tbStockQty.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockQty.Location = new System.Drawing.Point(128, 162);
            this.tbStockQty.Name = "tbStockQty";
            this.tbStockQty.ReadOnly = true;
            this.tbStockQty.Size = new System.Drawing.Size(121, 29);
            this.tbStockQty.TabIndex = 1034;
            this.tbStockQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStockQty_KeyPress);
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQty.Location = new System.Drawing.Point(15, 168);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(83, 19);
            this.lblStockQty.TabIndex = 1037;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnit.Location = new System.Drawing.Point(405, 162);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(153, 29);
            this.tbUnit.TabIndex = 1036;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(293, 168);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 1035;
            this.lblUnit.Text = "Unit";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdateStock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Location = new System.Drawing.Point(19, 205);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(135, 41);
            this.btnUpdateStock.TabIndex = 1038;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(189, 9);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(238, 26);
            this.lblStock.TabIndex = 1039;
            this.lblStock.Text = "Restaurant Item Stock";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(423, 205);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 41);
            this.btnConfirm.TabIndex = 1040;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(19, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 41);
            this.btnCancel.TabIndex = 1041;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 42);
            this.panel1.TabIndex = 1042;
            // 
            // RestaurantStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 263);
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
            this.Controls.Add(this.tbRestaurantID);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblRestaurantID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RestaurantStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantStock";
            this.Load += new System.EventHandler(this.RestaurantStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStockStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox tbRestaurantID;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblRestaurantID;
        private System.Windows.Forms.TextBox tbStockQty;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}