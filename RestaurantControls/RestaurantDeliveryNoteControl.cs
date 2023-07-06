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

namespace UI.RestaurantControls
{
    public partial class RestaurantDeliveryNoteControl : UserControl
    {
        private string userID = User.UserID;
        private readonly Connection_class ResDeliveryNoteConn = new Connection_class();
        private readonly DataTable ResDeliveryNoteTable = new DataTable();
        private ResDeliveryNoteDetails resDeliveryNoteDetails;
        private string query = $"SELECT delivery_note.deliveryNoteID,delivery_note.requestID, delivery_note.restaurantID,  " +
            $"delivery_note.restaurantName,delivery_note.shipAddress, delivery_note.deliveryDate,delivery_note.status " +
            $"FROM delivery_note " +
            $"JOIN request_record ON delivery_note.requestID = request_record.requestID " +
            $"WHERE request_record.userID = @userID ";
        public RestaurantDeliveryNoteControl()
        {
            InitializeComponent();
        }

        private void RestaurantDeliveryNoteControl_Load(object sender, EventArgs e)
        {
            displayDeliveryOrder();
            cbSearchType.SelectedIndex = 0;
            dgvResDeliveryNoteList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvResDeliveryNoteList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvResDeliveryNoteList.EnableHeadersVisualStyles = false;
        }

        private void displayDeliveryOrder()
        {
            using (var conn = new MySqlConnection(ResDeliveryNoteConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(ResDeliveryNoteTable);
                        dgvResDeliveryNoteList.Rows.Clear();
                        FillData();
                        dgvResDeliveryNoteList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                    }
                }
            }
        }


        private void FillData()
        {
            foreach (DataRow row in ResDeliveryNoteTable.Rows)
            {
                int n = dgvResDeliveryNoteList.Rows.Add();
                dgvResDeliveryNoteList.Rows[n].Cells[0].Value = row["deliveryNoteID"].ToString();
                dgvResDeliveryNoteList.Rows[n].Cells[1].Value = row["requestID"].ToString();
                dgvResDeliveryNoteList.Rows[n].Cells[2].Value = row["restaurantID"].ToString();
                dgvResDeliveryNoteList.Rows[n].Cells[3].Value = row["restaurantName"].ToString();
                dgvResDeliveryNoteList.Rows[n].Cells[4].Value = row["shipAddress"].ToString();

                DateTime dtpDeliveryDate = Convert.ToDateTime(row["deliveryDate"]);
                string formDtpDeliveryDate = dtpDeliveryDate.ToString("yyyy-MM-dd");
                dgvResDeliveryNoteList.Rows[n].Cells[5].Value = formDtpDeliveryDate;
                dgvResDeliveryNoteList.Rows[n].Cells[6].Value = row["status"].ToString();
            }
        }

        private void dgvResDeliveryNoteList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
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

        private void dgvResDeliveryNoteList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvResDeliveryNoteList.SelectedCells.Count > 0) // Make sure a valid row is clicked
                {
                    int selectedRowIndex = dgvResDeliveryNoteList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvResDeliveryNoteList.Rows[selectedRowIndex];

                    // Get the selected data from the clicked row
                    string deliveryID = selectedRow.Cells[0].Value.ToString();
                    string requestID = selectedRow.Cells[1].Value.ToString();
                    string restaurantID = selectedRow.Cells[2].Value.ToString();
                    string restaurantName = selectedRow.Cells[3].Value.ToString();
                    string shipAddress = selectedRow.Cells[4].Value.ToString();
                    string deliveryDate = selectedRow.Cells[5].Value.ToString();
                    string status = selectedRow.Cells[6].Value.ToString();

                    if (resDeliveryNoteDetails == null || resDeliveryNoteDetails.IsDisposed)
                    {
                        resDeliveryNoteDetails = new ResDeliveryNoteDetails();
                    }

                    // Set the selected data in the PPAOrderForm
                    resDeliveryNoteDetails.SetData(deliveryID, requestID, restaurantID, restaurantName, shipAddress, deliveryDate, status);

                    resDeliveryNoteDetails.Show();
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
                    searchItem("delivery_note.requestID", input);
                }
                if (ResDeliveryNoteTable.Rows.Count == 0)
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

            string searchQuery = query + $" AND {colName}  LIKE @input";
            using (var conn = new MySqlConnection(ResDeliveryNoteConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@userID", userID);
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    ResDeliveryNoteTable.Clear();
                    adapter.Fill(ResDeliveryNoteTable);
                    dgvResDeliveryNoteList.Rows.Clear();
                    FillData();
                }
            }
        }
    }
}
