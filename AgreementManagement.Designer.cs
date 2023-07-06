namespace UI
{
    partial class AgreementManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navPannel = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.navCPAOrder = new FontAwesome.Sharp.IconButton();
            this.navPPAOrder = new FontAwesome.Sharp.IconButton();
            this.navBPAOrder = new FontAwesome.Sharp.IconButton();
            this.navCPA = new FontAwesome.Sharp.IconButton();
            this.navPPA = new FontAwesome.Sharp.IconButton();
            this.navDashboard = new FontAwesome.Sharp.IconButton();
            this.navQueue = new FontAwesome.Sharp.IconButton();
            this.navBPA = new FontAwesome.Sharp.IconButton();
            this.navDespatchInstruction = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lbluIDTitle = new System.Windows.Forms.Label();
            this.lblPosistionTitle = new System.Windows.Forms.Label();
            this.lblPosistion = new System.Windows.Forms.Label();
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
            this.navPannel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // navPannel
            // 
            this.navPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPannel.Controls.Add(this.btnLogout);
            this.navPannel.Controls.Add(this.tableLayoutPanel4);
            this.navPannel.Controls.Add(this.iconPictureBox2);
            this.navPannel.Controls.Add(this.iconPictureBox1);
            this.navPannel.Controls.Add(this.lblUserID);
            this.navPannel.Controls.Add(this.lbluIDTitle);
            this.navPannel.Controls.Add(this.lblPosistionTitle);
            this.navPannel.Controls.Add(this.lblPosistion);
            this.navPannel.Controls.Add(this.pbLogo);
            this.navPannel.Location = new System.Drawing.Point(0, 0);
            this.navPannel.Name = "navPannel";
            this.navPannel.Size = new System.Drawing.Size(199, 861);
            this.navPannel.TabIndex = 19;
            this.navPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPannel_Paint);
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
            this.btnLogout.Size = new System.Drawing.Size(197, 61);
            this.btnLogout.TabIndex = 78;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.navCPAOrder, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.navPPAOrder, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.navBPAOrder, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.navCPA, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.navPPA, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.navDashboard, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.navQueue, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.navBPA, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.navDespatchInstruction, 0, 8);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 164);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 372);
            this.tableLayoutPanel4.TabIndex = 41;
            // 
            // navCPAOrder
            // 
            this.navCPAOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navCPAOrder.FlatAppearance.BorderSize = 0;
            this.navCPAOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCPAOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCPAOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navCPAOrder.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.navCPAOrder.IconColor = System.Drawing.Color.White;
            this.navCPAOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navCPAOrder.IconSize = 24;
            this.navCPAOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navCPAOrder.Location = new System.Drawing.Point(3, 290);
            this.navCPAOrder.Name = "navCPAOrder";
            this.navCPAOrder.Size = new System.Drawing.Size(188, 33);
            this.navCPAOrder.TabIndex = 87;
            this.navCPAOrder.Text = "CPA Order";
            this.navCPAOrder.UseVisualStyleBackColor = false;
            this.navCPAOrder.Click += new System.EventHandler(this.navCPAOrder_Click);
            // 
            // navPPAOrder
            // 
            this.navPPAOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navPPAOrder.FlatAppearance.BorderSize = 0;
            this.navPPAOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPPAOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPPAOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navPPAOrder.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.navPPAOrder.IconColor = System.Drawing.Color.White;
            this.navPPAOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navPPAOrder.IconSize = 24;
            this.navPPAOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPPAOrder.Location = new System.Drawing.Point(3, 249);
            this.navPPAOrder.Name = "navPPAOrder";
            this.navPPAOrder.Size = new System.Drawing.Size(188, 33);
            this.navPPAOrder.TabIndex = 86;
            this.navPPAOrder.Text = "PPA Order";
            this.navPPAOrder.UseVisualStyleBackColor = false;
            this.navPPAOrder.Click += new System.EventHandler(this.navPPAOrder_Click);
            // 
            // navBPAOrder
            // 
            this.navBPAOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navBPAOrder.FlatAppearance.BorderSize = 0;
            this.navBPAOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBPAOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBPAOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navBPAOrder.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.navBPAOrder.IconColor = System.Drawing.Color.White;
            this.navBPAOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navBPAOrder.IconSize = 24;
            this.navBPAOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navBPAOrder.Location = new System.Drawing.Point(3, 208);
            this.navBPAOrder.Name = "navBPAOrder";
            this.navBPAOrder.Size = new System.Drawing.Size(188, 35);
            this.navBPAOrder.TabIndex = 85;
            this.navBPAOrder.Text = "BPA Order";
            this.navBPAOrder.UseVisualStyleBackColor = false;
            this.navBPAOrder.Click += new System.EventHandler(this.navBPAOrder_Click);
            // 
            // navCPA
            // 
            this.navCPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navCPA.FlatAppearance.BorderSize = 0;
            this.navCPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCPA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navCPA.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.navCPA.IconColor = System.Drawing.Color.White;
            this.navCPA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navCPA.IconSize = 24;
            this.navCPA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navCPA.Location = new System.Drawing.Point(3, 167);
            this.navCPA.Name = "navCPA";
            this.navCPA.Size = new System.Drawing.Size(188, 35);
            this.navCPA.TabIndex = 84;
            this.navCPA.Text = "CPA";
            this.navCPA.UseVisualStyleBackColor = false;
            this.navCPA.Click += new System.EventHandler(this.navCPA_Click);
            // 
            // navPPA
            // 
            this.navPPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navPPA.FlatAppearance.BorderSize = 0;
            this.navPPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPPA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navPPA.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.navPPA.IconColor = System.Drawing.Color.White;
            this.navPPA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navPPA.IconSize = 24;
            this.navPPA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPPA.Location = new System.Drawing.Point(3, 126);
            this.navPPA.Name = "navPPA";
            this.navPPA.Size = new System.Drawing.Size(188, 35);
            this.navPPA.TabIndex = 83;
            this.navPPA.Text = "PPA";
            this.navPPA.UseVisualStyleBackColor = false;
            this.navPPA.Click += new System.EventHandler(this.navPPA_Click);
            // 
            // navDashboard
            // 
            this.navDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
            this.navDashboard.Size = new System.Drawing.Size(188, 33);
            this.navDashboard.TabIndex = 74;
            this.navDashboard.Text = "Dashboard";
            this.navDashboard.UseVisualStyleBackColor = false;
            this.navDashboard.Click += new System.EventHandler(this.navDashboard_Click);
            // 
            // navQueue
            // 
            this.navQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navQueue.FlatAppearance.BorderSize = 0;
            this.navQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navQueue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navQueue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navQueue.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.navQueue.IconColor = System.Drawing.Color.White;
            this.navQueue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navQueue.IconSize = 24;
            this.navQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navQueue.Location = new System.Drawing.Point(3, 44);
            this.navQueue.Name = "navQueue";
            this.navQueue.Size = new System.Drawing.Size(188, 33);
            this.navQueue.TabIndex = 75;
            this.navQueue.Text = "Request Queue";
            this.navQueue.UseVisualStyleBackColor = false;
            this.navQueue.Click += new System.EventHandler(this.navQueue_Click);
            // 
            // navBPA
            // 
            this.navBPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navBPA.FlatAppearance.BorderSize = 0;
            this.navBPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBPA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navBPA.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.navBPA.IconColor = System.Drawing.Color.White;
            this.navBPA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navBPA.IconSize = 24;
            this.navBPA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navBPA.Location = new System.Drawing.Point(3, 85);
            this.navBPA.Name = "navBPA";
            this.navBPA.Size = new System.Drawing.Size(188, 35);
            this.navBPA.TabIndex = 76;
            this.navBPA.Text = "BPA";
            this.navBPA.UseVisualStyleBackColor = false;
            this.navBPA.Click += new System.EventHandler(this.navBPA_Click);
            // 
            // navDespatchInstruction
            // 
            this.navDespatchInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.navDespatchInstruction.FlatAppearance.BorderSize = 0;
            this.navDespatchInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navDespatchInstruction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDespatchInstruction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.navDespatchInstruction.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.navDespatchInstruction.IconColor = System.Drawing.Color.White;
            this.navDespatchInstruction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navDespatchInstruction.IconSize = 24;
            this.navDespatchInstruction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDespatchInstruction.Location = new System.Drawing.Point(3, 331);
            this.navDespatchInstruction.Name = "navDespatchInstruction";
            this.navDespatchInstruction.Size = new System.Drawing.Size(188, 38);
            this.navDespatchInstruction.TabIndex = 82;
            this.navDespatchInstruction.Text = "Despatch Instruction";
            this.navDespatchInstruction.UseVisualStyleBackColor = false;
            this.navDespatchInstruction.Click += new System.EventHandler(this.navDespatchInstruction_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 58;
            this.iconPictureBox2.Location = new System.Drawing.Point(62, 675);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(58, 59);
            this.iconPictureBox2.TabIndex = 77;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(62, 549);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(58, 59);
            this.iconPictureBox1.TabIndex = 76;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserID.Location = new System.Drawing.Point(50, 635);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(81, 26);
            this.lblUserID.TabIndex = 75;
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluIDTitle
            // 
            this.lbluIDTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluIDTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbluIDTitle.Location = new System.Drawing.Point(50, 611);
            this.lbluIDTitle.Name = "lbluIDTitle";
            this.lbluIDTitle.Size = new System.Drawing.Size(81, 24);
            this.lbluIDTitle.TabIndex = 73;
            this.lbluIDTitle.Text = "User ID";
            this.lbluIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosistionTitle
            // 
            this.lblPosistionTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosistionTitle.Location = new System.Drawing.Point(36, 737);
            this.lblPosistionTitle.Name = "lblPosistionTitle";
            this.lblPosistionTitle.Size = new System.Drawing.Size(102, 25);
            this.lblPosistionTitle.TabIndex = 74;
            this.lblPosistionTitle.Text = "Position";
            this.lblPosistionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosistion
            // 
            this.lblPosistion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosistion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPosistion.Location = new System.Drawing.Point(6, 768);
            this.lblPosistion.Name = "lblPosistion";
            this.lblPosistion.Size = new System.Drawing.Size(179, 26);
            this.lblPosistion.TabIndex = 72;
            this.lblPosistion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::UI.Properties.Resources.company_logo200;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(198, 158);
            this.pbLogo.TabIndex = 35;
            this.pbLogo.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mainPanel.Controls.Add(this.dgvRequestList);
            this.mainPanel.Controls.Add(this.dgvItemList);
            this.mainPanel.Controls.Add(this.lblRequestList);
            this.mainPanel.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.mainPanel.Location = new System.Drawing.Point(197, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1386, 861);
            this.mainPanel.TabIndex = 20;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
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
            this.dgvRequestList.Location = new System.Drawing.Point(1104, 1584);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.RowHeadersWidth = 82;
            this.dgvRequestList.RowTemplate.Height = 24;
            this.dgvRequestList.Size = new System.Drawing.Size(1854, 385);
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
            this.dgvItemList.Size = new System.Drawing.Size(1571, 38);
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
            // AgreementManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPannel);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "AgreementManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgreementManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgreementManagement_FormClosing);
            this.Load += new System.EventHandler(this.AgreementManagement_Load);
            this.navPannel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPannel;
        private System.Windows.Forms.PictureBox pbLogo;
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lbluIDTitle;
        private System.Windows.Forms.Label lblPosistionTitle;
        private System.Windows.Forms.Label lblPosistion;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton navDashboard;
        private FontAwesome.Sharp.IconButton navQueue;
        private FontAwesome.Sharp.IconButton navBPA;
        private FontAwesome.Sharp.IconButton navDespatchInstruction;
        private FontAwesome.Sharp.IconButton navCPAOrder;
        private FontAwesome.Sharp.IconButton navPPAOrder;
        private FontAwesome.Sharp.IconButton navBPAOrder;
        private FontAwesome.Sharp.IconButton navCPA;
        private FontAwesome.Sharp.IconButton navPPA;
    }
}