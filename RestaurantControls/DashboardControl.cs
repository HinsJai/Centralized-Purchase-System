using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CircularProgressBar;
using MySql.Data.MySqlClient;
using UI.connMySql;

namespace UI
{
    public partial class DashboardControl : UserControl
    {
        private readonly Connection_class chartConn = new Connection_class();
        string userID = User.UserID;

        public DashboardControl()
        {
            InitializeComponent();

            PopulateChart();
            PopulateStockPie();
            PopulateCountItemChart();
            PopulateCircularProgressBar();
            setReminder();
        }

        private void PopulateChart()
        {
            // SQL query to retrieve the order count per month
            string query = "SELECT MONTH(requestDateTime) AS Month, COUNT(*) AS OrderCount FROM request_record GROUP BY Month";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a MySqlCommand object and set its properties
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Create a MySqlDataAdapter to fill a DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        monthlyChart.DataSource = dataTable;

                        // Set the X and Y values for the chart
                        monthlyChart.Series[0].XValueMember = "Month";
                        monthlyChart.Series[0].YValueMembers = "OrderCount";
                        monthlyChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                        monthlyChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

                        // Set the chart type to a column chart
                        monthlyChart.Series[0].ChartType = SeriesChartType.Column;

                        // Set the chart title
                        monthlyChart.Titles.Add("Order Count per Month");
                        monthlyChart.Titles[0].ForeColor = Color.White;
                        monthlyChart.Titles[0].Font = new Font(monthlyChart.Titles[0].Font.FontFamily, 16, FontStyle.Bold);

                        // Set the chart background color
                        monthlyChart.BackColor = Color.FromArgb(37, 42, 64);

                        monthlyChart.Refresh();
                    }
                }
            }
        }



        private void PopulateStockPie()
        {
            string query = "SELECT stockStatus, COUNT(*) AS StockCount FROM restaurant_stock GROUP BY stockStatus";

            using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        stockPie.Series.Clear();

                        Series series = new Series("Stock Quantity");
                        series.ChartType = SeriesChartType.Pie;
                        series.BackGradientStyle = GradientStyle.TopBottom;
                        stockPie.BackColor = Color.FromArgb(37, 42, 64);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string stockStatus = row["stockStatus"].ToString();
                            int stockCount = Convert.ToInt32(row["StockCount"]);

                            DataPoint dataPoint = new DataPoint();
                            dataPoint.Label = $"{stockStatus} ({stockCount})";
                            dataPoint.SetValueY(stockCount);

                            switch (stockStatus)
                            {
                                case "Out of Stock":
                                    dataPoint.Color = Color.Red;
                                    break;
                                case "Low":
                                    dataPoint.Color = Color.Yellow;
                                    break;
                                default:
                                    dataPoint.Color = Color.LightGreen;
                                    break;
                            }

                            series.Points.Add(dataPoint);

                        }

                        stockPie.Series.Add(series);
                        stockPie.ChartAreas[0].InnerPlotPosition.Width = 100; 
                        stockPie.ChartAreas[0].InnerPlotPosition.Height = 100;
                        stockPie.Titles.Clear();
                        stockPie.Titles.Add(new Title("Stock Quantity by Status", Docking.Top, new Font("Arial", 16, FontStyle.Bold), Color.White));

                        stockPie.Refresh();
                    }
                }
            }
        }

        private void PopulateCountItemChart()
        {
            string query = "SELECT request_item.requestItemName, SUM(request_item.requestQty) AS TotalQty " +
                          "FROM request_item " +
                          "JOIN request_record ON request_item.requestID = request_record.requestID " +
                          "WHERE request_record.status NOT IN ('Cancel Request', 'Rejected') " +
                          "AND request_record.requestDateTime >= DATE_SUB(NOW(), INTERVAL 1 MONTH) " +
                          "AND request_record.userID = @userID " +
                          "GROUP BY request_item.requestItemName " +
                          "ORDER BY TotalQty DESC " +
                          "LIMIT 3";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a MySqlCommand object and set its properties
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@userID", userID);

                    // Create a MySqlDataAdapter to fill a DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Clear existing series in the chart
                        chartCountItem.Series.Clear();

                        // Create a new series for the pie chart
                        Series series = new Series("Request Quantity");
                        series.ChartType = SeriesChartType.Pie;
                        series.Color = Color.LightBlue;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string requestItemName = row["requestItemName"].ToString();
                            int totalQty = Convert.ToInt32(row["TotalQty"]);

                            // Add data points to the series
                            DataPoint dataPoint = new DataPoint();
                            dataPoint.AxisLabel = requestItemName; // Set the axis label to the item name
                            dataPoint.YValues = new double[] { totalQty };
                            series.Points.Add(dataPoint);
                        }

                        // Add the series to the chart
                        chartCountItem.Series.Add(series);

                        // Set the chart title
                        chartCountItem.Titles.Clear();
                        chartCountItem.Titles.Add(new Title("Top Three Request Item Per Month", Docking.Top, new Font("Arial", 16, FontStyle.Bold), Color.White));

                        // Set the chart background color
                        chartCountItem.BackColor = Color.FromArgb(37, 42, 64);
                        chartCountItem.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                        chartCountItem.Refresh();
                    }
                }
            }
        }



        private void PopulateCircularProgressBar()
        {
            // Get the userID from the user class (assuming you have a User class with a property called UserID)

            // SQL query to retrieve the count of completed requests for the specified userID
            string query = $"SELECT COUNT(*) AS CompletedCount FROM request_record WHERE userID = {userID} AND status IN ('Completed')";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a MySqlCommand object and set its properties
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and get the count of completed requests
                    int completedCount = Convert.ToInt32(command.ExecuteScalar());

                    // SQL query to retrieve the count of all non-cancelled requests for the specified userID
                    string totalQuery = $"SELECT COUNT(*) FROM request_record WHERE userID = {userID} AND status NOT IN ('Cancelled', 'Cancel Request')";

                    // Set the query for the total count
                    command.CommandText = totalQuery;

                    // Execute the query and get the total count of non-cancelled requests
                    int totalCount = Convert.ToInt32(command.ExecuteScalar());

                    // Calculate the percentage of completed requests
                    int percentage = (int)((double)completedCount / totalCount * 100);

                    // Set the value of the circularProgressBar
                    circularProgressBar.Value = percentage;
                    circularProgressBar.Text = $"{percentage}%";
                    lblDisplayTotalOrder.Text = $"{completedCount} / {totalCount} Orders Completed";
                }
            }
        }



        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }

        private void setReminder()
        {

            string threeDaySql = @"SELECT COUNT(deliveryNoteID) AS numDeliveryNotes
                            FROM delivery_note
                            WHERE deliveryDate >= CURDATE() AND deliveryDate <= CURDATE() + INTERVAL 3 DAY
                              AND status = 'In Progress'
                              AND requestID IN (
                                SELECT requestID
                                FROM request_record
                                WHERE userID = @userID
                              );";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(threeDaySql, connection);
                    cmd.Parameters.AddWithValue("@userID", userID); 
                    int countThreeDayDelivery = Convert.ToInt32(cmd.ExecuteScalar());
                    lblDispalyLastThreeDay.Text = countThreeDayDelivery.ToString();
                }


                string lateDeliverySql = @"SELECT COUNT(deliveryNoteID) AS numDeliveryNotes
                                                            FROM delivery_note
                                                            WHERE deliveryDate < CURDATE()
                                                              AND status = 'In Progress'
                                                              AND requestID IN (
                                                                SELECT requestID
                                                                FROM request_record
                                                                WHERE userID = @userID
                                                              );";

                using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(lateDeliverySql, connection);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    int LateDelivery = Convert.ToInt32(cmd.ExecuteScalar());
                    lblCountDisplayLateDelivery.Text = LateDelivery.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
