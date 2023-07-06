using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;

namespace UI.AgreementControls
{
    public partial class PlannedPurchaseAgreementControl : UserControl
    {

        private readonly Connection_class PPAListConn = new Connection_class();
        private readonly DataTable PPAMangeList = new DataTable();
        string query;
        public PlannedPurchaseAgreementControl()
        {
            InitializeComponent();
        }

        private void PlannedPurchaseAgreementControl_Load(object sender, EventArgs e)
        {
            CheckIsValidPPA();
            displayPPAData();
            cbSearchType.SelectedIndex = 0;
        }

        private void CheckIsValidPPA()
        {
            try
            {
                using (var conn = new MySqlConnection(PPAListConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE ppa SET Status = 'Invalid' WHERE EndDate < CURDATE()";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        int affectedRows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void displayPPAData()
        {

            PPAMangeList.Clear(); // Clear the DataTable
            PPAMangeList.Columns.Clear(); // Remove existing columns
            using (var conn = new MySqlConnection(PPAListConn.conndb.ConnectionString))
            {
                query = "SELECT ContractNumber as 'Contract Number', StartDate as 'Start Date', EndDate as 'End Date', EffectiveDay as 'Effective Day', TentativeSchedules as 'Tentative Schedules', SupplierID as 'Supplier ID', ItemID as 'Item ID', Status " +
                    "FROM ppa";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(PPAMangeList);
                        dgvPPA.DataSource = PPAMangeList;
                    }
                }
            }
            dgvPPA.RowTemplate.Height = 35;
        }
        private void dgvPPA_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvPPA.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void dgvPPA_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPPA.CurrentCell != null)
            {
                try
                {
                    // Get the selected row index
                    int rowIndex = dgvPPA.CurrentCell.RowIndex;

                    // Get the actual item ID from the selected row in the dgvMappingList
                    string contractNumber = dgvPPA.Rows[rowIndex].Cells["Contract Number"].Value.ToString();
                    //string effectiveDay = 
                    string supplierID = dgvPPA.Rows[rowIndex].Cells["Supplier ID"].Value.ToString();
                    int itemID = (int)dgvPPA.Rows[rowIndex].Cells["Item ID"].Value;

                    PPADetails ppaDetails = new PPADetails(contractNumber);
                    ppaDetails.ShowDialog();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void dgvPPA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }


            if (e.RowIndex >= 0 && e.ColumnIndex == dgvPPA.Columns["Status"].Index)
            {
                string status = e.Value.ToString();

                // Set the background color based on the status value
                if (status == "Valid")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else if (status == "Invalid")
                {
                    e.CellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void searchPPA(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, PPAListConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                PPAMangeList.Clear();
                adapter.Fill(PPAMangeList);
                dgvPPA.DataSource = PPAMangeList;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearchPPA.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchPPA("contractNumber", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchPPA("SupplierID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchPPA("ItemID", input);
                }

                if (PPAMangeList.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
                tbSearchPPA.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnNewPPA_Click(object sender, EventArgs e)
        {
            PlannedPurchaseAgreement plannedPurchaseAgreement = new PlannedPurchaseAgreement();
            plannedPurchaseAgreement.ShowDialog();
        }

        private void tbSearchPPA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void lblPPAList_Click(object sender, EventArgs e)
        {

        }

        private void dgvPPA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
