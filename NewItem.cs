using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using UI.connMySql;

namespace UI
{
    public partial class NewItem : Form
    {

        Connection_class newItemConn = new Connection_class();
        public NewItem()
        {
            InitializeComponent();
        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            PopulateItemNames();
            cbNewItemID.SelectedIndex = 0;
        }



        private void PopulateItemNames()
        {
            string query = "SELECT itemID FROM item LEFT JOIN vidmapping ON item.itemID = vidmapping.aID WHERE vidmapping.aID IS NULL";
            using (var conn = new MySqlConnection(newItemConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        cbNewItemID.Items.Clear();
                        while (reader.Read())
                        {
                            string newItemID = reader.GetString("itemID");
                            cbNewItemID.Items.Add(newItemID);
                        }
                        reader.Close();
                    }
                }
            }
        }

        private void cbNewItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedNewItemID = cbNewItemID.SelectedItem.ToString();

                // Retrieve the data for the selected item
                string query = "SELECT i.* FROM item i LEFT JOIN vidmapping v ON i.itemID = v.aID WHERE v.aID IS NULL AND itemID = @itemID";

                using (var conn = new MySqlConnection(newItemConn.conndb.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemID", selectedNewItemID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                tbItemName.Text = reader.GetString("itemName");
                                tbSupplierID.Text = reader.GetString("supplierID");
                                tbTypeID.Text = reader.GetString("typeID");
                                tbCategoryID.Text = reader.GetString("categoryID");
                                tbBrand.Text = reader.GetString("brand");
                                tbStockQty.Text = reader.GetString("stockItemQty");
                                tbUnit.Text = reader.GetString("unit");
                                tbItemRemark.Text = reader.IsDBNull(reader.GetOrdinal("remark")) ? string.Empty : reader.GetString("remark");
                            }
                            reader.Close();
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbTypeID_TextChanged(object sender, EventArgs e)
        {
            string typeID = tbTypeID.Text.Trim();

            // Check if the entered type ID exists in the item_type table
            string query = "SELECT typeName FROM item_type WHERE itemTypeID = @typeID";
            using (MySqlConnection conn = newItemConn.conndb)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@typeID", typeID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) // Type ID exists in the item_type table
                    {
                        tbTypeName.Text = result.ToString();
                    }
                    else
                    {
                        tbTypeName.Text = string.Empty; // Clear the item type text box
                    }
                }
            }
        }

        private void tbCategoryID_TextChanged(object sender, EventArgs e)
        {
            string categoryID = tbCategoryID.Text.Trim();

            // Check if the entered Category ID exists in the item_category table
            string query = "SELECT categoryName FROM item_category WHERE categoryID = @categoryID";
            using (MySqlConnection conn = newItemConn.conndb)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) // Category ID exists in the item_category table
                    {
                        tbCategoryName.Text = result.ToString();
                    }
                    else
                    {
                        tbCategoryName.Text = string.Empty; // Clear the category name text box
                    }
                }
            }
        }

        private void tbSupplierID_TextChanged(object sender, EventArgs e)
        {
            string supplierID = tbSupplierID.Text.Trim();

            // Check if the entered supplier ID exists in the supplier table
            string query = "SELECT companyName FROM supplier WHERE supplierID = @supplierID";
            using (MySqlConnection conn = newItemConn.conndb)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) // supplier ID exists in the supplier table
                    {
                        tbSupplierName.Text = result.ToString();
                    }
                    else
                    {
                        tbSupplierName.Text = string.Empty; // Clear the ssupplier name text box
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the new item ID: {cbNewItemID.SelectedItem}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string selectedNewItemID = cbNewItemID.SelectedItem.ToString();

                string query = "DELETE FROM item WHERE itemID = @itemID";

                using (var conn = new MySqlConnection(newItemConn.conndb.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemID", selectedNewItemID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form fields or refresh the data
                            ClearFields();
                            PopulateItemNames();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void ClearFields()
        {
            // Clear all input fields
            tbItemName.Text = string.Empty;
            tbTypeID.Text = string.Empty;
            tbCategoryID.Text = string.Empty;
            tbSupplierID.Text = string.Empty;
            tbStockQty.Text = string.Empty;
            tbUnit.Text = string.Empty;
            tbBrand.Text = string.Empty;
            tbItemRemark.Text = string.Empty;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            tbItemName.ReadOnly = false;
            tbTypeID.ReadOnly = false;
            tbCategoryID.ReadOnly = false;
            tbSupplierID.ReadOnly = false;
            tbStockQty.ReadOnly = false;
            tbUnit.ReadOnly = false;
            tbBrand.ReadOnly = false;
            tbItemRemark.ReadOnly = false;
            btnDelete.Visible = false;
            btnModify.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OriginForm();
        }

        private void OriginForm()
        {
            tbItemName.ReadOnly = true;
            tbTypeID.ReadOnly = true;
            tbCategoryID.ReadOnly = true;
            tbSupplierID.ReadOnly = true;
            tbStockQty.ReadOnly = true;
            tbUnit.ReadOnly = true;
            tbBrand.ReadOnly = true;
            tbItemRemark.ReadOnly = true;
            btnDelete.Visible = true;
            btnModify.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the new item ID: {cbNewItemID.SelectedItem}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string selectedNewItemID = cbNewItemID.SelectedItem.ToString();

                    // Retrieve the updated values from the input fields
                    string itemName = tbItemName.Text.Trim();
                    string supplierID = tbSupplierID.Text.Trim();
                    string typeID = tbTypeID.Text.Trim();
                    string categoryID = tbCategoryID.Text.Trim();
                    string brand = tbBrand.Text.Trim();
                    string stockQty = tbStockQty.Text.Trim();
                    string unit = tbUnit.Text.Trim();
                    string itemRemark = tbItemRemark.Text.Trim();

                    // Update the item in the item table
                    string query = "UPDATE item SET itemName = @itemName, supplierID = @supplierID, typeID = @typeID, categoryID = @categoryID, brand = @brand, stockItemQty = @stockQty, unit = @unit, remark = @itemRemark WHERE itemID = @itemID";

                    using (var conn = new MySqlConnection(newItemConn.conndb.ConnectionString))
                    {
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@itemName", itemName);
                            cmd.Parameters.AddWithValue("@supplierID", supplierID);
                            cmd.Parameters.AddWithValue("@typeID", typeID);
                            cmd.Parameters.AddWithValue("@categoryID", categoryID);
                            cmd.Parameters.AddWithValue("@brand", brand);
                            cmd.Parameters.AddWithValue("@stockQty", stockQty);
                            cmd.Parameters.AddWithValue("@unit", unit);
                            cmd.Parameters.AddWithValue("@itemRemark", itemRemark);
                            cmd.Parameters.AddWithValue("@itemID", selectedNewItemID);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the form fields and refresh the data
                                ClearFields();
                                PopulateItemNames();
                                OriginForm();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
