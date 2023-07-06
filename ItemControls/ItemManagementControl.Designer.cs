namespace UI.ItemControls
{
    partial class ItemManagementControl
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
            this.dgvMangeItemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemList = new System.Windows.Forms.Label();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRequestManagement = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCheckNewItem = new System.Windows.Forms.Button();
            this.btnSearchItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangeItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMangeItemList
            // 
            this.dgvMangeItemList.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.dgvMangeItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMangeItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMangeItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMangeItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMangeItemList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMangeItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMangeItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMangeItemList.ColumnHeadersHeight = 50;
            this.dgvMangeItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMangeItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.lvID,
            this.lItemName,
            this.Column2,
            this.litemType,
            this.lItemQty,
            this.lUnit,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMangeItemList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMangeItemList.EnableHeadersVisualStyles = false;
            this.dgvMangeItemList.Location = new System.Drawing.Point(26, 148);
            this.dgvMangeItemList.Name = "dgvMangeItemList";
            this.dgvMangeItemList.RowHeadersVisible = false;
            this.dgvMangeItemList.RowHeadersWidth = 5;
            this.dgvMangeItemList.RowTemplate.Height = 24;
            this.dgvMangeItemList.Size = new System.Drawing.Size(1343, 652);
            this.dgvMangeItemList.TabIndex = 37;
            this.dgvMangeItemList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMangeItemList_CellPainting);
            this.dgvMangeItemList.DoubleClick += new System.EventHandler(this.dgvMangeItemList_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Actual Item ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lvID
            // 
            this.lvID.HeaderText = "Virtual item ID";
            this.lvID.MinimumWidth = 10;
            this.lvID.Name = "lvID";
            this.lvID.ReadOnly = true;
            // 
            // lItemName
            // 
            this.lItemName.HeaderText = "Item name";
            this.lItemName.MinimumWidth = 10;
            this.lItemName.Name = "lItemName";
            this.lItemName.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TypeID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // litemType
            // 
            this.litemType.HeaderText = "Type";
            this.litemType.MinimumWidth = 10;
            this.litemType.Name = "litemType";
            this.litemType.ReadOnly = true;
            // 
            // lItemQty
            // 
            this.lItemQty.HeaderText = "Stock Qty";
            this.lItemQty.MinimumWidth = 10;
            this.lItemQty.Name = "lItemQty";
            this.lItemQty.ReadOnly = true;
            // 
            // lUnit
            // 
            this.lUnit.HeaderText = "Unit";
            this.lUnit.MinimumWidth = 10;
            this.lUnit.Name = "lUnit";
            this.lUnit.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Remark";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblItemList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblItemList.Location = new System.Drawing.Point(21, 77);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(112, 29);
            this.lblItemList.TabIndex = 36;
            this.lblItemList.Text = "Item List";
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Actual  item ID",
            "Virtual Item ID",
            "Item Name",
            "TypeID",
            "Type Name"});
            this.cbSearchType.Location = new System.Drawing.Point(1071, 103);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(173, 30);
            this.cbSearchType.TabIndex = 35;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(856, 104);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(193, 29);
            this.tbSearch.TabIndex = 34;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(762, 106);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 24);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRequestManagement
            // 
            this.lblRequestManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRequestManagement.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblRequestManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRequestManagement.Location = new System.Drawing.Point(579, 33);
            this.lblRequestManagement.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRequestManagement.Name = "lblRequestManagement";
            this.lblRequestManagement.Size = new System.Drawing.Size(201, 45);
            this.lblRequestManagement.TabIndex = 31;
            this.lblRequestManagement.Text = "Manage Item";
            this.lblRequestManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(22, 106);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(425, 24);
            this.lblReminder.TabIndex = 38;
            this.lblReminder.Text = "Double click the row to check or edit item";
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreateItem.Location = new System.Drawing.Point(26, 809);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(135, 41);
            this.btnCreateItem.TabIndex = 39;
            this.btnCreateItem.Text = "Create Item";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnCheckNewItem
            // 
            this.btnCheckNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheckNewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckNewItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckNewItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCheckNewItem.Location = new System.Drawing.Point(1199, 809);
            this.btnCheckNewItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCheckNewItem.Name = "btnCheckNewItem";
            this.btnCheckNewItem.Size = new System.Drawing.Size(170, 41);
            this.btnCheckNewItem.TabIndex = 40;
            this.btnCheckNewItem.Text = "Check New Item ";
            this.btnCheckNewItem.UseVisualStyleBackColor = false;
            this.btnCheckNewItem.Click += new System.EventHandler(this.btnCheckNewItem_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSearchItem.Location = new System.Drawing.Point(1267, 95);
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(102, 44);
            this.btnSearchItem.TabIndex = 32;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = false;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // ItemManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnCheckNewItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.dgvMangeItemList);
            this.Controls.Add(this.lblItemList);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.lblRequestManagement);
            this.Name = "ItemManagementControl";
            this.Size = new System.Drawing.Size(1388, 861);
            this.Load += new System.EventHandler(this.itemManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangeItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMangeItemList;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRequestManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn litemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCheckNewItem;
        private System.Windows.Forms.Button btnSearchItem;
    }
}
