using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UI.connMySql;
using UI.InventoryControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class InventoryStockUpdate : Form
    {
        public event EventHandler QuantityUpdated;

        Connection_class updateStockConn = new Connection_class();
        private int itemID;
        private string itemName;
        private string status;
        private string unit;
        private int updateStockQty;

        public InventoryStockUpdate(int itemID, string itemName, string status, string unit, int stockQty)
        {
            InitializeComponent();
            this.itemID = itemID;
            this.itemName = itemName;
            this.status = status;
            this.unit = unit;
            this.updateStockQty = stockQty;
        }

        private void InventoryStockUpdate_Load(object sender, EventArgs e)
        {
            setItemStock();

        }

        private void setItemStock()
        {
            tbItemID.Text = itemID.ToString();
            tbItemName.Text = itemName;
            tbStockQty.Text = updateStockQty.ToString();
            tbUnit.Text = unit;
            tbStockStatus.Text = status;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnUpdateStock.Visible = true;
            tbStockQty.ReadOnly = true;
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            tbStockQty.ReadOnly = false;
            btnCancel.Visible = true;
            btnConfirm.Visible = true;
            btnUpdateStock.Visible = false;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {

            StockControl stockControl = new StockControl();
            string sql = "UPDATE item SET stockItemQty = @stockQty WHERE itemID = @itemID";

            int updateStockQty = Convert.ToInt32(tbStockQty.Text);

            try
            {
                DialogResult result = MessageBox.Show($"Are you sure update stock qty to {tbStockQty.Text} in item ID: {itemID}  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    using (MySqlConnection conn = new MySqlConnection(updateStockConn.conndb.ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@stockQty", tbStockQty.Text);
                            cmd.Parameters.AddWithValue("@itemID", itemID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Update Item Stock successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Stock Item.");
                            }

                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnCancel.Visible = false;
            btnConfirm.Visible = false;
            btnUpdateStock.Visible = true;
            tbStockQty.ReadOnly = true;
        }

        private void tbStockQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
