using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace UI
{
    public partial class MappingItem : Form
    {
        Connection_class mappingConn = new Connection_class();
        private int mappingItemID;
        private bool mapped;
        private string query;
        public MappingItem(int actualItemID, bool isMapped)
        {
            InitializeComponent();
            mappingItemID = actualItemID;
            mapped = isMapped;
        }



        private void MappedItem_Load(object sender, EventArgs e)
        {
            if (mapped)
            {
                setMappedItem();
            }
            else
            {
                assignMappingID();
                btnModifyItem.Visible = false;
                btnAssignVID.Visible = true;
                btnDeleteVID.Visible = false;
                lblMappedItem.Text = "Mapping Item";
            }

        }

        private void btnAssignVID_Click(object sender, EventArgs e)
        {
            PopulateVirtualIDComboBox();
            cbVID.Visible = true;
            cbVName.Visible = true;
            tbVID.Visible = false;
            tbVName.Visible = false;
            tbVID.ReadOnly = false;
            btnCancel.Visible = true;
            btnAssignConfirm.Visible = true;
            btnAssignVID.Visible = false;
        }

        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            PopulateActualIDComboBox();
            tbAID.Visible = false;
            tbItemName.Visible = false;
            cbMappedAID.Visible = true;
            cbMappedIAName.Visible = true;
            tbAID.ReadOnly = false;
            tbVName.ReadOnly = false;
            btnCancel.Visible = true;
            btnModifyItem.Visible = false;
            btnModifyConfirm.Visible = true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (mapped)
            {
                cbMappedAID.Visible = false; 
                cbMappedIAName.Visible = false;
                tbAID.Visible = true;
                tbItemName.Visible = true;
                tbAID.ReadOnly = true;
                btnCancel.Visible = false;
                btnModifyItem.Visible = true;
                btnModifyConfirm.Visible = false;
                tbVName.ReadOnly = true;
            }
            else
            {
                tbVID.Visible = true;
                tbVName.Visible = true;
                cbVID.Visible = false;
                cbVName.Visible = false;
                tbVID.ReadOnly = true;
                btnCancel.Visible = false;
                btnAssignConfirm.Visible = false;
                btnAssignVID.Visible = true;
            }
        }


        private void btnAssignConfirm_Click(object sender, EventArgs e)
        {
            int affectedRow;
            if (tbVName.Text.Length > 0 && tbVID.Text.Length >= 4)
            {
                try
                {
                    if (MessageBox.Show($"Are you sure you want mapping actual item ID: {tbAID.Text} to virtual item ID: {tbVID.Text}", "Confirm Mapping", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        query = "UPDATE vidmapping SET aID = @ActualItemID WHERE vID = @VID";

                        using (var connection = new MySqlConnection(mappingConn.conndb.ConnectionString))
                        {
                            connection.Open();

                            using (var command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ActualItemID", tbAID.Text);
                                command.Parameters.AddWithValue("@VID", tbVID.Text);

                                affectedRow = command.ExecuteNonQuery();
                            }
                        }
                        if (affectedRow > 0)
                        {
                            MessageBox.Show("Item has been update successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbVID.ReadOnly = true;
                            btnCancel.Visible = false;
                            btnAssignConfirm.Visible = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Assign failed!", "Assign Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Your virtual item ID record not found or incorrect, please try again!");
                }
            }
            else
            {
                MessageBox.Show("Your virtual item ID record not found or incorrect, please try again!");
            }
        }

        private void btnModifyConfirm_Click(object sender, EventArgs e)
        {
            int affectedRow;

            try
            {
                if (MessageBox.Show($"Are you sure you want to update actual item ID: {tbAID.Text}", "Confirm Modify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    query = "UPDATE vidmapping SET aID = @ActualItemID, vName = @VName WHERE vID = @VID";

                    using (var connection = new MySqlConnection(mappingConn.conndb.ConnectionString))
                    {
                        connection.Open();

                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ActualItemID", tbAID.Text);
                            command.Parameters.AddWithValue("@VName", tbVName.Text);
                            command.Parameters.AddWithValue("@VID", tbVID.Text);
                            affectedRow = command.ExecuteNonQuery();
                        }
                    }
                    if (affectedRow > 0)
                    {
                        MessageBox.Show("Item has been update successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbAID.ReadOnly = true;
                        btnCancel.Visible = false;
                        btnModifyItem.Visible = true;
                        btnModifyConfirm.Visible = false;
                        tbVName.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Update failed!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your actual item ID record not found or incorrect, please try again!");
            }

        }

        private void assignMappingID()
        {
            query = "SELECT  item.itemID, item.itemName, item.typeID, item_type.typeName, item.categoryID, item_category.categoryName, item.supplierID, supplier.companyName AS supplierName, item.stockItemQty AS stockQty, item.remark, item.brand, item.unit " +
           "FROM item " +
           "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
           "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
           "INNER JOIN supplier ON item.supplierID = supplier.supplierID " +
           "WHERE item.itemID = @ActualItemID";

            using (var connection = new MySqlConnection(mappingConn.conndb.ConnectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ActualItemID", mappingItemID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the data from the reader and insert in textbox
                            tbAID.Text = reader.GetInt32("itemID").ToString();
                            tbItemName.Text = reader.GetString("itemName");
                            tbTypeID.Text = reader.GetInt32("typeID").ToString();
                            tbTypeName.Text = reader.GetString("typeName");
                            tbCategoryID.Text = reader.GetInt32("categoryID").ToString();
                            tbCategoryName.Text = reader.GetString("categoryName");
                            tbSupplierID.Text = reader.GetString("supplierID").ToString();
                            tbSupplierName.Text = reader.GetString("supplierName");
                            tbStockQty.Text = reader.GetInt32("stockQty").ToString();
                            tbItemRemark.Text = reader.IsDBNull(reader.GetOrdinal("remark")) ? string.Empty : reader.GetString("remark");
                            tbBrand.Text = reader.GetString("brand");
                            tbUnit.Text = reader.GetString("unit");
                        }
                    }
                }
            }

        }

        private void setMappedItem()
        {

            query = "SELECT vidmapping.vID,vidmapping.vName, item.itemID, item.itemName, item.typeID, item_type.typeName, item.categoryID, item_category.categoryName, item.supplierID, supplier.companyName AS supplierName, item.stockItemQty AS stockQty, item.remark, item.brand, item.unit " +
        "FROM item " +
        "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
        "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
        "INNER JOIN supplier ON item.supplierID = supplier.supplierID " +
        "INNER JOIN vidmapping ON item.itemID = vidmapping.aID " +
        "WHERE item.itemID = @ActualItemID";


            using (var connection = new MySqlConnection(mappingConn.conndb.ConnectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ActualItemID", mappingItemID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the data from the reader and insert in textbox
                            tbVID.Text = reader.GetInt32("vID").ToString();
                            tbVName.Text = reader.GetString("vName");
                            tbAID.Text = reader.GetInt32("itemID").ToString();
                            tbItemName.Text = reader.GetString("itemName");
                            tbTypeID.Text = reader.GetInt32("typeID").ToString();
                            tbTypeName.Text = reader.GetString("typeName");
                            tbCategoryID.Text = reader.GetInt32("categoryID").ToString();
                            tbCategoryName.Text = reader.GetString("categoryName");
                            tbSupplierID.Text = reader.GetString("supplierID").ToString();
                            tbSupplierName.Text = reader.GetString("supplierName");
                            tbStockQty.Text = reader.GetInt32("stockQty").ToString();
                            tbItemRemark.Text = reader.IsDBNull(reader.GetOrdinal("remark")) ? string.Empty : reader.GetString("remark");
                            tbBrand.Text = reader.GetString("brand");
                            tbUnit.Text = reader.GetString("unit");
                        }
                    }
                }
            }

        }

        private void tbAID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT  item.itemID, item.itemName, item.typeID, item_type.typeName, item.categoryID, item_category.categoryName, item.supplierID, supplier.companyName AS supplierName, item.stockItemQty AS stockQty, item.remark, item.brand, item.unit " +
            "FROM item " +
            "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
            "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
            "INNER JOIN supplier ON item.supplierID = supplier.supplierID " +
            "WHERE item.itemID = @ActualItemID";

                mappingItemID = Convert.ToInt32(tbAID.Text);
                using (var connection = new MySqlConnection(mappingConn.conndb.ConnectionString))
                {
                    connection.Open();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ActualItemID", mappingItemID);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader and insert in textbox
                                tbItemName.Text = reader.GetString("itemName");
                                tbTypeID.Text = reader.GetInt32("typeID").ToString();
                                tbTypeName.Text = reader.GetString("typeName");
                                tbCategoryID.Text = reader.GetInt32("categoryID").ToString();
                                tbCategoryName.Text = reader.GetString("categoryName");
                                tbSupplierID.Text = reader.GetString("supplierID").ToString();
                                tbSupplierName.Text = reader.GetString("supplierName");
                                tbStockQty.Text = reader.GetInt32("stockQty").ToString();
                                tbItemRemark.Text = reader.IsDBNull(reader.GetOrdinal("remark")) ? string.Empty : reader.GetString("remark");
                                tbBrand.Text = reader.GetString("brand");
                                tbUnit.Text = reader.GetString("unit");
                            }
                            else
                            {
                                tbItemName.Text = "";
                                tbTypeID.Text = "";
                                tbTypeName.Text = "";
                                tbCategoryID.Text = "";
                                tbCategoryName.Text = "";
                                tbSupplierID.Text = "";
                                tbSupplierName.Text = "";
                                tbStockQty.Text = "";
                                tbItemRemark.Text = "";
                                tbBrand.Text = "";
                                tbUnit.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void tbAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbVID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*        int vid = Convert.ToInt32(tbVID.Text);*/

                query = "SELECT vName FROM vidmapping WHERE vid = @VID";

                using (var connection = new MySqlConnection(mappingConn.conndb.ConnectionString))
                {
                    connection.Open();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VID", tbVID.Text);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader and insert in textbox

                                tbVName.Text = reader.GetString("vName").ToString();
                            }
                            else
                            {
                                tbVName.Text = "";
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

        private void btnDeleteVID_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Are you sure you want to delete VID: {tbVID.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = mappingConn.conndb)
                    {
                        conn.Open();

                        // Delete the row from vidmapping based on vID
                        string deleteQuery = "DELETE FROM vidmapping WHERE vID = @vID";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@vID", tbVID.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("VID deleted successfully.");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting VID: " + ex.Message);
                }
            }
        }

        private void PopulateActualIDComboBox()
        {
            try
            {
                cbMappedAID.Items.Clear();
                cbMappedIAName.Items.Clear();

                using (MySqlConnection conn = mappingConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT itemID, itemName FROM item";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int itemID = reader.GetInt32("itemID");
                                string itemName = reader.GetString("itemName");

                                cbMappedAID.Items.Add(itemID);
                                cbMappedIAName.Items.Add(itemName); // Add item names to AssignAName combobox

                                // Check if the current itemID matches the mappingItemID
                                if (itemID == mappingItemID)
                                {
                                    // Set the selected index of cbMappedAID to the matching item
                                    cbMappedAID.SelectedIndex = cbMappedAID.Items.Count - 1;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the comboboxes: " + ex.Message);
            }
        }

        private void cbMappedAID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMappedAID.SelectedIndex != -1)
                {
                    int selectedIndex = cbMappedAID.SelectedIndex;
                    cbMappedIAName.SelectedIndex = selectedIndex;
                    tbAID.Text = cbMappedAID.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the AssignAName combobox: " + ex.Message);
            }
        }

        private void cbMappedIAName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMappedIAName.SelectedIndex != -1)
                {
                    int selectedIndex = cbMappedIAName.SelectedIndex;
                    cbMappedAID.SelectedIndex = selectedIndex; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the cbAssignAID combobox: " + ex.Message);
            }
        }

        private void PopulateVirtualIDComboBox()
        {
            try
            {
                cbVID.Items.Clear();
                cbVName.Items.Clear();

                using (MySqlConnection conn = mappingConn.conndb)
                {
                    conn.Open();

                    string query = " SELECT vID, vName FROM vidmapping WHERE aID is NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int itemID = reader.GetInt32("vID");
                                string itemName = reader.GetString("vName");

                                // Add item names and id to  combobox
                                cbVID.Items.Add(itemID);
                                cbVName.Items.Add(itemName); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the comboboxes: " + ex.Message);
            }
        }


        private void cbVID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbVID.SelectedIndex != -1)
                {
                    int selectedIndex = cbVID.SelectedIndex;
                    cbVName.SelectedIndex = selectedIndex;
                    tbVID.Text = cbVID.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbVName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMappedAID.SelectedIndex != -1)
                {
                    int selectedIndex = cbVName.SelectedIndex;
                    cbVID.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
