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

namespace UI.AccountingControls
{
    public partial class AccountingDeliveryNoteControl : UserControl
    {
        private readonly Connection_class deliveryNoteConn = new Connection_class();
        private readonly DataTable AccountDeliveryNoteTable = new DataTable();
        private AccountDeliveryNoteDetails accountDeliveryNoteDetails;
        private string query = @"SELECT * FROM delivery_note";
        public AccountingDeliveryNoteControl()
        {
            InitializeComponent();
        }

        private void AccountingDeliveryNoteControl_Load(object sender, EventArgs e)
        {
            displayDeliveryNote();
            cbSearchType.SelectedIndex = 0;
            dgvAccountDeliveryNoteList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvAccountDeliveryNoteList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvAccountDeliveryNoteList.EnableHeadersVisualStyles = false;
        }

        private void displayDeliveryNote()
        {
            using (var conn = new MySqlConnection(deliveryNoteConn.conndb.ConnectionString))
            {

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(AccountDeliveryNoteTable);
                        dgvAccountDeliveryNoteList.Rows.Clear();
                        FillData();
                        dgvAccountDeliveryNoteList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                    }
                }
            }
        }
        private void FillData()
        {
            foreach (DataRow row in AccountDeliveryNoteTable.Rows)
            {
                int n = dgvAccountDeliveryNoteList.Rows.Add();
                dgvAccountDeliveryNoteList.Rows[n].Cells[0].Value = row["deliveryNoteID"].ToString();
                dgvAccountDeliveryNoteList.Rows[n].Cells[1].Value = row["requestID"].ToString();
                dgvAccountDeliveryNoteList.Rows[n].Cells[2].Value = row["restaurantID"].ToString();

                dgvAccountDeliveryNoteList.Rows[n].Cells[3].Value = row["restaurantName"].ToString();
                dgvAccountDeliveryNoteList.Rows[n].Cells[4].Value = row["restaurantContact"].ToString();

                DateTime pickUpDate = Convert.ToDateTime(row["deliveryDate"]);
                string formattedPickUpDate = pickUpDate.ToString("yyyy-MM-dd");
                dgvAccountDeliveryNoteList.Rows[n].Cells[5].Value = formattedPickUpDate;

                DateTime createUpDate = Convert.ToDateTime(row["createDate"]);
                string formattedCreateDate = createUpDate.ToString("yyyy-MM-dd");
                dgvAccountDeliveryNoteList.Rows[n].Cells[6].Value = formattedCreateDate;
                dgvAccountDeliveryNoteList.Rows[n].Cells[7].Value = row["shipAddress"].ToString();
                dgvAccountDeliveryNoteList.Rows[n].Cells[8].Value = row["status"].ToString();

            }
        }

        private void dgvAccountDeliveryNoteList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                    switch (status)
                    {
                        case "In Progress":
                            backgroundColor = Color.Yellow;
                            break;
                        case "Completed":
                            backgroundColor = Color.LightGreen;
                            break;
                        case "Delivered":
                            backgroundColor = Color.LightBlue;
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

        private void dgvAccountDeliveryNoteList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccountDeliveryNoteList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvAccountDeliveryNoteList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAccountDeliveryNoteList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string deliveryID = selectedRow.Cells[0].Value.ToString();
                    string requestID = selectedRow.Cells[1].Value.ToString();
                    string restaurantID = selectedRow.Cells[2].Value.ToString();
                    string restaurantName = selectedRow.Cells[3].Value.ToString();
                    string restaurantContact = selectedRow.Cells[4].Value.ToString();
                    string deliveryDate = selectedRow.Cells[5].Value.ToString();
                    string createDate = selectedRow.Cells[6].Value.ToString();
                    string address = selectedRow.Cells[7].Value.ToString();
                    string status = selectedRow.Cells[8].Value.ToString();

                    if (accountDeliveryNoteDetails == null || accountDeliveryNoteDetails.IsDisposed)
                    {
                        accountDeliveryNoteDetails = new AccountDeliveryNoteDetails();
                    }

                    accountDeliveryNoteDetails.SetData(deliveryID, requestID, restaurantID,restaurantName, restaurantContact, deliveryDate, createDate, status, address);

                    accountDeliveryNoteDetails.Show();
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
                    searchItem("deliveryNoteID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("requestID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("restaurantID", input);
                }
                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchItem("restaurantName", input);
                }

                if (AccountDeliveryNoteTable.Rows.Count == 0)
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
            using (var conn = new MySqlConnection(deliveryNoteConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    AccountDeliveryNoteTable.Clear();
                    adapter.Fill(AccountDeliveryNoteTable);
                    dgvAccountDeliveryNoteList.Rows.Clear();
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
