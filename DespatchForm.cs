using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using UI.Confirmed_Item;
using UI.connMySql;
using UI.Staff_Restaurant_Info;

namespace UI
{
    public partial class DespatchForm : Form
    {

        // Define the ConfirmedItems property to receive the confirmed items from formRequestManagement
        public List<UI.DespatchConfirm.DespatchConfirm> DespatchConfirms { get; set; }
        private readonly Connection_class despatchConn = new Connection_class();
        private int userID;
        private int maxDespatchID;
        private string requestID;

        public DespatchForm()
        {
            InitializeComponent();
            RetrieveRestaurantInfo();
        }

        private void DespatchForm_Load(object sender, EventArgs e)
        {
            setForm();

        }

        private void RetrieveRestaurantInfo()
        {

            string query = @"SELECT
                        restaurant.restaurantID,
                        restaurant.restaurantName,
                        restaurant.address,
                        restaurant.phone,
                        request_record.pickUpDate
                    FROM
                        restaurant
                        JOIN restaurant_staff_mapping ON restaurant_staff_mapping.restaurantID = restaurant.restaurantID
                        JOIN request_record ON request_record.userID = restaurant_staff_mapping.userID
                    WHERE
                        request_record.requestID = @requestID";

            try
            {
                using (var connection = new MySqlConnection(despatchConn.conndb.ConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@requestID", 119);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader and insert in TextBoxes
                                tbResID.Text = reader.GetString("restaurantID");
                                tbResName.Text = reader.GetString("restaurantName");
                                tbResContent.Text = reader.GetString("phone");
                                DateTime pickupDate = reader.GetDateTime("pickUpDate");
                                tbPickUpDate.Text = pickupDate.ToString("yyyy-MM-dd"); // Format the date as desired
                                tbRAdress.Text = reader.GetString("address");
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void setForm()
        {
            userID = Int32.Parse(User.UserID);

            try
            {
                using (var connection = new MySqlConnection(despatchConn.conndb.ConnectionString))
                {
                    connection.Open();

                    // Get the maximum despatchID from the despatch_instruction table
                    string getMaxDespatchIDQuery = "SELECT MAX(despatchID) FROM despatch_instruction";
                    using (var command = new MySqlCommand(getMaxDespatchIDQuery, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            maxDespatchID = (Convert.ToInt32(result)+1);
                        }
                        else
                        {
                            maxDespatchID = 0; // Default value if no data exists
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            if (DespatchConfirms != null)
            {
                foreach (UI.DespatchConfirm.DespatchConfirm confirmedItem in DespatchConfirms)
                {
                    int rowIndex = dgvDespatchList.Rows.Add();
                    dgvDespatchList.Rows[rowIndex].Cells[0].Value = confirmedItem.requestID;
                    dgvDespatchList.Rows[rowIndex].Cells[1].Value = confirmedItem.itemID;
                    dgvDespatchList.Rows[rowIndex].Cells[2].Value = confirmedItem.ItemName;
                    dgvDespatchList.Rows[rowIndex].Cells[3].Value = confirmedItem.requestQty;
                    dgvDespatchList.Rows[rowIndex].Cells[4].Value = confirmedItem.unit;
                    dgvDespatchList.Rows[rowIndex].Cells[5].Value = confirmedItem.itemStatus;
                }
            }

            requestID = dgvDespatchList.Rows[0].Cells[0].Value.ToString();
            tbPurchaseManagerID.Text = userID.ToString();
            tbDespatchID.Text = (maxDespatchID).ToString();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to submit the request?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; 
            }

            // Get the values to insert
            int despatchID = maxDespatchID;
            int purchaseManagerID = userID;
            int restaurantID = Int32.Parse(tbResID.Text);
            int requestID = Convert.ToInt32(dgvDespatchList.Rows[0].Cells[0].Value);

            try
            {
                using (var connection = new MySqlConnection(despatchConn.conndb.ConnectionString))
                {
                    connection.Open();

                    // Insert the values into the despatch_instruction table
                    string insertDespatchQuery = "INSERT INTO despatch_instruction (despatchID, purchaseManagerID, restaurantID, requestID) VALUES (@despatchID, @purchaseManagerID, @restaurantID, @requestID)";
                    using (var command = new MySqlCommand(insertDespatchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@despatchID", despatchID);
                        command.Parameters.AddWithValue("@purchaseManagerID", purchaseManagerID);
                        command.Parameters.AddWithValue("@restaurantID", restaurantID);
                        command.Parameters.AddWithValue("@requestID", requestID);
                        command.ExecuteNonQuery();
                    }

                    // Insert the values into the despatch_instruction_item_mapping table
                    foreach (DataGridViewRow row in dgvDespatchList.Rows)
                    {
                        int itemID = Convert.ToInt32(row.Cells[1].Value);
                        int requestQty = Convert.ToInt32(row.Cells[3].Value);
                        string unit = row.Cells[4].Value.ToString();

                        string insertMappingQuery = "INSERT INTO despatch_instruction_item_mapping (despatchitemMappingID,despatchID,ItemID, requestQty, unit) " +
                            "VALUES (@despatchitemMappingID,@despatchID,@itemID , @requestQty, @unit)";

                        string updateItemStatusQuery = "UPDATE request_item SET itemStatus = 'In Progress' WHERE requestID = @requestID";

                        string updateRequestStatusQuery = "UPDATE request_record SET status = 'Order Placed' WHERE requestID = @requestID";

                        using (var command = new MySqlCommand(updateItemStatusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@requestID", requestID);
                            command.ExecuteNonQuery();
                        }

                        using (var command = new MySqlCommand(updateRequestStatusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@requestID", requestID);
                            command.ExecuteNonQuery();
                        }

                        using (var command = new MySqlCommand(insertMappingQuery, connection))
                        {
                            command.Parameters.AddWithValue("@despatchitemMappingID", "");
                            command.Parameters.AddWithValue("@itemID", itemID);
                            command.Parameters.AddWithValue("@despatchID", despatchID);
                            command.Parameters.AddWithValue("@requestQty", requestQty);
                            command.Parameters.AddWithValue("@unit", unit);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            MessageBox.Show("Despatch Instruction Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel the despatch instruction form?",
                              "Confirm cancel!!",
                              MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblDespatch_Click(object sender, EventArgs e)
        {

        }
    }
}
