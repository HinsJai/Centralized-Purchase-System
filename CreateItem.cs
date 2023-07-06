using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI
{
    public partial class CreateItem : Form
    {
        private readonly Connection_class createItemConn = new Connection_class();
        private int nextItemID;
        /*        private MySqlConnection conn;
        */
        private int typeID;
        private string typeName;
        private int categoryID;
        private string categoryName;
        private string supplierID;
        private string supplierName;
        public CreateItem()
        {
            InitializeComponent();
            /*            conn = createItemConn.conndb;
            */
        }

        private void CreateItem_Load(object sender, EventArgs e)
        {
            GetMaxItemID();
            PopulateAllComboBox();
            tbItemID.Text = nextItemID.ToString();
        }

        // Get the next item ID
        private void GetMaxItemID()
        {
            try
            {
                using (MySqlConnection conn = createItemConn.conndb)
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(itemID), 0) + 1 AS nextID FROM item";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        nextItemID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the next item ID: " + ex.Message);
            }
        }

        private void tbStockQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbItemName.TextLength>0 && cbTypeID.SelectedIndex != -1  && cbCategoryID.SelectedIndex != -1 && cbSupplierID.SelectedIndex != -1
                 && tbStockQty.TextLength > 0 && tbUnit.TextLength > 0 && tbBrand.TextLength > 0)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to create item ID: {tbItemID.Text} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = createItemConn.conndb)
                        {
                            conn.Open();
                            string query = "INSERT INTO item (itemID, supplierID, typeID, categoryID, itemName, brand, remark, stockItemQty, unit) VALUES (@itemID, @supplierID, @typeID, @categoryID, @itemName, @brand, @remark, @stockItemQty, @unit)";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@itemID", tbItemID.Text.Trim());
                                cmd.Parameters.AddWithValue("@supplierID", supplierID);
                                cmd.Parameters.AddWithValue("@typeID",typeID);
                                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                                cmd.Parameters.AddWithValue("@itemName", tbItemName.Text.Trim());
                                cmd.Parameters.AddWithValue("@brand", tbBrand.Text.Trim());
                                cmd.Parameters.AddWithValue("@remark", tbItemRemark.Text.Trim());
                                cmd.Parameters.AddWithValue("@stockItemQty", Convert.ToInt32(tbStockQty.Text.Trim()));
                                cmd.Parameters.AddWithValue("@unit", tbUnit.Text.Trim());

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Item created successfully!");
                                    conn.Close();
                                    ClearFields();
                                    GetMaxItemID();
                                    tbItemID.Text = nextItemID.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to create item.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error:  " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.");
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure reset the create form ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearFields();
            }
        }
        private void ClearFields()
        {
            // Clear all input fields
            cbTypeID.SelectedIndex = -1;
            cbTypeName.SelectedIndex = -1;
            cbCategoryID.SelectedIndex = -1;
            cbCategoryName.SelectedIndex = -1;
            cbSupplierID.SelectedIndex = -1;
            cbSupplierName.SelectedIndex = -1;
            tbStockQty.Text = string.Empty;
            tbUnit.Text = string.Empty;
            tbBrand.Text = string.Empty;
            tbItemRemark.Text = string.Empty;
        }

        private void PopulateAllComboBox()
        {
            try
            {
                cbTypeID.Items.Clear();
                cbTypeName.Items.Clear();
                cbCategoryID.Items.Clear();
                cbCategoryName.Items.Clear();
                cbSupplierID.Items.Clear();
                cbSupplierName.Items.Clear();

                using (MySqlConnection conn = createItemConn.conndb)
                {
                    conn.Open();

                    string typeQuery = "SELECT * FROM item_type";
                    using (MySqlCommand cmd = new MySqlCommand(typeQuery, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int typeID = reader.GetInt32("itemTypeID");
                               string typeName = reader.GetString("typeName");

                                cbTypeID.Items.Add(typeID);
                                cbTypeName.Items.Add(typeName);

                            }
                        }
                    }

                    string categoryQuery = "SELECT * FROM item_category";
                    using (MySqlCommand cmd = new MySqlCommand(categoryQuery, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int categoryID = reader.GetInt32("categoryID");
                                string categoryName = reader.GetString("categoryName");

                                cbCategoryID.Items.Add(categoryID);
                                cbCategoryName.Items.Add(categoryName);

                            }
                        }
                    }

                    string supplierQuery = "SELECT supplierID, companyName FROM supplier";
                    using (MySqlCommand cmd = new MySqlCommand(supplierQuery, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string supplierID = reader.GetString("supplierID");
                                string supplierName = reader.GetString("companyName");

                                cbSupplierID.Items.Add(supplierID);
                                cbSupplierName.Items.Add(supplierName);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTypeID.SelectedIndex != -1)
                {
                    int selectedIndex = cbTypeID.SelectedIndex;
                    cbTypeName.SelectedIndex = selectedIndex;
                    typeID = Convert.ToInt32(cbTypeID.SelectedItem);
                    typeName = cbTypeName.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTypeName.SelectedIndex != -1)
                {
                    int selectedIndex = cbTypeName.SelectedIndex;
                    cbTypeID.SelectedIndex = selectedIndex;
                    typeID = Convert.ToInt32(cbTypeID.SelectedItem);
                    typeName = cbTypeName.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCategoryID.SelectedIndex != -1)
                {
                    int selectedIndex = cbCategoryID.SelectedIndex;
                    cbCategoryName.SelectedIndex = selectedIndex;
                    categoryID = Convert.ToInt32(cbCategoryID.SelectedItem);
                    categoryName = cbCategoryName.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCategoryName.SelectedIndex != -1)
                {
                    int selectedIndex = cbCategoryName.SelectedIndex;
                    cbCategoryID.SelectedIndex = selectedIndex;
                    categoryID = Convert.ToInt32(cbCategoryID.SelectedItem);
                    categoryName = cbCategoryName.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierID.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierID.SelectedIndex;
                    cbSupplierName.SelectedIndex = selectedIndex;
                    supplierID = cbSupplierID.SelectedItem.ToString();
                    supplierName = cbSupplierName.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierName.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierName.SelectedIndex;
                    cbSupplierID.SelectedIndex = selectedIndex;
                    supplierID = cbSupplierID.SelectedItem.ToString();
                    supplierName = cbSupplierName.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

