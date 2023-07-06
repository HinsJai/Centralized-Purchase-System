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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.ItemControls
{
    public partial class SupplierManageControl : UserControl
    {
        private string query;
        private string supplierID;
        private int itemID;
        private readonly Connection_class supplierConn = new Connection_class();
        private readonly DataTable supplierMangeList = new DataTable();
        private bool supplierFormType = false;

        public SupplierManageControl()
        {
            InitializeComponent();
        }

        private void SupplierManageControl_Load(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            displaySupplierData();
        }

        private void displaySupplierData()
        {

            supplierMangeList.Clear(); // Clear the DataTable
            supplierMangeList.Columns.Clear(); // Remove existing columns
            using (var conn = new MySqlConnection(supplierConn.conndb.ConnectionString))
            {
                query = "SELECT supplierID as 'Supplier ID', companyName as 'Company Name', contactName as 'Contact Name', contactNumber as 'Contact Number', address as 'Address'  FROM supplier";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(supplierMangeList);
                        dgvSupplierList.DataSource = supplierMangeList;
                    }
                }
            }
        }

        private void dgvSupplierList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvSupplierList.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void searchSupplier(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, supplierConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                supplierMangeList.Clear();
                adapter.Fill(supplierMangeList);
                dgvSupplierList.DataSource = supplierMangeList;
            }
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchSupplier("supplierID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchSupplier("companyName", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchSupplier("contactName", input);
                }
                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchSupplier("contactNumber", input);
                }

                if (supplierMangeList.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
                tbSearch.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvSupplierList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSupplierList.CurrentCell != null)
            {
                try
                {
                    // Get the selected row index
                    int rowIndex = dgvSupplierList.CurrentCell.RowIndex;

                    // Get the actual item ID from the selected row in the dgvMappingList
                    if (supplierFormType == false)
                    {
                        supplierID = dgvSupplierList.Rows[rowIndex].Cells["Supplier ID"].Value.ToString();
                    }
                    else
                    {
                        itemID = (int)dgvSupplierList.Rows[rowIndex].Cells["Item ID"].Value;
                    }

                    if (supplierFormType == false)
                    {
                        SupplierDetails supplierDetails = new SupplierDetails(supplierID);
                        supplierDetails.ShowDialog();
                    }
                    else
                    {
                        ChangeSupplier changeSupplier = new ChangeSupplier(itemID);
                        changeSupplier.ShowDialog();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnManageSupplier_Click(object sender, EventArgs e)
        {
            displaySupplierData();
            supplierFormType = false;
            cbSearchType.Visible = true;
            btnSearchSupplier.Visible = true;
            cbChangeSupplierSearch.Visible = false;
            btnChangeSupplierSearch.Visible = false;
            lblSupplierManage.Text = "Manage Supplier";
        }

        private void btnChangeSupplier_Click(object sender, EventArgs e)
        {
            cbChangeSupplierSearch.SelectedIndex = 0;
            lblSupplierManage.Text = "Change Supplier";
            supplierFormType = true;
            cbSearchType.Visible = false;
            btnSearchSupplier.Visible = false;
            cbChangeSupplierSearch.Visible = true;
            btnChangeSupplierSearch.Visible = true;

            try
            {
                supplierMangeList.Clear(); // Clear the DataTable
                supplierMangeList.Columns.Clear(); // Remove existing columns

                // Add the  columns to the DataTable
                supplierMangeList.Columns.Add("Item ID", typeof(int));
                supplierMangeList.Columns.Add("Item Name", typeof(string));
                supplierMangeList.Columns.Add("Type", typeof(string));
                supplierMangeList.Columns.Add("Category", typeof(string));
                supplierMangeList.Columns.Add("Brand", typeof(string));
                supplierMangeList.Columns.Add("Supplier ID", typeof(string));
                supplierMangeList.Columns.Add("Company Name", typeof(string));
                supplierMangeList.Columns.Add("Contact Name", typeof(string));
                supplierMangeList.Columns.Add("Contact Number", typeof(int));
                supplierMangeList.Columns.Add("Address", typeof(string));

                using (var conn = new MySqlConnection(supplierConn.conndb.ConnectionString))
                {
                    query = "SELECT item.itemID, item.itemName, item_type.typeName, item_category.categoryName, item.brand, supplier.* " +
                                 "FROM item " +
                                 "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
                                 "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
                                 "LEFT JOIN supplier ON item.supplierID = supplier.supplierID " +
                                 "Order by supplier.supplierID ASC";


                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve values from the reader
                                int itemID = reader.GetInt32("itemID");
                                string itemName = reader.GetString("itemName");
                                string type = reader.GetString("typeName");
                                string category = reader.GetString("categoryName");
                                string brand = reader.GetString("brand");
                                string supplierID = reader.IsDBNull(reader.GetOrdinal("supplierID")) ? "" : reader.GetString("supplierID");
                                string companyName = reader.IsDBNull(reader.GetOrdinal("companyName")) ? "" : reader.GetString("companyName");
                                string contactName = reader.IsDBNull(reader.GetOrdinal("contactName")) ? "" : reader.GetString("contactName");
                                int? contactNumber = reader.IsDBNull(reader.GetOrdinal("contactNumber")) ? (int?)null : reader.GetInt32("contactNumber");
                                string address = reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address");

                                // Add a new row to the DataTable
                                supplierMangeList.Rows.Add(itemID, itemName, type, category, brand, supplierID, companyName, contactName, contactNumber, address);
                            }
                        }
                    }
                }
                dgvSupplierList.DataSource = supplierMangeList;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvSupplierList_ColumnContextMenuStripChanged(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvSupplierList_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btnCreateSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSupplier.PerformClick();
                btnChangeSupplierSearch.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void searchChangeSupplier(string colName, string input)
        {
            string searchQuery = $"SELECT item.itemID, item.itemName, item_type.typeName, item_category.categoryName, item.brand, supplier.* " +
                                           "FROM item " +
                                           "INNER JOIN item_type ON item.typeID = item_type.itemTypeID " +
                                           "INNER JOIN item_category ON item.categoryID = item_category.categoryID " +
                                           "LEFT JOIN supplier ON item.supplierID = supplier.supplierID " +
                                           $"Where {colName} LIKE  @input " +
                                           $"Order by supplier.supplierID ASC";

            using (var adapter = new MySqlDataAdapter(searchQuery, supplierConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");

                DataTable searchAssignResults = new DataTable();
                adapter.Fill(searchAssignResults);

                // Rename the columns in the DataTable
                searchAssignResults.Columns["itemID"].ColumnName = "Item ID";
                /*                searchAssignResults.Columns.Add("Virtual Item ID", typeof(string));
                */
                searchAssignResults.Columns["itemName"].ColumnName = "Item Name";
                searchAssignResults.Columns["typeName"].ColumnName = "Type";
                searchAssignResults.Columns["categoryName"].ColumnName = "Category";
                searchAssignResults.Columns["brand"].ColumnName = "Brand";
                searchAssignResults.Columns["supplierID"].ColumnName = "Supplier ID";
                searchAssignResults.Columns["companyName"].ColumnName = "Company Name";
                searchAssignResults.Columns["contactName"].ColumnName = "Contact Name";
                searchAssignResults.Columns["contactNumber"].ColumnName = "Contact Number";
                searchAssignResults.Columns["address"].ColumnName = "Address";

                dgvSupplierList.DataSource = searchAssignResults;
            }
        }
        // Search Supplier
        private void btnChangeSupplierSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {

                if (cbChangeSupplierSearch.SelectedIndex == 0)
                {
                    searchChangeSupplier("itemID", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 1)
                {
                    searchChangeSupplier("itemName", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 2)
                {
                    searchChangeSupplier("typeName", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 3)
                {
                    searchChangeSupplier("categoryName", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 4)
                {
                    searchChangeSupplier("brand", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 5)
                {
                    searchChangeSupplier("supplier.supplierID", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 6)
                {
                    searchChangeSupplier("companyName", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 7)
                {
                    searchChangeSupplier("contactName", input);
                }
                else if (cbChangeSupplierSearch.SelectedIndex == 8)
                {
                    searchChangeSupplier("contactNumber", input);
                }

                if (supplierMangeList.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
                tbSearch.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void dgvSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSupplierList_Click(object sender, EventArgs e)
        {

        }
    }
}
