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
    public partial class AccountDeliveryNoteDetails : Form
    {
        private readonly Connection_class accountDeliveryDetailsConn = new Connection_class();
        private readonly DataTable accountDeliveryDetailsTable = new DataTable();
        public AccountDeliveryNoteDetails()
        {
            InitializeComponent();
        }

        private void AccountDeliveryNoteDetails_Load(object sender, EventArgs e)
        {
            if (lblDisplayStatus.Text != "Delivered")
            {
                btnCompleteDNote.Enabled = false;
            }
        }

        public void SetData(string deliveryID, string requestID, string restaurantID, string restaurantName, string contact,string deliveryDate, string createDate, string status, string address)
        {
            tbDeliveryNoteID.Text = deliveryID;
            tbRequestID.Text = requestID;
            tbRestaurantID.Text = restaurantID;
            tbRestaurantName.Text = restaurantName;
            tbContact.Text = contact;
            tbShipAddress.Text = address;
            dtpDeliveryDate.Text = deliveryDate;
            dtpCreateDate.Text = createDate;
            lblDisplayStatus.Text = status;
        }

        private void btnCompleteDNote_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure complete this delivery note ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }


            // Update query to set the status to "Completed"
            string updateQuery = "UPDATE delivery_note SET status = 'Completed' WHERE deliveryNoteID = @deliveryNoteID";

            using (var conn = new MySqlConnection(accountDeliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    // Set the deliveryID parameter value
                    cmd.Parameters.AddWithValue("@deliveryNoteID", tbDeliveryNoteID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Update the status label
                    lblDisplayStatus.Text = "Completed";
                }
            }

            // Update query to set the status to "Completed"
            string updateRequestRecordQuery = "UPDATE request_record SET status = 'Completed' WHERE requestID = @requestID";

            using (var conn = new MySqlConnection(accountDeliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(updateRequestRecordQuery, conn))
                {
                    // Set the deliveryID parameter value
                    cmd.Parameters.AddWithValue("@requestID", tbRequestID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            // Update query to set the status to "Completed"
            string updateRequestItemQuery = "UPDATE request_item SET itemStatus = 'Completed' WHERE requestID = @requestID";

            using (var conn = new MySqlConnection(accountDeliveryDetailsConn.conndb.ConnectionString))
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

