namespace UI
{
    partial class SupplierDetails
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
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.tbSupplierAddress = new System.Windows.Forms.TextBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblSupplierDetail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModifyConfirm = new System.Windows.Forms.Button();
            this.btnModifySupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(180, 360);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteSupplier.TabIndex = 1082;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(27, 166);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(88, 22);
            this.lblSupplierAddress.TabIndex = 1072;
            this.lblSupplierAddress.Text = "Address";
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplierAddress.Location = new System.Drawing.Point(31, 191);
            this.tbSupplierAddress.Multiline = true;
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.ReadOnly = true;
            this.tbSupplierAddress.Size = new System.Drawing.Size(782, 146);
            this.tbSupplierAddress.TabIndex = 1063;
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSupplierID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplierID.Location = new System.Drawing.Point(180, 76);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(200, 29);
            this.tbSupplierID.TabIndex = 1059;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(24, 79);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(112, 22);
            this.lblSupplierID.TabIndex = 1069;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompanyName.Location = new System.Drawing.Point(613, 76);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.ReadOnly = true;
            this.tbCompanyName.Size = new System.Drawing.Size(200, 29);
            this.tbCompanyName.TabIndex = 1058;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(434, 79);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(156, 22);
            this.lblCompanyName.TabIndex = 1068;
            this.lblCompanyName.Text = "Company Name";
            // 
            // tbContactName
            // 
            this.tbContactName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactName.Location = new System.Drawing.Point(180, 119);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.ReadOnly = true;
            this.tbContactName.Size = new System.Drawing.Size(200, 29);
            this.tbContactName.TabIndex = 1067;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(24, 122);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(139, 22);
            this.lblContactName.TabIndex = 1066;
            this.lblContactName.Text = "Contact Name";
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactNumber.Location = new System.Drawing.Point(613, 119);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.ReadOnly = true;
            this.tbContactNumber.Size = new System.Drawing.Size(200, 29);
            this.tbContactNumber.TabIndex = 1060;
            this.tbContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContactNumber_KeyPress);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(434, 122);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(160, 22);
            this.lblContactNumber.TabIndex = 1064;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblSupplierDetail
            // 
            this.lblSupplierDetail.AutoSize = true;
            this.lblSupplierDetail.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblSupplierDetail.Location = new System.Drawing.Point(300, 9);
            this.lblSupplierDetail.Name = "lblSupplierDetail";
            this.lblSupplierDetail.Size = new System.Drawing.Size(208, 32);
            this.lblSupplierDetail.TabIndex = 1057;
            this.lblSupplierDetail.Text = "Supplier Detail";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(28, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 38);
            this.btnCancel.TabIndex = 1056;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModifyConfirm
            // 
            this.btnModifyConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModifyConfirm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyConfirm.Location = new System.Drawing.Point(699, 360);
            this.btnModifyConfirm.Name = "btnModifyConfirm";
            this.btnModifyConfirm.Size = new System.Drawing.Size(114, 38);
            this.btnModifyConfirm.TabIndex = 1055;
            this.btnModifyConfirm.Text = "Confirm";
            this.btnModifyConfirm.UseVisualStyleBackColor = false;
            this.btnModifyConfirm.Visible = false;
            this.btnModifyConfirm.Click += new System.EventHandler(this.btnModifyConfirm_Click);
            // 
            // btnModifySupplier
            // 
            this.btnModifySupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifySupplier.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifySupplier.Location = new System.Drawing.Point(28, 360);
            this.btnModifySupplier.Name = "btnModifySupplier";
            this.btnModifySupplier.Size = new System.Drawing.Size(122, 38);
            this.btnModifySupplier.TabIndex = 1054;
            this.btnModifySupplier.Text = "Modify";
            this.btnModifySupplier.UseVisualStyleBackColor = false;
            this.btnModifySupplier.Click += new System.EventHandler(this.btnModifySupplier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblSupplierDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 55);
            this.panel1.TabIndex = 1083;
            // 
            // SupplierDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.tbSupplierAddress);
            this.Controls.Add(this.tbSupplierID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.tbContactName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.tbContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyConfirm);
            this.Controls.Add(this.btnModifySupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(844, 454);
            this.Name = "SupplierDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierDetail";
            this.Load += new System.EventHandler(this.SupplierDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.TextBox tbSupplierAddress;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblSupplierDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModifyConfirm;
        private System.Windows.Forms.Button btnModifySupplier;
        private System.Windows.Forms.Panel panel1;
    }
}