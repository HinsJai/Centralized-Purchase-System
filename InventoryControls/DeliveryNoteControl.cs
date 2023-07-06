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

namespace UI.DespatchInstructionControls
{

    public partial class DeliveryNoteControl : UserControl
    {
        private readonly Connection_class deliveryNoteConn = new Connection_class();
        private readonly DataTable deliveryNoteTable = new DataTable();
        private DeliveryNoteDetails deliveryNoteDetails;
        private string query = @"SELECT * FROM delivery_note";
        string shipAddress;

        public DeliveryNoteControl()
        {
            InitializeComponent();
        }

        private void DeliveryNoteList_Load(object sender, EventArgs e)
        {
            displayDeliveryOrder();
            cbSearchType.SelectedIndex = 0;
            dgvDeliveryNoteList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDeliveryNoteList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvDeliveryNoteList.EnableHeadersVisualStyles = false;
        }

        private void displayDeliveryOrder()
        {
            using (var conn = new MySqlConnection(deliveryNoteConn.conndb.ConnectionString))
            {

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(deliveryNoteTable);
                        dgvDeliveryNoteList.Rows.Clear();
                        FillData();
                        dgvDeliveryNoteList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                    }
                }
            }
        }

        private void FillData()
        {
            foreach (DataRow row in deliveryNoteTable.Rows)
            {
                int n = dgvDeliveryNoteList.Rows.Add();
                dgvDeliveryNoteList.Rows[n].Cells[0].Value = row["deliveryNoteID"].ToString();
                dgvDeliveryNoteList.Rows[n].Cells[1].Value = row["restaurantName"].ToString();
                dgvDeliveryNoteList.Rows[n].Cells[2].Value = row["restaurantContact"].ToString();

                DateTime pickUpDate = Convert.ToDateTime(row["deliveryDate"]);
                string formattedPickUpDate = pickUpDate.ToString("yyyy-MM-dd");
                dgvDeliveryNoteList.Rows[n].Cells[3].Value = formattedPickUpDate;

                DateTime createUpDate = Convert.ToDateTime(row["createDate"]);
                string formattedCreateDate = createUpDate.ToString("yyyy-MM-dd");
                dgvDeliveryNoteList.Rows[n].Cells[4].Value = formattedCreateDate;

                dgvDeliveryNoteList.Rows[n].Cells[5].Value = row["status"].ToString();

                shipAddress = row["shipAddress"].ToString();


            }
        }

        private void dgvDeliveryNoteList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dgvDeliveryNoteList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvDeliveryNoteList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvDeliveryNoteList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvDeliveryNoteList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string deliveryID = selectedRow.Cells[0].Value.ToString();
                    string restaurantName = selectedRow.Cells[1].Value.ToString();
                    string restaurantContact = selectedRow.Cells[2].Value.ToString();
                    string deliveryDate = selectedRow.Cells[3].Value.ToString();
                    string createDate = selectedRow.Cells[4].Value.ToString();
                    string status = selectedRow.Cells[5].Value.ToString();

                    if (deliveryNoteDetails == null || deliveryNoteDetails.IsDisposed)
                    {
                        deliveryNoteDetails = new DeliveryNoteDetails();
                    }

                    // Set the selected data in the PPAOrderForm
                    deliveryNoteDetails.SetData(deliveryID, restaurantName, restaurantContact, deliveryDate, createDate, status, shipAddress);

                    deliveryNoteDetails.Show();
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
                    searchItem("restaurantName", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchItem("restaurantContact", input);
                }

                if (deliveryNoteTable.Rows.Count == 0)
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
                    deliveryNoteTable.Clear();
                    adapter.Fill(deliveryNoteTable);
                    dgvDeliveryNoteList.Rows.Clear();
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
