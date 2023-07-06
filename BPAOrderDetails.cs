using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;
using System.Drawing;

namespace UI
{
    public partial class BPAOrderDetails : Form
    {

        Connection_class bpaOrderConn = new Connection_class();
        private int itemID;


        public BPAOrderDetails()
        {
            InitializeComponent();
        }

        private void BPAOrderDetails_Load(object sender, EventArgs e)
        {
          
        }


        private void getItemType(string aID)
        {
            using (var conn = new MySqlConnection(bpaOrderConn.conndb.ConnectionString))
            {
                string query = "SELECT typeName FROM item_type " +
                               "INNER JOIN item ON item.typeID = item_type.itemTypeID " +
                               "WHERE item.itemID = @itemID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemID", tbItemAID.Text);
                    conn.Open();
                    var typeName = cmd.ExecuteScalar()?.ToString();
                    if (!string.IsNullOrEmpty(typeName))
                    {
                        tbitemType.Text = typeName;
                    }
                    else
                    {
                        tbitemType.Text = "";
                    }
                }
            }
        }

        public void SetData(string orderID, string orderType, string agreementID, string itemID, string  itemName, string orderQty, string unit, string pickUpDate,string remark, string status)
        {
            tbOrderID.Text = orderID;
            tbOrderType.Text = orderType;
            tbAgreementID.Text = agreementID;
            tbItemAID.Text = itemID;
            tbItemName.Text = itemName;
            tbOrderQty.Text = orderQty;
            lblUnitDisplay.Text = unit;
            dtpPickUpDate.Text = pickUpDate;
            tbOrderRemark.Text = remark;
            lblDisplayStatus.Text = status;
            getItemType(tbItemAID.Text);

            if (lblDisplayStatus.Text == "Completed" || lblDisplayStatus.Text == "Cancelled")
            {
                btnCancelOrder.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            using (var conn = new MySqlConnection(bpaOrderConn.conndb.ConnectionString))
            {
                string query = "UPDATE orders " +
                               "SET status = 'Cancelled' " +
                               "WHERE orderID = @orderID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", tbOrderID.Text);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order cancelled successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel the order.");
                    }
                }
            }
        }
    }
}
