namespace UI.ItemControls
{
    partial class VirtualIDMappingControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMappingNewItem = new System.Windows.Forms.Button();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblItemList = new System.Windows.Forms.Label();
            this.cbSearchMappedType = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblMappingItem = new System.Windows.Forms.Label();
            this.dgvMappingList = new System.Windows.Forms.DataGridView();
            this.brnCreateVID = new System.Windows.Forms.Button();
            this.cmSearhMappingNewItemType = new System.Windows.Forms.ComboBox();
            this.btnCreateVID = new System.Windows.Forms.Button();
            this.btnSearchMappedItem = new System.Windows.Forms.Button();
            this.btnSearchMappingNewItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappingList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMappingNewItem
            // 
            this.btnMappingNewItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMappingNewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMappingNewItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMappingNewItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMappingNewItem.Location = new System.Drawing.Point(1158, 814);
            this.btnMappingNewItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMappingNewItem.Name = "btnMappingNewItem";
            this.btnMappingNewItem.Size = new System.Drawing.Size(208, 41);
            this.btnMappingNewItem.TabIndex = 48;
            this.btnMappingNewItem.Text = "Mapping New Item";
            this.btnMappingNewItem.UseVisualStyleBackColor = false;
            this.btnMappingNewItem.Click += new System.EventHandler(this.btnMappingNewItem_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(23, 92);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(425, 24);
            this.lblReminder.TabIndex = 47;
            this.lblReminder.Text = "Double click the row to check or edit item";
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblItemList.Location = new System.Drawing.Point(22, 63);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(112, 29);
            this.lblItemList.TabIndex = 46;
            this.lblItemList.Text = "Item List";
            // 
            // cbSearchMappedType
            // 
            this.cbSearchMappedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchMappedType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchMappedType.FormattingEnabled = true;
            this.cbSearchMappedType.Items.AddRange(new object[] {
            "Virtual Item ID",
            "Virtual Item Name",
            "Actual  item ID",
            "Item Name"});
            this.cbSearchMappedType.Location = new System.Drawing.Point(1068, 81);
            this.cbSearchMappedType.Name = "cbSearchMappedType";
            this.cbSearchMappedType.Size = new System.Drawing.Size(173, 30);
            this.cbSearchMappedType.TabIndex = 45;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(853, 82);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(191, 29);
            this.tbSearch.TabIndex = 44;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(759, 84);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 24);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMappingItem
            // 
            this.lblMappingItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMappingItem.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblMappingItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMappingItem.Location = new System.Drawing.Point(467, 20);
            this.lblMappingItem.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMappingItem.Name = "lblMappingItem";
            this.lblMappingItem.Size = new System.Drawing.Size(333, 46);
            this.lblMappingItem.TabIndex = 41;
            this.lblMappingItem.Text = "Mapped Item";
            this.lblMappingItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMappingList
            // 
            this.dgvMappingList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMappingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMappingList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMappingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMappingList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMappingList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMappingList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMappingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMappingList.ColumnHeadersHeight = 50;
            this.dgvMappingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMappingList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMappingList.EnableHeadersVisualStyles = false;
            this.dgvMappingList.Location = new System.Drawing.Point(26, 128);
            this.dgvMappingList.Name = "dgvMappingList";
            this.dgvMappingList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMappingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMappingList.RowHeadersVisible = false;
            this.dgvMappingList.RowHeadersWidth = 5;
            this.dgvMappingList.RowTemplate.Height = 24;
            this.dgvMappingList.Size = new System.Drawing.Size(1357, 672);
            this.dgvMappingList.TabIndex = 50;
            this.dgvMappingList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMappingList_CellPainting);
            this.dgvMappingList.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvMappingList_ColumnAdded);
            this.dgvMappingList.DoubleClick += new System.EventHandler(this.dgvMappingList_DoubleClick);
            // 
            // brnCreateVID
            // 
            this.brnCreateVID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.brnCreateVID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnCreateVID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCreateVID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.brnCreateVID.Location = new System.Drawing.Point(936, 814);
            this.brnCreateVID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.brnCreateVID.Name = "brnCreateVID";
            this.brnCreateVID.Size = new System.Drawing.Size(208, 41);
            this.brnCreateVID.TabIndex = 51;
            this.brnCreateVID.Text = "Mapped Item";
            this.brnCreateVID.UseVisualStyleBackColor = false;
            this.brnCreateVID.Click += new System.EventHandler(this.btnMappedItem_Click);
            // 
            // cmSearhMappingNewItemType
            // 
            this.cmSearhMappingNewItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSearhMappingNewItemType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmSearhMappingNewItemType.FormattingEnabled = true;
            this.cmSearhMappingNewItemType.Items.AddRange(new object[] {
            "Actual  item ID",
            "Item Name"});
            this.cmSearhMappingNewItemType.Location = new System.Drawing.Point(1068, 81);
            this.cmSearhMappingNewItemType.Name = "cmSearhMappingNewItemType";
            this.cmSearhMappingNewItemType.Size = new System.Drawing.Size(173, 30);
            this.cmSearhMappingNewItemType.TabIndex = 53;
            this.cmSearhMappingNewItemType.Visible = false;
            // 
            // btnCreateVID
            // 
            this.btnCreateVID.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCreateVID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateVID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreateVID.Location = new System.Drawing.Point(27, 814);
            this.btnCreateVID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCreateVID.Name = "btnCreateVID";
            this.btnCreateVID.Size = new System.Drawing.Size(208, 41);
            this.btnCreateVID.TabIndex = 54;
            this.btnCreateVID.Text = "Create  VID";
            this.btnCreateVID.UseVisualStyleBackColor = false;
            this.btnCreateVID.Click += new System.EventHandler(this.btnCreateVID_Click);
            // 
            // btnSearchMappedItem
            // 
            this.btnSearchMappedItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchMappedItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMappedItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMappedItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSearchMappedItem.Location = new System.Drawing.Point(1264, 73);
            this.btnSearchMappedItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchMappedItem.Name = "btnSearchMappedItem";
            this.btnSearchMappedItem.Size = new System.Drawing.Size(102, 44);
            this.btnSearchMappedItem.TabIndex = 42;
            this.btnSearchMappedItem.Text = "Search";
            this.btnSearchMappedItem.UseVisualStyleBackColor = false;
            this.btnSearchMappedItem.Click += new System.EventHandler(this.btnSearchMappedItem_Click);
            // 
            // btnSearchMappingNewItem
            // 
            this.btnSearchMappingNewItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchMappingNewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMappingNewItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMappingNewItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSearchMappingNewItem.Location = new System.Drawing.Point(1264, 72);
            this.btnSearchMappingNewItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchMappingNewItem.Name = "btnSearchMappingNewItem";
            this.btnSearchMappingNewItem.Size = new System.Drawing.Size(102, 44);
            this.btnSearchMappingNewItem.TabIndex = 52;
            this.btnSearchMappingNewItem.Text = "Search";
            this.btnSearchMappingNewItem.UseVisualStyleBackColor = false;
            this.btnSearchMappingNewItem.Click += new System.EventHandler(this.btnSearchMappingNewItem_Click);
            // 
            // VirtualIDMappingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnCreateVID);
            this.Controls.Add(this.cmSearhMappingNewItemType);
            this.Controls.Add(this.btnSearchMappingNewItem);
            this.Controls.Add(this.brnCreateVID);
            this.Controls.Add(this.dgvMappingList);
            this.Controls.Add(this.btnMappingNewItem);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblItemList);
            this.Controls.Add(this.cbSearchMappedType);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearchMappedItem);
            this.Controls.Add(this.lblMappingItem);
            this.Name = "VirtualIDMappingControl";
            this.Size = new System.Drawing.Size(1388, 861);
            this.Load += new System.EventHandler(this.VirtualIDMappingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMappingNewItem;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.ComboBox cbSearchMappedType;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblMappingItem;
        private System.Windows.Forms.DataGridView dgvMappingList;
        private System.Windows.Forms.Button brnCreateVID;
        private System.Windows.Forms.ComboBox cmSearhMappingNewItemType;
        private System.Windows.Forms.Button btnCreateVID;
        private System.Windows.Forms.Button btnSearchMappedItem;
        private System.Windows.Forms.Button btnSearchMappingNewItem;
    }
}
