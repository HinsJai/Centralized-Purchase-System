namespace UI
{
    partial class AddSupplier
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
            this.lblAddSupplier = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierAddress.Location = new System.Drawing.Point(19, 200);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(73, 19);
            this.lblSupplierAddress.TabIndex = 1096;
            this.lblSupplierAddress.Text = "Address";
            // 
            // tbSupplierAddress
            // 
            this.tbSupplierAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSupplierAddress.Location = new System.Drawing.Point(21, 225);
            this.tbSupplierAddress.Multiline = true;
            this.tbSupplierAddress.Name = "tbSupplierAddress";
            this.tbSupplierAddress.Size = new System.Drawing.Size(312, 89);
            this.tbSupplierAddress.TabIndex = 1090;
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSupplierID.Location = new System.Drawing.Point(171, 96);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(162, 26);
            this.tbSupplierID.TabIndex = 1088;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(19, 100);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(93, 19);
            this.lblSupplierID.TabIndex = 1095;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCompanyName.Location = new System.Drawing.Point(532, 96);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(162, 26);
            this.tbCompanyName.TabIndex = 1087;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.Location = new System.Drawing.Point(368, 99);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(131, 19);
            this.lblCompanyName.TabIndex = 1094;
            this.lblCompanyName.Text = "Company Name";
            // 
            // tbContactName
            // 
            this.tbContactName.Font = new System.Drawing.Font("Arial", 12F);
            this.tbContactName.Location = new System.Drawing.Point(171, 151);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(162, 26);
            this.tbContactName.TabIndex = 1093;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactName.Location = new System.Drawing.Point(17, 151);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(117, 19);
            this.lblContactName.TabIndex = 1092;
            this.lblContactName.Text = "Contact Name";
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.tbContactNumber.Location = new System.Drawing.Point(532, 151);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(162, 26);
            this.tbContactNumber.TabIndex = 1089;
            this.tbContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContactNumber_KeyPress);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactNumber.Location = new System.Drawing.Point(368, 154);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(134, 19);
            this.lblContactNumber.TabIndex = 1091;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblAddSupplier
            // 
            this.lblAddSupplier.AutoSize = true;
            this.lblAddSupplier.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblAddSupplier.Location = new System.Drawing.Point(264, 9);
            this.lblAddSupplier.Name = "lblAddSupplier";
            this.lblAddSupplier.Size = new System.Drawing.Size(164, 29);
            this.lblAddSupplier.TabIndex = 1086;
            this.lblAddSupplier.Text = "Add Supplier";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(24, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 54);
            this.btnReset.TabIndex = 1085;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(576, 341);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 54);
            this.btnCreate.TabIndex = 1084;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Arial", 11F);
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(21, 61);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(268, 17);
            this.lblHint.TabIndex = 1097;
            this.lblHint.Text = "*Supplier  ID is auto generate by system";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblAddSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 55);
            this.panel1.TabIndex = 1098;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHint);
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
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblAddSupplier;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Panel panel1;
    }
}