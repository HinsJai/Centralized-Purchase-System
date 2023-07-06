using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;

namespace UI.AgreementControls
{
    public partial class ContractPurchaseAgreementControl : UserControl
    {
        private readonly Connection_class CPAListConn = new Connection_class();
        private readonly DataTable CPAMangeList = new DataTable();
        string query;
        public ContractPurchaseAgreementControl()
        {
            InitializeComponent();
        }

        private void ContractPurchaseAgreementControl_Load(object sender, EventArgs e)
        {
            CheckIsValidCPA();
            displayCPAData();
            cbSearchType.SelectedIndex = 0;
        }

        private void displayCPAData()
        {

            CPAMangeList.Clear(); // Clear the DataTable
            CPAMangeList.Columns.Clear(); // Remove existing columns
            using (var conn = new MySqlConnection(CPAListConn.conndb.ConnectionString))
            {
                query = "SELECT ContractNumber as 'Contract Number', StartDate as 'Start Date', EndDate as 'End Date', EffectiveDay as 'Effective Day', SupplierID as 'Supplier ID',  Status " +
                    "FROM cpa";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(CPAMangeList);
                        dgvContractPurchaseAgreement.DataSource = CPAMangeList;
                    }
                }
            }
            dgvContractPurchaseAgreement.RowTemplate.Height = 35;
        }

        private void dgvContractPurchaseAgreement_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvContractPurchaseAgreement.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void dgvContractPurchaseAgreement_DoubleClick(object sender, EventArgs e)
        {
            if (dgvContractPurchaseAgreement.CurrentCell != null)
            {
                try
                {
                    // Get the selected row index
                    int rowIndex = dgvContractPurchaseAgreement.CurrentCell.RowIndex;

                    // Get the actual item ID from the selected row in the dgvMappingList
                    string contractNumber = dgvContractPurchaseAgreement.Rows[rowIndex].Cells["Contract Number"].Value.ToString();
                    string supplierID = dgvContractPurchaseAgreement.Rows[rowIndex].Cells["Supplier ID"].Value.ToString();
/*                    int itemID = (int)dgvContractPurchaseAgreement.Rows[rowIndex].Cells["Item ID"].Value;
*/
                    CPADetails cpaDetails = new CPADetails(contractNumber, supplierID);
                    cpaDetails.ShowDialog();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnNewCPA_Click(object sender, EventArgs e)
        {
            ContractPurchaseAgreement cpa = new ContractPurchaseAgreement();
            cpa.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearchCPA.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchCPA("contractNumber", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchCPA("SupplierID", input);
                }
             /*   else if (cbSearchType.SelectedIndex == 2)
                {
                    searchCPA("ItemID", input);
                }*/

                if (CPAMangeList.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
                tbSearchCPA.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void searchCPA(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, CPAListConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                CPAMangeList.Clear();
                adapter.Fill(CPAMangeList);
                dgvContractPurchaseAgreement.DataSource = CPAMangeList;
            }
        }

        private void dgvContractPurchaseAgreement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;

                if (e.ColumnIndex == dgvContractPurchaseAgreement.Columns["Status"].Index)
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
        }


        private void CheckIsValidCPA()
        {
            try
            {
                using (var conn = new MySqlConnection(CPAListConn.conndb.ConnectionString))
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

        private void tbSearchCPA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnCreateCPAOrder_Click(object sender, EventArgs e)
        {
            CPAOrder cpaOrders = new CPAOrder();
            cpaOrders.ShowDialog();
        }
    }
}
