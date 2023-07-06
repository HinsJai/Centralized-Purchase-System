namespace UI.AgreementControls
{
    partial class BlanketPurchaseAgreementControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.centralized_procurement_systemDataSet = new UI.centralized_procurement_systemDataSet();
            this.centralizedprocurementsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBlanketPurchaseAgreement = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.tbSearchBPA = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.btnNewBPA = new System.Windows.Forms.Button();
            this.lblBPAList = new System.Windows.Forms.Label();
            this.dgvBlanketPurchaseAgreement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.centralized_procurement_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralizedprocurementsystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlanketPurchaseAgreement)).BeginInit();
            this.SuspendLayout();
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
            // 
            // lblBlanketPurchaseAgreement
            // 
            this.lblBlanketPurchaseAgreement.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblBlanketPurchaseAgreement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBlanketPurchaseAgreement.Location = new System.Drawing.Point(450, 16);
            this.lblBlanketPurchaseAgreement.Name = "lblBlanketPurchaseAgreement";
            this.lblBlanketPurchaseAgreement.Size = new System.Drawing.Size(385, 37);
            this.lblBlanketPurchaseAgreement.TabIndex = 8;
            this.lblBlanketPurchaseAgreement.Text = "Blanket Purchase Agreement";
            this.lblBlanketPurchaseAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(1265, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 41);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Contract Number",
            "Supplier ID",
            "Item ID"});
            this.cbSearchType.Location = new System.Drawing.Point(1049, 82);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(192, 30);
            this.cbSearchType.TabIndex = 20;
            // 
            // tbSearchBPA
            // 
            this.tbSearchBPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchBPA.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSearchBPA.Location = new System.Drawing.Point(795, 82);
            this.tbSearchBPA.Name = "tbSearchBPA";
            this.tbSearchBPA.Size = new System.Drawing.Size(224, 29);
            this.tbSearchBPA.TabIndex = 19;
            this.tbSearchBPA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchBPA_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(692, 82);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 26);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search: ";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReminder
            // 
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(12, 87);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(464, 24);
            this.lblReminder.TabIndex = 17;
            this.lblReminder.Text = "Double click the row for more details and edit";
            // 
            // btnNewBPA
            // 
            this.btnNewBPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewBPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewBPA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnNewBPA.Location = new System.Drawing.Point(16, 768);
            this.btnNewBPA.Name = "btnNewBPA";
            this.btnNewBPA.Size = new System.Drawing.Size(153, 80);
            this.btnNewBPA.TabIndex = 16;
            this.btnNewBPA.Text = "Create BPA";
            this.btnNewBPA.UseVisualStyleBackColor = false;
            this.btnNewBPA.Click += new System.EventHandler(this.btnNewBPA_Click);
            // 
            // lblBPAList
            // 
            this.lblBPAList.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblBPAList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBPAList.Location = new System.Drawing.Point(11, 61);
            this.lblBPAList.Name = "lblBPAList";
            this.lblBPAList.Size = new System.Drawing.Size(90, 26);
            this.lblBPAList.TabIndex = 22;
            this.lblBPAList.Text = "BPA list";
            // 
            // dgvBlanketPurchaseAgreement
            // 
            this.dgvBlanketPurchaseAgreement.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBlanketPurchaseAgreement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBlanketPurchaseAgreement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBlanketPurchaseAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBlanketPurchaseAgreement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBlanketPurchaseAgreement.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBlanketPurchaseAgreement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlanketPurchaseAgreement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBlanketPurchaseAgreement.ColumnHeadersHeight = 50;
            this.dgvBlanketPurchaseAgreement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBlanketPurchaseAgreement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBlanketPurchaseAgreement.EnableHeadersVisualStyles = false;
            this.dgvBlanketPurchaseAgreement.Location = new System.Drawing.Point(16, 125);
            this.dgvBlanketPurchaseAgreement.Name = "dgvBlanketPurchaseAgreement";
            this.dgvBlanketPurchaseAgreement.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlanketPurchaseAgreement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBlanketPurchaseAgreement.RowHeadersVisible = false;
            this.dgvBlanketPurchaseAgreement.RowHeadersWidth = 5;
            this.dgvBlanketPurchaseAgreement.RowTemplate.Height = 24;
            this.dgvBlanketPurchaseAgreement.Size = new System.Drawing.Size(1358, 637);
            this.dgvBlanketPurchaseAgreement.TabIndex = 52;
            this.dgvBlanketPurchaseAgreement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBlanketPurchaseAgreement_CellFormatting);
            this.dgvBlanketPurchaseAgreement.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBlanketPurchaseAgreement_CellPainting);
            this.dgvBlanketPurchaseAgreement.DoubleClick += new System.EventHandler(this.dgvBlanketPurchaseAgreement_DoubleClick);
            // 
            // BlanketPurchaseAgreementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dgvBlanketPurchaseAgreement);
            this.Controls.Add(this.lblBPAList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbSearchBPA);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.btnNewBPA);
            this.Controls.Add(this.lblBlanketPurchaseAgreement);
            this.Name = "BlanketPurchaseAgreementControl";
            this.Size = new System.Drawing.Size(1377, 861);
            this.Load += new System.EventHandler(this.BlanketPurchaseAgreementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centralized_procurement_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralizedprocurementsystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlanketPurchaseAgreement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private centralized_procurement_systemDataSet centralized_procurement_systemDataSet;
        private System.Windows.Forms.BindingSource centralizedprocurementsystemDataSetBindingSource;
        private System.Windows.Forms.Label lblBlanketPurchaseAgreement;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.TextBox tbSearchBPA;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnNewBPA;
        private System.Windows.Forms.Label lblBPAList;
        private System.Windows.Forms.DataGridView dgvBlanketPurchaseAgreement;
    }
}
