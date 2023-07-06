namespace UI
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblStockRemain = new System.Windows.Forms.Label();
            this.lblMonthOrder = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.lblOrderCompletetion = new System.Windows.Forms.Label();
            this.monthlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplayTotalOrder = new System.Windows.Forms.Label();
            this.lblTotalOrderTitle = new System.Windows.Forms.Label();
            this.stockPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCountItem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTopThreeItem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReminder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDispalyLastThreeDay = new System.Windows.Forms.Label();
            this.lblLateDelivery = new System.Windows.Forms.Label();
            this.lblCountDisplayLateDelivery = new System.Windows.Forms.Label();
            this.lblCountLateDelivery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStockRemain
            // 
            this.lblStockRemain.AutoSize = true;
            this.lblStockRemain.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblStockRemain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockRemain.Location = new System.Drawing.Point(477, 111);
            this.lblStockRemain.Name = "lblStockRemain";
            this.lblStockRemain.Size = new System.Drawing.Size(387, 37);
            this.lblStockRemain.TabIndex = 105;
            this.lblStockRemain.Text = "Restaurant Stock Status";
            // 
            // lblMonthOrder
            // 
            this.lblMonthOrder.AutoSize = true;
            this.lblMonthOrder.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblMonthOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMonthOrder.Location = new System.Drawing.Point(48, 111);
            this.lblMonthOrder.Name = "lblMonthOrder";
            this.lblMonthOrder.Size = new System.Drawing.Size(253, 37);
            this.lblMonthOrder.TabIndex = 104;
            this.lblMonthOrder.Text = "Monthly Orders";
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
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.circularProgressBar.InnerColor = System.Drawing.Color.Silver;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = 0;
            this.circularProgressBar.Location = new System.Drawing.Point(52, 131);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("PMingLiU", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(166, 147);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "°C";
            this.circularProgressBar.TabIndex = 108;
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // lblOrderCompletetion
            // 
            this.lblOrderCompletetion.AutoSize = true;
            this.lblOrderCompletetion.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblOrderCompletetion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrderCompletetion.Location = new System.Drawing.Point(477, 440);
            this.lblOrderCompletetion.Name = "lblOrderCompletetion";
            this.lblOrderCompletetion.Size = new System.Drawing.Size(298, 37);
            this.lblOrderCompletetion.TabIndex = 109;
            this.lblOrderCompletetion.Text = "Order Completion ";
            // 
            // monthlyChart
            // 
            this.monthlyChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.Name = "ChartArea1";
            this.monthlyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyChart.Legends.Add(legend1);
            this.monthlyChart.Location = new System.Drawing.Point(46, 172);
            this.monthlyChart.Name = "monthlyChart";
            this.monthlyChart.Padding = new System.Windows.Forms.Padding(2);
            this.monthlyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "orders";
            this.monthlyChart.Series.Add(series1);
            this.monthlyChart.Size = new System.Drawing.Size(406, 245);
            this.monthlyChart.TabIndex = 110;
            this.monthlyChart.Text = "Montyly Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblDisplayTotalOrder);
            this.panel1.Controls.Add(this.lblTotalOrderTitle);
            this.panel1.Controls.Add(this.circularProgressBar);
            this.panel1.Location = new System.Drawing.Point(484, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 300);
            this.panel1.TabIndex = 111;
            // 
            // lblDisplayTotalOrder
            // 
            this.lblDisplayTotalOrder.AutoSize = true;
            this.lblDisplayTotalOrder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotalOrder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDisplayTotalOrder.Location = new System.Drawing.Point(46, 84);
            this.lblDisplayTotalOrder.Name = "lblDisplayTotalOrder";
            this.lblDisplayTotalOrder.Size = new System.Drawing.Size(79, 24);
            this.lblDisplayTotalOrder.TabIndex = 106;
            this.lblDisplayTotalOrder.Text = "Orders";
            // 
            // lblTotalOrderTitle
            // 
            this.lblTotalOrderTitle.AutoSize = true;
            this.lblTotalOrderTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrderTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalOrderTitle.Location = new System.Drawing.Point(25, 16);
            this.lblTotalOrderTitle.Name = "lblTotalOrderTitle";
            this.lblTotalOrderTitle.Size = new System.Drawing.Size(207, 37);
            this.lblTotalOrderTitle.TabIndex = 105;
            this.lblTotalOrderTitle.Text = "Total Orders";
            // 
            // stockPie
            // 
            chartArea2.Name = "ChartArea1";
            this.stockPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.stockPie.Legends.Add(legend2);
            this.stockPie.Location = new System.Drawing.Point(484, 172);
            this.stockPie.Name = "stockPie";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.stockPie.Series.Add(series2);
            this.stockPie.Size = new System.Drawing.Size(367, 245);
            this.stockPie.TabIndex = 112;
            this.stockPie.Text = "chart1";
            // 
            // chartCountItem
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCountItem.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCountItem.Legends.Add(legend3);
            this.chartCountItem.Location = new System.Drawing.Point(46, 493);
            this.chartCountItem.Name = "chartCountItem";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCountItem.Series.Add(series3);
            this.chartCountItem.Size = new System.Drawing.Size(406, 300);
            this.chartCountItem.TabIndex = 113;
            this.chartCountItem.Text = "chart1";
            // 
            // lblTopThreeItem
            // 
            this.lblTopThreeItem.AutoSize = true;
            this.lblTopThreeItem.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTopThreeItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTopThreeItem.Location = new System.Drawing.Point(39, 440);
            this.lblTopThreeItem.Name = "lblTopThreeItem";
            this.lblTopThreeItem.Size = new System.Drawing.Size(244, 37);
            this.lblTopThreeItem.TabIndex = 114;
            this.lblTopThreeItem.Text = "Top Three Item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 76);
            this.panel2.TabIndex = 1043;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(947, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 1044;
            this.label1.Text = "Delivery Date Reminder";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblCountDisplayLateDelivery);
            this.panel3.Controls.Add(this.lblCountLateDelivery);
            this.panel3.Controls.Add(this.lblLateDelivery);
            this.panel3.Controls.Add(this.lblDispalyLastThreeDay);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblReminder);
            this.panel3.Location = new System.Drawing.Point(958, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 621);
            this.panel3.TabIndex = 1045;
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblReminder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReminder.Location = new System.Drawing.Point(25, 16);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(215, 32);
            this.lblReminder.TabIndex = 105;
            this.lblReminder.Text = "Last three days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 106;
            this.label2.Text = "Total Delivery:";
            // 
            // lblDispalyLastThreeDay
            // 
            this.lblDispalyLastThreeDay.AutoSize = true;
            this.lblDispalyLastThreeDay.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDispalyLastThreeDay.ForeColor = System.Drawing.Color.Yellow;
            this.lblDispalyLastThreeDay.Location = new System.Drawing.Point(216, 69);
            this.lblDispalyLastThreeDay.Name = "lblDispalyLastThreeDay";
            this.lblDispalyLastThreeDay.Size = new System.Drawing.Size(52, 29);
            this.lblDispalyLastThreeDay.TabIndex = 107;
            this.lblDispalyLastThreeDay.Text = "Qty";
            // 
            // lblLateDelivery
            // 
            this.lblLateDelivery.AutoSize = true;
            this.lblLateDelivery.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblLateDelivery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLateDelivery.Location = new System.Drawing.Point(34, 149);
            this.lblLateDelivery.Name = "lblLateDelivery";
            this.lblLateDelivery.Size = new System.Drawing.Size(185, 32);
            this.lblLateDelivery.TabIndex = 108;
            this.lblLateDelivery.Text = "Late Delivery";
            // 
            // lblCountDisplayLateDelivery
            // 
            this.lblCountDisplayLateDelivery.AutoSize = true;
            this.lblCountDisplayLateDelivery.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCountDisplayLateDelivery.ForeColor = System.Drawing.Color.Red;
            this.lblCountDisplayLateDelivery.Location = new System.Drawing.Point(225, 216);
            this.lblCountDisplayLateDelivery.Name = "lblCountDisplayLateDelivery";
            this.lblCountDisplayLateDelivery.Size = new System.Drawing.Size(52, 29);
            this.lblCountDisplayLateDelivery.TabIndex = 110;
            this.lblCountDisplayLateDelivery.Text = "Qty";
            // 
            // lblCountLateDelivery
            // 
            this.lblCountLateDelivery.AutoSize = true;
            this.lblCountLateDelivery.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCountLateDelivery.ForeColor = System.Drawing.Color.Red;
            this.lblCountLateDelivery.Location = new System.Drawing.Point(44, 216);
            this.lblCountLateDelivery.Name = "lblCountLateDelivery";
            this.lblCountLateDelivery.Size = new System.Drawing.Size(175, 29);
            this.lblCountLateDelivery.TabIndex = 109;
            this.lblCountLateDelivery.Text = "Total Delivery:";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTopThreeItem);
            this.Controls.Add(this.chartCountItem);
            this.Controls.Add(this.stockPie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthlyChart);
            this.Controls.Add(this.lblOrderCompletetion);
            this.Controls.Add(this.lblStockRemain);
            this.Controls.Add(this.lblMonthOrder);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1384, 861);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStockRemain;
        private System.Windows.Forms.Label lblMonthOrder;
        private System.Windows.Forms.Label lblDashboard;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label lblOrderCompletetion;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalOrderTitle;
        private System.Windows.Forms.Label lblDisplayTotalOrder;
        private System.Windows.Forms.DataVisualization.Charting.Chart stockPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountItem;
        private System.Windows.Forms.Label lblTopThreeItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblDispalyLastThreeDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountDisplayLateDelivery;
        private System.Windows.Forms.Label lblCountLateDelivery;
        private System.Windows.Forms.Label lblLateDelivery;
    }
}
