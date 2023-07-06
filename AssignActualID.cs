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
    public partial class AssignActualID : Form
    {
        private int vID;
        private string vName;
        private readonly Connection_class assignAIDConn = new Connection_class();


        public AssignActualID(int vID, string vName)
        {
            InitializeComponent();
            this.vID = vID;
            this.vName = vName;
        }

        private void AssignActualID_Load(object sender, EventArgs e)
        {
            tbVID.Text = vID.ToString();
            tbVName.Text = vName;
            PopulateComboBox();

        }

        private void PopulateComboBox()
        {
            try
            {
                cbAssignAID.Items.Clear();
                using (MySqlConnection conn = assignAIDConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT i.itemID FROM item AS i LEFT JOIN vidmapping AS v ON v.aID = i.itemID WHERE v.aID IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int itemID = reader.GetInt32("itemID");
                                cbAssignAID.Items.Add(itemID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the combobox: " + ex.Message);
            }
        }

        private void cbAssignAID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAssignAID.SelectedItem != null)
            {
                // Get the selected itemID from the combobox
                int selectedItemId = Convert.ToInt32(cbAssignAID.SelectedItem);

                // Perform the query to retrieve item details
                string query = "SELECT item.itemID, item.itemName, item.typeID, item_type.typeName, item.categoryID, item_category.categoryName, item.supplierID, supplier.companyName AS supplierName, item.stockItemQty AS stockQty, item.remark, item.brand, item.unit " +
                    "FROM item " +
                    "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
                    "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
                    "INNER JOIN supplier ON item.supplierID = supplier.supplierID " +
                    "WHERE item.itemID = @ActualItemID";

                using (var conn = new MySqlConnection(assignAIDConn.conndb.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ActualItemID", selectedItemId);
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
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
        }

        private void btnAssignVID_Click(object sender, EventArgs e)
        {
            int selectedItemId = Convert.ToInt32(cbAssignAID.SelectedItem);
            if (cbAssignAID.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you assign item ID: {selectedItemId} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = assignAIDConn.conndb)
                        {
                            conn.Open();

                            // Update the aID column in vidmapping based on the vID
                            string updateQuery = "UPDATE vidmapping SET aID = @aID WHERE vID = @vID";
                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@aID", selectedItemId);
                                cmd.Parameters.AddWithValue("@vID", vID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Assign VID successfully.");
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while assigning VID: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item ID.");
            }
        }

        private void btnDeleteVID_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete VID: {vID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = assignAIDConn.conndb)
                    {
                        conn.Open();

                        // Delete the row from vidmapping based on vID
                        string deleteQuery = "DELETE FROM vidmapping WHERE vID = @vID";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@vID", vID);
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

    }
}
