using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class dvgRequestRecordDetails : Form
    {
        Connection_class requestEditConn = new Connection_class();
        private int requestLogID;
        private int stockQty;
        private string requestID;
        private string requestItemVID;
        private int countItem = 0;   // check if only one item in the request, only accept use click cancel request button
        public dvgRequestRecordDetails()
        {
            InitializeComponent();
        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
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

            using (var conn = new MySqlConnection(requestEditConn.conndb.ConnectionString))
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
        }

        private void tbRequestQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            /*            if (lblStatusDisplay.Text != "Order Placed" && displayItemStatus.Text != "Cancel" || lblStatusDisplay.Text != "Delivered" && displayItemStatus.Text != "Cancel" || lblStatusDisplay.Text != "Completed" && displayItemStatus.Text != "Cancel" || lblStatusDisplay.Text != "Cancel" && displayItemStatus.Text != "Cancel")
            */
            if (lblStatusDisplay.Text != "Cancelled" && lblStatusDisplay.Text != "Cancel Request" && lblStatusDisplay.Text != "Order Placed" && lblStatusDisplay.Text != "Delivered" && lblStatusDisplay.Text != "Completed")
            {
                if (displayItemStatus.Text != "Cancelled" && displayItemStatus.Text != "Completed" && displayItemStatus.Text != "Cancel Request")
                {
                    cbItemName.Enabled = false;
                    tbRequestQty.ReadOnly = false;
                    dtpPickUpDate.Enabled = true;
                    tbRequestRemark.ReadOnly = false;
                    tbModifyReason.ReadOnly = false;
                    btnModify.Visible = false;
                    btnUpdate.Visible = true;
                    btnCancelItem.Visible = true;
                    btnCancelRequest.Visible = true;
                    btnCancelModify.Visible = true;

                    if (countItem == 1)
                    {
                        btnCancelItem.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("This request cannot modify! Please contact purchase department if any needs.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This request cannot modify! Please contact purchase department if any needs.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
 /*               if (Int32.Parse(tbRequestQty.Text) > stockQty)
                {
                    MessageBox.Show($"The quantity for item {Int32.Parse(tbRequestQty.Text)} is greater than the available quantity ({stockQty}). Please adjust the quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }*/

                var confirmResult = MessageBox.Show("Are you sure to change your request ??",
                                 "Confirm Change!!",
                                 MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Insert data into request_change_log table
                    requestEditConn.conndb.Open();
                    string insertLogQuery = "INSERT INTO request_change_log (requestID, modifyType, logPickUpDate, requestDateTime, modifyReason, requestRemark) VALUES (@requestID, @modifyType, @logPickUpDate, @requestDateTime, @modifyReason, @requestRemark)";

                    using (var insertLogCmd = new MySqlCommand(insertLogQuery, requestEditConn.conndb))
                    {
                        insertLogCmd.Parameters.AddWithValue("@requestID", tbRequestID.Text);
                        insertLogCmd.Parameters.AddWithValue("@modifyType", "Update");
                        insertLogCmd.Parameters.AddWithValue("@modifyReason", tbModifyReason.Text);
                        insertLogCmd.Parameters.AddWithValue("@logPickUpDate", dtpPickUpDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        insertLogCmd.Parameters.AddWithValue("@requestDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        insertLogCmd.Parameters.AddWithValue("@requestRemark", tbRequestRemark.Text);
                        insertLogCmd.ExecuteNonQuery();

                        // Retrieve the last inserted ID
                        insertLogCmd.CommandText = "SELECT LAST_INSERT_ID()";
                        requestLogID = Convert.ToInt32(insertLogCmd.ExecuteScalar());
                    }

                    // Insert data into request_change_item_log table
                    string insertItemLogQuery = "INSERT INTO request_change_item_log (requestLogID, logItemVID, logItemName, logItemType, logItemCategory,logBrand, logItemQty, logItemUnit) VALUES (@requestLogID, @logItemVID, @logItemName, @logItemType, @logItemCategory,@logBrand, @logItemQty, @logItemUnit)";

                    using (var insertItemLogCmd = new MySqlCommand(insertItemLogQuery, requestEditConn.conndb))
                    {
                        insertItemLogCmd.Parameters.AddWithValue("@requestLogID", requestLogID);
                        insertItemLogCmd.Parameters.AddWithValue("@logItemVID", tbRequestItemVID.Text);
                        insertItemLogCmd.Parameters.AddWithValue("@logItemName", cbItemName.SelectedItem.ToString());
                        insertItemLogCmd.Parameters.AddWithValue("@logItemType", tbRequestItemTypeName.Text);
                        insertItemLogCmd.Parameters.AddWithValue("@logItemCategory", tbRequestItemCategory.Text);
                        insertItemLogCmd.Parameters.AddWithValue("@logBrand", tbRequestItemCategory.Text);
                        insertItemLogCmd.Parameters.AddWithValue("@logItemQty", Int32.Parse(tbRequestQty.Text));
                        insertItemLogCmd.Parameters.AddWithValue("@logItemUnit", lblUnitDisplay.Text);
                        insertItemLogCmd.ExecuteNonQuery();
                    }

                    // Update the request_item table to set the item status to "Update"
                    string updateRequestItemQuery = "UPDATE request_item SET itemStatus = 'Update', requestQty = @requestQty WHERE requestID = @requestID AND requestItemVID =@requestItemVID";
                    using (var updateRequestItemCmd = new MySqlCommand(updateRequestItemQuery, requestEditConn.conndb))
                    {
                        updateRequestItemCmd.Parameters.AddWithValue("@requestID", requestID);
                        updateRequestItemCmd.Parameters.AddWithValue("@requestItemVID", requestItemVID);
                        updateRequestItemCmd.Parameters.AddWithValue("@requestQty", Int32.Parse(tbRequestQty.Text));
                        updateRequestItemCmd.ExecuteNonQuery();
                    }

                    string updateRequestRecord = "UPDATE request_record SET remark = @remark WHERE requestID = @requestID;";
                        using (var updateRequestRecordCmd = new MySqlCommand(updateRequestRecord, requestEditConn.conndb))
                    {
                        updateRequestRecordCmd.Parameters.AddWithValue("@requestID", requestID);
                        updateRequestRecordCmd.Parameters.AddWithValue("@remark", tbRequestRemark.Text);
                        updateRequestRecordCmd.ExecuteNonQuery();
                    }



                    btnUpdate.Visible = false;
                    btnModify.Visible = true;
                    btnCancelItem.Visible = false;
                    tbRequestQty.ReadOnly = true;
                    dtpPickUpDate.Enabled = false;
                    tbRequestRemark.ReadOnly = true;
                    tbModifyReason.ReadOnly = true;
                    btnCancelRequest.Visible = false;
                }
             /*   else
                {
                    btnUpdate.Visible = false;
                    btnModify.Visible = true;

                }*/
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                requestEditConn.conndb.Close();
            }
        }

        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRequestID = tbRequestID.Text.Trim();
            string selectedItemName = cbItemName.SelectedItem.ToString();

            // Retrieve the data for the selected item
            string query = "SELECT requestItemVID, requestItemTypeName, requestItemCategory,requestBrand, requestQty, unit, itemStatus FROM request_item WHERE requestID = @requestID AND requestItemName = @itemName";

            using (var conn = new MySqlConnection(requestEditConn.conndb.ConnectionString))
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
        }

        // set the request name in combo box
        private void PopulateItemNames(string requestID)
        {
            string query = "SELECT requestItemName FROM request_item WHERE requestID = @requestID";

            using (var conn = new MySqlConnection(requestEditConn.conndb.ConnectionString))
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
                            countItem++;
                        }
                        reader.Close();
                    }
                }
            }
        }

        private void btnItemCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbModifyReason.Text) && char.IsLetter(tbModifyReason.Text, 0))
            {
                var confirmResult = MessageBox.Show($"Are you sure to cancel the request item ID: {requestItemVID}??",
                                            "Confirm cancel!!",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Insert data into request_change_log table only if it doesn't exist
                        requestEditConn.conndb.Open();
                        string checkLogQuery = "SELECT COUNT(*) FROM request_change_log WHERE requestID = @requestID";
                        using (var checkLogCmd = new MySqlCommand(checkLogQuery, requestEditConn.conndb))
                        {
                            checkLogCmd.Parameters.AddWithValue("@requestID", requestID);
                            int logCount = Convert.ToInt32(checkLogCmd.ExecuteScalar());

                            if (logCount == 0)          // update the cancel item log to log table
                            {
                                string insertLogQuery = "INSERT INTO request_change_log (requestID, modifyType, logPickUpDate, requestDateTime, modifyReason, requestRemark) VALUES (@requestID, @modifyType, @logPickUpDate, @requestDateTime, @modifyReason, @requestRemark)";

                                using (var insertLogCmd = new MySqlCommand(insertLogQuery, requestEditConn.conndb))
                                {
                                    insertLogCmd.Parameters.AddWithValue("@requestID", requestID);
                                    insertLogCmd.Parameters.AddWithValue("@modifyType", "Cancel Item");
                                    insertLogCmd.Parameters.AddWithValue("@modifyReason", tbModifyReason.Text);
                                    insertLogCmd.Parameters.AddWithValue("@logPickUpDate", dtpPickUpDate.Value.ToString("yyyy-MM-dd"));
                                    insertLogCmd.Parameters.AddWithValue("@requestDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                    insertLogCmd.Parameters.AddWithValue("@requestRemark", tbRequestRemark.Text);
                                    insertLogCmd.ExecuteNonQuery();

                                    // Retrieve the last inserted ID
                                    insertLogCmd.CommandText = "SELECT LAST_INSERT_ID()";
                                    requestLogID = Convert.ToInt32(insertLogCmd.ExecuteScalar());
                                }
                            }
                            else
                            {
                                // Retrieve the existing requestLogID
                                string retrieveLogIDQuery = "SELECT requestLogID FROM request_change_log WHERE requestID = @requestID";
                                using (var retrieveLogIDCmd = new MySqlCommand(retrieveLogIDQuery, requestEditConn.conndb))
                                {
                                    retrieveLogIDCmd.Parameters.AddWithValue("@requestID", requestID);
                                    requestLogID = Convert.ToInt32(retrieveLogIDCmd.ExecuteScalar());
                                }
                            }
                        }

                        // Check if the record with the same requestLogID and LogItemVID already exists in request_change_item_log table
                        string checkItemLogQuery = "SELECT COUNT(*) FROM request_change_item_log WHERE requestLogID = @requestLogID AND logItemVID = @logItemVID";
                        using (var checkItemLogCmd = new MySqlCommand(checkItemLogQuery, requestEditConn.conndb))
                        {
                            checkItemLogCmd.Parameters.AddWithValue("@requestLogID", requestLogID);
                            checkItemLogCmd.Parameters.AddWithValue("@logItemVID", tbRequestItemVID.Text);
                            int itemLogCount = Convert.ToInt32(checkItemLogCmd.ExecuteScalar());

                            if (itemLogCount == 0)
                            {
                                // Insert data into request_change_item_log table
                                string insertItemLogQuery = "INSERT INTO request_change_item_log (requestLogID, logItemVID, logItemName, logItemType, logItemCategory,logBrand, logItemQty, logItemUnit) VALUES (@requestLogID, @logItemVID, @logItemName, @logItemType, @logItemCategory,@logBrand, @logItemQty, @logItemUnit)";

                                using (var insertItemLogCmd = new MySqlCommand(insertItemLogQuery, requestEditConn.conndb))
                                {
                                    insertItemLogCmd.Parameters.AddWithValue("@requestLogID", requestLogID);
                                    insertItemLogCmd.Parameters.AddWithValue("@logItemVID", tbRequestItemVID.Text);
                                    insertItemLogCmd.Parameters.AddWithValue("@logItemName", cbItemName.SelectedItem.ToString());
                                    insertItemLogCmd.Parameters.AddWithValue("@logItemType", tbRequestItemTypeName.Text);
                                    insertItemLogCmd.Parameters.AddWithValue("@logItemCategory", tbRequestItemCategory.Text);
                                    insertItemLogCmd.Parameters.AddWithValue("@logBrand", tbBrand.Text);
                                    insertItemLogCmd.Parameters.AddWithValue("@logItemQty", Int32.Parse(tbRequestQty.Text));
                                    insertItemLogCmd.Parameters.AddWithValue("@logItemUnit", lblUnitDisplay.Text);
                                    insertItemLogCmd.ExecuteNonQuery();
                                }
                            }
                            else if (displayItemStatus.Text == "Cancelled" || displayItemStatus.Text == "Cancelled Request")
                            {
                                {
                                    MessageBox.Show("The item has already been canceled!");
                                    return;
                                }
                            }
                        }

                        // Update the request_item table to set the status to "Cancel"
                        string updateRequestItemQuery = "UPDATE request_item SET itemStatus = 'Cancel Request' WHERE requestID = @requestID AND requestItemVID =@requestItemVID";
                        using (var updateRequestItemCmd = new MySqlCommand(updateRequestItemQuery, requestEditConn.conndb))
                        {
                            updateRequestItemCmd.Parameters.AddWithValue("@requestID", requestID);
                            updateRequestItemCmd.Parameters.AddWithValue("@requestItemVID", requestItemVID);
                            updateRequestItemCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Your cancel request has been sent!");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        requestEditConn.conndb.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide your cancel reason!");
            }
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            if (lblStatusDisplay.Text != "Cancelled" && lblStatusDisplay.Text != "Cancel Request" && lblStatusDisplay.Text != "Order Placed" && lblStatusDisplay.Text != "Delivered" && lblStatusDisplay.Text != "Completed")
            {
                if (!string.IsNullOrEmpty(tbModifyReason.Text) && char.IsLetter(tbModifyReason.Text, 0))
                {
                    var confirmResult = MessageBox.Show($"Are you sure to cancel the request ID: {tbRequestID.Text}??",
                                        "Confirm cancel!!",
                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            requestEditConn.conndb.Open();
                            // Update the request_item table to set the status to "Cancel Item"
                            string updateRequestQuery = "UPDATE request_record SET status = 'Cancel Request' WHERE requestID = @requestID";
                            using (var updateRequestCmd = new MySqlCommand(updateRequestQuery, requestEditConn.conndb))
                            {
                                updateRequestCmd.Parameters.AddWithValue("@requestID", requestID);
                                updateRequestCmd.ExecuteNonQuery();
                                MessageBox.Show("Your cancel request has been sent!");
                            }


                            // Update the request_item table to set the status to "Cancel"
                            string updateRequestItemQuery = "UPDATE request_item SET itemStatus = 'Cancel Request' WHERE requestID = @requestID";
                            using (var updateRequestItemCmd = new MySqlCommand(updateRequestItemQuery, requestEditConn.conndb))
                            {
                                updateRequestItemCmd.Parameters.AddWithValue("@requestID", requestID);
                                updateRequestItemCmd.ExecuteNonQuery();
                            }

                            string insertLogQuery = "INSERT INTO request_change_log (requestID, modifyType, logPickUpDate, requestDateTime, modifyReason, requestRemark) VALUES (@requestID, @modifyType, @logPickUpDate, @requestDateTime, @modifyReason, @requestRemark)";

                            using (var insertLogCmd = new MySqlCommand(insertLogQuery, requestEditConn.conndb))
                            {
                                insertLogCmd.Parameters.AddWithValue("@requestID", requestID);
                                insertLogCmd.Parameters.AddWithValue("@modifyType", "Cancel Request");
                                insertLogCmd.Parameters.AddWithValue("@modifyReason", tbModifyReason.Text);
                                insertLogCmd.Parameters.AddWithValue("@logPickUpDate", dtpPickUpDate.Value.ToString("yyyy-MM-dd"));
                                insertLogCmd.Parameters.AddWithValue("@requestDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                insertLogCmd.Parameters.AddWithValue("@requestRemark", tbRequestRemark.Text);
                                insertLogCmd.ExecuteNonQuery();
                            }

                            string countTotalItemsQuery = "SELECT COUNT(*) FROM request_item WHERE requestID = @requestID";
                            int totalItems;
                            using (var countTotalItemsCmd = new MySqlCommand(countTotalItemsQuery, requestEditConn.conndb))
                            {
                                countTotalItemsCmd.Parameters.AddWithValue("@requestID", requestID);
                                totalItems = Convert.ToInt32(countTotalItemsCmd.ExecuteScalar());
                            }


                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please provide your cancel reason!");
                }
            }
            else
            {
                MessageBox.Show("The request has already been canceled!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelModify_Click(object sender, EventArgs e)
        {
            cbItemName.Enabled = true;
            btnUpdate.Visible = false;
            btnCancelItem.Visible = false;
            btnCancelRequest.Visible = false;
            tbRequestQty.ReadOnly = true;
            dtpPickUpDate.Enabled = false;
            tbRequestRemark.ReadOnly = true;
            tbModifyReason.ReadOnly = true;
            btnModify.Visible = true; ;
            btnCancelModify.Visible = false;
        }

        private void tbBrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}