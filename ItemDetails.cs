using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class ItemDetails : Form
    {
        Connection_class itemManageConn = new Connection_class();
        private string query;
        public ItemDetails()
        {
            InitializeComponent();
        }

        private void ItemDetails_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string aID, string vID, string ItemName, string typeID, string typeName, string stockQty, string unit, string itemRemark)
        {
            // Set the data in the appropriate controls in the form
            tbAID.Text = aID;
            tbVID.Text = vID;
            tbItemName.Text = ItemName;
            tbTypeID.Text = typeID;
            tbItemType.Text = typeName;
            tbStockQty.Text = stockQty;
            tbUnit.Text = unit;
            tbItemRemark.Text = itemRemark;
        }

        /*        private string updateQuery;  
        */
        private void btnUpdateStockQty_Click(object sender, EventArgs e)
        {
            tbStockQty.ReadOnly = false;
            btnUpdateStockQty.Visible = false;
            btnModifyItem.Visible = false;
            btnConfirmStock.Visible = true;
            btnCancel.Visible = true;
            btnDeleteItem.Visible = false;
        }

        private void btnStockQtyConfirm_Click(object sender, EventArgs e)
        {

            if (tbStockQty.Text.Length == 0)
            {
                MessageBox.Show("The stock qty do not empty!");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to update the stock quantity to {tbStockQty.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int newStockQty = Convert.ToInt32(tbStockQty.Text);
                    int itemID = Convert.ToInt32(tbAID.Text);

                    string completeQuery = "UPDATE item SET stockItemQty = @newStockQty WHERE itemID = @itemID";  // Append the WHERE clause to the update query

                    using (MySqlConnection conn = itemManageConn.conndb)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(completeQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@newStockQty", newStockQty);
                            cmd.Parameters.AddWithValue("@itemID", itemID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Stock quantity updated successfully!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error updating stock quantity: " + ex.Message);
                }
                tbStockQty.ReadOnly = true;
                btnConfirmStock.Visible = false;
                btnUpdateStockQty.Visible = true;
                btnModifyItem.Visible = true;
                btnDeleteItem.Visible = true;
                btnCancel.Visible = false;
            }
        }

        private void tbStockQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTypeID_TextChanged(object sender, EventArgs e)
        {
            string typeID = tbTypeID.Text.Trim();

            // Check if the entered type ID exists in the item_type table
            string query = "SELECT typeName FROM item_type WHERE itemTypeID = @typeID";
            using (MySqlConnection conn = itemManageConn.conndb)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@typeID", typeID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) // Type ID exists in the item_type table
                    {
                        tbItemType.Text = result.ToString(); // Set the item type text box
                    }
                    else
                    {
                        tbItemType.Text = string.Empty; // Clear the item type text box
                    }
                }
            }
        }


        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            tbUnit.ReadOnly = false;
            tbItemRemark.ReadOnly = false;
            tbUnit.ReadOnly = false;
            tbTypeID.ReadOnly = false;
            btnModifyItem.Visible = false;
            btnUpdateStockQty.Visible = false;
            btnDeleteItem.Visible = false;
            btnModifyConfirm.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnModifyConfirm_Click(object sender, EventArgs e)
        {
            if (tbItemType.Text.Length == 0)
            {
                MessageBox.Show("Please check your Type ID is correct!");
                return;
            }

            if (tbUnit.Text.Length == 0)
            {
                MessageBox.Show("The unit cannot be empty!");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to update the actual item ID: {tbAID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int itemID = Convert.ToInt32(tbAID.Text);
                    int typeID = Convert.ToInt32(tbTypeID.Text);
                    string unit = tbUnit.Text;
                    string remark = tbItemRemark.Text;

                    string updateQuery = "UPDATE item SET typeID = @typeID, unit = @unit, remark = @remark WHERE itemID = @itemID";

                    using (MySqlConnection conn = itemManageConn.conndb)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@typeID", typeID);
                            cmd.Parameters.AddWithValue("@unit", unit);
                            cmd.Parameters.AddWithValue("@remark", remark);
                            cmd.Parameters.AddWithValue("@itemID", itemID);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item details updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Nothing change in this modify!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating item details: " + ex.Message);
                }

                btnModifyConfirm.Visible = false;
                btnModifyItem.Visible = true;
                tbTypeID.ReadOnly = true;
                tbUnit.ReadOnly = true;
                tbItemRemark.ReadOnly = true;
                btnUpdateStockQty.Visible = true;
                btnDeleteItem.Visible = true;
                btnCancel.Visible = false;
            }
        }

        private void tbTypeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete item ID: {tbAID.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int itemID = Convert.ToInt32(tbAID.Text);

                    using (MySqlConnection conn = itemManageConn.conndb)
                    {
                        conn.Open();

                        // Delete vidmapping records with matching aID (itemID)
                        string deleteVidMappingQuery = "DELETE FROM vidmapping WHERE aID = @itemID";
                        using (MySqlCommand deleteVidMappingCmd = new MySqlCommand(deleteVidMappingQuery, conn))
                        {
                            deleteVidMappingCmd.Parameters.AddWithValue("@itemID", itemID);
                            deleteVidMappingCmd.ExecuteNonQuery();
                        }

                        // Delete the item record
                        string deleteItemQuery = "DELETE FROM item WHERE itemID = @itemID";
                        using (MySqlCommand deleteItemCmd = new MySqlCommand(deleteItemQuery, conn))
                        {
                            deleteItemCmd.Parameters.AddWithValue("@itemID", itemID);
                            int rowsAffected = deleteItemCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item deleted successfully!");
                                // Close the ItemDetails form or perform any other necessary actions
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete item.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting item:  as refer other data!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbStockQty.ReadOnly = true;
            tbTypeID.ReadOnly = true;
            tbUnit.ReadOnly = true;
            tbItemRemark.ReadOnly = true;
            btnCancel.Visible = false;
            btnModifyConfirm.Visible = false;
            btnUpdateStockQty.Visible = true;
            btnModifyItem.Visible = true;
            btnDeleteItem.Visible = true;
            btnConfirmStock.Visible = false;
        }
    }
}
