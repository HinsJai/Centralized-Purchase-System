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
using MySql.Data.MySqlClient;
using System.Collections;

namespace UI.AgreementControls
{
    public partial class RequestQueueControl : UserControl
    {
        private readonly Connection_class recordConn = new Connection_class();
        private readonly DataTable ReocordListTable = new DataTable();
        private static readonly string query = "SELECT rr.requestID, rr.requestDateTime, rr.pickUpDate, rr.remark, rr.status, ri.requestItemVID, ri.requestItemName, ri.requestItemTypeName, ri.requestItemCategory,ri.requestBrand, ri.requestQty, ri.unit,ri.itemStatus, i.stockItemQty FROM request_record rr INNER JOIN request_item ri ON rr.requestID = ri.requestID INNER JOIN vidmapping vm ON ri.requestItemVID = vm.vID INNER JOIN item i On vm.aID = i.itemID";
        private RequestQueueDetails requestQueueForm;
        public RequestQueueControl()
        {
            InitializeComponent();
        }

        private void RequestQueue_Load(object sender, EventArgs e)
        {
            SetTable();
            cbRecordSearchType.SelectedIndex = 0;
            dgvRecordList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvRecordList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvRecordList.EnableHeadersVisualStyles = false;
        }

        private void btnSearchRecord_Click(object sender, EventArgs e)
        {
            initializeStatus();

            string input = tbSearch.Text.Trim();

            try
            {
                if (cbRecordSearchType.SelectedIndex == 0)
                {
                    searchItem("rr.requestID", input);
                }
                else if (cbRecordSearchType.SelectedIndex == 1)
                {
                    searchItem("ri.requestItemVID", input);
                }
                else if (cbRecordSearchType.SelectedIndex == 2)
                {
                    searchItem("ri.requestItemName", input);
                }

                else if (cbRecordSearchType.SelectedIndex == 3)
                {
                    searchItem("ri.requestItemTypeName", input);
                }

                else if (cbRecordSearchType.SelectedIndex == 4)
                {
                    searchItem("ri.requestItemCategory", input);
                }
                else if (cbRecordSearchType.SelectedIndex == 5)
                {
                    searchItem("rr.requestDateTime", input);
                }
                else if (cbRecordSearchType.SelectedIndex == 6)
                {
                    searchItem("rr.status", input);
                }
                if (ReocordListTable.Rows.Count == 0)
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
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var conn = new MySqlConnection(recordConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    ReocordListTable.Clear();
                    adapter.Fill(ReocordListTable);
                    dgvRecordList.Rows.Clear();
                    FillData();
                }
            }
        }
        private void SetTable()
        {
            using (var conn = new MySqlConnection(recordConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(ReocordListTable);
                    dgvRecordList.Rows.Clear();
                    FillData();

                    dgvRecordList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                }
            }
        }
        private void FillData()
        {
            dgvRecordList.Rows.Clear();

            foreach (DataRow item in ReocordListTable.Rows)
            {
                int i = dgvRecordList.Rows.Add();

                dgvRecordList.Rows[i].Cells[0].Value = item["requestID"].ToString();
                dgvRecordList.Rows[i].Cells[1].Value = item["requestItemVID"].ToString();
                dgvRecordList.Rows[i].Cells[2].Value = item["requestItemName"].ToString();
                dgvRecordList.Rows[i].Cells[3].Value = item["requestItemTypeName"].ToString();
                dgvRecordList.Rows[i].Cells[4].Value = item["requestItemCategory"].ToString();
                dgvRecordList.Rows[i].Cells[5].Value = item["requestBrand"].ToString();
                dgvRecordList.Rows[i].Cells[6].Value = item["requestQty"].ToString();
                dgvRecordList.Rows[i].Cells[7].Value = item["unit"].ToString();
                dgvRecordList.Rows[i].Cells[8].Value = item["pickUpDate"].ToString();
                dgvRecordList.Rows[i].Cells[9].Value = item["requestDateTime"].ToString();
                dgvRecordList.Rows[i].Cells[10].Value = item["status"].ToString();
                dgvRecordList.Rows[i].Cells[11].Value = item["stockItemQty"].ToString();
                dgvRecordList.Rows[i].Cells[12].Value = item["remark"].ToString();
                dgvRecordList.Rows[i].Cells[13].Value = item["itemStatus"].ToString();
            }
        }

