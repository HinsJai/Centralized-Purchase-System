using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UI.connMySql;

namespace UI.InventoryControls
{
    public partial class InventoryDashboardControl : UserControl
    {

        private readonly Connection_class chartConn = new Connection_class();

        public InventoryDashboardControl()
        {
            InitializeComponent();
        }

        private void InventoryDashboardControl_Load(object sender, EventArgs e)
        {
            displayDespatchHandle();
            DisplayStockStatus();
        }

        private void displayDespatchHandle()
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
                {
                    connection.Open();
                    string countInProgressSql = "SELECT COUNT(*) AS numDeliveryNotes FROM despatch_instruction WHERE status = 'In Progress';";
                    MySqlCommand cmd = new MySqlCommand(countInProgressSql, connection);
                    int countInProgress = Convert.ToInt32(cmd.ExecuteScalar());
                    lblDisplayCountWaitHandel.Text = countInProgress.ToString();
                }

                using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
                {
                    connection.Open();
                    string countCancelSql = "SELECT COUNT(*) AS numDeliveryNotes FROM despatch_instruction WHERE status = 'Cancelled';";
                    MySqlCommand cmd = new MySqlCommand(countCancelSql, connection);
                    int countCancelled = Convert.ToInt32(cmd.ExecuteScalar());
                    lblDisplayCountCancelledDespatch.Text = countCancelled.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayStockStatus()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
                {
                    connection.Open();
                    string stockStatusCountSql = "SELECT stockStatus, COUNT(*) AS Count FROM item GROUP BY stockStatus;";
                    MySqlCommand cmd = new MySqlCommand(stockStatusCountSql, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing chart data
                    chart1.Series.Clear();

                    // Create a new series for the chart
                    Series series = new Series("Stock Status");
                    series.ChartType = SeriesChartType.Column;

                    // Set background gradient style
                    chart1.ChartAreas[0].BackGradientStyle = GradientStyle.VerticalCenter;

                    // Set background color
                    chart1.BackColor = Color.FromArgb(37, 42, 64);

                    // Set stockStatus text color to white
                    chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                    chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

                    // Add data points to the series
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string stockStatus = row["stockStatus"].ToString();
                        int count = Convert.ToInt32(row["Count"]);
                        series.Points.AddXY(stockStatus, count);

                        // Set text color based on stockStatus
                        if (stockStatus == "Low")
                            series.Points.Last().Color = Color.Yellow;
                        else if (stockStatus == "Out of Stock")
                            series.Points.Last().Color = Color.Red;
                        else if (stockStatus == "Normal")
                            series.Points.Last().Color = Color.Green;
                    }

                    // Set data point label text size to 10
                    foreach (DataPoint dataPoint in series.Points)
                    {
                        dataPoint.LabelForeColor = Color.White;
                        dataPoint.Font = new Font("Arial", 10);
                    }

                    // Add the series to the chart
                    chart1.Series.Add(series);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
