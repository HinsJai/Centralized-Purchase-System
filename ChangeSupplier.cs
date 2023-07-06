using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UI.connMySql;

namespace UI
{
    public partial class ChangeSupplier : Form
    {
        private int itemID;
        private string query;
        private readonly Connection_class changeSupplierConn = new Connection_class();

        public ChangeSupplier(int itemID)
        {
            InitializeComponent();
            this.itemID = itemID;
        }

        private void ChangeSupplier_Load(object sender, EventArgs e)
        {
            setSupplierData();
            /*   if (tbSupplierID.Text == "")
               {
                   btnDeleteSupplier.Visible = false;
               }
               else
               {
                   lblChangeSupplier.Text = "Change Supplier";
               }*/
        }

        private void setSupplierData()
        {
            try
            {
                // Retrieve the data from the database
                query = "SELECT item.itemID, item.itemName, item_type.typeName, item_category.categoryName, item.brand, supplier.* " +
                                 "FROM item " +
                                 "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
                                 "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
                                 "LEFT JOIN supplier ON item.supplierID = supplier.supplierID " +
                                 "WHERE item.itemID = @ItemID";

                using (var conn = new MySqlConnection(changeSupplierConn.conndb.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader and insert in textbox
                                tbAID.Text = itemID.ToString();
                                tbBrand.Text = reader.GetString("brand");
                                tbCategory.Text = reader.GetString("categoryName");
                                tbItemType.Text = reader.GetString("typeName");
                                tbItemName.Text = reader.GetString("itemName");
                                tbSupplierID.Text = reader.IsDBNull(reader.GetOrdinal("supplierID")) ? "" : reader.GetString("supplierID");
                                tbCompanyName.Text = reader.IsDBNull(reader.GetOrdinal("companyName")) ? "" : reader.GetString("companyName");
                                tbContactName.Text = reader.IsDBNull(reader.GetOrdinal("contactName")) ? "" : reader.GetString("contactName");
                                tbContactNumber.Text = reader.IsDBNull(reader.GetOrdinal("contactNumber")) ? string.Empty : reader.GetInt32("contactNumber").ToString();
                                tbSupplierAddress.Text = reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address");


                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void tbSupplierID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedSupplierQuery = "SELECT * FROM supplier WHERE supplierID = @SupplierID";

                //  mappingItemID = Convert.ToInt32(tbAID.Text);
                using (var connection = new MySqlConnection(changeSupplierConn.conndb.ConnectionString))
                {
                    connection.Open();

                    using (var command = new MySqlCommand(selectedSupplierQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", tbSupplierID.Text.ToString());

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader and insert in textbox

                                tbCompanyName.Text = reader.GetString("companyName");
                                tbContactName.Text = reader.GetString("contactName");
                                tbContactNumber.Text = reader.GetString("contactNumber");
                                tbSupplierAddress.Text = reader.GetString("address");
                            }
                            else
                            {
                                tbCompanyName.Text = "";
                                tbContactName.Text = "";
                                tbContactNumber.Text = "";
                                tbSupplierAddress.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnChangeSupplier_Click(object sender, EventArgs e)
        {
            PopulateAllComboBox();
            tbSupplierID.Visible = false;
            tbCompanyName.Visible = false;
            cbSupplierID.Visible = true;
            cbSupplierName.Visible = true;
            btnCancel.Visible = true;
            btnChangeSupplier.Visible = false;
            btnAssignConfirm.Visible = true;
            btnDeleteSupplier.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbSupplierID.Visible = true;
            tbCompanyName.Visible = true;
            cbSupplierID.Visible = false;
            cbSupplierName.Visible = false;
            btnCancel.Visible = false;
            btnChangeSupplier.Visible = true;
            btnAssignConfirm.Visible = false;
            btnDeleteSupplier.Visible = true;
        }

        private void btnChangeConfirm_Click(object sender, EventArgs e)
        {
            if (tbCompanyName.Text == "")
            {
                MessageBox.Show("Please enter a supplier ID");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to assign Supplier ID: {tbSupplierID.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                query = "UPDATE item SET supplierID = @SupplierID WHERE itemID = @ItemID";
                try
                {
                    using (MySqlConnection conn = changeSupplierConn.conndb)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SupplierID", tbSupplierID.Text.ToString());
                            cmd.Parameters.AddWithValue("@itemID", tbAID.Text.ToString());

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Assign supplier updated successfully!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error updating supplier ID " + ex.Message);
                }
                this.Close();
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {

            int aID = Convert.ToInt32(tbAID.Text);

            DialogResult result = MessageBox.Show($"Are you sure you want to delete supplier ID: {tbSupplierID.Text} in item ID :{tbAID.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                query = "UPDATE item SET supplierID = NULL WHERE itemID = @ItemID";
                try
                {
                    using (MySqlConnection conn = changeSupplierConn.conndb)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@itemID", aID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Delete supplier in item successfully!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error updating supplier ID " + ex.Message);
                }
            }
        }

        private void PopulateAllComboBox()
        {
            try
            {
                cbSupplierID.Items.Clear();
                cbSupplierName.Items.Clear();


                using (MySqlConnection conn = changeSupplierConn.conndb)
                {
                    conn.Open();

                    string supplierQuery = "SELECT * FROM supplier";
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

        private void cbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierID.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierID.SelectedIndex;
                    cbSupplierName.SelectedIndex = selectedIndex;
                    tbSupplierID.Text = cbSupplierID.SelectedItem.ToString();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
