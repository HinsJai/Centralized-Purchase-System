namespace UI.AgreementControls
{
    partial class PlannedPurchaseAgreementControl
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
            this.lblReminder = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.tbSearchPPA = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnNewPPA = new System.Windows.Forms.Button();
            this.dgvPPA = new System.Windows.Forms.DataGridView();
            this.lblPlannedPurchaseAgreement = new System.Windows.Forms.Label();
            this.lblPPAList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(3, 83);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(464, 24);
            this.lblReminder.TabIndex = 15;
            this.lblReminder.Text = "Double click the row for more details and edit";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(1264, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Contract Number",
            "Supplier ID",
            "Item ID"});
            this.cbSearchType.Location = new System.Drawing.Point(1072, 78);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(173, 30);
            this.cbSearchType.TabIndex = 13;
            // 
            // tbSearchPPA
            // 
            this.tbSearchPPA.Font = new System.Drawing.Font("Arial", 14F);
            this.tbSearchPPA.Location = new System.Drawing.Point(857, 77);
            this.tbSearchPPA.Name = "tbSearchPPA";
            this.tbSearchPPA.Size = new System.Drawing.Size(198, 29);
            this.tbSearchPPA.TabIndex = 12;
            this.tbSearchPPA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchPPA_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(760, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 26);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewPPA
            // 
            this.btnNewPPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewPPA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnNewPPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewPPA.Location = new System.Drawing.Point(8, 778);
            this.btnNewPPA.Name = "btnNewPPA";
            this.btnNewPPA.Size = new System.Drawing.Size(157, 66);
            this.btnNewPPA.TabIndex = 10;
            this.btnNewPPA.Text = "Create PPA";
            this.btnNewPPA.UseVisualStyleBackColor = false;
            this.btnNewPPA.Click += new System.EventHandler(this.btnNewPPA_Click);
            // 
            // dgvPPA
            // 
            this.dgvPPA.AllowUserToAddRows = false;
            this.dgvPPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPPA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPPA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPPA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPPA.ColumnHeadersHeight = 50;
            this.dgvPPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPPA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPPA.EnableHeadersVisualStyles = false;
            this.dgvPPA.Location = new System.Drawing.Point(8, 118);
            this.dgvPPA.Name = "dgvPPA";
            this.dgvPPA.RowHeadersVisible = false;
            this.dgvPPA.RowTemplate.Height = 24;
            this.dgvPPA.Size = new System.Drawing.Size(1348, 654);
            this.dgvPPA.TabIndex = 9;
            this.dgvPPA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPPA_CellContentClick);
            this.dgvPPA.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPPA_CellFormatting);
            this.dgvPPA.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPPA_CellPainting);
            this.dgvPPA.DoubleClick += new System.EventHandler(this.dgvPPA_DoubleClick);
            // 
            // lblPlannedPurchaseAgreement
            // 
            this.lblPlannedPurchaseAgreement.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblPlannedPurchaseAgreement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlannedPurchaseAgreement.Location = new System.Drawing.Point(450, 16);
            this.lblPlannedPurchaseAgreement.Name = "lblPlannedPurchaseAgreement";
            this.lblPlannedPurchaseAgreement.Size = new System.Drawing.Size(392, 37);
            this.lblPlannedPurchaseAgreement.TabIndex = 8;
            this.lblPlannedPurchaseAgreement.Text = "Planned Purchase Agreement";
            this.lblPlannedPurchaseAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPPAList
            // 
            this.lblPPAList.AutoSize = true;
            this.lblPPAList.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblPPAList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPPAList.Location = new System.Drawing.Point(2, 57);
            this.lblPPAList.Name = "lblPPAList";
            this.lblPPAList.Size = new System.Drawing.Size(97, 26);
            this.lblPPAList.TabIndex = 24;
            this.lblPPAList.Text = "PPA List";
            this.lblPPAList.Click += new System.EventHandler(this.lblPPAList_Click);
            // 
            // PlannedPurchaseAgreementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.lblPPAList);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbSearchPPA);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnNewPPA);
            this.Controls.Add(this.dgvPPA);
            this.Controls.Add(this.lblPlannedPurchaseAgreement);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "PlannedPurchaseAgreementControl";
            this.Size = new System.Drawing.Size(1377, 861);
            this.Load += new System.EventHandler(this.PlannedPurchaseAgreementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.TextBox tbSearchPPA;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnNewPPA;
        private System.Windows.Forms.DataGridView dgvPPA;
        private System.Windows.Forms.Label lblPlannedPurchaseAgreement;
        private System.Windows.Forms.Label lblPPAList;
    }
}
