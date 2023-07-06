using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace UI
{
    public partial class CPAOrder : Form
    {
        Connection_class cpaOrderConn = new Connection_class();
        private string contractNumber;
        private readonly DataTable CPAOrderTable = new DataTable();
        private string query = @"SELECT
                                                cpa.SupplierID,
                                                supplier.CompanyName,
                                                item.ItemID,
                                                item.ItemName,
                                                SUM(request_item.requestQty) AS TotalRequestQty,
                                                request_item.Unit
                                            FROM
                                                cpa
                                                INNER JOIN item ON cpa.SupplierID = item.SupplierID
                                                INNER JOIN vidmapping ON item.ItemID = vidmapping.aID
                                                INNER JOIN request_item ON vidmapping.vID = request_item.requestItemVID
                                                INNER JOIN supplier ON cpa.SupplierID = supplier.SupplierID
                                            WHERE
                                                cpa.ContractNumber = @contractNumber
                                                AND request_item.itemStatus = 'Pending'
                                            GROUP BY
                                                cpa.SupplierID,
                                                supplier.CompanyName,
                                                item.ItemID,
                                                item.ItemName,
                                                request_item.Unit;
                                            ";

        public CPAOrder()
        {
            InitializeComponent();
        }

        private void CPAOrder_Load(object sender, EventArgs e)
        {
            GenerateNextContractNumber();
            setCPAOrderDetails();
            PopulateComboBox();
        }

        private void SetTable()
        {
            using (var conn = new MySqlConnection(cpaOrderConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(query, conn))
                {
                    // Replace @contractNumber with cbAgreementID selected value 
                    adapter.SelectCommand.Parameters.AddWithValue("@contractNumber", cbAgreementID.SelectedItem.ToString());
                    CPAOrderTable.Clear();
                    adapter.Fill(CPAOrderTable);
                    dgvCPARequestList.Rows.Clear();
                    FillData();
                    dgvCPARequestList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                }
            }
        }


        private void FillData()
        {
            dgvCPARequestList.Rows.Clear();

            foreach (DataRow item in CPAOrderTable.Rows)
            {
                int i = dgvCPARequestList.Rows.Add();
                
                dgvCPARequestList.Rows[i].Cells[1].Value = item["ItemID"].ToString();
                dgvCPARequestList.Rows[i].Cells[2].Value = item["ItemName"].ToString();
                dgvCPARequestList.Rows[i].Cells[3].Value = item["SupplierID"].ToString();
                dgvCPARequestList.Rows[i].Cells[4].Value = item["CompanyName"].ToString();
                dgvCPARequestList.Rows[i].Cells[5].Value = item["TotalRequestQty"].ToString();
                dgvCPARequestList.Rows[i].Cells[6].Value = item["Unit"].ToString();

            }
        }

        private void GenerateNextContractNumber()
        {
            try
            {
                using (var conn = new MySqlConnection(cpaOrderConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // Retrieve the latest ContractNumber from the database


                    query = "SELECT MAX(CONVERT(SUBSTRING(contractOrderID, 4), UNSIGNED INTEGER)) AS MaxContractNumber FROM contract_order";


                    using (var command = new MySqlCommand(query, conn))
                    {
                        object result = command.ExecuteScalar();

                        // Parse the numeric part of the ContractNumber
                        int maxContractNumber = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        int nextContractNumber = maxContractNumber + 1;

                        // Generate the next ContractNumber with the format "oxxxx"
                        contractNumber = "c" + nextContractNumber.ToString("00000");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process
                MessageBox.Show(ex.Message);
            }
        }

        private void setCPAOrderDetails()
        {
            tbOrderID.Text = contractNumber;
            tbOrderType.Text = "CPA";
            cbShippToChoice.SelectedIndex = 0;
            tbAddress.Text = "Yummy Warehouse, 1234 Yummy Street, Yummy City";
        }

        private void PopulateComboBox()
        {
            try
            {
                cbAgreementID.Items.Clear();

                using (MySqlConnection conn = cpaOrderConn.conndb)
                {
                    conn.Open();

                    string query = @"SELECT cpa.ContractNumber, cpa.SupplierID, supplier.companyName
                                                FROM cpa
                                                INNER JOIN supplier ON cpa.SupplierID = supplier.supplierID;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string supplierID = reader.GetString("SupplierID");
                                string companyName = reader.GetString("companyName");
                                string agreementID = reader.GetString("ContractNumber");

                                cbAgreementID.Items.Add(agreementID);
                                cbSupplierID.Items.Add(supplierID);
                                cbSupplierName.Items.Add(companyName); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the comboboxes: " + ex.Message);
            }
        }

        private void cbAgreementID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAgreementID.SelectedIndex != -1)
                {
                    int selectedIndex = cbAgreementID.SelectedIndex;
                    cbSupplierName.SelectedIndex = selectedIndex; 
                    cbSupplierID.SelectedIndex = selectedIndex;
                    SetTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the AssignAName combobox: " + ex.Message);
            }
        }

        private void cbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierID.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierID.SelectedIndex;
                    cbSupplierName.SelectedIndex = selectedIndex;
                    cbAgreementID.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the AssignAName combobox: " + ex.Message);
            }
        }

        private void cbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierName.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierName.SelectedIndex;
                    cbSupplierID.SelectedIndex = selectedIndex;
                    cbAgreementID.SelectedIndex = selectedIndex; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the AssignAName combobox: " + ex.Message);
            }
        }

        private void cbShippToChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbShippToChoice.SelectedIndex == 0) {
            tbAddress.Text = "Yummy Warehouse, 1234 Yummy Street, Yummy City";
            }
            else
            {
                tbAddress.Text = "";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check if at least one checkbox is selected
            int selectedCount = 0;
            foreach (DataGridViewRow row in dgvCPARequestList.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value))
                {
                    selectedCount++;
                }
            }

            if (selectedCount == 0)
            {
                MessageBox.Show("Please select at least one item.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbAgreementID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an agreement ID");
                return;
            }

            if (dgvCPARequestList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgvCPARequestList.Rows)
            {
                if (row.Cells[5].Value == null)
                {
                    MessageBox.Show("The item order query is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (tbAddress.Text == "")
            {
                MessageBox.Show("Please enter an address");
                return;
            }

     

            // Get the selected items from the DataGridView
            List<DataGridViewRow> selectedRows = dgvCPARequestList.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToBoolean(row.Cells[0].Value)).ToList();

            using (var conn = new MySqlConnection(cpaOrderConn.conndb.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Insert into contract_order table
                    string insertOrderQuery = @"INSERT INTO contract_order (contractOrderID, agreementID, orderType, supplierID, supplierName, shipToAddress, createDate, pickUpDate, status) 
                                        VALUES (@contractOrderID, @agreementID, @orderType, @supplierID, @supplierName, @shipToAddress, @createDate, @pickUpDate, @status)";
                    using (var cmd = new MySqlCommand(insertOrderQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@contractOrderID", tbOrderID.Text);
                        cmd.Parameters.AddWithValue("@agreementID", cbAgreementID.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@orderType", tbOrderType.Text);
                        cmd.Parameters.AddWithValue("@supplierID", cbSupplierID.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@supplierName", cbSupplierName.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@shipToAddress", tbAddress.Text);
                        cmd.Parameters.AddWithValue("@createDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@pickUpDate", dtpPickUpDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@status", "In Progress");
                        cmd.ExecuteNonQuery();
                    }

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string itemAID = row.Cells[1].Value.ToString();
                        string orderID = tbOrderID.Text;

                        string getRequestItemVIDQuery = "SELECT request_item.requestItemVID " +
                                                        "FROM request_item " +
                                                        "INNER JOIN vidmapping ON vidmapping.AID = @itemAID AND vidmapping.VID = request_item.requestItemVID";
                        using (var getRequestItemVIDCmd = new MySqlCommand(getRequestItemVIDQuery, conn))
                        {
                            getRequestItemVIDCmd.Parameters.AddWithValue("@itemAID", itemAID);
                            object requestItemVIDObj = getRequestItemVIDCmd.ExecuteScalar();
                            if (requestItemVIDObj == null)
                            {
                                MessageBox.Show("Failed to fetch requestItemVID for itemAID: " + itemAID);
                                continue;
                            }
                            string requestItemVID = requestItemVIDObj.ToString();

                            string insertQuery = "INSERT INTO order_cpa_item_mapping (itemAID, itemName, ordersID, totalQty, unit) VALUES (@itemAID, @itemName, @ordersID, @totalQty, @unit)";
                            using (var cmd = new MySqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@itemAID", itemAID);
                                cmd.Parameters.AddWithValue("@itemName", row.Cells[2].Value.ToString());
                                cmd.Parameters.AddWithValue("@ordersID", orderID);
                                cmd.Parameters.AddWithValue("@totalQty", row.Cells[5].Value.ToString());
                                cmd.Parameters.AddWithValue("@unit", row.Cells[6].Value.ToString());
                                cmd.ExecuteNonQuery();
                            }

                            string updateQuery = "UPDATE request_item SET itemStatus = 'In Progress' WHERE requestItemVID = @requestItemVID";
                            using (var updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@requestItemVID", requestItemVID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Items inserted into the order_cpa_item_mapping table successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting items into the order_cpa_item_mapping table: " + ex.Message);
                }
            }
        }

        private void dgvCPARequestList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Check if the current cell is in the desired column
            if (dgv.CurrentCell.ColumnIndex == 5) //  "Item Qty" column
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    // Remove the existing event handler, if any
                    textBox.KeyPress -= TextBox_KeyPress;

                    // Attach the event handler to restrict input to numeric values
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
