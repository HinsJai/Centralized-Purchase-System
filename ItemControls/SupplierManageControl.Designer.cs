namespace UI.ItemControls
{
    partial class SupplierManageControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblSupplierList = new System.Windows.Forms.Label();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.lblSupplierManage = new System.Windows.Forms.Label();
            this.dgvSupplierList = new System.Windows.Forms.DataGridView();
            this.btnCreateSupplier = new System.Windows.Forms.Button();
            this.btnManageSupplier = new System.Windows.Forms.Button();
            this.btnChangeSupplier = new System.Windows.Forms.Button();
            this.cbChangeSupplierSearch = new System.Windows.Forms.ComboBox();
            this.btnChangeSupplierSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.Red;
            this.lblReminder.Location = new System.Drawing.Point(22, 111);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(463, 24);
            this.lblReminder.TabIndex = 45;
            this.lblReminder.Text = "Double click the row to check or edit supplier";
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblSupplierList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierList.Location = new System.Drawing.Point(21, 82);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(160, 29);
            this.lblSupplierList.TabIndex = 44;
            this.lblSupplierList.Text = "Supplier List";
            this.lblSupplierList.Click += new System.EventHandler(this.lblSupplierList_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Supplier ID",
            "Company Name",
            "Contact Name",
            "Contact Number"});
            this.cbSearchType.Location = new System.Drawing.Point(1051, 105);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(182, 30);
            this.cbSearchType.TabIndex = 43;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(811, 105);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(222, 29);
            this.tbSearch.TabIndex = 42;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(700, 107);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 24);
            this.lblSearch.TabIndex = 41;
            this.lblSearch.Text = "Search:";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1253, 97);
            this.btnSearchSupplier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(102, 44);
            this.btnSearchSupplier.TabIndex = 40;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // lblSupplierManage
            // 
            this.lblSupplierManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupplierManage.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lblSupplierManage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierManage.Location = new System.Drawing.Point(552, 32);
            this.lblSupplierManage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSupplierManage.Name = "lblSupplierManage";
            this.lblSupplierManage.Size = new System.Drawing.Size(236, 45);
            this.lblSupplierManage.TabIndex = 39;
            this.lblSupplierManage.Text = "Manage Supplier";
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSupplierList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplierList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSupplierList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSupplierList.ColumnHeadersHeight = 50;
            this.dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSupplierList.EnableHeadersVisualStyles = false;
            this.dgvSupplierList.Location = new System.Drawing.Point(25, 150);
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSupplierList.RowHeadersVisible = false;
            this.dgvSupplierList.RowHeadersWidth = 5;
            this.dgvSupplierList.RowTemplate.Height = 24;
            this.dgvSupplierList.Size = new System.Drawing.Size(1330, 650);
            this.dgvSupplierList.TabIndex = 51;
            this.dgvSupplierList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellContentClick);
            this.dgvSupplierList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSupplierList_CellPainting);
            this.dgvSupplierList.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvSupplierList_ColumnAdded);
            this.dgvSupplierList.DoubleClick += new System.EventHandler(this.dgvSupplierList_DoubleClick);
            // 
            // btnCreateSupplier
            // 
            this.btnCreateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSupplier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreateSupplier.Location = new System.Drawing.Point(26, 809);
            this.btnCreateSupplier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCreateSupplier.Name = "btnCreateSupplier";
            this.btnCreateSupplier.Size = new System.Drawing.Size(208, 41);
            this.btnCreateSupplier.TabIndex = 57;
            this.btnCreateSupplier.Text = "Create Supplier";
            this.btnCreateSupplier.UseVisualStyleBackColor = false;
            this.btnCreateSupplier.Click += new System.EventHandler(this.btnCreateSupplier_Click);
            // 
            // btnManageSupplier
            // 
            this.btnManageSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnManageSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSupplier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnManageSupplier.Location = new System.Drawing.Point(925, 809);
            this.btnManageSupplier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnManageSupplier.Name = "btnManageSupplier";
            this.btnManageSupplier.Size = new System.Drawing.Size(208, 41);
            this.btnManageSupplier.TabIndex = 56;
            this.btnManageSupplier.Text = "Manage Supplier";
            this.btnManageSupplier.UseVisualStyleBackColor = false;
            this.btnManageSupplier.Click += new System.EventHandler(this.btnManageSupplier_Click);
            // 
            // btnChangeSupplier
            // 
            this.btnChangeSupplier.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangeSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeSupplier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChangeSupplier.Location = new System.Drawing.Point(1147, 809);
            this.btnChangeSupplier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnChangeSupplier.Name = "btnChangeSupplier";
            this.btnChangeSupplier.Size = new System.Drawing.Size(208, 41);
            this.btnChangeSupplier.TabIndex = 55;
            this.btnChangeSupplier.Text = "Change Supplier";
            this.btnChangeSupplier.UseVisualStyleBackColor = false;
            this.btnChangeSupplier.Click += new System.EventHandler(this.btnChangeSupplier_Click);
            // 
            // cbChangeSupplierSearch
            // 
            this.cbChangeSupplierSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeSupplierSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChangeSupplierSearch.FormattingEnabled = true;
            this.cbChangeSupplierSearch.Items.AddRange(new object[] {
            "Item ID",
            "Item Name",
            "Item Type",
            "Category",
            "Brand",
            "Supplier ID",
            "Company Name",
            "Contact Name",
            "Contact Number"});
            this.cbChangeSupplierSearch.Location = new System.Drawing.Point(1051, 104);
            this.cbChangeSupplierSearch.Name = "cbChangeSupplierSearch";
            this.cbChangeSupplierSearch.Size = new System.Drawing.Size(182, 30);
            this.cbChangeSupplierSearch.TabIndex = 59;
            this.cbChangeSupplierSearch.Visible = false;
            // 
            // btnChangeSupplierSearch
            // 
            this.btnChangeSupplierSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChangeSupplierSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeSupplierSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSupplierSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChangeSupplierSearch.Location = new System.Drawing.Point(1253, 97);
            this.btnChangeSupplierSearch.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnChangeSupplierSearch.Name = "btnChangeSupplierSearch";
            this.btnChangeSupplierSearch.Size = new System.Drawing.Size(102, 44);
            this.btnChangeSupplierSearch.TabIndex = 58;
            this.btnChangeSupplierSearch.Text = "Search";
            this.btnChangeSupplierSearch.UseVisualStyleBackColor = false;
            this.btnChangeSupplierSearch.Visible = false;
            this.btnChangeSupplierSearch.Click += new System.EventHandler(this.btnChangeSupplierSearch_Click);
            // 
            // SupplierManageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.cbChangeSupplierSearch);
            this.Controls.Add(this.btnChangeSupplierSearch);
            this.Controls.Add(this.btnCreateSupplier);
            this.Controls.Add(this.btnManageSupplier);
            this.Controls.Add(this.btnChangeSupplier);
            this.Controls.Add(this.dgvSupplierList);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblSupplierList);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.lblSupplierManage);
            this.Name = "SupplierManageControl";
            this.Size = new System.Drawing.Size(1388, 861);
            this.Load += new System.EventHandler(this.SupplierManageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblSupplierList;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.Label lblSupplierManage;
        private System.Windows.Forms.DataGridView dgvSupplierList;
        private System.Windows.Forms.Button btnCreateSupplier;
        private System.Windows.Forms.Button btnManageSupplier;
        private System.Windows.Forms.Button btnChangeSupplier;
        private System.Windows.Forms.ComboBox cbChangeSupplierSearch;
        private System.Windows.Forms.Button btnChangeSupplierSearch;
    }
}
