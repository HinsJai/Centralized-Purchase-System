using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Crypto.Agreement;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.DespatchInstructionControls
{
    public partial class DespatchControl : UserControl
    {

        private readonly Connection_class despatchConn = new Connection_class();
        private readonly DataTable despatchTable = new DataTable();
        private DespatchInstructionDetails despatchInstructionDetails;
        private string query = @"SELECT di.*, r.restaurantName, request_record.pickUpDate
                                                FROM despatch_instruction di
                                                JOIN restaurant r ON di.restaurantID = r.RestaurantID
                                               JOIN request_record ON di.requestID = request_record.requestID ";

        public DespatchControl()
        {
            InitializeComponent();
        }

        private void DespatchControl_Load(object sender, EventArgs e)
        {
            displayDespatch();
            cbSearchType.SelectedIndex = 0;
            dgvDespatchList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDespatchList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvDespatchList.EnableHeadersVisualStyles = false;
        }

        private void displayDespatch()
        {

            using (var conn = new MySqlConnection(despatchConn.conndb.ConnectionString))
            {

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))

                        adapter.Fill(despatchTable);
                    dgvDespatchList.Rows.Clear();
                    FillData();
                    dgvDespatchList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                }
            }
        }
        private void FillData()
        {
            foreach (DataRow row in despatchTable.Rows)
            {
                int n = dgvDespatchList.Rows.Add();
                dgvDespatchList.Rows[n].Cells[0].Value = row["despatchID"].ToString();
                dgvDespatchList.Rows[n].Cells[1].Value = "Purchase manger ID： " + row["purchaseManagerID"].ToString();
                dgvDespatchList.Rows[n].Cells[2].Value = row["restaurantID"].ToString();
                dgvDespatchList.Rows[n].Cells[3].Value = row["restaurantName"].ToString();
                DateTime pickUpDate = Convert.ToDateTime(row["pickUpDate"]);
                string formattedPickUpDate = pickUpDate.ToString("yyyy-MM-dd");
                dgvDespatchList.Rows[n].Cells[4].Value = formattedPickUpDate;
                dgvDespatchList.Rows[n].Cells[5].Value = row["status"].ToString();
                dgvDespatchList.Rows[n].Cells[6].Value = row["requestID"].ToString();
            }
        }

        private void dgvDespatchList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvDespatchList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvDespatchList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvDespatchList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string despatchID = selectedRow.Cells[0].Value.ToString();
                    string handleBy = selectedRow.Cells[1].Value.ToString();
                    string restaurantID = selectedRow.Cells[2].Value.ToString();
                    string restaurantName = selectedRow.Cells[3].Value.ToString();
                    string pickUpDate = selectedRow.Cells[4].Value.ToString();
                    string status = selectedRow.Cells[5].Value.ToString();
                    string requestID = selectedRow.Cells[6].Value.ToString();


                    if (despatchInstructionDetails == null || despatchInstructionDetails.IsDisposed)
                    {
                        despatchInstructionDetails = new DespatchInstructionDetails();
                    }

                    despatchInstructionDetails.SetData(despatchID, handleBy, restaurantID, restaurantName, pickUpDate, status, requestID);

                    despatchInstructionDetails.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvDespatchList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.ColumnIndex == 5)
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    Color backgroundColor;

                    switch (status)
                    {
                        case "In Progress":
                            backgroundColor = Color.Yellow;
                            break;
                        case "Completed":
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();
            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchItem("despatchID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("di.restaurantID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("r.restaurantName", input);
                }


                if (despatchTable.Rows.Count == 0)
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
            string searchQuery = query + $" Where {colName} LIKE @input ";
            using (var conn = new MySqlConnection(despatchConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    despatchTable.Clear();
                    adapter.Fill(despatchTable);
                    dgvDespatchList.Rows.Clear();
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
