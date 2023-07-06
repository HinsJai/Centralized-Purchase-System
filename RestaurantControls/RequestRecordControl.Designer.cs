
namespace UI.UserControls
{
    partial class RequestRecordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecordList = new System.Windows.Forms.DataGridView();
            this.cbRecordSearchType = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblRequestRecord = new System.Windows.Forms.Label();
            this.lblRequestRecordList = new System.Windows.Forms.Label();
            this.btnSearchRecord = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecordList
            // 
            this.dgvRecordList.AllowUserToAddRows = false;
            this.dgvRecordList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecordList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRecordList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecordList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecordList.ColumnHeadersHeight = 60;
            this.dgvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column14,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column10,
            this.Column13});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecordList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecordList.EnableHeadersVisualStyles = false;
            this.dgvRecordList.Location = new System.Drawing.Point(23, 139);
            this.dgvRecordList.Name = "dgvRecordList";
            this.dgvRecordList.ReadOnly = true;
            this.dgvRecordList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecordList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecordList.RowHeadersWidth = 4;
            this.dgvRecordList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecordList.RowTemplate.Height = 38;
            this.dgvRecordList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRecordList.Size = new System.Drawing.Size(1341, 702);
            this.dgvRecordList.TabIndex = 1;
            this.dgvRecordList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecordList_CellFormatting);
            this.dgvRecordList.DoubleClick += new System.EventHandler(this.dgvRecordList_DoubleClick);
            // 
            // cbRecordSearchType
            // 
            this.cbRecordSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecordSearchType.Font = new System.Drawing.Font("Arial Narrow", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecordSearchType.FormattingEnabled = true;
            this.cbRecordSearchType.Items.AddRange(new object[] {
            "Request ID",
            "Item ID",
            "Item Name",
            "Item Type",
            "Item Category",
            "Request Date Time",
            "Status"});
            this.cbRecordSearchType.Location = new System.Drawing.Point(1059, 93);
            this.cbRecordSearchType.Name = "cbRecordSearchType";
            this.cbRecordSearchType.Size = new System.Drawing.Size(203, 33);
            this.cbRecordSearchType.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial Narrow", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(832, 93);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(221, 32);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(19, 112);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(425, 24);
            this.lblReminder.TabIndex = 48;
            this.lblReminder.Text = "Double click the row to check or edit item";
            // 
            // lblRequestRecord
            // 
            this.lblRequestRecord.AutoSize = true;
            this.lblRequestRecord.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblRequestRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRequestRecord.Location = new System.Drawing.Point(551, 34);
            this.lblRequestRecord.Name = "lblRequestRecord";
            this.lblRequestRecord.Size = new System.Drawing.Size(260, 37);
            this.lblRequestRecord.TabIndex = 49;
            this.lblRequestRecord.Text = "Request Record";
            // 
            // lblRequestRecordList
            // 
            this.lblRequestRecordList.AutoSize = true;
            this.lblRequestRecordList.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestRecordList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRequestRecordList.Location = new System.Drawing.Point(18, 83);
            this.lblRequestRecordList.Name = "lblRequestRecordList";
            this.lblRequestRecordList.Size = new System.Drawing.Size(137, 29);
            this.lblRequestRecordList.TabIndex = 50;
            this.lblRequestRecordList.Text = "Record list";
            // 
            // btnSearchRecord
            // 
            this.btnSearchRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchRecord.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRecord.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRecord.Location = new System.Drawing.Point(1272, 92);
            this.btnSearchRecord.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchRecord.Name = "btnSearchRecord";
            this.btnSearchRecord.Size = new System.Drawing.Size(92, 38);
            this.btnSearchRecord.TabIndex = 26;
            this.btnSearchRecord.Text = "Search";
            this.btnSearchRecord.UseVisualStyleBackColor = false;
            this.btnSearchRecord.Click += new System.EventHandler(this.btnSearchRecord_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(738, 97);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 24);
            this.lblSearch.TabIndex = 59;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 55.14481F;
            this.Column1.HeaderText = "Request ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 55.14481F;
            this.Column2.HeaderText = "Item ID";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 91.908F;
            this.Column3.HeaderText = "Item Name";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 79.27961F;
            this.Column4.HeaderText = "Item Type";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 79.27961F;
            this.Column5.HeaderText = "Item Category";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.FillWeight = 69.36966F;
            this.Column14.HeaderText = "Brand";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 49.54976F;
            this.Column6.HeaderText = "Request Qty";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 55.14481F;
            this.Column7.HeaderText = "Unit";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 59.45971F;
            this.Column9.HeaderText = "Pick Up Data";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 91.908F;
            this.Column8.HeaderText = "Create Date";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 89.18957F;
            this.Column11.HeaderText = "Status";
            this.Column11.MinimumWidth = 10;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 0.1964488F;
            this.Column12.HeaderText = "sQTY";
            this.Column12.MinimumWidth = 2;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 1F;
            this.Column10.HeaderText = "Remark";
            this.Column10.MinimumWidth = 2;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column13
            // 
            this.Column13.FillWeight = 79.27961F;
            this.Column13.HeaderText = "Item Status";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // RequestRecordControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblRequestRecordList);
            this.Controls.Add(this.lblRequestRecord);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.btnSearchRecord);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbRecordSearchType);
            this.Controls.Add(this.dgvRecordList);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RequestRecordControl";
            this.Size = new System.Drawing.Size(1384, 861);
            this.Load += new System.EventHandler(this.RequestRecordControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRecordSearchType;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearchRecord;
        public System.Windows.Forms.DataGridView dgvRecordList;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblRequestRecord;
        private System.Windows.Forms.Label lblRequestRecordList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
