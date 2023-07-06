namespace UI.AgreementControls
{
    partial class ContractPurchaseAgreementControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvContractPurchaseAgreement = new System.Windows.Forms.DataGridView();
            this.lblCPAList = new System.Windows.Forms.Label();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.tbSearchCPA = new System.Windows.Forms.TextBox();
            this.btnNewCPA = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateCPAOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractPurchaseAgreement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContractPurchaseAgreement
            // 
            this.dgvContractPurchaseAgreement.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvContractPurchaseAgreement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContractPurchaseAgreement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContractPurchaseAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractPurchaseAgreement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContractPurchaseAgreement.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvContractPurchaseAgreement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractPurchaseAgreement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContractPurchaseAgreement.ColumnHeadersHeight = 50;
            this.dgvContractPurchaseAgreement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContractPurchaseAgreement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContractPurchaseAgreement.EnableHeadersVisualStyles = false;
            this.dgvContractPurchaseAgreement.Location = new System.Drawing.Point(18, 115);
            this.dgvContractPurchaseAgreement.Name = "dgvContractPurchaseAgreement";
            this.dgvContractPurchaseAgreement.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractPurchaseAgreement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContractPurchaseAgreement.RowHeadersVisible = false;
            this.dgvContractPurchaseAgreement.RowHeadersWidth = 5;
            this.dgvContractPurchaseAgreement.RowTemplate.Height = 24;
            this.dgvContractPurchaseAgreement.Size = new System.Drawing.Size(1342, 657);
            this.dgvContractPurchaseAgreement.TabIndex = 53;
            this.dgvContractPurchaseAgreement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContractPurchaseAgreement_CellFormatting);
            this.dgvContractPurchaseAgreement.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvContractPurchaseAgreement_CellPainting);
            this.dgvContractPurchaseAgreement.DoubleClick += new System.EventHandler(this.dgvContractPurchaseAgreement_DoubleClick);
            // 
            // lblCPAList
            // 
            this.lblCPAList.AutoSize = true;
            this.lblCPAList.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblCPAList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPAList.Location = new System.Drawing.Point(13, 53);
            this.lblCPAList.Name = "lblCPAList";
            this.lblCPAList.Size = new System.Drawing.Size(98, 26);
            this.lblCPAList.TabIndex = 23;
            this.lblCPAList.Text = "CPA List";
            this.lblCPAList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Contract Number",
            "Supplier ID"});
            this.cbSearchType.Location = new System.Drawing.Point(1073, 76);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(159, 30);
            this.cbSearchType.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(758, 77);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 26);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(14, 79);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(464, 24);
            this.lblReminder.TabIndex = 11;
            this.lblReminder.Text = "Double click the row for more details and edit";
            this.lblReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearchCPA
            // 
            this.tbSearchCPA.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSearchCPA.Location = new System.Drawing.Point(861, 76);
            this.tbSearchCPA.Name = "tbSearchCPA";
            this.tbSearchCPA.Size = new System.Drawing.Size(190, 29);
            this.tbSearchCPA.TabIndex = 10;
            this.tbSearchCPA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchCPA_KeyDown);
            // 
            // btnNewCPA
            // 
            this.btnNewCPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewCPA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnNewCPA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewCPA.Location = new System.Drawing.Point(18, 778);
            this.btnNewCPA.Name = "btnNewCPA";
            this.btnNewCPA.Size = new System.Drawing.Size(153, 62);
            this.btnNewCPA.TabIndex = 9;
            this.btnNewCPA.Text = "Creat CPA";
            this.btnNewCPA.UseVisualStyleBackColor = false;
            this.btnNewCPA.Click += new System.EventHandler(this.btnNewCPA_Click);
            // 
            // s
            // 
            this.s.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.s.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.s.Location = new System.Drawing.Point(450, 16);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(450, 43);
            this.s.TabIndex = 8;
            this.s.Text = "Contract Purchase Agreement";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(1251, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreateCPAOrder
            // 
            this.btnCreateCPAOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateCPAOrder.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnCreateCPAOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateCPAOrder.Location = new System.Drawing.Point(1170, 778);
            this.btnCreateCPAOrder.Name = "btnCreateCPAOrder";
            this.btnCreateCPAOrder.Size = new System.Drawing.Size(190, 62);
            this.btnCreateCPAOrder.TabIndex = 54;
            this.btnCreateCPAOrder.Text = "Creat Order";
            this.btnCreateCPAOrder.UseVisualStyleBackColor = false;
            this.btnCreateCPAOrder.Click += new System.EventHandler(this.btnCreateCPAOrder_Click);
            // 
            // ContractPurchaseAgreementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnCreateCPAOrder);
            this.Controls.Add(this.dgvContractPurchaseAgreement);
            this.Controls.Add(this.lblCPAList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.tbSearchCPA);
            this.Controls.Add(this.btnNewCPA);
            this.Controls.Add(this.s);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ContractPurchaseAgreementControl";
            this.Size = new System.Drawing.Size(1377, 861);
            this.Load += new System.EventHandler(this.ContractPurchaseAgreementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractPurchaseAgreement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContractPurchaseAgreement;
        private System.Windows.Forms.Label lblCPAList;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.TextBox tbSearchCPA;
        private System.Windows.Forms.Button btnNewCPA;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreateCPAOrder;
    }
}
