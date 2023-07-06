
namespace UI.UserControls
{
    partial class RequestManagementControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRequestManagement = new System.Windows.Forms.Label();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.lblItemList = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.dgvSelectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCategorty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.dgvRequestList = new System.Windows.Forms.DataGridView();
            this.reqSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblRequestList = new System.Windows.Forms.Label();
            this.btnRemoveAllItem = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequestManagement
            // 
            this.lblRequestManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRequestManagement.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRequestManagement.Location = new System.Drawing.Point(541, 33);
            this.lblRequestManagement.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRequestManagement.Name = "lblRequestManagement";
            this.lblRequestManagement.Size = new System.Drawing.Size(242, 31);
            this.lblRequestManagement.TabIndex = 17;
            this.lblRequestManagement.Text = "Request Management";
            this.lblRequestManagement.Click += new System.EventHandler(this.lblRequestManagement_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.Location = new System.Drawing.Point(1261, 71);
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(102, 44);
            this.btnSearchItem.TabIndex = 18;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = false;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(756, 83);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 24);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(850, 82);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(192, 26);
            this.tbSearch.TabIndex = 20;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "  Virtual Item ID",
            "  Item Name",
            "  Category"});
            this.cbSearchType.Location = new System.Drawing.Point(1062, 81);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(189, 26);
            this.cbSearchType.TabIndex = 21;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemList.Location = new System.Drawing.Point(28, 80);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(96, 24);
            this.lblItemList.TabIndex = 22;
            this.lblItemList.Text = "Item List";
            this.lblItemList.Click += new System.EventHandler(this.lblItemList_Click);
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.dgvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemList.ColumnHeadersHeight = 40;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSelectItem,
            this.lvID,
            this.lItemName,
            this.litemType,
            this.lCategorty,
            this.Column1,
            this.lItemQty,
            this.lUnit});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemList.EnableHeadersVisualStyles = false;
            this.dgvItemList.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItemList.Location = new System.Drawing.Point(32, 124);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowHeadersWidth = 82;
            this.dgvItemList.RowTemplate.Height = 24;
            this.dgvItemList.Size = new System.Drawing.Size(1331, 329);
            this.dgvItemList.TabIndex = 27;
            this.dgvItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellContentClick);
            this.dgvItemList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemList_CellMouseUp);
            this.dgvItemList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvItemList_CellPainting);
            // 
            // dgvSelectItem
            // 
            this.dgvSelectItem.DataPropertyName = "dgvSelectItem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSelectItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelectItem.FillWeight = 50F;
            this.dgvSelectItem.HeaderText = "Select";
            this.dgvSelectItem.MinimumWidth = 10;
            this.dgvSelectItem.Name = "dgvSelectItem";
            this.dgvSelectItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // litemType
            // 
            this.litemType.HeaderText = "Type";
            this.litemType.MinimumWidth = 10;
            this.litemType.Name = "litemType";
            this.litemType.ReadOnly = true;
            // 
            // lCategorty
            // 
            this.lCategorty.HeaderText = "Category";
            this.lCategorty.MinimumWidth = 10;
            this.lCategorty.Name = "lCategorty";
            this.lCategorty.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Brand";
            this.Column1.Name = "Column1";
            // 
            // lItemQty
            // 
            this.lItemQty.HeaderText = "Item Qty";
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
            // btnRemoveItem
            // 
            this.btnRemoveItem.AutoSize = true;
            this.btnRemoveItem.BackColor = System.Drawing.Color.MistyRose;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(32, 814);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(135, 41);
            this.btnRemoveItem.TabIndex = 28;
            this.btnRemoveItem.Text = "Delete";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.AllowUserToAddRows = false;
            this.dgvRequestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRequestList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRequestList.ColumnHeadersHeight = 40;
            this.dgvRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqSelect,
            this.rvID,
            this.rItemName,
            this.rItemType,
            this.rCategory,
            this.Column2,
            this.rItemQty,
            this.rUnit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequestList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRequestList.EnableHeadersVisualStyles = false;
            this.dgvRequestList.Location = new System.Drawing.Point(32, 512);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.RowHeadersVisible = false;
            this.dgvRequestList.RowHeadersWidth = 82;
            this.dgvRequestList.RowTemplate.Height = 40;
            this.dgvRequestList.Size = new System.Drawing.Size(1331, 293);
            this.dgvRequestList.TabIndex = 29;
            this.dgvRequestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestList_CellContentClick);
            this.dgvRequestList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRequestList_CellPainting);
            this.dgvRequestList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvRequestList_EditingControlShowing);
            // 
            // reqSelect
            // 
            this.reqSelect.FillWeight = 16.40625F;
            this.reqSelect.HeaderText = "Select";
            this.reqSelect.Name = "reqSelect";
            this.reqSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reqSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rvID
            // 
            this.rvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rvID.FillWeight = 20F;
            this.rvID.HeaderText = "Virtual Item ID";
            this.rvID.MinimumWidth = 10;
            this.rvID.Name = "rvID";
            this.rvID.ReadOnly = true;
            this.rvID.Width = 133;
            // 
            // rItemName
            // 
            this.rItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemName.FillWeight = 32.8125F;
            this.rItemName.HeaderText = "Item Name";
            this.rItemName.MinimumWidth = 10;
            this.rItemName.Name = "rItemName";
            this.rItemName.ReadOnly = true;
            // 
            // rItemType
            // 
            this.rItemType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemType.FillWeight = 32.8125F;
            this.rItemType.HeaderText = "Item type";
            this.rItemType.MinimumWidth = 10;
            this.rItemType.Name = "rItemType";
            this.rItemType.ReadOnly = true;
            // 
            // rCategory
            // 
            this.rCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rCategory.FillWeight = 32.8125F;
            this.rCategory.HeaderText = "Category";
            this.rCategory.MinimumWidth = 10;
            this.rCategory.Name = "rCategory";
            this.rCategory.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Brand";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // rItemQty
            // 
            this.rItemQty.FillWeight = 32.8125F;
            this.rItemQty.HeaderText = "Qty";
            this.rItemQty.MinimumWidth = 10;
            this.rItemQty.Name = "rItemQty";
            // 
            // rUnit
            // 
            this.rUnit.FillWeight = 32.8125F;
            this.rUnit.HeaderText = "Unit";
            this.rUnit.MinimumWidth = 10;
            this.rUnit.Name = "rUnit";
            this.rUnit.ReadOnly = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(1228, 462);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(135, 41);
            this.btnAddItem.TabIndex = 30;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblRequestList
            // 
            this.lblRequestList.AutoSize = true;
            this.lblRequestList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRequestList.Location = new System.Drawing.Point(28, 471);
            this.lblRequestList.Name = "lblRequestList";
            this.lblRequestList.Size = new System.Drawing.Size(125, 22);
            this.lblRequestList.TabIndex = 31;
            this.lblRequestList.Text = "Request List";
            // 
            // btnRemoveAllItem
            // 
            this.btnRemoveAllItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveAllItem.AutoSize = true;
            this.btnRemoveAllItem.BackColor = System.Drawing.Color.MistyRose;
            this.btnRemoveAllItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllItem.Location = new System.Drawing.Point(181, 814);
            this.btnRemoveAllItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemoveAllItem.Name = "btnRemoveAllItem";
            this.btnRemoveAllItem.Size = new System.Drawing.Size(135, 41);
            this.btnRemoveAllItem.TabIndex = 32;
            this.btnRemoveAllItem.Text = "Delete all";
            this.btnRemoveAllItem.UseVisualStyleBackColor = false;
            this.btnRemoveAllItem.Click += new System.EventHandler(this.btnRemoveAllItem_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(1228, 814);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 41);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // RequestManagementControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemoveAllItem);
            this.Controls.Add(this.lblRequestList);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvRequestList);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.lblItemList);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.lblRequestManagement);
            this.Name = "RequestManagementControl";
            this.Size = new System.Drawing.Size(1384, 861);
            this.Load += new System.EventHandler(this.RequestManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestManagement;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridView dgvRequestList;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblRequestList;
        private System.Windows.Forms.Button btnRemoveAllItem;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn litemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCategorty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reqSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn rvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUnit;
    }
}
