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
using System.Xml.Linq;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.ItemControls
{
    public partial class VirtualIDMappingControl : UserControl
    {
        private readonly Connection_class virtualIDmappingConn = new Connection_class();
        private readonly DataTable mappingItemList = new DataTable();
        private string query;
        private int actualItemID;
        public bool isMapped = true;   //check the mappingItemList is mapped item list or mapping new item list

        public VirtualIDMappingControl()
        {
            InitializeComponent();
        }

        private void VirtualIDMappingControl_Load(object sender, EventArgs e)
        {
            cbSearchMappedType.SelectedIndex = 0;
            displayMappedData();

        }

        public bool IsMapped
        {
            get { return isMapped; }
        }


        private void displayMappedData()
{
    mappingItemList.Clear(); // Clear the DataTable
    mappingItemList.Columns.Clear(); // Remove existing columns

    using (var conn = new MySqlConnection(virtualIDmappingConn.conndb.ConnectionString))
    {
        query = "SELECT v.vID as 'Virtual Item ID', v.vName 'Virtual Item Name', i.ItemID as 'Actual Item ID', i.itemName as 'Actual Item Name' " +
                "FROM vidmapping AS v " +
                "LEFT JOIN item AS i ON v.aID = i.itemID";

        using (var cmd = new MySqlCommand(query, conn))
        {
            conn.Open();
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(mappingItemList);

                // Check if the aID is not assigned (null or DBNull.Value) and add the new vID and vName
                foreach (DataRow row in mappingItemList.Rows)
                {
                    if (row["Actual Item ID"] == null || row["Actual Item ID"] == DBNull.Value)
                    {
                        row["Actual Item ID"] = DBNull.Value; // Set it to DBNull.Value or leave it empty
                        row["Actual Item Name"] = DBNull.Value; // Set it to DBNull.Value or leave it empty
                        row["Virtual Item ID"] = row["Virtual Item ID"].ToString(); // Add the vID
                        row["Virtual Item Name"] = row["Virtual Item Name"].ToString(); // Add the vName
                    }
                }

                dgvMappingList.DataSource = mappingItemList;
            }
        }
    }
}

        private void searchItem(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, virtualIDmappingConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                mappingItemList.Clear();
                adapter.Fill(mappingItemList);
                dgvMappingList.DataSource = mappingItemList;
            }
        }

        private void searhNewItem(string colName, string input)
        {
            string searchQuery = query + $" AND {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, virtualIDmappingConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                DataTable searchResults = new DataTable();
                adapter.Fill(searchResults);

                // Rename the columns in the DataTable
                searchResults.Columns["itemID"].ColumnName = "Actual Item ID";
                searchResults.Columns.Add("Virtual Item ID", typeof(string));
                searchResults.Columns["itemName"].ColumnName = "Item Name";
                searchResults.Columns["supplierID"].ColumnName = "Supplier ID";
                searchResults.Columns["typeID"].ColumnName = "Type ID";
                searchResults.Columns["categoryID"].ColumnName = "Category ID";
                searchResults.Columns["brand"].ColumnName = "Brand";

                dgvMappingList.DataSource = searchResults;
            }
        }

        private void btnSearchMappingNewItem_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {
                if (cmSearhMappingNewItemType.SelectedIndex == 0)
                {
                    searhNewItem("itemID", input);
                }
                else if (cmSearhMappingNewItemType.SelectedIndex == 1)
                {
                    searhNewItem("itemName", input);
                }

                if (dgvMappingList.Rows.Count == 0)
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

        private void btnSearchMappedItem_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {
                if (cbSearchMappedType.SelectedIndex == 0)
                {
                    searchItem("vID", input);
                }
                else if (cbSearchMappedType.SelectedIndex == 1)
                {
                    searchItem("vName", input);
                }
                else if (cbSearchMappedType.SelectedIndex == 2)
                {
                    searchItem("aID", input);
                }
                else if (cbSearchMappedType.SelectedIndex == 3)
                {
                    searchItem("vName", input);
                }

                if (dgvMappingList.Rows.Count == 0)
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
        private void dgvMappingList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvMappingList.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void btnMappingNewItem_Click(object sender, EventArgs e)
        {
            cmSearhMappingNewItemType.SelectedIndex = 0;
            lblMappingItem.Text = "Mapping New Item";
            isMapped = false;
            cmSearhMappingNewItemType.Visible = true;
            btnSearchMappingNewItem.Visible = true;
            cbSearchMappedType.Visible = false;
            btnSearchMappedItem.Visible = false;

            try
            {
                mappingItemList.Clear(); // Clear the DataTable
                mappingItemList.Columns.Clear(); // Remove existing columns

                // Add the  columns to the DataTable
                mappingItemList.Columns.Add("Actual Item ID", typeof(int));
                mappingItemList.Columns.Add("Virtual Item ID", typeof(string));
                mappingItemList.Columns.Add("Item Name", typeof(string));
                mappingItemList.Columns.Add("Supplier ID", typeof(string));
                mappingItemList.Columns.Add("Type ID", typeof(int));
                mappingItemList.Columns.Add("Category ID", typeof(int));
                mappingItemList.Columns.Add("Brand", typeof(string));

                using (var conn = new MySqlConnection(virtualIDmappingConn.conndb.ConnectionString))
                {
                    query = "SELECT i.itemID, i.itemName, i.supplierID, i.typeID, i.categoryID, i.brand " +
                           "FROM item AS i " +
                           "LEFT JOIN vidmapping AS v ON v.aID = i.itemID " +
                           "WHERE v.aID IS NULL";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve values from the reader

                                /*                                int itemID = reader.GetInt32("itemID");
                                                                string itemName = reader.GetString("itemName");
                                                                string supplierID = reader.GetString("supplierID");
                                                                int typeID = reader.GetInt32("typeID");
                                                                int categoryID = reader.GetInt32("categoryID");
                                                                string brand = reader.GetString("brand");*/

                                int? itemID = reader.IsDBNull(reader.GetOrdinal("itemID")) ? null : (int?)reader.GetInt32("itemID");
                                string itemName = reader.IsDBNull(reader.GetOrdinal("itemName")) ? null : reader.GetString("itemName");
                                string supplierID = reader.IsDBNull(reader.GetOrdinal("supplierID")) ? null : reader.GetString("supplierID");
                                int? typeID = reader.IsDBNull(reader.GetOrdinal("typeID")) ? null : (int?)reader.GetInt32("typeID");
                                int? categoryID = reader.IsDBNull(reader.GetOrdinal("categoryID")) ? null : (int?)reader.GetInt32("categoryID");
                                string brand = reader.IsDBNull(reader.GetOrdinal("brand")) ? null : reader.GetString("brand");

                                // Add a new row to the DataTable
                                mappingItemList.Rows.Add(itemID, null, itemName, supplierID, typeID, categoryID, brand);
                            }
                        }
                    }
                }

                dgvMappingList.DataSource = mappingItemList;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnMappedItem_Click(object sender, EventArgs e)
        {
            lblMappingItem.Text = "Manage Mapping Item";
            isMapped = true;
            cmSearhMappingNewItemType.Visible = false;
            btnSearchMappingNewItem.Visible = false;
            cbSearchMappedType.Visible = true;
            btnSearchMappedItem.Visible = true;
            displayMappedData();
        }


        private void dgvMappingList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMappingList.CurrentCell != null)
            {
                try
                {
                    // Get the selected row index
                    int rowIndex = dgvMappingList.CurrentCell.RowIndex;

                    // Check if "Actual Item ID" is DBNull.Value or empty
                    if (dgvMappingList.Rows[rowIndex].Cells["Actual Item ID"].Value == DBNull.Value ||
                        string.IsNullOrEmpty(dgvMappingList.Rows[rowIndex].Cells["Actual Item ID"].Value.ToString()))
                    {
                        int vID = (int)dgvMappingList.Rows[rowIndex].Cells["Virtual Item ID"].Value;
                        string vName = dgvMappingList.Rows[rowIndex].Cells["Virtual Item Name"].Value.ToString();
                        AssignActualID assignActualID = new AssignActualID(vID, vName);
                        assignActualID.ShowDialog();
                    }
                    else
                    {
                        actualItemID = Convert.ToInt32(dgvMappingList.Rows[rowIndex].Cells["Actual Item ID"].Value);
                        MappingItem mappingItem = new MappingItem(actualItemID, isMapped);
                        mappingItem.ShowDialog();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }


        private void btnCreateVID_Click(object sender, EventArgs e)
        {
            CreateNewVID createNewVID = new CreateNewVID();
            createNewVID.ShowDialog();
        }

        private void dgvMappingList_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchMappedItem.PerformClick();
                btnSearchMappingNewItem.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
