using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.connMySql;

namespace UI.AgreementControls
{
    public partial class DespatchInstructionControl : UserControl
    {
        private readonly Connection_class DesPatchConn = new Connection_class();
        private readonly DataTable DesPatchTable = new DataTable();
        private ArrayList dgvItemListRows = new ArrayList();
        private string query = "SELECT ri.requestID AS 'Request ID', ri.requestItemVID AS 'Item ID', " +
             "vidmapping.vName AS 'Item Name', ri.requestQty AS 'Request Qty', i.unit AS 'Unit', ri.itemStatus AS 'Item Status' " +
             "FROM request_item ri " +
             "JOIN vidmapping ON ri.requestItemVID = vidmapping.vID " +
             "JOIN item i ON vidmapping.aID = i.itemID " +
             "WHERE ri.requestQty <= i.stockItemQty " +
             "AND ri.itemStatus NOT IN ('Cancel Request', 'Cancelled', 'Completed', 'In Progress', 'Rejected')";


        public List<UI.DespatchConfirm.DespatchConfirm> DespatchConfirm { get; set; }
        public DespatchInstructionControl()
        {
            InitializeComponent();
        }

        private void DespatchInstructionControl_Load(object sender, EventArgs e)
        {

            cbSearchType.SelectedIndex = 0;

            if (DespatchConfirm != null)
            {
                foreach (UI.DespatchConfirm.DespatchConfirm despatchConfirm in DespatchConfirm)
                {
                    // Access the confirmed item properties
                    _ = despatchConfirm.requestID;
                    _ = despatchConfirm.itemID;
                    _ = despatchConfirm.ItemName;
                    _ = despatchConfirm.requestQty;
                    _ = despatchConfirm.unit;
                    _ = despatchConfirm.itemStatus;
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
            using (var adapter = new MySqlDataAdapter(query, DesPatchConn.conndb))
            {
                adapter.Fill(DesPatchTable);
                dgvDespatchInstruction.Rows.Clear();
                fillData();

                dgvDespatchInstruction.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {

            string input = tbSearch.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchItem("ri.requestID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("ri.requestItemVID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("vidmapping.vName", input);
                }
                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchItem("ri.itemStatus", input);
                }
/*

                if (DesPatchTable.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }*/
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            tbSearch.Text = "";
            cbSearchType.SelectedIndex = 0;
        }

        private void searchItem(string colName, string input)
        {
            string searchQuery = query + $" AND {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, DesPatchConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                DesPatchTable.Clear();
                adapter.Fill(DesPatchTable);
                dgvDespatchInstruction.Rows.Clear();
                fillData();
            }
        }

        private void fillData()
        {
            dgvItemListRows.Clear();

            foreach (DataRow item in DesPatchTable.Rows)
            {
                int i = dgvDespatchInstruction.Rows.Add();
                dgvDespatchInstruction.Rows[i].Cells[1].Value = item["Request ID"].ToString();
                dgvDespatchInstruction.Rows[i].Cells[2].Value = item["Item ID"].ToString();
                dgvDespatchInstruction.Rows[i].Cells[3].Value = item["Item Name"].ToString();
                dgvDespatchInstruction.Rows[i].Cells[4].Value = item["Request Qty"].ToString();
                dgvDespatchInstruction.Rows[i].Cells[5].Value = item["Unit"].ToString();
                dgvDespatchInstruction.Rows[i].Cells[6].Value = item["Item Status"].ToString();
                dgvItemListRows.Add(dgvDespatchInstruction.Rows[i]);
                dgvDespatchInstruction.Rows[i].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            }
        }

        private void dgvDespatchInstruction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDespatchInstruction.Columns[e.ColumnIndex].Name == "dgvSelectItem")
            {
                dgvDespatchInstruction.AllowUserToAddRows = false;
                bool flag = (bool)dgvDespatchInstruction.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                dgvDespatchInstruction.Rows[e.RowIndex].DefaultCellStyle.BackColor = flag ? Color.LightGreen : Color.White;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            List<string> repeatedItemIDs = new List<string>();
            StringBuilder repeatedItemIDsMessage = new StringBuilder();



            foreach (DataGridViewRow itemRow in dgvDespatchInstruction.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = itemRow.Cells[0] as DataGridViewCheckBoxCell;
                bool isSelected = checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value;

                if (isSelected)
                {
                    bool isDuplicate = false;

                    foreach (DataGridViewRow requestRow in dgvDespatchConfirmList.Rows)
                    {

                        if (requestRow.Cells[1].Value != null && itemRow.Cells[1].Value != null && itemRow.Cells[1].Value.ToString() != requestRow.Cells[1].Value.ToString()
                             || itemRow.Cells[2].Value.ToString() == requestRow.Cells[2].Value.ToString())

                        {
                            isDuplicate = true;
                            repeatedItemIDs.Add(requestRow.Cells[1].Value.ToString());
                            break;
                    }
                }

                    if (!isDuplicate)
                    {
                        int i = dgvDespatchConfirmList.Rows.Add();
                        dgvDespatchConfirmList.Rows[i].Cells[1].Value = itemRow.Cells[1].Value?.ToString();
                        dgvDespatchConfirmList.Rows[i].Cells[2].Value = itemRow.Cells[2].Value?.ToString();
                        dgvDespatchConfirmList.Rows[i].Cells[3].Value = itemRow.Cells[3].Value?.ToString();
                        dgvDespatchConfirmList.Rows[i].Cells[4].Value = itemRow.Cells[4].Value?.ToString();
                        dgvDespatchConfirmList.Rows[i].Cells[5].Value = itemRow.Cells[5].Value?.ToString();
                        dgvDespatchConfirmList.Rows[i].Cells[6].Value = itemRow.Cells[6].Value?.ToString();
                        dgvDespatchConfirmList.Rows[i].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
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
                repeatedItemIDsMessage.Append("Only accpet one Request ID: ");
                repeatedItemIDsMessage.Append(string.Join(", ", repeatedItemIDs));
                MessageBox.Show(repeatedItemIDsMessage.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvDespatchConfirmList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            // Iterate over the rows in dgvDespatchConfirmList
            foreach (DataGridViewRow row in dgvDespatchConfirmList.Rows)
            {
                // Check if the checkbox in the row is selected
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
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
                string virtualItemId = row.Cells[2].Value?.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to remove  item ID: " + virtualItemId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvDespatchConfirmList.Rows.Remove(row);
                }
            }
        }

        private void btnRemoveAllItem_Click(object sender, EventArgs e)
        {
            if (dgvDespatchConfirmList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove all items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvDespatchConfirmList.Rows.Clear();
                }
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (dgvDespatchConfirmList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            List<UI.DespatchConfirm.DespatchConfirm> despatchConfirms = new List<UI.DespatchConfirm.DespatchConfirm>();

            foreach (DataGridViewRow row in dgvDespatchConfirmList.Rows)
            {
                string requestID = row.Cells[1].Value?.ToString();
                string itemID = row.Cells[2].Value?.ToString();
                string itemName = row.Cells[3].Value?.ToString();
                string requestQty = row.Cells[4].Value?.ToString();
                string unit = row.Cells[5].Value?.ToString();
                string itemStatus = row.Cells[6].Value?.ToString();

                try
                {
                    UI.DespatchConfirm.DespatchConfirm despatchConfirm = new UI.DespatchConfirm.DespatchConfirm()
                    {
                        requestID = requestID,
                        ItemName = itemName,
                        itemID = itemID,
                        requestQty = int.Parse(requestQty),
                        unit = unit,
                        itemStatus = itemStatus

                    };
                    despatchConfirms.Add(despatchConfirm);
                }
                catch (Exception)
                {
                    MessageBox.Show("There have empty qty or format incorrrect, please input again!");
                    return;
                }
            }

            // Pass the confirmed items to the RequestForm
            DespatchForm despatchForm = new DespatchForm();
            despatchForm.DespatchConfirms = despatchConfirms;
            despatchForm.ShowDialog();
            dgvDespatchConfirmList.Rows.Clear();
            btnSearch.PerformClick();

        }


        private void dgvDespatchInstruction_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {

                // Set the desired font for the column header
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }


        private void dgvDespatchConfirmList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Set the desired font for the column header
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }

        private void dgvDespatchInstruction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    Color backgroundColor;
                    // item status
                    switch (status)
                    {
                        case "Pending":
                            backgroundColor = Color.Yellow;
                            break;
                        case "In Progress":
                            backgroundColor = Color.LightCyan;
                            break;
                        case "Update":
                            backgroundColor = Color.LightSkyBlue;
                            break;
                        default:
                            backgroundColor = Color.White;
                            break;
                    }
                    e.CellStyle.BackColor = backgroundColor;
                }
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.PerformClick();
                    // stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    }

