using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UI.connMySql;
using System.Threading.Tasks;

namespace UI.UserControls
{
    public partial class RequestManagementControl : UserControl
    {

        private readonly Connection_class searchConn = new Connection_class();
        private readonly DataTable itemListTable = new DataTable();
        private static readonly string query = "SELECT vID as 'Virtual item ID', vName as 'Item name', typeName as 'Type', brand, categoryName as 'Category', stockItemQty as 'Item Qty', unit as 'Unit' FROM item, item_type, item_category, vidmapping WHERE vidmapping.aID = item.itemID and item.typeID = item_type.itemTypeID and item.categoryid = item_category.categoryID";
        private ArrayList dgvItemListRows = new ArrayList();


        public List<UI.Confirmed_Item.ConfirmedItem> ConfirmedItems { get; set; }
        public RequestManagementControl()
        {
            InitializeComponent();
        }

        private void RequestManagement_Load(object sender, EventArgs e)
        {

            cbSearchType.SelectedIndex = 0;

            if (ConfirmedItems != null)
            {
                foreach (UI.Confirmed_Item.ConfirmedItem confirmedItem in ConfirmedItems)
                {
                    // Access the confirmed item properties
                    _ = confirmedItem.VirtualItemId;
                    _ = confirmedItem.ItemName;
                    _ = confirmedItem.ItemType;
                    _ = confirmedItem.Category;
                    _ = confirmedItem.brand;
                    _ = confirmedItem.Quantity;
                    _ = confirmedItem.Unit;
                }
            }

            try
            {
                setTable();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void setTable()
        {
            using (var adapter = new MySqlDataAdapter(query, searchConn.conndb))
            {
                adapter.Fill(itemListTable);
                dgvItemList.Rows.Clear();
                fillData();

                dgvItemList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {

            string input = tbSearch.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchItem("vID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("vName", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("categoryName", input);
                }

                if (itemListTable.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void searchItem(string colName, string input)
        {
            string searchQuery = query + $" AND {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, searchConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                itemListTable.Clear();
                adapter.Fill(itemListTable);
                dgvItemList.Rows.Clear();
                fillData();
            }
        }

        private void fillData()
        {
            dgvItemListRows.Clear();

            foreach (DataRow item in itemListTable.Rows)
            {
                int i = dgvItemList.Rows.Add();
                dgvItemList.Rows[i].Cells[1].Value = item["Virtual item ID"].ToString();
                dgvItemList.Rows[i].Cells[2].Value = item["Item name"].ToString();
                dgvItemList.Rows[i].Cells[3].Value = item["Type"].ToString();
                dgvItemList.Rows[i].Cells[4].Value = item["Category"].ToString();
                dgvItemList.Rows[i].Cells[5].Value = item["brand"].ToString();
                dgvItemList.Rows[i].Cells[6].Value = item["Item Qty"].ToString();
                dgvItemList.Rows[i].Cells[7].Value = item["Unit"].ToString();
                dgvItemListRows.Add(dgvItemList.Rows[i]);
                dgvItemList.Rows[i].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemList.Columns[e.ColumnIndex].Name == "dgvSelectItem")
            {
                dgvItemList.AllowUserToAddRows = false;
                bool flag = (bool)dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                dgvItemList.Rows[e.RowIndex].DefaultCellStyle.BackColor = flag ? Color.LightGreen : Color.White;
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            List<string> repeatedItemIDs = new List<string>();
            StringBuilder repeatedItemIDsMessage = new StringBuilder();

            foreach (DataGridViewRow itemRow in dgvItemList.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = itemRow.Cells[0] as DataGridViewCheckBoxCell;
                bool isSelected = checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value;

                if (isSelected)
                {
                    bool isDuplicate = false;

                    foreach (DataGridViewRow requestRow in dgvRequestList.Rows)
                    {
                        if (requestRow.Cells[1].Value != null && itemRow.Cells[1].Value != null && itemRow.Cells[1].Value.ToString() == requestRow.Cells[1].Value.ToString())
                        {
                            isDuplicate = true;
                            repeatedItemIDs.Add(requestRow.Cells[1].Value.ToString());
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        int i = dgvRequestList.Rows.Add();
                        dgvRequestList.Rows[i].Cells[1].Value = itemRow.Cells[1].Value?.ToString();
                        dgvRequestList.Rows[i].Cells[2].Value = itemRow.Cells[2].Value?.ToString();
                        dgvRequestList.Rows[i].Cells[3].Value = itemRow.Cells[3].Value?.ToString();
                        dgvRequestList.Rows[i].Cells[4].Value = itemRow.Cells[4].Value?.ToString();
                        dgvRequestList.Rows[i].Cells[5].Value = itemRow.Cells[5].Value?.ToString();
                        dgvRequestList.Rows[i].Cells[7].Value = itemRow.Cells[7].Value?.ToString();
                        dgvRequestList.Rows[i].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                        itemRow.Cells[0].Value = false;
                    }
                    else
                    {
                        itemRow.Cells[0].Value = false;
                    }
                }
            }

            if (repeatedItemIDs.Count > 0)
            {
                repeatedItemIDsMessage.Append("Repeated Item ID: ");
                repeatedItemIDsMessage.Append(string.Join(", ", repeatedItemIDs));
                MessageBox.Show(repeatedItemIDsMessage.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRequestList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Check if the current cell is in the desired column
            if (dgv.CurrentCell.ColumnIndex == 6) //  "Item Qty" column
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    // Remove the existing event handler, if any
                    textBox.KeyPress -= TextBox_KeyPress;

                    // Attach the event handler to restrict input to numeric values
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvRequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRequestList.Columns[e.ColumnIndex].Name == "reqSelect")
            {
                dgvRequestList.AllowUserToAddRows = false;
                bool flag = (bool)dgvRequestList.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                dgvRequestList.Rows[e.RowIndex].DefaultCellStyle.BackColor = flag ? Color.LightGreen : Color.White;
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvRequestList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            // Iterate over the rows in dgvRequestList
            foreach (DataGridViewRow row in dgvRequestList.Rows)
            {
                // Check if the checkbox in the row is selected
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["reqSelect"] as DataGridViewCheckBoxCell;
                bool isSelected = checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value;

                if (isSelected)
                {
                    // Add the row to the list of rows to remove
                    rowsToRemove.Add(row);
                }
            }

            if (rowsToRemove.Count == 0)
            {
                MessageBox.Show("No items selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Prompt for confirmation and remove the selected rows from dgvRequestList
            foreach (DataGridViewRow row in rowsToRemove)
            {
                string virtualItemId = row.Cells[1].Value?.ToString(); // Assuming the virtual item ID is in the second column (index 1)
                DialogResult result = MessageBox.Show("Are you sure you want to remove virtual item ID: " + virtualItemId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvRequestList.Rows.Remove(row);
                }
            }
        }

        private void btnRemoveAllItem_Click(object sender, EventArgs e)
        {
            if (dgvRequestList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove all items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvRequestList.Rows.Clear();
                }
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvRequestList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            List<UI.Confirmed_Item.ConfirmedItem> confirmedItems = new List<UI.Confirmed_Item.ConfirmedItem>();

            foreach (DataGridViewRow row in dgvRequestList.Rows)
            {
                string virtualItemId = row.Cells[1].Value?.ToString();
                string itemName = row.Cells[2].Value?.ToString();
                string itemType = row.Cells[3].Value?.ToString();
                string category = row.Cells[4].Value?.ToString();
                string brand = row.Cells[5].Value?.ToString();
                string quantity = row.Cells[6].Value?.ToString();
                string unit = row.Cells[7].Value?.ToString();


                try
                {
                    UI.Confirmed_Item.ConfirmedItem confirmedItem = new UI.Confirmed_Item.ConfirmedItem()
                    {
                        VirtualItemId = virtualItemId,
                        ItemName = itemName,
                        ItemType = itemType,
                        Category = category,
                        brand = brand,
                        Quantity = int.Parse(quantity),
                        Unit = unit
                    };
                    confirmedItems.Add(confirmedItem);
                }
                catch (Exception)
                {
                    MessageBox.Show("There have empty qty or format incorrrect, please input again!");
                    return;
                }
            }
            // Compare the quantities
            foreach (UI.Confirmed_Item.ConfirmedItem confirmedItem in confirmedItems)
            {
                string virtualItemId = confirmedItem.VirtualItemId;
                int quantity = confirmedItem.Quantity;

                // Find the corresponding item in dgvItemList
                DataGridViewRow itemRow = dgvItemListRows.Cast<DataGridViewRow>()
                    .FirstOrDefault(row => row.Cells[1].Value.ToString() == virtualItemId);

                if (itemRow != null)
                {
                    int itemQty = int.Parse(itemRow.Cells[6].Value.ToString());
                }
            }

            DialogResult result = MessageBox.Show("Are you sure you want to submit the request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Pass the confirmed items to the RequestForm
                RequestForm requestForm = new RequestForm();
                requestForm.ConfirmedItems = confirmedItems;
                requestForm.ShowDialog();
            }
        }
        private void dgvItemList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {

                // Set the desired font for the column header
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }
        private void dgvRequestList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Set the desired font for the column header
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }

        private void lblRequestManagement_Click(object sender, EventArgs e)
        {

        }

        private void lblItemList_Click(object sender, EventArgs e)
        {

        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearchItem.PerformClick();
                    // stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void dgvItemList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}

