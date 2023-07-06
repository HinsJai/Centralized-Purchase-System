namespace UI
{
    partial class DespatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRAddress = new System.Windows.Forms.Label();
            this.lblPurchaseManagerID = new System.Windows.Forms.Label();
            this.lblResName = new System.Windows.Forms.Label();
            this.tbResName = new System.Windows.Forms.TextBox();
            this.tbPurchaseManagerID = new System.Windows.Forms.TextBox();
            this.tbRAdress = new System.Windows.Forms.TextBox();
            this.lblDespatchID = new System.Windows.Forms.Label();
            this.lblResContent = new System.Windows.Forms.Label();
            this.tbResContent = new System.Windows.Forms.TextBox();
            this.tbDespatchID = new System.Windows.Forms.TextBox();
            this.dgvDespatchList = new System.Windows.Forms.DataGridView();
            this.rvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.tbPickUpDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.lblDespatch = new System.Windows.Forms.Label();
            this.lblResID = new System.Windows.Forms.Label();
            this.tbResID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRequestItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRAddress
            // 
            this.lblRAddress.AutoSize = true;
            this.lblRAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRAddress.Location = new System.Drawing.Point(12, 264);
            this.lblRAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRAddress.Name = "lblRAddress";
            this.lblRAddress.Size = new System.Drawing.Size(160, 19);
            this.lblRAddress.TabIndex = 28;
            this.lblRAddress.Text = "Restaurant Address";
            this.lblRAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPurchaseManagerID
            // 
            this.lblPurchaseManagerID.AutoSize = true;
            this.lblPurchaseManagerID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseManagerID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPurchaseManagerID.Location = new System.Drawing.Point(398, 103);
            this.lblPurchaseManagerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseManagerID.Name = "lblPurchaseManagerID";
            this.lblPurchaseManagerID.Size = new System.Drawing.Size(172, 19);
            this.lblPurchaseManagerID.TabIndex = 27;
            this.lblPurchaseManagerID.Text = "Purchase Manager ID";
            // 
            // lblResName
            // 
            this.lblResName.AutoSize = true;
            this.lblResName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResName.Location = new System.Drawing.Point(398, 158);
            this.lblResName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResName.Name = "lblResName";
            this.lblResName.Size = new System.Drawing.Size(141, 19);
            this.lblResName.TabIndex = 26;
            this.lblResName.Text = "Restaurant Name";
            // 
            // tbResName
            // 
            this.tbResName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbResName.Location = new System.Drawing.Point(600, 151);
            this.tbResName.Margin = new System.Windows.Forms.Padding(4);
            this.tbResName.Name = "tbResName";
            this.tbResName.ReadOnly = true;
            this.tbResName.Size = new System.Drawing.Size(175, 26);
            this.tbResName.TabIndex = 25;
            // 
            // tbPurchaseManagerID
            // 
            this.tbPurchaseManagerID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbPurchaseManagerID.Location = new System.Drawing.Point(600, 96);
            this.tbPurchaseManagerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbPurchaseManagerID.Name = "tbPurchaseManagerID";
            this.tbPurchaseManagerID.ReadOnly = true;
            this.tbPurchaseManagerID.Size = new System.Drawing.Size(175, 26);
            this.tbPurchaseManagerID.TabIndex = 24;
            // 
            // tbRAdress
            // 
            this.tbRAdress.Font = new System.Drawing.Font("Arial", 14.25F);
            this.tbRAdress.Location = new System.Drawing.Point(16, 300);
            this.tbRAdress.Margin = new System.Windows.Forms.Padding(4);
            this.tbRAdress.Multiline = true;
            this.tbRAdress.Name = "tbRAdress";
            this.tbRAdress.ReadOnly = true;
            this.tbRAdress.Size = new System.Drawing.Size(355, 106);
            this.tbRAdress.TabIndex = 23;
            // 
            // lblDespatchID
            // 
            this.lblDespatchID.AutoSize = true;
            this.lblDespatchID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespatchID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDespatchID.Location = new System.Drawing.Point(12, 101);
            this.lblDespatchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDespatchID.Name = "lblDespatchID";
            this.lblDespatchID.Size = new System.Drawing.Size(102, 19);
            this.lblDespatchID.TabIndex = 33;
            this.lblDespatchID.Text = "Despatch ID";
            // 
            // lblResContent
            // 
            this.lblResContent.AutoSize = true;
            this.lblResContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResContent.Location = new System.Drawing.Point(12, 221);
            this.lblResContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResContent.Name = "lblResContent";
            this.lblResContent.Size = new System.Drawing.Size(158, 19);
            this.lblResContent.TabIndex = 32;
            this.lblResContent.Text = "Restaurant Content";
            // 
            // tbResContent
            // 
            this.tbResContent.Font = new System.Drawing.Font("Arial", 12F);
            this.tbResContent.Location = new System.Drawing.Point(196, 213);
            this.tbResContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbResContent.Name = "tbResContent";
            this.tbResContent.ReadOnly = true;
            this.tbResContent.Size = new System.Drawing.Size(175, 26);
            this.tbResContent.TabIndex = 31;
            // 
            // tbDespatchID
            // 
            this.tbDespatchID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbDespatchID.Location = new System.Drawing.Point(196, 93);
            this.tbDespatchID.Margin = new System.Windows.Forms.Padding(4);
            this.tbDespatchID.Name = "tbDespatchID";
            this.tbDespatchID.ReadOnly = true;
            this.tbDespatchID.Size = new System.Drawing.Size(175, 26);
            this.tbDespatchID.TabIndex = 30;
            // 
            // dgvDespatchList
            // 
            this.dgvDespatchList.AllowUserToAddRows = false;
            this.dgvDespatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespatchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespatchList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDespatchList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespatchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDespatchList.ColumnHeadersHeight = 50;
            this.dgvDespatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDespatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rvID,
            this.rItemName,
            this.rItemType,
            this.rCategory,
            this.Column1,
            this.rItemQty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDespatchList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDespatchList.EnableHeadersVisualStyles = false;
            this.dgvDespatchList.Location = new System.Drawing.Point(16, 451);
            this.dgvDespatchList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDespatchList.Name = "dgvDespatchList";
            this.dgvDespatchList.RowHeadersVisible = false;
            this.dgvDespatchList.RowHeadersWidth = 82;
            this.dgvDespatchList.RowTemplate.Height = 40;
            this.dgvDespatchList.Size = new System.Drawing.Size(759, 227);
            this.dgvDespatchList.TabIndex = 34;
            // 
            // rvID
            // 
            this.rvID.FillWeight = 13.15803F;
            this.rvID.HeaderText = "Request ID";
            this.rvID.MinimumWidth = 10;
            this.rvID.Name = "rvID";
            this.rvID.ReadOnly = true;
            // 
            // rItemName
            // 
            this.rItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemName.FillWeight = 16.7727F;
            this.rItemName.HeaderText = "Item ID";
            this.rItemName.MinimumWidth = 10;
            this.rItemName.Name = "rItemName";
            this.rItemName.ReadOnly = true;
            // 
            // rItemType
            // 
            this.rItemType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemType.FillWeight = 13.15803F;
            this.rItemType.HeaderText = "Item Name";
            this.rItemType.MinimumWidth = 10;
            this.rItemType.Name = "rItemType";
            this.rItemType.ReadOnly = true;
            // 
            // rCategory
            // 
            this.rCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rCategory.FillWeight = 13.15803F;
            this.rCategory.HeaderText = "Request Qty";
            this.rCategory.MinimumWidth = 10;
            this.rCategory.Name = "rCategory";
            this.rCategory.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Unit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // rItemQty
            // 
            this.rItemQty.FillWeight = 7.894815F;
            this.rItemQty.HeaderText = "Item Status";
            this.rItemQty.MinimumWidth = 10;
            this.rItemQty.Name = "rItemQty";
            this.rItemQty.ReadOnly = true;
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPickUpDate.Location = new System.Drawing.Point(398, 220);
            this.lblPickUpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(107, 19);
            this.lblPickUpDate.TabIndex = 36;
            this.lblPickUpDate.Text = "Pick Up Date";
            // 
            // tbPickUpDate
            // 
            this.tbPickUpDate.Font = new System.Drawing.Font("Arial", 12F);
            this.tbPickUpDate.Location = new System.Drawing.Point(600, 213);
            this.tbPickUpDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbPickUpDate.Name = "tbPickUpDate";
            this.tbPickUpDate.ReadOnly = true;
            this.tbPickUpDate.Size = new System.Drawing.Size(175, 26);
            this.tbPickUpDate.TabIndex = 35;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(16, 692);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 48);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitRequest.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmitRequest.Location = new System.Drawing.Point(668, 692);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(107, 48);
            this.btnSubmitRequest.TabIndex = 38;
            this.btnSubmitRequest.Text = "Submit";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // lblDespatch
            // 
            this.lblDespatch.AutoSize = true;
            this.lblDespatch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDespatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDespatch.Location = new System.Drawing.Point(287, 9);
            this.lblDespatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDespatch.Name = "lblDespatch";
            this.lblDespatch.Size = new System.Drawing.Size(252, 29);
            this.lblDespatch.TabIndex = 39;
            this.lblDespatch.Text = "Despatch Instruction";
            this.lblDespatch.Click += new System.EventHandler(this.lblDespatch_Click);
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResID.Location = new System.Drawing.Point(12, 166);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(113, 19);
            this.lblResID.TabIndex = 41;
            this.lblResID.Text = "Restaurant ID";
            // 
            // tbResID
            // 
            this.tbResID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbResID.Location = new System.Drawing.Point(196, 158);
            this.tbResID.Margin = new System.Windows.Forms.Padding(4);
            this.tbResID.Name = "tbResID";
            this.tbResID.ReadOnly = true;
            this.tbResID.Size = new System.Drawing.Size(175, 26);
            this.tbResID.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblDespatch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 55);
            this.panel1.TabIndex = 1084;
            // 
            // lblRequestItem
            // 
            this.lblRequestItem.AutoSize = true;
            this.lblRequestItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblRequestItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRequestItem.Location = new System.Drawing.Point(13, 425);
            this.lblRequestItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestItem.Name = "lblRequestItem";
            this.lblRequestItem.Size = new System.Drawing.Size(130, 22);
            this.lblRequestItem.TabIndex = 1085;
            this.lblRequestItem.Text = "Request Item";
            // 
            // DespatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 761);
            this.Controls.Add(this.lblRequestItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResID);
            this.Controls.Add(this.tbResID);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.tbPickUpDate);
            this.Controls.Add(this.dgvDespatchList);
            this.Controls.Add(this.lblDespatchID);
            this.Controls.Add(this.lblResContent);
            this.Controls.Add(this.tbResContent);
            this.Controls.Add(this.tbDespatchID);
            this.Controls.Add(this.lblRAddress);
            this.Controls.Add(this.lblPurchaseManagerID);
            this.Controls.Add(this.lblResName);
            this.Controls.Add(this.tbResName);
            this.Controls.Add(this.tbPurchaseManagerID);
            this.Controls.Add(this.tbRAdress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DespatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DespatchForm";
            this.Load += new System.EventHandler(this.DespatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRAddress;
        private System.Windows.Forms.Label lblPurchaseManagerID;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.TextBox tbResName;
        private System.Windows.Forms.TextBox tbPurchaseManagerID;
        private System.Windows.Forms.TextBox tbRAdress;
        private System.Windows.Forms.Label lblDespatchID;
        private System.Windows.Forms.Label lblResContent;
        private System.Windows.Forms.TextBox tbResContent;
        private System.Windows.Forms.TextBox tbDespatchID;
        private System.Windows.Forms.DataGridView dgvDespatchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn rvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemQty;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.TextBox tbPickUpDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Label lblDespatch;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.TextBox tbResID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRequestItem;
    }
}