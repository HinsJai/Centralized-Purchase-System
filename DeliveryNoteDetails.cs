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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class DeliveryNoteDetails : Form
    {
        private readonly Connection_class deliveryDetailsConn = new Connection_class();
        private readonly DataTable deliveryDetailsTAble = new DataTable();

        public DeliveryNoteDetails()
        {
            InitializeComponent();
        }

        private void DeliveryNoteDetails_Load(object sender, EventArgs e)
        {
        }

        public void SetData(string deliveryID, string restaurantName, string restaurantContact, string deliveryDate, string createDate, string status, string address)
        {
            tbDeliveryNoteID.Text = deliveryID;
            tbRestaurantName.Text = restaurantName;
            tbRestaurantContact.Text = restaurantContact;
            tbShipAddress.Text = address;
            dtpDeliveryDate.Text = deliveryDate;
            dtpCreateDate.Text = createDate;
            lblDisplayStatus.Text = status;
            setDeliveryItem();

        }

        private void setDeliveryItem()
        {
            // Get the delivery ID from the text box
            string deliveryID = tbDeliveryNoteID.Text;

            // Query to select delivery item data
            string itemQuery = "SELECT itemID, itemName, qty, unit FROM delivery_note_item WHERE deliveryID = @deliveryID";

            using (var conn = new MySqlConnection(deliveryDetailsConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(itemQuery, conn))
                {
                    // Set the deliveryID parameter value
                    cmd.Parameters.AddWithValue("@deliveryID", deliveryID);

                    conn.Open();

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        // Clear existing data in the DataTable
                        deliveryDetailsTAble.Clear();

                        // Fill the DataTable with the delivery item data
                        adapter.Fill(deliveryDetailsTAble);
                    }
                }
            }

            // Display the delivery item data in the DataGridView
            dgvDeliveryitemList.DataSource = deliveryDetailsTAble;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
