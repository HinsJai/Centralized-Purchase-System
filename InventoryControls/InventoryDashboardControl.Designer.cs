namespace UI.InventoryControls
{
    partial class InventoryDashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCancelledTotal = new System.Windows.Forms.Label();
            this.lblCancelledDespatch = new System.Windows.Forms.Label();
            this.lblDisplayCountCancelledDespatch = new System.Windows.Forms.Label();
            this.lblDespatchInProgressTotal = new System.Windows.Forms.Label();
            this.lblInProgressDespatch = new System.Windows.Forms.Label();
            this.lblDisplayCountWaitHandel = new System.Windows.Forms.Label();
            this.lblDespatchQueue = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblCancelledTotal);
            this.panel4.Controls.Add(this.lblCancelledDespatch);
            this.panel4.Controls.Add(this.lblDisplayCountCancelledDespatch);
            this.panel4.Controls.Add(this.lblDespatchInProgressTotal);
            this.panel4.Controls.Add(this.lblInProgressDespatch);
            this.panel4.Controls.Add(this.lblDisplayCountWaitHandel);
            this.panel4.Location = new System.Drawing.Point(125, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 278);
            this.panel4.TabIndex = 116;
            // 
            // lblCancelledTotal
            // 
            this.lblCancelledTotal.AutoSize = true;
            this.lblCancelledTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCancelledTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblCancelledTotal.Location = new System.Drawing.Point(41, 202);
            this.lblCancelledTotal.Name = "lblCancelledTotal";
            this.lblCancelledTotal.Size = new System.Drawing.Size(76, 29);
            this.lblCancelledTotal.TabIndex = 116;
            this.lblCancelledTotal.Text = "Total:";
            this.lblCancelledTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCancelledDespatch
            // 
            this.lblCancelledDespatch.AutoSize = true;
            this.lblCancelledDespatch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCancelledDespatch.ForeColor = System.Drawing.Color.Yellow;
            this.lblCancelledDespatch.Location = new System.Drawing.Point(41, 155);
            this.lblCancelledDespatch.Name = "lblCancelledDespatch";
            this.lblCancelledDespatch.Size = new System.Drawing.Size(240, 29);
            this.lblCancelledDespatch.TabIndex = 115;
            this.lblCancelledDespatch.Text = "Cancelled Despatch";
            this.lblCancelledDespatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayCountCancelledDespatch
            // 
            this.lblDisplayCountCancelledDespatch.AutoSize = true;
            this.lblDisplayCountCancelledDespatch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDisplayCountCancelledDespatch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDisplayCountCancelledDespatch.Location = new System.Drawing.Point(141, 202);
            this.lblDisplayCountCancelledDespatch.Name = "lblDisplayCountCancelledDespatch";
            this.lblDisplayCountCancelledDespatch.Size = new System.Drawing.Size(90, 29);
            this.lblDisplayCountCancelledDespatch.TabIndex = 114;
            this.lblDisplayCountCancelledDespatch.Text = "Orders";
            // 
            // lblDespatchInProgressTotal
            // 
            this.lblDespatchInProgressTotal.AutoSize = true;
            this.lblDespatchInProgressTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDespatchInProgressTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblDespatchInProgressTotal.Location = new System.Drawing.Point(41, 90);
            this.lblDespatchInProgressTotal.Name = "lblDespatchInProgressTotal";
            this.lblDespatchInProgressTotal.Size = new System.Drawing.Size(76, 29);
            this.lblDespatchInProgressTotal.TabIndex = 113;
            this.lblDespatchInProgressTotal.Text = "Total:";
            this.lblDespatchInProgressTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInProgressDespatch
            // 
            this.lblInProgressDespatch.AutoSize = true;
            this.lblInProgressDespatch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblInProgressDespatch.ForeColor = System.Drawing.Color.Yellow;
            this.lblInProgressDespatch.Location = new System.Drawing.Point(41, 43);
            this.lblInProgressDespatch.Name = "lblInProgressDespatch";
            this.lblInProgressDespatch.Size = new System.Drawing.Size(189, 29);
            this.lblInProgressDespatch.TabIndex = 112;
            this.lblInProgressDespatch.Text = "Wait for Handle";
            this.lblInProgressDespatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayCountWaitHandel
            // 
            this.lblDisplayCountWaitHandel.AutoSize = true;
            this.lblDisplayCountWaitHandel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDisplayCountWaitHandel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDisplayCountWaitHandel.Location = new System.Drawing.Point(141, 90);
            this.lblDisplayCountWaitHandel.Name = "lblDisplayCountWaitHandel";
            this.lblDisplayCountWaitHandel.Size = new System.Drawing.Size(90, 29);
            this.lblDisplayCountWaitHandel.TabIndex = 106;
            this.lblDisplayCountWaitHandel.Text = "Orders";
            // 
            // lblDespatchQueue
            // 
            this.lblDespatchQueue.AutoSize = true;
            this.lblDespatchQueue.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblDespatchQueue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDespatchQueue.Location = new System.Drawing.Point(118, 190);
            this.lblDespatchQueue.Name = "lblDespatchQueue";
            this.lblDespatchQueue.Size = new System.Drawing.Size(424, 37);
            this.lblDespatchQueue.TabIndex = 105;
            this.lblDespatchQueue.Text = "Despatch Instrution Queue";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.lblDashboard);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1384, 76);
            this.panel6.TabIndex = 1045;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDashboard.Location = new System.Drawing.Point(526, 10);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(275, 56);
            this.lblDashboard.TabIndex = 103;
            this.lblDashboard.Text = "Dashboard";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(707, 259);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 278);
            this.chart1.TabIndex = 1046;
            this.chart1.Text = "chart1";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblStockStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockStatus.Location = new System.Drawing.Point(700, 190);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(211, 37);
            this.lblStockStatus.TabIndex = 1047;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // InventoryDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.lblStockStatus);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDespatchQueue);
            this.MaximumSize = new System.Drawing.Size(1384, 861);
            this.Name = "InventoryDashboardControl";
            this.Size = new System.Drawing.Size(1384, 861);
            this.Load += new System.EventHandler(this.InventoryDashboardControl_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCancelledTotal;
        private System.Windows.Forms.Label lblCancelledDespatch;
        private System.Windows.Forms.Label lblDisplayCountCancelledDespatch;
        private System.Windows.Forms.Label lblDespatchInProgressTotal;
        private System.Windows.Forms.Label lblInProgressDespatch;
        private System.Windows.Forms.Label lblDisplayCountWaitHandel;
        private System.Windows.Forms.Label lblDespatchQueue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblStockStatus;
    }
}
