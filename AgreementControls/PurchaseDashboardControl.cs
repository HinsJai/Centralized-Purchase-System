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
using UI.connMySql;

namespace UI.AgreementControls
{
    public partial class PurchaseDashboardControl : UserControl
    {
        private readonly Connection_class chartConn = new Connection_class();

        public PurchaseDashboardControl()
        {
            InitializeComponent();
        }

        private void PurchaseDashboardControl_Load(object sender, EventArgs e)
        {

            PopulateCircularProgressBar();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(chartConn.conndb.ConnectionString))
                {
                    connection.Open();

                    // Calculate the count of remaining days for BPA contracts
                    MySqlCommand bpaCountCommand = new MySqlCommand("SELECT COUNT(*) FROM bpa WHERE DATEDIFF(EndDate, CURDATE()) <= 7 AND Status = 'Valid'", connection);
                    int bpaContractCount = Convert.ToInt32(bpaCountCommand.ExecuteScalar());
                    lblDisplayBPAExpireSoon.Text = bpaContractCount.ToString();

                    // Count the number of valid BPA contracts with remaining days greater than 7
                    MySqlCommand bpaRemainingCountCommand = new MySqlCommand("SELECT COUNT(*) FROM bpa WHERE DATEDIFF(EndDate, CURDATE()) > 7 AND Status = 'Valid'", connection);
                    int bpaRemainingContractCount = Convert.ToInt32(bpaRemainingCountCommand.ExecuteScalar());
                    lblDisplayBPANormal.Text = bpaRemainingContractCount.ToString();

                    // Count the number of invalid BPA contracts
                    MySqlCommand bpaInvalidCountCommand = new MySqlCommand("SELECT COUNT(*) FROM bpa WHERE Status = 'Invalid'", connection);
                    int bpaInvalidContractCount = Convert.ToInt32(bpaInvalidCountCommand.ExecuteScalar());

                    lblDispayBPAExpiredTotal.Text = bpaInvalidContractCount.ToString();



                    // Calculate the count of remaining days for CPA contracts
                    MySqlCommand cpaCountCommand = new MySqlCommand("SELECT COUNT(*) FROM cpa WHERE DATEDIFF(EndDate, CURDATE()) <= 7 AND Status = 'Valid'", connection);
                    int cpaContractCount = Convert.ToInt32(cpaCountCommand.ExecuteScalar());
                    lblDisplayCPAExpireSoon.Text = cpaContractCount.ToString();


                    MySqlCommand cpaRemainingCountCommand = new MySqlCommand("SELECT COUNT(*) FROM cpa WHERE DATEDIFF(EndDate, CURDATE()) > 7 AND Status = 'Valid'", connection);
                    int cpaRemainingContractCount = Convert.ToInt32(cpaRemainingCountCommand.ExecuteScalar());
                    lblDisplayCPANormal.Text = cpaRemainingContractCount.ToString();


                    // Count the number of invalid CPA contracts
                    MySqlCommand cpaInvalidCountCommand = new MySqlCommand("SELECT COUNT(*) FROM cpa WHERE Status = 'Invalid'", connection);
                    int cpaInvalidContractCount = Convert.ToInt32(cpaInvalidCountCommand.ExecuteScalar());
                    lblDisplayCPAExpiredTotal.Text = cpaInvalidContractCount.ToString();



                    // Calculate the count of remaining days for PPA contracts
                    MySqlCommand ppaCountCommand = new MySqlCommand("SELECT COUNT(*) FROM ppa WHERE DATEDIFF(EndDate, CURDATE()) <= 7 AND Status = 'Valid'", connection);
                    int ppaContractCount = Convert.ToInt32(ppaCountCommand.ExecuteScalar());
                    lblDisplayPPAExpireSoon.Text = ppaContractCount.ToString();



                    // Count the number of valid PPA contracts with remaining days greater than 7
                    MySqlCommand ppaRemainingCountCommand = new MySqlCommand("SELECT COUNT(*) FROM ppa WHERE DATEDIFF(EndDate, CURDATE()) > 7 AND Status = 'Valid'", connection);
                    int ppaRemainingContractCount = Convert.ToInt32(ppaRemainingCountCommand.ExecuteScalar());
                    lblDisplayPPANormal.Text = ppaRemainingContractCount.ToString();


                    // Count the number of invalid PPA contracts
                    MySqlCommand ppaInvalidCountCommand = new MySqlCommand("SELECT COUNT(*) FROM ppa WHERE Status = 'Invalid'", connection);
                    int ppaInvalidContractCount = Convert.ToInt32(ppaInvalidCountCommand.ExecuteScalar());
                    lblDisplayPPAExpiredTotal.Text = ppaInvalidContractCount.ToString();

                    // Count the pending number of total requests
                    MySqlCommand totalCountPendingCommand = new MySqlCommand("SELECT COUNT(DISTINCT requestID) FROM request_record WHERE Status = 'Pending'", connection);
                    int totalRequestCount = Convert.ToInt32(totalCountPendingCommand.ExecuteScalar());
                    lblDisplayCountWaitApprove.Text = totalRequestCount.ToString();


                    MySqlCommand totalCounUpdatetCmd = new MySqlCommand("SELECT COUNT(DISTINCT requestID) FROM request_item WHERE itemStatus = 'Update'", connection);
                    int totalUpdatetCount = Convert.ToInt32(totalCounUpdatetCmd.ExecuteScalar());
                    lblDisplayCountUpdate.Text = totalUpdatetCount.ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateCircularProgressBar()
        {
            // Get the userID from the user class (assuming you have a User class with a property called UserID)

            // SQL query to retrieve the count of completed requests for the specified userID
            string query = $"SELECT COUNT(*) AS CompletedCount FROM request_record WHERE  status IN ('Completed')";

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
                    string totalQuery = $"SELECT COUNT(*) FROM request_record WHERE status NOT IN ('Cancelled', 'Cancel Request')";

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
    }
}
