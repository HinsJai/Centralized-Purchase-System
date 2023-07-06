using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace UI
{
    public partial class RequestQueueDetails : Form
    {

        Connection_class requesQueueConn = new Connection_class();
        private int requestLogID;
        private int stockQty;
        private string requestID;
        private string requestItemVID;
        private string contractNumber;
        string orderType;
        public RequestQueueDetails()
        {
            InitializeComponent();
        }

        private void RequestQueueDetails_Load(object sender, EventArgs e)
        {

            /*            if (lblStatusDisplay.Text == "Rejected" || lblStatusDisplay.Text=="Cancel Request")
            */
            if (lblStatusDisplay.Text != "Pending")

            {
                btnReject.Visible = false;
            }

            if (lblStatusDisplay.Text == "Pending" || lblStatusDisplay.Text == "Reivew" || displayItemStatus.Text == "Pending" || displayItemStatus.Text == "Update")
            {
                cbAggreement.Enabled = true;
                btnCreateOrder.Visible = true;
            }
            else
            {
                cbAggreement.Enabled = false;
                btnCreateOrder.Visible = false;
            }
        }

        public void SetComboBoxIndex(int index)
        {
            cbItemName.SelectedIndex = index;
        }

        public void SetData(string requestID, string requestItemVID, string requestItemName, string requestItemTypeName, string requestItemCategory, string requestBrand, string requestQty, string unit, string pickUpDate, string requestDateTime, string status, string remark, string sQty)
        {
            // Set the data in the appropriate controls in the form
            tbRequestID.Text = requestID;
            tbRequestItemVID.Text = requestItemVID;
            tbRequestItemTypeName.Text = requestItemTypeName;
            tbRequestItemCategory.Text = requestItemCategory;
            tbBrand.Text = requestBrand;
            tbRequestQty.Text = requestQty;
            lblUnitDisplay.Text = unit;
            dtpPickUpDate.Value = Convert.ToDateTime(pickUpDate);
            lblDisplayRequestDateTime.Text = requestDateTime;
            lblStatusDisplay.Text = status;
            tbRequestRemark.Text = remark;
            this.stockQty = Int32.Parse(sQty);
            this.requestID = requestID;
            this.requestItemVID = requestItemVID;


            string query = "SELECT modifyReason FROM request_change_log WHERE requestID = @requestID";

            using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string modifyReason = reader.GetString("modifyReason");
                            tbModifyReason.Text = modifyReason;
                        }
                        reader.Close();
                    }
                }
            }

            PopulateItemNames(requestID);
            PopulateAgreement();
        }

        private void PopulateAgreement()
        {
            string contractSql = @"
                   SELECT DISTINCT
                   BPA.contractNumber AS BPA_ContractNumber,
                   PPA.contractNumber AS PPA_ContractNumber
                   FROM vidmapping
            LEFT JOIN
                BPA ON vidmapping.aID = BPA.itemID AND BPA.status = @Status
            LEFT JOIN
                PPA ON vidmapping.aID = PPA.itemID AND PPA.status = @Status
            WHERE
                vidmapping.vID = @ItemID AND
                (BPA.Quantity >= @RequestQty OR PPA.Quantity >= @RequestQty);
    ";

            using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(contractSql, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", tbRequestItemVID.Text.ToString());
                    cmd.Parameters.AddWithValue("@Status", "Valid");
                    cmd.Parameters.AddWithValue("@RequestQty", tbRequestQty.Text.Trim());

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        cbAggreement.Items.Clear();
                        while (reader.Read())
                        {
                            string bpaContractNumber = reader["BPA_ContractNumber"].ToString();
                            string ppaContractNumber = reader["PPA_ContractNumber"].ToString();

                            if (!string.IsNullOrEmpty(bpaContractNumber))
                            {
                                cbAggreement.Items.Add(bpaContractNumber);
                            }
                            if (!string.IsNullOrEmpty(ppaContractNumber))
                            {
                                cbAggreement.Items.Add(ppaContractNumber);
                            }
                        }
                        reader.Close();
                    }
                }
            }
        }


        // set the request name in combo box
        private void PopulateItemNames(string requestID)
        {
            string query = "SELECT requestItemName FROM request_item WHERE requestID = @requestID";


            using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        cbItemName.Items.Clear();
                        while (reader.Read())
                        {
                            string itemName = reader.GetString("requestItemName");
                            cbItemName.Items.Add(itemName);
                        }
                        reader.Close();
                    }
                }
            }
        }


        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedRequestID = tbRequestID.Text.Trim();
            string selectedItemName = cbItemName.SelectedItem.ToString();


            // Retrieve the data for the selected item
            string query = "SELECT requestItemVID, requestItemTypeName, requestItemCategory,requestBrand, requestQty, unit, itemStatus FROM request_item WHERE requestID = @requestID AND requestItemName = @itemName";

            using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", selectedRequestID);
                    cmd.Parameters.AddWithValue("@itemName", selectedItemName);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            tbRequestItemVID.Text = reader.GetString("requestItemVID");
                            tbRequestItemTypeName.Text = reader.GetString("requestItemTypeName");
                            tbRequestItemCategory.Text = reader.GetString("requestItemCategory");
                            tbBrand.Text = reader.GetString("requestBrand");
                            tbRequestQty.Text = reader.GetString("requestQty");
                            lblUnitDisplay.Text = reader.GetString("unit");
                            displayItemStatus.Text = reader.GetString("itemStatus");
                        }
                        reader.Close();
                    }
                }
            }
            PopulateAgreement();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to create a new order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string orderAgreementId = cbAggreement.SelectedItem.ToString();
                string orderQty = tbRequestQty.Text.Trim();
                string status = "In Progress";

                getOrderType();

                // Get the item_aID from the vidmapping table
                int itemAId;
                string vid = tbRequestItemVID.Text.Trim();
                string query = "SELECT aID FROM vidmapping WHERE vID = @vID";

                using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vID", vid);

                        conn.Open();
                        object rs = cmd.ExecuteScalar();
                        if (rs != null && int.TryParse(rs.ToString(), out itemAId))
                        {
                            // Insert the new order into the orders table

                            query = @"INSERT INTO orders (orderID, order_type, requestID, order_agreement_id, item_aID, item_vID, order_qty, unit, pickUpDate,createDate,remark, status)
                                  VALUES (@orderID, @orderType,@requestID, @orderAgreementId, @itemAId, @itemVId, @orderQty,@unit,@pickUpDate,@createDate, @remark, @status)";


                            using (var insertCmd = new MySqlCommand(query, conn))
                            {
                                GenerateNextContractNumber();

                                // Set the parameter values
                                insertCmd.Parameters.AddWithValue("@orderID", contractNumber);
                                insertCmd.Parameters.AddWithValue("@orderType", orderType);
                                insertCmd.Parameters.AddWithValue("@requestID", tbRequestID.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@orderAgreementId", orderAgreementId);
                                insertCmd.Parameters.AddWithValue("@itemAId", itemAId);
                                insertCmd.Parameters.AddWithValue("@itemVId", vid);
                                insertCmd.Parameters.AddWithValue("@pickUpDate", dtpPickUpDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                insertCmd.Parameters.AddWithValue("@createDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                insertCmd.Parameters.AddWithValue("@orderQty", orderQty);
                                insertCmd.Parameters.AddWithValue("@unit", lblUnitDisplay.Text);
                                insertCmd.Parameters.AddWithValue("@remark", tbOrderRemark.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@status", status);


                                // Execute the insert command
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Invalid item_aID
                            MessageBox.Show("Invalid item selected.");
                        }
                    }



                    if (orderType == "bpa")
                    {
                        string updateQuery = "UPDATE bpa SET Quantity = Quantity - @orderQty WHERE ContractNumber = @orderAgreementId";
                        using (var updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            // Set the parameter values
                            updateCmd.Parameters.AddWithValue("@orderAgreementId", orderAgreementId);
                            updateCmd.Parameters.AddWithValue("@orderQty", orderQty);

                            // Execute the update command
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else if (orderType == "ppa")
                    {
                        string updateQuery = "UPDATE ppa SET Quantity = Quantity - @orderQty WHERE ContractNumber = @orderAgreementId";
                        using (var updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            // Set the parameter values
                            updateCmd.Parameters.AddWithValue("@orderAgreementId", orderAgreementId);
                            updateCmd.Parameters.AddWithValue("@orderQty", orderQty);

                            // Execute the update command
                            updateCmd.ExecuteNonQuery();
                        }
                    }

                    // Update the status of the request item
                    string updateRequestItemQuery = "UPDATE request_item SET itemStatus = @itemStatus WHERE requestItemVID = @requestItemVID AND requestID = @requestID";
                    using (var updateRequestItemCmd = new MySqlCommand(updateRequestItemQuery, conn))
                    {
                        string itemStatus = "In Progress";
                        // Set the parameter values
                        updateRequestItemCmd.Parameters.AddWithValue("@itemStatus", itemStatus);
                        updateRequestItemCmd.Parameters.AddWithValue("@requestItemVID", vid);
                        updateRequestItemCmd.Parameters.AddWithValue("@requestID", tbRequestID.Text.Trim());

                        // Execute the update command
                        updateRequestItemCmd.ExecuteNonQuery();
                    }



                    string updateRequestStatusQuery = @" UPDATE request_record
                                                                        SET status = 'Order Placed'
                                                                        WHERE requestID = @requestID
                                                                          AND (
                                                                            SELECT COUNT(*) 
                                                                            FROM request_item ri
                                                                            WHERE ri.requestID = @requestID
                                                                          ) = (
                                                                            SELECT COUNT(*) 
                                                                            FROM orders o
                                                                            JOIN request_item ri ON o.item_vID = ri.requestItemVID
                                                                            WHERE ri.requestID = @requestID
                                                                          );
                                                                        ";
                    using (var cmd = new MySqlCommand(updateRequestStatusQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@requestID", requestID);
                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("New order created successfully.");

                }
            }
        }

        private void GenerateNextContractNumber()
        {
            try
            {
                using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // Retrieve the latest ContractNumber from the database


                    query = "SELECT MAX(CONVERT(SUBSTRING(orderID, 4), UNSIGNED INTEGER)) AS MaxContractNumber FROM orders";


                    using (var command = new MySqlCommand(query, conn))
                    {
                        object result = command.ExecuteScalar();

                        // Parse the numeric part of the ContractNumber
                        int maxContractNumber = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        int nextContractNumber = maxContractNumber + 1;

                        // Generate the next ContractNumber with the format "oxxxx"
                        contractNumber = "o" + nextContractNumber.ToString("00000");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process
                MessageBox.Show(ex.Message);
            }
        }

        private void getOrderType()
        {
            // Get the selected agreement
            string selectedAgreement = cbAggreement.SelectedItem.ToString();

            // Determine the order type based on the selected agreement

            if (selectedAgreement.StartsWith("bpa"))
            {
                orderType = "bpa";
            }

            else if (selectedAgreement.StartsWith("ppa"))
            {
                orderType = "ppa";
            }
            else
            {
                // Invalid agreement selected
                MessageBox.Show("Invalid agreement selected.");
                return;
            }
        }

        private void cbAggreement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ItemStatus = displayItemStatus.Text.Trim();
            lblOrderRemark.Visible = true;
            tbOrderRemark.Visible = true;
            lblRequestRemark.Visible = false;
            tbRequestRemark.Visible = false;


            if (cbAggreement.SelectedIndex != -1 || ItemStatus == "Pending" || ItemStatus == "Update")
            {
                btnCreateOrder.Enabled = true;
            }

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            tbRequestRemark.ReadOnly = false;
            btnCreateOrder.Visible = false;
            btnCancel.Visible = true;
            btnClose.Visible = false;
            btnReject.Visible = false;
            btnConfirmReject.Visible = true;
        }

        private void btnConfirmReject_Click(object sender, EventArgs e)
        {
            if (tbRequestRemark.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a reject remark.");
                return;
            }

            string requestID = tbRequestID.Text.Trim();
            string remark = tbRequestRemark.Text.Trim();

            // Update the status and remark of the request_record table
            string updateRequestRecordQuery = "UPDATE request_record SET status = 'Rejected', remark = @remark WHERE requestID = @requestID";
            using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(updateRequestRecordQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.Parameters.AddWithValue("@remark", remark);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update the itemStatus of the request_item table
            string updateRequestItemQuery = "UPDATE request_item SET itemStatus = 'Rejected' WHERE requestID = @requestID";
            using (var conn = new MySqlConnection(requesQueueConn.conndb.ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(updateRequestItemQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Request rejected successfully.");

            // Close the form or perform any other necessary actions
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbRequestRemark.ReadOnly = true;
            btnCreateOrder.Visible = true;
            btnCancel.Visible = false;
            btnClose.Visible = true;
            btnReject.Visible = true;
            btnConfirmReject.Visible = false;
        }
    }
}
