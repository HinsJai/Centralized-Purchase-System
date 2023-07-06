namespace UI
{
    partial class ItemManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navPannel = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvRequestList = new System.Windows.Forms.DataGridView();
            this.reqSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.dgvSelectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCategorty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRequestList = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.navCreatEditItem = new FontAwesome.Sharp.IconButton();
            this.navVirtualIDMapping = new FontAwesome.Sharp.IconButton();
            this.navSupplierManage = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lbluIDTitle = new System.Windows.Forms.Label();
            this.lblPosistionTitle = new System.Windows.Forms.Label();
            this.lblPosistion = new System.Windows.Forms.Label();
            this.navPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navPannel
            // 
            this.navPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPannel.Controls.Add(this.tableLayoutPanel2);
            this.navPannel.Controls.Add(this.btnLogout);
            this.navPannel.Controls.Add(this.iconPictureBox2);
            this.navPannel.Controls.Add(this.iconPictureBox1);
            this.navPannel.Controls.Add(this.lblUserID);
            this.navPannel.Controls.Add(this.lbluIDTitle);
            this.navPannel.Controls.Add(this.lblPosistionTitle);
            this.navPannel.Controls.Add(this.lblPosistion);
            this.navPannel.Controls.Add(this.pbLogo);
            this.navPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPannel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPannel.Location = new System.Drawing.Point(0, 0);
            this.navPannel.Name = "navPannel";
            this.navPannel.Size = new System.Drawing.Size(196, 861);
            this.navPannel.TabIndex = 18;
            this.navPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPannel_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(196, 158);
            this.pbLogo.TabIndex = 34;
            this.pbLogo.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mainPanel.Controls.Add(this.dgvRequestList);
            this.mainPanel.Controls.Add(this.dgvItemList);
            this.mainPanel.Controls.Add(this.lblRequestList);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.mainPanel.Location = new System.Drawing.Point(196, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1388, 861);
            this.mainPanel.TabIndex = 19;
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.AllowUserToAddRows = false;
            this.dgvRequestList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequestList.ColumnHeadersHeight = 40;
            this.dgvRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqSelect,
            this.rvID,
            this.rItemName,
            this.rItemType,
            this.rCategory,
            this.rItemQty,
            this.rUnit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequestList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequestList.EnableHeadersVisualStyles = false;
            this.dgvRequestList.Location = new System.Drawing.Point(1104, 1584);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.RowHeadersWidth = 82;
            this.dgvRequestList.RowTemplate.Height = 24;
            this.dgvRequestList.Size = new System.Drawing.Size(1856, 385);
            this.dgvRequestList.TabIndex = 3;
            // 
            // reqSelect
            // 
            this.reqSelect.FillWeight = 35F;
            this.reqSelect.HeaderText = "Select";
            this.reqSelect.MinimumWidth = 10;
            this.reqSelect.Name = "reqSelect";
            this.reqSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reqSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rvID
            // 
            this.rvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rvID.FillWeight = 71.17873F;
            this.rvID.HeaderText = "Virtual Item ID";
            this.rvID.MinimumWidth = 10;
            this.rvID.Name = "rvID";
            this.rvID.ReadOnly = true;
            // 
            // rItemName
            // 
            this.rItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemName.FillWeight = 71.17873F;
            this.rItemName.HeaderText = "Item Name";
            this.rItemName.MinimumWidth = 10;
            this.rItemName.Name = "rItemName";
            this.rItemName.ReadOnly = true;
            // 
            // rItemType
            // 
            this.rItemType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rItemType.FillWeight = 71.17873F;
            this.rItemType.HeaderText = "Item type";
            this.rItemType.MinimumWidth = 10;
            this.rItemType.Name = "rItemType";
            this.rItemType.ReadOnly = true;
            // 
            // rCategory
            // 
            this.rCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rCategory.FillWeight = 71.17873F;
            this.rCategory.HeaderText = "Category";
            this.rCategory.MinimumWidth = 10;
            this.rCategory.Name = "rCategory";
            this.rCategory.ReadOnly = true;
            // 
            // rItemQty
            // 
            this.rItemQty.FillWeight = 71.17873F;
            this.rItemQty.HeaderText = "Qty";
            this.rItemQty.MinimumWidth = 10;
            this.rItemQty.Name = "rItemQty";
            // 
            // rUnit
            // 
            this.rUnit.FillWeight = 71.17873F;
            this.rUnit.HeaderText = "Unit";
            this.rUnit.MinimumWidth = 10;
            this.rUnit.Name = "rUnit";
            this.rUnit.ReadOnly = true;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemList.ColumnHeadersHeight = 40;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSelectItem,
            this.lvID,
            this.lItemName,
            this.litemType,
            this.lCategorty,
            this.lItemQty,
            this.lUnit});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemList.EnableHeadersVisualStyles = false;
            this.dgvItemList.Location = new System.Drawing.Point(1048, 1240);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersWidth = 82;
            this.dgvItemList.RowTemplate.Height = 24;
            this.dgvItemList.Size = new System.Drawing.Size(1573, 38);
            this.dgvItemList.TabIndex = 4;
            // 
            // dgvSelectItem
            // 
            this.dgvSelectItem.DataPropertyName = "dgvSelectItem";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSelectItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelectItem.FillWeight = 40F;
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
            // lblRequestList
            // 
            this.lblRequestList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRequestList.AutoSize = true;
            this.lblRequestList.Location = new System.Drawing.Point(596, 1282);
            this.lblRequestList.Name = "lblRequestList";
            this.lblRequestList.Size = new System.Drawing.Size(62, 12);
            this.lblRequestList.TabIndex = 10;
            this.lblRequestList.Text = "Request List";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.navSupplierManage, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.navCreatEditItem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.navVirtualIDMapping, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 179);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 191);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // navCreatEditItem
            // 
            this.navCreatEditItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navCreatEditItem.FlatAppearance.BorderSize = 0;
            this.navCreatEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCreatEditItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCreatEditItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navCreatEditItem.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.navCreatEditItem.IconColor = System.Drawing.Color.White;
            this.navCreatEditItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navCreatEditItem.IconSize = 24;
            this.navCreatEditItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navCreatEditItem.Location = new System.Drawing.Point(3, 3);
            this.navCreatEditItem.Name = "navCreatEditItem";
            this.navCreatEditItem.Size = new System.Drawing.Size(188, 57);
            this.navCreatEditItem.TabIndex = 78;
            this.navCreatEditItem.Text = "Mange Item";
            this.navCreatEditItem.UseVisualStyleBackColor = false;
            this.navCreatEditItem.Click += new System.EventHandler(this.navCreatEditItem_Click);
            // 
            // navVirtualIDMapping
            // 
            this.navVirtualIDMapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navVirtualIDMapping.FlatAppearance.BorderSize = 0;
            this.navVirtualIDMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navVirtualIDMapping.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navVirtualIDMapping.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navVirtualIDMapping.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.navVirtualIDMapping.IconColor = System.Drawing.Color.White;
            this.navVirtualIDMapping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navVirtualIDMapping.IconSize = 24;
            this.navVirtualIDMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navVirtualIDMapping.Location = new System.Drawing.Point(3, 66);
            this.navVirtualIDMapping.Name = "navVirtualIDMapping";
            this.navVirtualIDMapping.Size = new System.Drawing.Size(188, 57);
            this.navVirtualIDMapping.TabIndex = 79;
            this.navVirtualIDMapping.Text = "Mapping";
            this.navVirtualIDMapping.UseVisualStyleBackColor = false;
            this.navVirtualIDMapping.Click += new System.EventHandler(this.navVirtualIDMapping_Click);
            // 
            // navSupplierManage
            // 
            this.navSupplierManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navSupplierManage.FlatAppearance.BorderSize = 0;
            this.navSupplierManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSupplierManage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSupplierManage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navSupplierManage.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.navSupplierManage.IconColor = System.Drawing.Color.White;
            this.navSupplierManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navSupplierManage.IconSize = 20;
            this.navSupplierManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSupplierManage.Location = new System.Drawing.Point(3, 129);
            this.navSupplierManage.Name = "navSupplierManage";
            this.navSupplierManage.Size = new System.Drawing.Size(189, 59);
            this.navSupplierManage.TabIndex = 80;
            this.navSupplierManage.Text = "Supplier Management";
            this.navSupplierManage.UseVisualStyleBackColor = false;
            this.navSupplierManage.Click += new System.EventHandler(this.navSupplierManage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(0, 798);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 61);
            this.btnLogout.TabIndex = 79;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 58;
            this.iconPictureBox2.Location = new System.Drawing.Point(65, 642);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(58, 59);
            this.iconPictureBox2.TabIndex = 78;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(65, 517);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(58, 59);
            this.iconPictureBox1.TabIndex = 77;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserID.Location = new System.Drawing.Point(53, 603);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(81, 26);
            this.lblUserID.TabIndex = 76;
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluIDTitle
            // 
            this.lbluIDTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluIDTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbluIDTitle.Location = new System.Drawing.Point(53, 579);
            this.lbluIDTitle.Name = "lbluIDTitle";
            this.lbluIDTitle.Size = new System.Drawing.Size(81, 24);
            this.lbluIDTitle.TabIndex = 74;
            this.lbluIDTitle.Text = "User ID";
            this.lbluIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosistionTitle
            // 
            this.lblPosistionTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosistionTitle.Location = new System.Drawing.Point(39, 704);
            this.lblPosistionTitle.Name = "lblPosistionTitle";
            this.lblPosistionTitle.Size = new System.Drawing.Size(102, 25);
            this.lblPosistionTitle.TabIndex = 75;
            this.lblPosistionTitle.Text = "Position";
            this.lblPosistionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosistion
            // 
            this.lblPosistion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosistion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPosistion.Location = new System.Drawing.Point(9, 735);
            this.lblPosistion.Name = "lblPosistion";
            this.lblPosistion.Size = new System.Drawing.Size(180, 26);
            this.lblPosistion.TabIndex = 73;
            this.lblPosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPannel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ItemManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemManagement_FormClosed);
            this.Load += new System.EventHandler(this.ItemManagement_Load);
            this.navPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPannel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dgvRequestList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reqSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn rvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUnit;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn litemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCategorty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUnit;
        private System.Windows.Forms.Label lblRequestList;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton navSupplierManage;
        private FontAwesome.Sharp.IconButton navCreatEditItem;
        private FontAwesome.Sharp.IconButton navVirtualIDMapping;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lbluIDTitle;
        private System.Windows.Forms.Label lblPosistionTitle;
        private System.Windows.Forms.Label lblPosistion;
    }
}