
namespace UI
{
    partial class formRequestManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.navPannel = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.centralized_procurement_systemDataSet = new UI.centralized_procurement_systemDataSet();
            this.centralizedprocurementsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter1 = new UI.centralized_procurement_systemDataSetTableAdapters.departmentTableAdapter();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lbluIDTitle = new System.Windows.Forms.Label();
            this.lblPosistionTitle = new System.Windows.Forms.Label();
            this.lblPosistion = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.navDashboard = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.navSearchRequest = new FontAwesome.Sharp.IconButton();
            this.navRequestRecord = new FontAwesome.Sharp.IconButton();
            this.navRestaurantStock = new FontAwesome.Sharp.IconButton();
            this.navResDNote = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.navPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centralized_procurement_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralizedprocurementsystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequestList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequestList.EnableHeadersVisualStyles = false;
            this.dgvRequestList.Location = new System.Drawing.Point(1104, 1601);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.RowHeadersWidth = 82;
            this.dgvRequestList.RowTemplate.Height = 24;
            this.dgvRequestList.Size = new System.Drawing.Size(2578, 385);
            this.dgvRequestList.TabIndex = 3;
            this.dgvRequestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestList_CellContentClick);
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
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.dgvItemList.Size = new System.Drawing.Size(2295, 55);
            this.dgvItemList.TabIndex = 4;
            this.dgvItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellContentClick);
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
            this.lblRequestList.Location = new System.Drawing.Point(596, 1299);
            this.lblRequestList.Name = "lblRequestList";
            this.lblRequestList.Size = new System.Drawing.Size(62, 12);
            this.lblRequestList.TabIndex = 10;
            this.lblRequestList.Text = "Request List";
            this.lblRequestList.Click += new System.EventHandler(this.lblRequestList_Click);
            // 
            // navPannel
            // 
            this.navPannel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navPannel.Controls.Add(this.tableLayoutPanel3);
            this.navPannel.Controls.Add(this.btnLogout);
            this.navPannel.Controls.Add(this.iconPictureBox2);
            this.navPannel.Controls.Add(this.iconPictureBox1);
            this.navPannel.Controls.Add(this.lblUserID);
            this.navPannel.Controls.Add(this.lbluIDTitle);
            this.navPannel.Controls.Add(this.lblPosistionTitle);
            this.navPannel.Controls.Add(this.lblPosistion);
            this.navPannel.Controls.Add(this.pbLogo);
            this.navPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPannel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navPannel.Location = new System.Drawing.Point(0, 0);
            this.navPannel.Name = "navPannel";
            this.navPannel.Size = new System.Drawing.Size(200, 861);
            this.navPannel.TabIndex = 17;
            this.navPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPannel_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::UI.Properties.Resources.company_logo200;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(198, 158);
            this.pbLogo.TabIndex = 35;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mainPanel.Controls.Add(this.dgvRequestList);
            this.mainPanel.Controls.Add(this.dgvItemList);
            this.mainPanel.Controls.Add(this.lblRequestList);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1384, 861);
            this.mainPanel.TabIndex = 18;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // centralized_procurement_systemDataSet
            // 
            this.centralized_procurement_systemDataSet.DataSetName = "centralized_procurement_systemDataSet";
            this.centralized_procurement_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // centralizedprocurementsystemDataSetBindingSource
            // 
            this.centralizedprocurementsystemDataSetBindingSource.DataSource = this.centralized_procurement_systemDataSet;
            this.centralizedprocurementsystemDataSetBindingSource.Position = 0;
            this.centralizedprocurementsystemDataSetBindingSource.CurrentChanged += new System.EventHandler(this.centralizedprocurementsystemDataSetBindingSource_CurrentChanged);
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 58;
            this.iconPictureBox2.Location = new System.Drawing.Point(65, 668);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(58, 59);
            this.iconPictureBox2.TabIndex = 71;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(65, 543);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(58, 59);
            this.iconPictureBox1.TabIndex = 70;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserID.Location = new System.Drawing.Point(53, 629);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(81, 26);
            this.lblUserID.TabIndex = 69;
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluIDTitle
            // 
            this.lbluIDTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluIDTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbluIDTitle.Location = new System.Drawing.Point(53, 605);
            this.lbluIDTitle.Name = "lbluIDTitle";
            this.lbluIDTitle.Size = new System.Drawing.Size(81, 24);
            this.lbluIDTitle.TabIndex = 67;
            this.lbluIDTitle.Text = "User ID";
            this.lbluIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosistionTitle
            // 
            this.lblPosistionTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosistionTitle.Location = new System.Drawing.Point(39, 730);
            this.lblPosistionTitle.Name = "lblPosistionTitle";
            this.lblPosistionTitle.Size = new System.Drawing.Size(102, 25);
            this.lblPosistionTitle.TabIndex = 68;
            this.lblPosistionTitle.Text = "Position";
            this.lblPosistionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosistion
            // 
            this.lblPosistion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosistion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPosistion.Location = new System.Drawing.Point(9, 761);
            this.lblPosistion.Name = "lblPosistion";
            this.lblPosistion.Size = new System.Drawing.Size(180, 26);
            this.lblPosistion.TabIndex = 66;
            this.lblPosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnLogout.Location = new System.Drawing.Point(0, 800);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 61);
            this.btnLogout.TabIndex = 72;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // navDashboard
            // 
            this.navDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navDashboard.FlatAppearance.BorderSize = 0;
            this.navDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.navDashboard.IconColor = System.Drawing.Color.White;
            this.navDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navDashboard.IconSize = 24;
            this.navDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDashboard.Location = new System.Drawing.Point(3, 3);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Size = new System.Drawing.Size(194, 37);
            this.navDashboard.TabIndex = 73;
            this.navDashboard.Text = "Dashboard";
            this.navDashboard.UseVisualStyleBackColor = false;
            this.navDashboard.Click += new System.EventHandler(this.navDashboard_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.navResDNote, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.navRestaurantStock, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.navRequestRecord, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.navSearchRequest, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.navDashboard, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 181);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 217);
            this.tableLayoutPanel3.TabIndex = 74;
            // 
            // navSearchRequest
            // 
            this.navSearchRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navSearchRequest.FlatAppearance.BorderSize = 0;
            this.navSearchRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSearchRequest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSearchRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navSearchRequest.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.navSearchRequest.IconColor = System.Drawing.Color.White;
            this.navSearchRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navSearchRequest.IconSize = 24;
            this.navSearchRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSearchRequest.Location = new System.Drawing.Point(3, 46);
            this.navSearchRequest.Name = "navSearchRequest";
            this.navSearchRequest.Size = new System.Drawing.Size(192, 37);
            this.navSearchRequest.TabIndex = 74;
            this.navSearchRequest.Text = "Request Item";
            this.navSearchRequest.UseVisualStyleBackColor = false;
            this.navSearchRequest.Click += new System.EventHandler(this.navSearchRequest_Click);
            // 
            // navRequestRecord
            // 
            this.navRequestRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navRequestRecord.FlatAppearance.BorderSize = 0;
            this.navRequestRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navRequestRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navRequestRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navRequestRecord.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.navRequestRecord.IconColor = System.Drawing.Color.White;
            this.navRequestRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navRequestRecord.IconSize = 24;
            this.navRequestRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navRequestRecord.Location = new System.Drawing.Point(3, 89);
            this.navRequestRecord.Name = "navRequestRecord";
            this.navRequestRecord.Size = new System.Drawing.Size(192, 37);
            this.navRequestRecord.TabIndex = 75;
            this.navRequestRecord.Text = "Request Record";
            this.navRequestRecord.UseVisualStyleBackColor = false;
            this.navRequestRecord.Click += new System.EventHandler(this.navRequestRecord_Click);
            // 
            // navRestaurantStock
            // 
            this.navRestaurantStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navRestaurantStock.FlatAppearance.BorderSize = 0;
            this.navRestaurantStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navRestaurantStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navRestaurantStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navRestaurantStock.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.navRestaurantStock.IconColor = System.Drawing.Color.White;
            this.navRestaurantStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navRestaurantStock.IconSize = 24;
            this.navRestaurantStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navRestaurantStock.Location = new System.Drawing.Point(3, 132);
            this.navRestaurantStock.Name = "navRestaurantStock";
            this.navRestaurantStock.Size = new System.Drawing.Size(192, 37);
            this.navRestaurantStock.TabIndex = 76;
            this.navRestaurantStock.Text = "Restaurant Stock";
            this.navRestaurantStock.UseVisualStyleBackColor = false;
            this.navRestaurantStock.Click += new System.EventHandler(this.navRequestStock_Click);
            // 
            // navResDNote
            // 
            this.navResDNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navResDNote.FlatAppearance.BorderSize = 0;
            this.navResDNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navResDNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navResDNote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navResDNote.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.navResDNote.IconColor = System.Drawing.Color.White;
            this.navResDNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navResDNote.IconSize = 24;
            this.navResDNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navResDNote.Location = new System.Drawing.Point(3, 175);
            this.navResDNote.Name = "navResDNote";
            this.navResDNote.Size = new System.Drawing.Size(192, 37);
            this.navResDNote.TabIndex = 77;
            this.navResDNote.Text = "Delivery Note";
            this.navResDNote.UseVisualStyleBackColor = false;
            this.navResDNote.Click += new System.EventHandler(this.navResDNote_Click);
            // 
            // formRequestManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPannel);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "formRequestManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formRequestManagement_FormClosed);
            this.Load += new System.EventHandler(this.formRequestManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.navPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centralized_procurement_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralizedprocurementsystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRequestList;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label lblRequestList;
        private System.Windows.Forms.BindingSource centralizedprocurementsystemDataSetBindingSource;
        private centralized_procurement_systemDataSet centralized_procurement_systemDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn litemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCategorty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reqSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn rvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUnit;
        private System.Windows.Forms.Panel navPannel;
        private System.Windows.Forms.Panel mainPanel;
        private centralized_procurement_systemDataSetTableAdapters.departmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lbluIDTitle;
        private System.Windows.Forms.Label lblPosistionTitle;
        private System.Windows.Forms.Label lblPosistion;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton navDashboard;
        private FontAwesome.Sharp.IconButton navResDNote;
        private FontAwesome.Sharp.IconButton navRestaurantStock;
        private FontAwesome.Sharp.IconButton navRequestRecord;
        private FontAwesome.Sharp.IconButton navSearchRequest;
    }
}