        private void dgvRecordList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.ColumnIndex == 10)
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    Color backgroundColor;
                    // request status
                    switch (status)
                    {
                        case "Pending":
                            backgroundColor = Color.Yellow;
                            break;
                        case "Review":
                            backgroundColor = Color.LightBlue;
                            break;
                        case "Approved":
                            backgroundColor = Color.LightGreen;
                            break;
                        case "Rejected":
                            backgroundColor = Color.Red;
                            break;
                        case "Order Placed":
                            backgroundColor = Color.LightCyan;
                            break;
                        case "Delivered":
                            backgroundColor = Color.LightGray;
                            break;
                        case "Completed":
                            backgroundColor = Color.LightGoldenrodYellow;
                            break;
                        case "Cancelled":
                            backgroundColor = Color.LightPink;
                            break;
                        case "Cancel Request":
                            backgroundColor = Color.LightSalmon;
                            break;
                        default:
                            backgroundColor = Color.White;
                            break;
                    }

                    e.CellStyle.BackColor = backgroundColor;
                }
            }

            if (e.ColumnIndex == 13)
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
                        case "Completed":
                            backgroundColor = Color.LightGreen;
                            break;
                        case "Rejected":
                            backgroundColor = Color.Red;
                            break;
                        case "Cancelled":
                            backgroundColor = Color.LightPink;
                            break;
                        case "Delivered":
                            backgroundColor = Color.LightGray;
                            break;
                        case "Cancel Request":
                            backgroundColor = Color.LightSalmon;
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
        private void dgvRecordList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecordList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvRecordList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvRecordList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string requestID = selectedRow.Cells[0].Value.ToString();
                    string requestItemVID = selectedRow.Cells[1].Value.ToString();
                    string requestItemName = selectedRow.Cells[2].Value.ToString();
                    string requestItemTypeName = selectedRow.Cells[3].Value.ToString();
                    string requestItemCategory = selectedRow.Cells[4].Value.ToString();
                    string requestBrand = selectedRow.Cells[5].Value.ToString();
                    string requestQty = selectedRow.Cells[6].Value.ToString();
                    string unit = selectedRow.Cells[7].Value.ToString();
                    string pickUpDate = selectedRow.Cells[8].Value.ToString();
                    string requestDateTime = selectedRow.Cells[9].Value.ToString();
                    string status = selectedRow.Cells[10].Value.ToString();
                    string sQty = selectedRow.Cells[11].Value.ToString();
                    string remark = selectedRow.Cells[12].Value.ToString();


                    // Create a new instance of RequestQueueForm if it doesn't exist
                    if (requestQueueForm == null || requestQueueForm.IsDisposed)
                    {
                        requestQueueForm = new RequestQueueDetails();
                    }

                    // Set the selected data in the RequestQueueForm
                    requestQueueForm.SetData(requestID, requestItemVID, requestItemName, requestItemTypeName, requestItemCategory, requestBrand, requestQty, unit, pickUpDate, requestDateTime, status, remark, sQty);


                    // Set the index of cbItemName to 0
                    requestQueueForm.SetComboBoxIndex(0);


                    requestQueueForm.Show();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchRecord.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void initializeStatus()
        {
            string updateQuery = "UPDATE request_record " +
                                 "SET status = 'Order Placed' " +
                                 "WHERE requestID IN ( " +
                                 "    SELECT ri.requestID " +
                                 "    FROM request_item ri " +
                                 "    WHERE ri.itemStatus = 'In Progress' " +
                                 "    GROUP BY ri.requestID " +
                                 "    HAVING COUNT(*) = ( " +
                                 "        SELECT COUNT(*) " +
                                 "        FROM request_item " +
                                 "        WHERE requestID = ri.requestID " +
                                 "    ) " +
                                 ")";

            using (var conn = new MySqlConnection(recordConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error updating status: " + err.Message);
                    }
                }
            }
        }


    }
}
