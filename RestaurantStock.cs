using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace UI
{


    public partial class RestaurantStock : Form
    {
        Connection_class updateStockConn = new Connection_class();
        private int restaurantID;
        private int itemID;
        private string itemName;
        private string status;
        private string unit;
        private int updateStockQty;
        private string updateStatus;


        public RestaurantStock(int restaurantID, int itemID , string itemName, string status, string  unit, int stockQty)
        {
            InitializeComponent();
            this.restaurantID = restaurantID;
            this.itemID = itemID;
            this.itemName = itemName;
            this.status = status;
            this.unit = unit;
            this.updateStockQty = stockQty;
        }

        private void RestaurantStock_Load(object sender, EventArgs e)
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
            tbRestaurantID.Text = restaurantID.ToString();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            tbStockQty.ReadOnly = false;
            btnCancel.Visible = true;
            btnConfirm.Visible = true;
            btnUpdateStock.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnUpdateStock.Visible = true;
            tbStockQty.ReadOnly = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE restaurant_stock SET stockQty = @stockQty, stockStatus = ";

            int updateStockQty = Convert.ToInt32(tbStockQty.Text);


            if (unit == "kilograms")
               
            {
                if (updateStockQty < 100 && updateStockQty > 0) {
                sql+= "'Low' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }else if (updateStockQty >= 100)
                {
                    sql += "'Normal' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }else if(updateStockQty == 0)
                {
                    sql += "'Out of Stock' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
            }

            if(unit == "pieces")
            {
                if (updateStockQty < 200 && updateStockQty > 0)
                {
                    sql += "'Low' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty >=200)
                {
                    sql += "'Normal' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty == 0)
                {
                    sql += "'Out of Stock' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
            }

            if(unit == "dozen")
            {
                if (updateStockQty < 100 && updateStockQty > 0)
                {
                    sql += "'Low' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty >= 100)
                {
                    sql += "'Normal' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty == 0)
                {
                    sql += "'Out of Stock' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
            }

            if (unit == "box")
            {
                if (updateStockQty < 10 && updateStockQty > 0)
                {
                    sql += "'Low' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty >= 10)
                {
                    sql += "'Normal' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty == 0)
                {
                    sql += "'Out of Stock' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
            }

            if(unit == "sets")
            {
                if (updateStockQty < 50 && updateStockQty > 0)
                {
                    sql += "'Low' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty >= 50)
                {
                    sql += "'Normal' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
                else if (updateStockQty == 0)
                {
                    sql += "'Out of Stock' WHERE restaurantID = @restaurantID AND itemID = @itemID";
                }
            }

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
                            cmd.Parameters.AddWithValue("@restaurantID", restaurantID);
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
            }catch (Exception ex)
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

        private void lblStock_Click(object sender, EventArgs e)
        {

        }
    }
}
