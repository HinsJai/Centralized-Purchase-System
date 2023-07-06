using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;

namespace UI.AgreementControls
{
    public partial class BlanketPurchaseAgreementControl : UserControl
    {

        private readonly Connection_class BPAListConn = new Connection_class();
        private readonly DataTable BPAMangeList = new DataTable();
        string query;
        public BlanketPurchaseAgreementControl()
        {
            InitializeComponent();
        }

        private void BlanketPurchaseAgreementControl_Load(object sender, EventArgs e)
        {
            CheckIsValidBPA();
            displayBPAData();
            cbSearchType.SelectedIndex = 0;
        }

        private void btnNewBPA_Click(object sender, EventArgs e)
        {
            BlanketPurchaseAgreement blanketPurchaseAgreement = new BlanketPurchaseAgreement();
            blanketPurchaseAgreement.ShowDialog();
        }
        private void displayBPAData()
        {

            BPAMangeList.Clear(); // Clear the DataTable
            BPAMangeList.Columns.Clear(); // Remove existing columns
            using (var conn = new MySqlConnection(BPAListConn.conndb.ConnectionString))
            {
                query = "SELECT ContractNumber as 'Contract Number', StartDate as 'Start Date', EndDate as 'End Date', EffectiveDay as 'Effective Day', SupplierID as 'Supplier ID', ItemID as 'Item ID', Status " +
                    "FROM bpa";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(BPAMangeList);
                        dgvBlanketPurchaseAgreement.DataSource = BPAMangeList;
                    }
                }
            }
            dgvBlanketPurchaseAgreement.RowTemplate.Height = 35;
        }


        private void dgvBlanketPurchaseAgreement_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvBlanketPurchaseAgreement.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void dgvBlanketPurchaseAgreement_DoubleClick(object sender, EventArgs e)
        {

            if (dgvBlanketPurchaseAgreement.CurrentCell != null)
            {
                try
                {
                    // Get the selected row index
                    int rowIndex = dgvBlanketPurchaseAgreement.CurrentCell.RowIndex;

                    // Get the actual item ID from the selected row in the dgvMappingList
                    string contractNumber = dgvBlanketPurchaseAgreement.Rows[rowIndex].Cells["Contract Number"].Value.ToString();
                    string supplierID = dgvBlanketPurchaseAgreement.Rows[rowIndex].Cells["Supplier ID"].Value.ToString();
                    int itemID = (int)dgvBlanketPurchaseAgreement.Rows[rowIndex].Cells["Item ID"].Value;

                    BPADetails bpaDetails = new BPADetails(contractNumber, supplierID, itemID);
                    bpaDetails.ShowDialog();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearchBPA.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchBPA("contractNumber", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchBPA("SupplierID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchBPA("ItemID", input);
                }
             
                if (BPAMangeList.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
                tbSearchBPA.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void searchBPA(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, BPAListConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                BPAMangeList.Clear();
                adapter.Fill(BPAMangeList);
                dgvBlanketPurchaseAgreement.DataSource = BPAMangeList;
            }
        }

        private void tbSearchBPA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvBlanketPurchaseAgreement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBlanketPurchaseAgreement.Columns["Status"].Index)
            {
                string status = e.Value.ToString();

                dgvBlanketPurchaseAgreement.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = SystemColors.GradientInactiveCaption;


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

        private void CheckIsValidBPA()
        {
            try
            {
                using (var conn = new MySqlConnection(BPAListConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE bpa SET Status = 'Invalid' WHERE EndDate < CURDATE()";
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
    }
}

