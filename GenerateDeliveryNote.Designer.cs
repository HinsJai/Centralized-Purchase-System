namespace UI
{
    partial class GenerateDeliveryNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbRestaurantContact = new System.Windows.Forms.TextBox();
            this.lblContacnt = new System.Windows.Forms.Label();
            this.tbRestaurantName = new System.Windows.Forms.TextBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblCPAItemList = new System.Windows.Forms.Label();
            this.dgvDeliveryitemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDNote = new System.Windows.Forms.Label();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.btnGenerateDNote = new System.Windows.Forms.Button();
            this.tbDeliveryNoteID = new System.Windows.Forms.TextBox();
            this.lblDeliveryNoteID = new System.Windows.Forms.Label();
            this.tbHiddenRequestID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryitemList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRestaurantContact
            // 
            this.tbRestaurantContact.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRestaurantContact.Location = new System.Drawing.Point(232, 184);
            this.tbRestaurantContact.Name = "tbRestaurantContact";
            this.tbRestaurantContact.ReadOnly = true;
            this.tbRestaurantContact.Size = new System.Drawing.Size(169, 26);
            this.tbRestaurantContact.TabIndex = 1133;
            // 
            // lblContacnt
            // 
            this.lblContacnt.AutoSize = true;
            this.lblContacnt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContacnt.Location = new System.Drawing.Point(26, 187);
            this.lblContacnt.Name = "lblContacnt";
            this.lblContacnt.Size = new System.Drawing.Size(157, 19);
            this.lblContacnt.TabIndex = 1132;
            this.lblContacnt.Text = "Restaurant Contact";
            // 
            // tbRestaurantName
            // 
            this.tbRestaurantName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRestaurantName.Location = new System.Drawing.Point(232, 137);
            this.tbRestaurantName.Name = "tbRestaurantName";
            this.tbRestaurantName.ReadOnly = true;
            this.tbRestaurantName.Size = new System.Drawing.Size(169, 26);
            this.tbRestaurantName.TabIndex = 1131;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantName.Location = new System.Drawing.Point(24, 140);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(141, 19);
            this.lblRestaurantName.TabIndex = 1130;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryDate.Location = new System.Drawing.Point(28, 242);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(110, 19);
            this.lblDeliveryDate.TabIndex = 1128;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblShipAddress.Location = new System.Drawing.Point(431, 89);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(111, 19);
            this.lblShipAddress.TabIndex = 1127;
            this.lblShipAddress.Text = "Ship Address";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.tbShipAddress.Location = new System.Drawing.Point(435, 132);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.ReadOnly = true;
            this.tbShipAddress.Size = new System.Drawing.Size(275, 129);
            this.tbShipAddress.TabIndex = 1126;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDeliveryDate.Location = new System.Drawing.Point(232, 235);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(169, 26);
            this.dtpDeliveryDate.TabIndex = 1129;
            // 
            // lblCPAItemList
            // 
            this.lblCPAItemList.AutoSize = true;
            this.lblCPAItemList.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCPAItemList.Location = new System.Drawing.Point(27, 302);
            this.lblCPAItemList.Name = "lblCPAItemList";
            this.lblCPAItemList.Size = new System.Drawing.Size(88, 22);
            this.lblCPAItemList.TabIndex = 1125;
            this.lblCPAItemList.Text = "Item List";
            this.lblCPAItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDeliveryitemList
            // 
            this.dgvDeliveryitemList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeliveryitemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDeliveryitemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveryitemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryitemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeliveryitemList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDeliveryitemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryitemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDeliveryitemList.ColumnHeadersHeight = 50;
            this.dgvDeliveryitemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeliveryitemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveryitemList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDeliveryitemList.EnableHeadersVisualStyles = false;
            this.dgvDeliveryitemList.Location = new System.Drawing.Point(32, 342);
            this.dgvDeliveryitemList.Name = "dgvDeliveryitemList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryitemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDeliveryitemList.RowHeadersVisible = false;
            this.dgvDeliveryitemList.RowHeadersWidth = 5;
            this.dgvDeliveryitemList.RowTemplate.Height = 24;
            this.dgvDeliveryitemList.Size = new System.Drawing.Size(678, 291);
            this.dgvDeliveryitemList.TabIndex = 1124;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 19.80812F;
            this.Column1.HeaderText = "Item ID";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 14.87251F;
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 6.975443F;
            this.Column6.HeaderText = "Total Qty";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 7.121422F;
            this.Column7.HeaderText = "Unit";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lblDNote
            // 
            this.lblDNote.AutoSize = true;
            this.lblDNote.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDNote.Location = new System.Drawing.Point(225, 9);
            this.lblDNote.Name = "lblDNote";
            this.lblDNote.Size = new System.Drawing.Size(275, 29);
            this.lblDNote.TabIndex = 1123;
            this.lblDNote.Text = "Generate Delivery Note";
            // 
            // tbSignature
            // 
            this.tbSignature.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignature.Location = new System.Drawing.Point(30, 697);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.ReadOnly = true;
            this.tbSignature.Size = new System.Drawing.Size(200, 29);
            this.tbSignature.TabIndex = 1137;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(26, 654);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(100, 22);
            this.lblSignature.TabIndex = 1136;
            this.lblSignature.Text = "Signature";
            // 
            // btnGenerateDNote
            // 
            this.btnGenerateDNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerateDNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateDNote.Location = new System.Drawing.Point(493, 672);
            this.btnGenerateDNote.Name = "btnGenerateDNote";
            this.btnGenerateDNote.Size = new System.Drawing.Size(217, 54);
            this.btnGenerateDNote.TabIndex = 1138;
            this.btnGenerateDNote.Text = "Generate Delivery Note";
            this.btnGenerateDNote.UseVisualStyleBackColor = false;
            this.btnGenerateDNote.Click += new System.EventHandler(this.btnGenerateDNote_Click);
            // 
            // tbDeliveryNoteID
            // 
            this.tbDeliveryNoteID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbDeliveryNoteID.Location = new System.Drawing.Point(232, 89);
            this.tbDeliveryNoteID.Name = "tbDeliveryNoteID";
            this.tbDeliveryNoteID.ReadOnly = true;
            this.tbDeliveryNoteID.Size = new System.Drawing.Size(169, 26);
            this.tbDeliveryNoteID.TabIndex = 1140;
            // 
            // lblDeliveryNoteID
            // 
            this.lblDeliveryNoteID.AutoSize = true;
            this.lblDeliveryNoteID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryNoteID.Location = new System.Drawing.Point(28, 96);
            this.lblDeliveryNoteID.Name = "lblDeliveryNoteID";
            this.lblDeliveryNoteID.Size = new System.Drawing.Size(131, 19);
            this.lblDeliveryNoteID.TabIndex = 1139;
            this.lblDeliveryNoteID.Text = "Delivery Note ID";
            // 
            // tbHiddenRequestID
            // 
            this.tbHiddenRequestID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbHiddenRequestID.Location = new System.Drawing.Point(230, 298);
            this.tbHiddenRequestID.Name = "tbHiddenRequestID";
            this.tbHiddenRequestID.ReadOnly = true;
            this.tbHiddenRequestID.Size = new System.Drawing.Size(171, 26);
            this.tbHiddenRequestID.TabIndex = 1141;
            this.tbHiddenRequestID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblDNote);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 55);
            this.panel1.TabIndex = 1142;
            // 
            // GenerateDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbHiddenRequestID);
            this.Controls.Add(this.tbDeliveryNoteID);
            this.Controls.Add(this.lblDeliveryNoteID);
            this.Controls.Add(this.btnGenerateDNote);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.tbRestaurantContact);
            this.Controls.Add(this.lblContacnt);
            this.Controls.Add(this.tbRestaurantName);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblShipAddress);
            this.Controls.Add(this.tbShipAddress);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.lblCPAItemList);
            this.Controls.Add(this.dgvDeliveryitemList);
            this.Name = "GenerateDeliveryNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateDeliveryNote";
            this.Load += new System.EventHandler(this.GenerateDeliveryNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryitemList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbRestaurantContact;
        private System.Windows.Forms.Label lblContacnt;
        private System.Windows.Forms.TextBox tbRestaurantName;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblCPAItemList;
        private System.Windows.Forms.DataGridView dgvDeliveryitemList;
        private System.Windows.Forms.Label lblDNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Button btnGenerateDNote;
        private System.Windows.Forms.TextBox tbDeliveryNoteID;
        private System.Windows.Forms.Label lblDeliveryNoteID;
        private System.Windows.Forms.TextBox tbHiddenRequestID;
        private System.Windows.Forms.Panel panel1;
    }
}