using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;

namespace UI.ItemControls
{
    public partial class ItemManagementControl : UserControl
    {
        private readonly Connection_class manageItemConn = new Connection_class();
        private readonly DataTable manageItemList = new DataTable();
        private   string query ;
        private ItemDetails itemdetail;

        public ItemManagementControl()
        {
            InitializeComponent();
        }

        private void itemManagementControl_Load(object sender, EventArgs e)
        {
            query = "SELECT v.vID, v.aID, v.vName, i.typeID AS itemTypeID, it.typeName, i.stockItemQty, i.unit, i.remark FROM item i JOIN vidmapping v ON i.itemID = v.aID JOIN item_type it ON i.typeID = it.itemTypeID";
            cbSearchType.SelectedIndex = 0;
            setTable();
        }

        private void setTable()
        {
            using (var adapter = new MySqlDataAdapter(query, manageItemConn.conndb))
            {
                adapter.Fill(manageItemList);
                dgvMangeItemList.Rows.Clear();
                fillData();
                dgvMangeItemList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }
        private void fillData()
        {
            foreach (DataRow item in manageItemList.Rows)
            {
                int i = dgvMangeItemList.Rows.Add();
                dgvMangeItemList.Rows[i].Cells[0].Value = item["aID"].ToString();
                dgvMangeItemList.Rows[i].Cells[1].Value = item["vID"].ToString();
                dgvMangeItemList.Rows[i].Cells[2].Value = item["vName"].ToString();
                dgvMangeItemList.Rows[i].Cells[3].Value = item["itemTypeID"].ToString();
                dgvMangeItemList.Rows[i].Cells[4].Value = item["typeName"].ToString();
                dgvMangeItemList.Rows[i].Cells[5].Value = item["stockItemQty"].ToString();
                dgvMangeItemList.Rows[i].Cells[6].Value = item["unit"].ToString();
                dgvMangeItemList.Rows[i].Cells[7].Value = item["remark"].ToString();

                dgvMangeItemList.Rows[i].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }
        private void dgvMangeItemList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

                if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Set the desired font for the column header
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchItem("aID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("vID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("vName", input);
                }else if(cbSearchType.SelectedIndex == 3)
                {
                    searchItem("typeID", input);
                }else if(cbSearchType.SelectedIndex == 4)
                {
                    searchItem("typeName", input);
                }
                if (manageItemList.Rows.Count == 0)
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

        private void searchItem(string colName, string input)
        {
            string searchQuery = query + $" AND {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, manageItemConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                manageItemList.Clear();
                adapter.Fill(manageItemList);
                dgvMangeItemList.Rows.Clear();
                fillData();
            }
        }
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchItem.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvMangeItemList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvMangeItemList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvMangeItemList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvMangeItemList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string aID = selectedRow.Cells[0].Value.ToString();
                    string vID = selectedRow.Cells[1].Value.ToString();
                    string ItemName = selectedRow.Cells[2].Value.ToString();
                    string typeID = selectedRow.Cells[3].Value.ToString();
                    string typeName = selectedRow.Cells[4].Value.ToString();
                    string stockQty = selectedRow.Cells[5].Value.ToString();
                    string unit = selectedRow.Cells[6].Value.ToString();
                    string itemRemark = selectedRow.Cells[7].Value.ToString();

                    // Create a new instance of RequestDetailsForm if it doesn't exist
                    if (itemdetail == null || itemdetail.IsDisposed)
                    {
                        itemdetail = new ItemDetails();
                    }

                    // Set the selected data in the RequestDetailsForm
                    itemdetail.SetData(aID, vID, ItemName, typeID, typeName, stockQty, unit, itemRemark);


                    // Show the RequestDetailsForm
                    itemdetail.Show();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            CreateItem createItem = new CreateItem();
            createItem.ShowDialog();
        }

        private void btnCheckNewItem_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem();
            newItem.ShowDialog();
        }
    }
}
