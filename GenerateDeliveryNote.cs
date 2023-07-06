using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    public partial class GenerateDeliveryNote : Form
    {
        private string restaurantID;
        private string deliveryNoteID;
        private string despatchID;
        private string requestID;

        private readonly Connection_class DeliveryConn = new Connection_class();
        public GenerateDeliveryNote()
        {
            InitializeComponent();
        }

        private void GenerateDeliveryNote_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string requestID,string tbDespatch,string restaurantID, string restaurantName, string restaurantContact, string shipAdress, DataTable despatchDetailsTable)
        {
            tbRestaurantName.Text = restaurantName;
            tbRestaurantContact.Text = restaurantContact;
            tbShipAddress.Text = shipAdress;
            this.restaurantID = restaurantID;
            this.despatchID = tbDespatch;
            this.requestID = requestID;
            getDeliveryNoteMaxID();
            tbDeliveryNoteID.Text = deliveryNoteID;
            tbHiddenRequestID.Text = requestID;

            foreach (DataRow row in despatchDetailsTable.Rows)
            {
                int n = dgvDeliveryitemList.Rows.Add();
                dgvDeliveryitemList.Rows[n].Cells[0].Value = row["itemID"].ToString();
                dgvDeliveryitemList.Rows[n].Cells[1].Value = row["vName"].ToString();
                dgvDeliveryitemList.Rows[n].Cells[2].Value = row["requestQty"].ToString();
                dgvDeliveryitemList.Rows[n].Cells[3].Value = row["unit"].ToString();
            }
        }

        private void btnGenerateDNote_Click(object sender, EventArgs e)
        {
            // Confirm with the user before generating the delivery note
            DialogResult result = MessageBox.Show("Are you sure you want to generate the delivery note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Check if the selected delivery date is not earlier than today
                    if (dtpDeliveryDate.Value.Date < DateTime.Today)
                    {
                        MessageBox.Show("Invalid delivery date. Please select a date not earlier than today.");
                        return;
                    }

                    using (var conn = new MySqlConnection(DeliveryConn.conndb.ConnectionString))
                    {
                        conn.Open();
                        var transaction = conn.BeginTransaction();

                        try
                        {
                            // Prepare the SQL query to insert into delivery_note table
                            string insertQuery = "INSERT INTO delivery_note (despatchID, deliveryNoteID, restaurantID, restaurantName, restaurantContact, shipAddress, deliveryDate, createDate, status,requestID) " +
                                       "VALUES (@despatchID, @deliveryNoteID, @restaurantID, @restaurantName, @restaurantContact, @shipAddress, @deliveryDate, @createDate, @status,@requestID)";

                            using (var insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                // Set the parameter values for delivery_note insertion
                                insertCmd.Parameters.AddWithValue("@despatchID", despatchID);
                                insertCmd.Parameters.AddWithValue("@deliveryNoteID", tbDeliveryNoteID.Text);
                                insertCmd.Parameters.AddWithValue("@restaurantID", restaurantID);
                                insertCmd.Parameters.AddWithValue("@restaurantName", tbRestaurantName.Text);
                                insertCmd.Parameters.AddWithValue("@restaurantContact", tbRestaurantContact.Text);
                                insertCmd.Parameters.AddWithValue("@shipAddress", tbShipAddress.Text);
                                insertCmd.Parameters.AddWithValue("@deliveryDate", dtpDeliveryDate.Value.Date);
                                insertCmd.Parameters.AddWithValue("@createDate", DateTime.Now.Date);
                                insertCmd.Parameters.AddWithValue("@status", "In Progress");
                                insertCmd.Parameters.AddWithValue("@requestID", requestID);

                                // Execute the insert query
                                insertCmd.ExecuteNonQuery();
                            }

                            // Prepare the SQL query to update despatch_instruction status to "Completed"
                            string updateQuery = "UPDATE despatch_instruction SET status = 'Completed' WHERE despatchID = @despatchID";

                            using (var updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                // Set the parameter value for despatch_instruction update
                                updateCmd.Parameters.AddWithValue("@despatchID", despatchID);

                                // Execute the update query
                                updateCmd.ExecuteNonQuery();
                            }

                            // Insert the delivery items into the delivery_note_item table
                            foreach (DataGridViewRow row in dgvDeliveryitemList.Rows)
                            {
                                int itemID = Convert.ToInt32(row.Cells[0].Value);
                                string itemName = row.Cells[1].Value.ToString();
                                int qty = Convert.ToInt32(row.Cells[2].Value);
                                string unit = row.Cells[3].Value.ToString();

                                // Prepare the SQL query to insert into delivery_note_item table
                                string insertItemQuery = "INSERT INTO delivery_note_item (deliveryID, itemID, itemName, qty, unit) " +
                                                         "VALUES ( @deliveryID, @itemID, @itemName, @qty, @unit)";

                                using (var insertItemCmd = new MySqlCommand(insertItemQuery, conn))
                                {
                                    // Generate a unique ID for the delivery note item
                                    string deliveryNoteItemID = deliveryNoteID;

                                    // Set the parameter values for delivery_note_item insertion
                                    insertItemCmd.Parameters.AddWithValue("@deliveryID", tbDeliveryNoteID.Text);
                                    insertItemCmd.Parameters.AddWithValue("@itemID", itemID);
                                    insertItemCmd.Parameters.AddWithValue("@itemName", itemName);
                                    insertItemCmd.Parameters.AddWithValue("@qty", qty);
                                    insertItemCmd.Parameters.AddWithValue("@unit", unit);

                                    // Execute the insert query for delivery_note_item
                                    insertItemCmd.ExecuteNonQuery();

                                    string getAID = "SELECT aID FROM vidmapping WHERE vID = @itemID";
                                    int aID;
                                    using (var getAIDCmd = new MySqlCommand(getAID, conn))
                                    {
                                        getAIDCmd.Parameters.AddWithValue("@itemID", itemID);
                                        using (var reader = getAIDCmd.ExecuteReader())
                                        {
                                            while (reader.Read())
                                            {
                                                 aID = Convert.ToInt32(reader["aID"]);
                                                UpdateItemQuantity(aID, qty);
                                            }
                                        }
                                    }

                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Delivery note generated successfully!");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error generating delivery note: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the process
                    MessageBox.Show("Error generating delivery note: " + ex.Message);
                }
            }
        }

        private void UpdateItemQuantity(int aID, int quantity)
        {
            try
            {
                using (var conn = new MySqlConnection(DeliveryConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE item SET stockItemQty = stockItemQty - @quantity WHERE itemID = @itemID";


                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@itemID", aID);
                        updateCmd.Parameters.AddWithValue("@quantity", quantity);

                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process
                MessageBox.Show("Error updating item quantity: " + ex.Message);
            }
        }


        private void getDeliveryNoteMaxID()
        {
            try
            {
                using (var conn = new MySqlConnection(DeliveryConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // Retrieve the latest ContractNumber from the database

                    query = "SELECT MAX(CONVERT(SUBSTRING(deliveryNoteID, 4), UNSIGNED INTEGER)) AS MaxDeliveryNoteNumber FROM delivery_note";


                    using (var command = new MySqlCommand(query, conn))
                    {
                        object result = command.ExecuteScalar();

                        // Parse the numeric part of the ContractNumber
                        int maxContractNumber = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        int nextContractNumber = maxContractNumber + 1;

                        // Generate the next ContractNumber with the format "dxxxx"
                        deliveryNoteID = "d" + nextContractNumber.ToString("00000");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process
                MessageBox.Show(ex.Message);
            }
        }
    }
}
