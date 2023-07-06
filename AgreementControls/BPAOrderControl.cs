using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Crypto.Agreement;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;

namespace UI.AgreementControls
{
    public partial class BPAOrderControl : UserControl
    {

        private readonly Connection_class BPAOrderConn = new Connection_class();
        private readonly DataTable BPAOrderTable = new DataTable();
        private BPAOrderDetails bpaOrderDetails;
       private string query = @"SELECT orders.orderID AS 'Order ID', orders.order_type AS 'Order Type',
                                   orders.requestID AS 'Request ID', orders.order_agreement_id AS 'Agreement ID',
                                   orders.item_aID AS 'Item ID', vidmapping.vName,
                                   orders.order_qty AS 'Qty', orders.unit, orders.remark,orders.status AS 'Status',
                                    orders.pickUpDate , orders.createDate
                            FROM orders
                            INNER JOIN vidmapping ON orders.item_vID = vidmapping.vID WHERE order_type = 'bpa'";

        public BPAOrderControl()
        {
            InitializeComponent();
        }

        private void BPAOrder_Load(object sender, EventArgs e)
        {
            displayBPAOrder();
            cbSearchType.SelectedIndex = 0;
            dgvBPAOrderList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvBPAOrderList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvBPAOrderList.EnableHeadersVisualStyles = false;
        }
        /*        dgvBPAOrderList
        */
        private void displayBPAOrder()
        {

            using (var conn = new MySqlConnection(BPAOrderConn.conndb.ConnectionString))
            {

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                      adapter.Fill(BPAOrderTable);
                        dgvBPAOrderList.Rows.Clear();
                        FillData();
                        dgvBPAOrderList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                    }
                }
            }
        }

        private void FillData()
        {
            foreach (DataRow row in BPAOrderTable.Rows)
            {
                int n = dgvBPAOrderList.Rows.Add();
                dgvBPAOrderList.Rows[n].Cells[0].Value = row["Order ID"].ToString();
                dgvBPAOrderList.Rows[n].Cells[1].Value = row["Order Type"].ToString();
                dgvBPAOrderList.Rows[n].Cells[2].Value = row["Request ID"].ToString();
                dgvBPAOrderList.Rows[n].Cells[3].Value = row["Agreement ID"].ToString();
                dgvBPAOrderList.Rows[n].Cells[4].Value = row["Item ID"].ToString();
                dgvBPAOrderList.Rows[n].Cells[5].Value = row["vName"].ToString();
                dgvBPAOrderList.Rows[n].Cells[6].Value = row["Qty"].ToString();
                dgvBPAOrderList.Rows[n].Cells[7].Value = row["unit"].ToString();

                // Extract only the date portion from the DateTime value
                DateTime createUpDate = Convert.ToDateTime(row["createDate"]);
                string formattedCreateDate = createUpDate.ToString("yyyy-MM-dd");
                dgvBPAOrderList.Rows[n].Cells[8].Value = formattedCreateDate;
                DateTime pickUpDate = Convert.ToDateTime(row["pickUpDate"]);
                string formattedPickUpDate = pickUpDate.ToString("yyyy-MM-dd");
                dgvBPAOrderList.Rows[n].Cells[9].Value = formattedPickUpDate;
                dgvBPAOrderList.Rows[n].Cells[10].Value = row["remark"].ToString();
                dgvBPAOrderList.Rows[n].Cells[11].Value = row["Status"].ToString();
            }

        }

        private void dgvBPAOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    Color backgroundColor;
                    // bpa order status
                    switch (status)
                    {
                        case "In Progress":
                            backgroundColor = Color.Yellow;
                            break;
                        case "Competed":
                            backgroundColor = Color.LightGreen;
                            break;
                        case "Cancelled":
                            backgroundColor = Color.Red;
                            break;
                        default:
                            backgroundColor = Color.White;
                            break;
                    }
                    e.CellStyle.BackColor = backgroundColor;
                }
            }
        }

        private void dgvBPAOrderList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvBPAOrderList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvBPAOrderList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvBPAOrderList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string orderID = selectedRow.Cells[0].Value.ToString();
                    string orderType = selectedRow.Cells[1].Value.ToString();
                    string agreementID = selectedRow.Cells[3].Value.ToString();
                    string itemID = selectedRow.Cells[4].Value.ToString();
                    string itemName = selectedRow.Cells[5].Value.ToString();
                    string orderQty = selectedRow.Cells[6].Value.ToString();
                    string unit = selectedRow.Cells[7].Value.ToString();
                    string requestDateTime = selectedRow.Cells[8].Value.ToString();
                    string pickUpDate = selectedRow.Cells[9].Value.ToString();
                    string remark = selectedRow.Cells[10].Value.ToString();
                    string status = selectedRow.Cells[11].Value.ToString();



                    // Create a new instance of BPAOrderForm if it doesn't exist
                    if (bpaOrderDetails == null || bpaOrderDetails.IsDisposed)
                    {
                        bpaOrderDetails = new BPAOrderDetails();
                    }

                    // Set the selected data in the BPAOrderForm
                    bpaOrderDetails.SetData(orderID, orderType, agreementID, itemID, itemName, orderQty, unit, pickUpDate, remark, status);

                    bpaOrderDetails.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();
            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchItem("orders.orderID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("orders.requestID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("orders.order_agreement_id", input);
                }

                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchItem("orders.item_aID", input);
                }

                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchItem("vidmapping.vName", input);
                }

                if (BPAOrderTable.Rows.Count == 0)
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
            using (var conn = new MySqlConnection(BPAOrderConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    BPAOrderTable.Clear();
                    adapter.Fill(BPAOrderTable);
                    dgvBPAOrderList.Rows.Clear();
                    FillData();
                }
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
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
}
