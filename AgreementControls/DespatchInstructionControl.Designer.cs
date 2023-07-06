namespace UI.AgreementControls
{
    partial class DespatchInstructionControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDespatchInstructionList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDespatchInstruction = new System.Windows.Forms.Label();
            this.btnRemoveAllItem = new System.Windows.Forms.Button();
            this.lblCreateList = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.dgvDespatchInstruction = new System.Windows.Forms.DataGridView();
            this.dgvSelectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCategorty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDespatchConfirmList = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchInstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchConfirmList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDespatchInstructionList
            // 
            this.lblDespatchInstructionList.AutoSize = true;
            this.lblDespatchInstructionList.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblDespatchInstructionList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDespatchInstructionList.Location = new System.Drawing.Point(12, 67);
            this.lblDespatchInstructionList.Name = "lblDespatchInstructionList";
            this.lblDespatchInstructionList.Size = new System.Drawing.Size(140, 26);
            this.lblDespatchInstructionList.TabIndex = 59;
            this.lblDespatchInstructionList.Text = "Request List";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(1268, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 41);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Request ID",
            "Item ID",
            "Item Name",
            "Item Status"});
            this.cbSearchType.Location = new System.Drawing.Point(1089, 65);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(173, 30);
            this.cbSearchType.TabIndex = 57;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSearch.Location = new System.Drawing.Point(861, 65);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(222, 29);
            this.tbSearch.TabIndex = 56;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(764, 66);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 26);
            this.lblSearch.TabIndex = 55;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDespatchInstruction
            // 
            this.lblDespatchInstruction.AutoSize = true;
            this.lblDespatchInstruction.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblDespatchInstruction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDespatchInstruction.Location = new System.Drawing.Point(575, 20);
            this.lblDespatchInstruction.Name = "lblDespatchInstruction";
            this.lblDespatchInstruction.Size = new System.Drawing.Size(280, 37);
            this.lblDespatchInstruction.TabIndex = 53;
            this.lblDespatchInstruction.Text = "Despatch Instruction";
            // 
            // btnRemoveAllItem
            // 
            this.btnRemoveAllItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveAllItem.AutoSize = true;
            this.btnRemoveAllItem.BackColor = System.Drawing.Color.MistyRose;
            this.btnRemoveAllItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllItem.Location = new System.Drawing.Point(166, 815);
            this.btnRemoveAllItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemoveAllItem.Name = "btnRemoveAllItem";
            this.btnRemoveAllItem.Size = new System.Drawing.Size(135, 41);
            this.btnRemoveAllItem.TabIndex = 65;
            this.btnRemoveAllItem.Text = "Delete all";
            this.btnRemoveAllItem.UseVisualStyleBackColor = false;
            this.btnRemoveAllItem.Click += new System.EventHandler(this.btnRemoveAllItem_Click);
            // 
            // lblCreateList
            // 
            this.lblCreateList.AutoSize = true;
            this.lblCreateList.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblCreateList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateList.Location = new System.Drawing.Point(12, 444);
            this.lblCreateList.Name = "lblCreateList";
            this.lblCreateList.Size = new System.Drawing.Size(122, 26);
            this.lblCreateList.TabIndex = 64;
            this.lblCreateList.Text = "Create List";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(1225, 436);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(135, 41);
            this.btnAddItem.TabIndex = 63;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.AutoSize = true;
            this.btnRemoveItem.BackColor = System.Drawing.Color.MistyRose;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(17, 815);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(135, 41);
            this.btnRemoveItem.TabIndex = 61;
            this.btnRemoveItem.Text = "Delete";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // dgvDespatchInstruction
            // 
            this.dgvDespatchInstruction.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.dgvDespatchInstruction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDespatchInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespatchInstruction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespatchInstruction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDespatchInstruction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDespatchInstruction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespatchInstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDespatchInstruction.ColumnHeadersHeight = 40;
            this.dgvDespatchInstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDespatchInstruction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSelectItem,
            this.lvID,
            this.lItemName,
            this.litemType,
            this.lCategorty,
            this.Column1,
            this.lItemQty});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDespatchInstruction.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDespatchInstruction.EnableHeadersVisualStyles = false;
            this.dgvDespatchInstruction.Location = new System.Drawing.Point(17, 107);
            this.dgvDespatchInstruction.Name = "dgvDespatchInstruction";
            this.dgvDespatchInstruction.RowHeadersVisible = false;
            this.dgvDespatchInstruction.RowHeadersWidth = 82;
            this.dgvDespatchInstruction.RowTemplate.Height = 24;
            this.dgvDespatchInstruction.Size = new System.Drawing.Size(1343, 320);
            this.dgvDespatchInstruction.TabIndex = 66;
            this.dgvDespatchInstruction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespatchInstruction_CellContentClick);
            this.dgvDespatchInstruction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDespatchInstruction_CellFormatting);
            this.dgvDespatchInstruction.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDespatchInstruction_CellPainting);
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
            this.lvID.HeaderText = "Request ID";
            this.lvID.MinimumWidth = 10;
            this.lvID.Name = "lvID";
            this.lvID.ReadOnly = true;
            // 
            // lItemName
            // 
            this.lItemName.HeaderText = "Item ID";
            this.lItemName.MinimumWidth = 10;
            this.lItemName.Name = "lItemName";
            this.lItemName.ReadOnly = true;
            // 
            // litemType
            // 
            this.litemType.HeaderText = "Item Name";
            this.litemType.MinimumWidth = 10;
            this.litemType.Name = "litemType";
            this.litemType.ReadOnly = true;
            // 
            // lCategorty
            // 
            this.lCategorty.HeaderText = "Request Qty";
            this.lCategorty.MinimumWidth = 10;
            this.lCategorty.Name = "lCategorty";
            this.lCategorty.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Unit";
            this.Column1.Name = "Column1";
            // 
            // lItemQty
            // 
            this.lItemQty.HeaderText = "Item Status";
            this.lItemQty.MinimumWidth = 10;
            this.lItemQty.Name = "lItemQty";
            this.lItemQty.ReadOnly = true;
            // 
            // dgvDespatchConfirmList
            // 
            this.dgvDespatchConfirmList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.dgvDespatchConfirmList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDespatchConfirmList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespatchConfirmList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespatchConfirmList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDespatchConfirmList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDespatchConfirmList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespatchConfirmList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDespatchConfirmList.ColumnHeadersHeight = 40;
            this.dgvDespatchConfirmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDespatchConfirmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("PMingLiU", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDespatchConfirmList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDespatchConfirmList.EnableHeadersVisualStyles = false;
            this.dgvDespatchConfirmList.Location = new System.Drawing.Point(17, 486);
            this.dgvDespatchConfirmList.Name = "dgvDespatchConfirmList";
            this.dgvDespatchConfirmList.RowHeadersVisible = false;
            this.dgvDespatchConfirmList.RowHeadersWidth = 82;
            this.dgvDespatchConfirmList.RowTemplate.Height = 24;
            this.dgvDespatchConfirmList.Size = new System.Drawing.Size(1343, 320);
            this.dgvDespatchConfirmList.TabIndex = 67;
            this.dgvDespatchConfirmList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDespatchConfirmList_CellPainting);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "confirmSelect";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCheckBoxColumn1.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 10;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Request ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Request Qty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Item Status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(1225, 815);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 41);
            this.btnConfirm.TabIndex = 68;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // DespatchInstructionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvDespatchConfirmList);
            this.Controls.Add(this.dgvDespatchInstruction);
            this.Controls.Add(this.btnRemoveAllItem);
            this.Controls.Add(this.lblCreateList);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblDespatchInstructionList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDespatchInstruction);
            this.Name = "DespatchInstructionControl";
            this.Size = new System.Drawing.Size(1377, 861);
            this.Load += new System.EventHandler(this.DespatchInstructionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchInstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespatchConfirmList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDespatchInstructionList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDespatchInstruction;
        private System.Windows.Forms.Button btnRemoveAllItem;
        private System.Windows.Forms.Label lblCreateList;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridView dgvDespatchInstruction;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn litemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCategorty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lItemQty;
        private System.Windows.Forms.DataGridView dgvDespatchConfirmList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnConfirm;
    }
}
