
namespace UI
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.tbRName = new System.Windows.Forms.TextBox();
            this.tbRAdress = new System.Windows.Forms.TextBox();
            this.tbRType = new System.Windows.Forms.TextBox();
            this.tbRContent = new System.Windows.Forms.TextBox();
            this.tbStaffPosition = new System.Windows.Forms.TextBox();
            this.lblRName = new System.Windows.Forms.Label();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.lblrContent = new System.Windows.Forms.Label();
            this.lblrType = new System.Windows.Forms.Label();
            this.lblRAddress = new System.Windows.Forms.Label();
            this.dgvConfirmtList = new System.Windows.Forms.DataGridView();
            this.rvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRequestForm = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.lblstaffID = new System.Windows.Forms.Label();
            this.lblStaffPosition = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRequestItem = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbRStaffID = new System.Windows.Forms.TextBox();
            this.lblRequestFormTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmtList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitRequest
            // 
            resources.ApplyResources(this.btnSubmitRequest, "btnSubmitRequest");
            this.btnSubmitRequest.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.BtnSubmitRequest_Click);
            // 
            // tbRName
            // 
            resources.ApplyResources(this.tbRName, "tbRName");
            this.tbRName.Name = "tbRName";
            this.tbRName.ReadOnly = true;
            // 
            // tbRAdress
            // 
            resources.ApplyResources(this.tbRAdress, "tbRAdress");
            this.tbRAdress.Name = "tbRAdress";
            this.tbRAdress.ReadOnly = true;
            // 
            // tbRType
            // 
            resources.ApplyResources(this.tbRType, "tbRType");
            this.tbRType.Name = "tbRType";
            this.tbRType.ReadOnly = true;
            // 
            // tbRContent
            // 
            resources.ApplyResources(this.tbRContent, "tbRContent");
            this.tbRContent.Name = "tbRContent";
            this.tbRContent.ReadOnly = true;
            // 
            // tbStaffPosition
            // 
            resources.ApplyResources(this.tbStaffPosition, "tbStaffPosition");
            this.tbStaffPosition.Name = "tbStaffPosition";
            this.tbStaffPosition.ReadOnly = true;
            // 
            // lblRName
            // 
            resources.ApplyResources(this.lblRName, "lblRName");
            this.lblRName.Name = "lblRName";
            // 
            // lblPickUpDate
            // 
            resources.ApplyResources(this.lblPickUpDate, "lblPickUpDate");
            this.lblPickUpDate.Name = "lblPickUpDate";
            // 
            // lblrContent
            // 
            resources.ApplyResources(this.lblrContent, "lblrContent");
            this.lblrContent.Name = "lblrContent";
            // 
            // lblrType
            // 
            resources.ApplyResources(this.lblrType, "lblrType");
            this.lblrType.Name = "lblrType";
            // 
            // lblRAddress
            // 
            resources.ApplyResources(this.lblRAddress, "lblRAddress");
            this.lblRAddress.Name = "lblRAddress";
            // 
            // dgvConfirmtList
            // 
            this.dgvConfirmtList.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvConfirmtList, "dgvConfirmtList");
            this.dgvConfirmtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfirmtList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConfirmtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConfirmtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConfirmtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConfirmtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rvID,
            this.rItemName,
            this.rItemType,
            this.rCategory,
            this.Column1,
            this.rItemQty,
            this.rUnit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConfirmtList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConfirmtList.EnableHeadersVisualStyles = false;
            this.dgvConfirmtList.Name = "dgvConfirmtList";
            this.dgvConfirmtList.RowHeadersVisible = false;
            this.dgvConfirmtList.RowTemplate.Height = 40;
            this.dgvConfirmtList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvConfirmtList_CellPainting);
            // 
            // rvID
            // 
            this.rvID.FillWeight = 13.15803F;
            resources.ApplyResources(this.rvID, "rvID");
            this.rvID.Name = "rvID";
            this.rvID.ReadOnly = true;
            // 
            // rItemName
            // 
            this.rItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemName.FillWeight = 16.7727F;
            resources.ApplyResources(this.rItemName, "rItemName");
            this.rItemName.Name = "rItemName";
            this.rItemName.ReadOnly = true;
            // 
            // rItemType
            // 
            this.rItemType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemType.FillWeight = 13.15803F;
            resources.ApplyResources(this.rItemType, "rItemType");
            this.rItemType.Name = "rItemType";
            this.rItemType.ReadOnly = true;
            // 
            // rCategory
            // 
            this.rCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rCategory.FillWeight = 13.15803F;
            resources.ApplyResources(this.rCategory, "rCategory");
            this.rCategory.Name = "rCategory";
            this.rCategory.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // rItemQty
            // 
            this.rItemQty.FillWeight = 7.894815F;
            resources.ApplyResources(this.rItemQty, "rItemQty");
            this.rItemQty.Name = "rItemQty";
            this.rItemQty.ReadOnly = true;
            // 
            // rUnit
            // 
            this.rUnit.FillWeight = 10.52642F;
            resources.ApplyResources(this.rUnit, "rUnit");
            this.rUnit.Name = "rUnit";
            this.rUnit.ReadOnly = true;
            // 
            // lblRequestForm
            // 
            resources.ApplyResources(this.lblRequestForm, "lblRequestForm");
            this.lblRequestForm.Name = "lblRequestForm";
            // 
            // dtpPickUpDate
            // 
            resources.ApplyResources(this.dtpPickUpDate, "dtpPickUpDate");
            this.dtpPickUpDate.MinDate = new System.DateTime(2023, 5, 24, 0, 0, 0, 0);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            // 
            // lblstaffID
            // 
            resources.ApplyResources(this.lblstaffID, "lblstaffID");
            this.lblstaffID.Name = "lblstaffID";
            // 
            // lblStaffPosition
            // 
            resources.ApplyResources(this.lblStaffPosition, "lblStaffPosition");
            this.lblStaffPosition.Name = "lblStaffPosition";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblRequestItem
            // 
            resources.ApplyResources(this.lblRequestItem, "lblRequestItem");
            this.lblRequestItem.Name = "lblRequestItem";
            // 
            // lblRemark
            // 
            resources.ApplyResources(this.lblRemark, "lblRemark");
            this.lblRemark.Name = "lblRemark";
            // 
            // tbRemark
            // 
            resources.ApplyResources(this.tbRemark, "tbRemark");
            this.tbRemark.Name = "tbRemark";
            // 
            // tbRStaffID
            // 
            resources.ApplyResources(this.tbRStaffID, "tbRStaffID");
            this.tbRStaffID.Name = "tbRStaffID";
            this.tbRStaffID.ReadOnly = true;
            // 
            // lblRequestFormTitle
            // 
            resources.ApplyResources(this.lblRequestFormTitle, "lblRequestFormTitle");
            this.lblRequestFormTitle.Name = "lblRequestFormTitle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblRequestFormTitle);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // RequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbRStaffID);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.lblRequestItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStaffPosition);
            this.Controls.Add(this.lblstaffID);
            this.Controls.Add(this.dtpPickUpDate);
            this.Controls.Add(this.lblRequestForm);
            this.Controls.Add(this.dgvConfirmtList);
            this.Controls.Add(this.lblRAddress);
            this.Controls.Add(this.lblrType);
            this.Controls.Add(this.lblrContent);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.tbStaffPosition);
            this.Controls.Add(this.tbRContent);
            this.Controls.Add(this.tbRType);
            this.Controls.Add(this.tbRAdress);
            this.Controls.Add(this.tbRName);
            this.Controls.Add(this.btnSubmitRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmtList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.TextBox tbRName;
        private System.Windows.Forms.TextBox tbRAdress;
        private System.Windows.Forms.TextBox tbRType;
        private System.Windows.Forms.TextBox tbRContent;
        private System.Windows.Forms.TextBox tbStaffPosition;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblrContent;
        private System.Windows.Forms.Label lblrType;
        private System.Windows.Forms.Label lblRAddress;
        private System.Windows.Forms.DataGridView dgvConfirmtList;
        private System.Windows.Forms.Label lblRequestForm;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.Label lblstaffID;
        private System.Windows.Forms.Label lblStaffPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRequestItem;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbRStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUnit;
        private System.Windows.Forms.Label lblRequestFormTitle;
        private System.Windows.Forms.Panel panel1;
    }
}