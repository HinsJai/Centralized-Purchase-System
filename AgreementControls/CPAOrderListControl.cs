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
    public partial class CPAOrderListControl : UserControl
    {

        private readonly Connection_class CPAOrderConn = new Connection_class();
        private readonly DataTable CPAOrderTable = new DataTable();
        private CPAOrderListDetails cpaOrderListDetails;
        private string query = @"SELECT * FROM contract_order ";
        private string orderType;
        private string agreementID;
        private string supplierID;
        private string supplierName;
        private string shipToAddress;
        private string createDate;
        private string pickUpDate;
        private string status;

        public CPAOrderListControl()
        {
            InitializeComponent();
        }

        private void CPAOrderListControl_Load(object sender, EventArgs e)
        {
            displayCPAOrder();
            cbSearchType.SelectedIndex = 0;
            dgvCPAOrderList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvCPAOrderList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvCPAOrderList.EnableHeadersVisualStyles = false;
        }

        private void displayCPAOrder()
        {

            using (var conn = new MySqlConnection(CPAOrderConn.conndb.ConnectionString))
            {

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    
                        adapter.Fill(CPAOrderTable);
                        dgvCPAOrderList.Rows.Clear();
                        FillData();
                        dgvCPAOrderList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                    }
                }
            }

        private void FillData()
        {
            foreach (DataRow row in CPAOrderTable.Rows)
            {
                int n = dgvCPAOrderList.Rows.Add();
                dgvCPAOrderList.Rows[n].Cells[0].Value = row["contractOrderID"].ToString();
                dgvCPAOrderList.Rows[n].Cells[1].Value = row["orderType"].ToString();
                dgvCPAOrderList.Rows[n].Cells[2].Value = row["AgreementID"].ToString();
                dgvCPAOrderList.Rows[n].Cells[3].Value = row["SupplierID"].ToString();
                dgvCPAOrderList.Rows[n].Cells[4].Value = row["supplierName"].ToString();
                dgvCPAOrderList.Rows[n].Cells[5].Value = row["ShipToAddress"].ToString();

                // Extract only the date portion from the DateTime value
                DateTime createUpDate = Convert.ToDateTime(row["createDate"]);
                string formattedCreateDate = createUpDate.ToString("yyyy-MM-dd");
                dgvCPAOrderList.Rows[n].Cells[6].Value = formattedCreateDate;
                DateTime pickUpDate = Convert.ToDateTime(row["pickUpDate"]);
                string formattedPickUpDate = pickUpDate.ToString("yyyy-MM-dd");
                dgvCPAOrderList.Rows[n].Cells[7].Value = formattedPickUpDate;
                dgvCPAOrderList.Rows[n].Cells[8].Value = row["status"].ToString();
            }

        }

        private void dgvCPAOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }


            if (e.ColumnIndex == 8)
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

        private void dgvCPAOrderList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvCPAOrderList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvCPAOrderList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvCPAOrderList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string orderID = selectedRow.Cells[0].Value.ToString();
                    orderType = selectedRow.Cells[1].Value.ToString();
                    agreementID = selectedRow.Cells[2].Value.ToString();
                    supplierID = selectedRow.Cells[3].Value.ToString();
                    supplierName = selectedRow.Cells[4].Value.ToString();
                    shipToAddress = selectedRow.Cells[5].Value.ToString();
                    createDate = selectedRow.Cells[6].Value.ToString();
                    pickUpDate = selectedRow.Cells[7].Value.ToString();
                    status = selectedRow.Cells[8].Value.ToString();



                    // Create a new instance of BPAOrderForm if it doesn't exist
                    if (cpaOrderListDetails == null || cpaOrderListDetails.IsDisposed)
                    {
                        cpaOrderListDetails = new CPAOrderListDetails(orderID);
                    }

                    // Set the selected data in the BPAOrderForm
                    cpaOrderListDetails.SetData(orderType, agreementID, supplierID, supplierName, shipToAddress, createDate, pickUpDate, status);

                    cpaOrderListDetails.Show();
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
                    searchItem("contractOrderID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("agreementID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("supplierID", input);
                }

                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchItem("supplierName", input);
                }

                if (CPAOrderTable.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                    tbSearch.Text = "";
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
            using (var conn = new MySqlConnection(CPAOrderConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    CPAOrderTable.Clear();
                    adapter.Fill(CPAOrderTable);
                    dgvCPAOrderList.Rows.Clear();
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
