namespace UI
{
    partial class DespatchInstructionDetails
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
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCPAItemList = new System.Windows.Forms.Label();
            this.dgvDespatchItemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldespatchDetails = new System.Windows.Forms.Label();
            this.tbRestaurantID = new System.Windows.Forms.TextBox();
            this.tbHandleBy = new System.Windows.Forms.TextBox();
            this.tbDespatch = new System.Windows.Forms.TextBox();
            this.lblRestaurantID = new System.Windows.Forms.Label();
            this.lblHandleBy = new System.Windows.Forms.Label();
            this.lblDespatchID = new System.Windows.Forms.Label();
            this.tbRestaurantName = new System.Windows.Forms.TextBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.tbRestaurantContact = new System.Windows.Forms.TextBox();
            this.lblContacnt = new System.Windows.Forms.Label();
            this.lblDisplayStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnGenerateDNote = new System.Windows.Forms.Button();
            this.tbHiddenRequestID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchItemList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPickUpDate.Location = new System.Drawing.Point(418, 213);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(107, 19);
            this.lblPickUpDate.TabIndex = 1108;
            this.lblPickUpDate.Text = "Pick Up Date";
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblShipAddress.Location = new System.Drawing.Point(37, 285);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(111, 19);
            this.lblShipAddress.TabIndex = 1107;
            this.lblShipAddress.Text = "Ship Address";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.tbShipAddress.Location = new System.Drawing.Point(41, 325);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.ReadOnly = true;
            this.tbShipAddress.Size = new System.Drawing.Size(344, 114);
            this.tbShipAddress.TabIndex = 1106;
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.Enabled = false;
            this.dtpPickUpDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpPickUpDate.Location = new System.Drawing.Point(566, 206);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpPickUpDate.TabIndex = 1109;
            // 
            // lblCPAItemList
            // 
            this.lblCPAItemList.AutoSize = true;
            this.lblCPAItemList.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCPAItemList.Location = new System.Drawing.Point(37, 458);
            this.lblCPAItemList.Name = "lblCPAItemList";
            this.lblCPAItemList.Size = new System.Drawing.Size(88, 22);
            this.lblCPAItemList.TabIndex = 1101;
            this.lblCPAItemList.Text = "Item List";
            this.lblCPAItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDespatchItemList
            // 
            this.dgvDespatchItemList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDespatchItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDespatchItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespatchItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespatchItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDespatchItemList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDespatchItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespatchItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDespatchItemList.ColumnHeadersHeight = 50;
            this.dgvDespatchItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDespatchItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvDespatchItemList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDespatchItemList.EnableHeadersVisualStyles = false;
            this.dgvDespatchItemList.Location = new System.Drawing.Point(30, 502);
            this.dgvDespatchItemList.Name = "dgvDespatchItemList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespatchItemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDespatchItemList.RowHeadersVisible = false;
            this.dgvDespatchItemList.RowHeadersWidth = 5;
            this.dgvDespatchItemList.RowTemplate.Height = 24;
            this.dgvDespatchItemList.Size = new System.Drawing.Size(733, 258);
            this.dgvDespatchItemList.TabIndex = 1100;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 19.80812F;
            this.Column1.HeaderText = "Item ID";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 86;
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
            // lbldespatchDetails
            // 
            this.lbldespatchDetails.AutoSize = true;
            this.lbldespatchDetails.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbldespatchDetails.Location = new System.Drawing.Point(291, 9);
            this.lbldespatchDetails.Name = "lbldespatchDetails";
            this.lbldespatchDetails.Size = new System.Drawing.Size(337, 29);
            this.lbldespatchDetails.TabIndex = 1098;
            this.lbldespatchDetails.Text = "Despatch Instruction Details";
            // 
            // tbRestaurantID
            // 
            this.tbRestaurantID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRestaurantID.Location = new System.Drawing.Point(213, 143);
            this.tbRestaurantID.Name = "tbRestaurantID";
            this.tbRestaurantID.ReadOnly = true;
            this.tbRestaurantID.Size = new System.Drawing.Size(172, 26);
            this.tbRestaurantID.TabIndex = 1095;
            // 
            // tbHandleBy
            // 
            this.tbHandleBy.Font = new System.Drawing.Font("Arial", 12F);
            this.tbHandleBy.Location = new System.Drawing.Point(566, 66);
            this.tbHandleBy.Name = "tbHandleBy";
            this.tbHandleBy.ReadOnly = true;
            this.tbHandleBy.Size = new System.Drawing.Size(200, 26);
            this.tbHandleBy.TabIndex = 1094;
            // 
            // tbDespatch
            // 
            this.tbDespatch.Font = new System.Drawing.Font("Arial", 12F);
            this.tbDespatch.Location = new System.Drawing.Point(213, 78);
            this.tbDespatch.Name = "tbDespatch";
            this.tbDespatch.ReadOnly = true;
            this.tbDespatch.Size = new System.Drawing.Size(172, 26);
            this.tbDespatch.TabIndex = 1093;
            // 
            // lblRestaurantID
            // 
            this.lblRestaurantID.AutoSize = true;
            this.lblRestaurantID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantID.Location = new System.Drawing.Point(37, 146);
            this.lblRestaurantID.Name = "lblRestaurantID";
            this.lblRestaurantID.Size = new System.Drawing.Size(113, 19);
            this.lblRestaurantID.TabIndex = 1090;
            this.lblRestaurantID.Text = "Restaurant ID";
            // 
            // lblHandleBy
            // 
            this.lblHandleBy.AutoSize = true;
            this.lblHandleBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblHandleBy.Location = new System.Drawing.Point(411, 76);
            this.lblHandleBy.Name = "lblHandleBy";
            this.lblHandleBy.Size = new System.Drawing.Size(88, 19);
            this.lblHandleBy.TabIndex = 1089;
            this.lblHandleBy.Text = "Handle By";
            // 
            // lblDespatchID
            // 
            this.lblDespatchID.AutoSize = true;
            this.lblDespatchID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDespatchID.Location = new System.Drawing.Point(35, 82);
            this.lblDespatchID.Name = "lblDespatchID";
            this.lblDespatchID.Size = new System.Drawing.Size(102, 19);
            this.lblDespatchID.TabIndex = 1088;
            this.lblDespatchID.Text = "Despatch ID";
            // 
            // tbRestaurantName
            // 
            this.tbRestaurantName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRestaurantName.Location = new System.Drawing.Point(566, 134);
            this.tbRestaurantName.Name = "tbRestaurantName";
            this.tbRestaurantName.ReadOnly = true;
            this.tbRestaurantName.Size = new System.Drawing.Size(200, 26);
            this.tbRestaurantName.TabIndex = 1111;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantName.Location = new System.Drawing.Point(411, 141);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(141, 19);
            this.lblRestaurantName.TabIndex = 1110;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // tbRestaurantContact
            // 
            this.tbRestaurantContact.Font = new System.Drawing.Font("Arial", 12F);
            this.tbRestaurantContact.Location = new System.Drawing.Point(213, 215);
            this.tbRestaurantContact.Name = "tbRestaurantContact";
            this.tbRestaurantContact.ReadOnly = true;
            this.tbRestaurantContact.Size = new System.Drawing.Size(172, 26);
            this.tbRestaurantContact.TabIndex = 1113;
            // 
            // lblContacnt
            // 
            this.lblContacnt.AutoSize = true;
            this.lblContacnt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContacnt.Location = new System.Drawing.Point(37, 218);
            this.lblContacnt.Name = "lblContacnt";
            this.lblContacnt.Size = new System.Drawing.Size(157, 19);
            this.lblContacnt.TabIndex = 1112;
            this.lblContacnt.Text = "Restaurant Contact";
            // 
            // lblDisplayStatus
            // 
            this.lblDisplayStatus.AutoSize = true;
            this.lblDisplayStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayStatus.Location = new System.Drawing.Point(593, 280);
            this.lblDisplayStatus.Name = "lblDisplayStatus";
            this.lblDisplayStatus.Size = new System.Drawing.Size(58, 19);
            this.lblDisplayStatus.TabIndex = 1115;
            this.lblDisplayStatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(418, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 1114;
            this.lblStatus.Text = "Status";
            // 
            // btnGenerateDNote
            // 
            this.btnGenerateDNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerateDNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateDNote.Location = new System.Drawing.Point(543, 426);
            this.btnGenerateDNote.Name = "btnGenerateDNote";
            this.btnGenerateDNote.Size = new System.Drawing.Size(220, 54);
            this.btnGenerateDNote.TabIndex = 1116;
            this.btnGenerateDNote.Text = "Generate Delivery Note";
            this.btnGenerateDNote.UseVisualStyleBackColor = false;
            this.btnGenerateDNote.Click += new System.EventHandler(this.btnGenerateDNote_Click);
            // 
            // tbHiddenRequestID
            // 
            this.tbHiddenRequestID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbHiddenRequestID.Location = new System.Drawing.Point(213, 277);
            this.tbHiddenRequestID.Name = "tbHiddenRequestID";
            this.tbHiddenRequestID.ReadOnly = true;
            this.tbHiddenRequestID.Size = new System.Drawing.Size(150, 26);
            this.tbHiddenRequestID.TabIndex = 1118;
            this.tbHiddenRequestID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbldespatchDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 56);
            this.panel1.TabIndex = 1119;
            // 
            // DespatchInstructionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 784);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbHiddenRequestID);
            this.Controls.Add(this.btnGenerateDNote);
            this.Controls.Add(this.lblDisplayStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbRestaurantContact);
            this.Controls.Add(this.lblContacnt);
            this.Controls.Add(this.tbRestaurantName);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblShipAddress);
            this.Controls.Add(this.tbShipAddress);
            this.Controls.Add(this.dtpPickUpDate);
            this.Controls.Add(this.lblCPAItemList);
            this.Controls.Add(this.dgvDespatchItemList);
            this.Controls.Add(this.tbRestaurantID);
            this.Controls.Add(this.tbHandleBy);
            this.Controls.Add(this.tbDespatch);
            this.Controls.Add(this.lblRestaurantID);
            this.Controls.Add(this.lblHandleBy);
            this.Controls.Add(this.lblDespatchID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DespatchInstructionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DespatchInstructionDetails";
            this.Load += new System.EventHandler(this.DespatchInstructionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchItemList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.Label lblCPAItemList;
        private System.Windows.Forms.DataGridView dgvDespatchItemList;
        private System.Windows.Forms.Label lbldespatchDetails;
        private System.Windows.Forms.TextBox tbRestaurantID;
        private System.Windows.Forms.TextBox tbHandleBy;
        private System.Windows.Forms.TextBox tbDespatch;
        private System.Windows.Forms.Label lblRestaurantID;
        private System.Windows.Forms.Label lblHandleBy;
        private System.Windows.Forms.Label lblDespatchID;
        private System.Windows.Forms.TextBox tbRestaurantName;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.TextBox tbRestaurantContact;
        private System.Windows.Forms.Label lblContacnt;
        private System.Windows.Forms.Label lblDisplayStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnGenerateDNote;
        private System.Windows.Forms.TextBox tbHiddenRequestID;
        private System.Windows.Forms.Panel panel1;
    }
}