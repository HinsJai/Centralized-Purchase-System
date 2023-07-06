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

namespace UI
{
    public partial class ResDeliveryNoteDetails : Form
    {
        private readonly Connection_class resDeliveryDetailsConn = new Connection_class();
        private readonly DataTable resDeliveryDetailsTable = new DataTable();
        public ResDeliveryNoteDetails()
        {
            InitializeComponent();
        }

        private void ResDeliveryNoteDetails_Load(object sender, EventArgs e)
        {
            if(lblDisplayStatus.Text != "In Progress")
            {
                btnReceiveItem.Enabled = false;
            }
            else
            {
                btnReceiveItem.Enabled = true;
            }
        }

        public void SetData(string deliveryID, string requestID,string restaurantID, string restaurantName, string address, string deliveryDate, string status)
        {
            tbDeliveryNoteID.Text = deliveryID;
            tbRequestID.Text = requestID;
            tbRestaurantID.Text = restaurantID;
            tbRestaurantName.Text = restaurantName;
            tbShipAddress.Text = address;
            dtpDeliveryDate.Text = deliveryDate;
            lblDisplayStatus.Text = status;
            setDeliveryItem();
        }

        private void setDeliveryItem()
        {
            // Get the delivery ID from the text box
            string deliveryID = tbDeliveryNoteID.Text;

            // Query to select delivery item data
            string itemQuery = "SELECT itemID, itemName, qty, unit FROM delivery_note_item WHERE deliveryID = @deliveryID";

            using (var conn = new MySqlConnection(resDeliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(itemQuery, conn))
                {
                    // Set the deliveryID parameter value
                    cmd.Parameters.AddWithValue("@deliveryID", deliveryID);

                    conn.Open();

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        // Clear existing data in the DataTable
                        resDeliveryDetailsTable.Clear();

                        // Fill the DataTable with the delivery item data
                        adapter.Fill(resDeliveryDetailsTable);
                    }
                }
            }
            // Display the delivery item data in the DataGridView
            dgvDeliveryitemList.DataSource = resDeliveryDetailsTable;
        }

        private void btnReceiveItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure receive the  items ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }


                // Update query to set the status to "Delivered"
                string updateQuery = "UPDATE delivery_note SET status = 'Delivered' WHERE deliveryNoteID = @deliveryNoteID";

            using (var conn = new MySqlConnection(resDeliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    // Set the deliveryID parameter value
                    cmd.Parameters.AddWithValue("@deliveryNoteID", tbDeliveryNoteID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Update the status label
                    lblDisplayStatus.Text = "Delivered";
                }
            }

            // Update query to set the status to "Delivered"
            string updateRequestRecordQuery = "UPDATE request_record SET status = 'Delivered' WHERE requestID = @requestID";

            using (var conn = new MySqlConnection(resDeliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(updateRequestRecordQuery, conn))
                {
                    // Set the deliveryID parameter value
                    cmd.Parameters.AddWithValue("@requestID", tbRequestID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Update the status label
                }
            }
            // Update query to set the status to "Delivered"
            string updateRequestItemQuery = "UPDATE request_item SET itemStatus = 'Delivered' WHERE requestID = @requestID";

            using (var conn = new MySqlConnection(resDeliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(updateRequestItemQuery, conn))
                {
                    // Set the requestID parameter value
                    cmd.Parameters.AddWithValue("@requestID", tbRequestID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
