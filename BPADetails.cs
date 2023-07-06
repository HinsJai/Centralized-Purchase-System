﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UI.connMySql;

namespace UI
{
    public partial class BPADetails : Form
    {
        private readonly Connection_class BPADetailConn = new Connection_class();
        private string contractNumber;
        private string supplierID;
        private int itemID;

        public BPADetails(string contractNumber, string supplierID, int itemID)
        {
            InitializeComponent();
            this.itemID = itemID;
            this.contractNumber = contractNumber;
            this.supplierID = supplierID;
        }

        private void BPADetails_Load(object sender, EventArgs e)
        {
            setContratDetails();
            setDefaultBuyerInfo();
            PopulateSupplierComboBox();
            PopulateItemComboBox();
        }

        private void setDefaultBuyerInfo()
        {
            tbBuyerName.Text = "Yummy Restaurant Limited";
            tbChargeAccount.Text = "54125874";
            tbShipAddress.Text = "No. 1, Yummy Road, Yummy District, Hong Kong";
        }

        private void setContratDetails()
        {
            try
            {
                string query = "SELECT bpa.*, item.itemName, supplier.* " +
                               "FROM bpa JOIN item ON bpa.ItemID = item.itemID " +
                               "JOIN supplier ON bpa.SupplierID = supplier.supplierID " +
                               "WHERE bpa.ContractNumber = @contractNumber";

                using (MySqlConnection connection = new MySqlConnection(BPADetailConn.conndb.ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@contractNumber", contractNumber);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbCNumber.Text = reader["ContractNumber"].ToString();
                                dtpStartDate.Value = Convert.ToDateTime(reader["StartDate"]);
                                dtpEndDate.Value = Convert.ToDateTime(reader["EndDate"]);
                                lblDisplayEffectDate.Text = reader["EffectiveDay"].ToString();
                                tbSupplierName.Text = reader["companyName"].ToString();
                                tbSupplierID.Text = reader["SupplierID"].ToString();
                                tbContactPerson.Text = reader["contactName"].ToString();
                                tbContactNumber.Text = reader["contactNumber"].ToString();
                                tbSupplierAddress.Text = reader["address"].ToString();
                                tbItemName.Text = reader["itemName"].ToString();
                                tbItemID.Text = reader["ItemID"].ToString();
                                tbQty.Text = reader["Quantity"].ToString();
                                tbUOM.Text = reader["UOM"].ToString();
                                tbPrice.Text = reader["Price"].ToString();
                                tbDiscount.Text = reader["Discounts"].ToString();
                                tbTermsCondition.Text = reader["TermsAndCondition"].ToString();
                                lblDisplatStatus.Text = reader["Status"].ToString();
                                tbSignature.Text = reader["Signatures"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PopulateSupplierComboBox()
        {
            try
            {
                cbSupplierName.Items.Clear();
                cbSupplierID.Items.Clear();

                using (MySqlConnection conn = BPADetailConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT * FROM supplier";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string supplierID = reader.GetString("supplierID");
                                string supplierName = reader.GetString("companyName");

                                cbSupplierName.Items.Add(supplierName);
                                cbSupplierID.Items.Add(supplierID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lblDisplatStatus.Text == "Invalid")
            {
                MessageBox.Show("You can not edit expired contract!");
                return;
            }

            btnEdit.Visible = false;
            btnCancel.Visible = true;
            btnConfirm.Visible = true;
            tbSupplierName.Visible = false;
            tbSupplierID.Visible = false;
            tbItemID.Visible = false;
            tbItemName.Visible = false;
            tbQty.ReadOnly = false;
            tbUOM.ReadOnly = false;
            tbPrice.ReadOnly = false;
            tbDiscount.ReadOnly = false;
            tbTermsCondition.ReadOnly = false;
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;

            // Find the index of the supplier name in the combobox
            int selectedSupplierIndex = cbSupplierName.FindStringExact(tbSupplierName.Text);

            // Set the selected index of cbSupplierName
            cbSupplierName.SelectedIndex = selectedSupplierIndex;

            // Find the index of the item name in the combobox
           int selectedItemIndex = cbItemName.FindStringExact(tbItemName.Text);
            cbItemName.SelectedIndex = selectedItemIndex;

        }

        private void cbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierName.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierName.SelectedIndex;
                    cbSupplierID.SelectedIndex = selectedIndex;

                    // Get the selected supplier ID
                    string selectedSupplierID = cbSupplierID.SelectedItem.ToString();

                    using (MySqlConnection conn = BPADetailConn.conndb)
                    {
                        conn.Open();

                        string query = "SELECT * FROM supplier WHERE supplierID = @supplierID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@supplierID", selectedSupplierID);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    tbSupplierAddress.Text = reader.GetString("address");
                                    tbContactPerson.Text = reader.GetString("contactName");
                                    tbContactNumber.Text = reader.GetInt32("contactNumber").ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    tbSupplierName.Text = cbSupplierName.SelectedItem.ToString();
                    tbSupplierID.Text = cbSupplierID.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateItemComboBox()
        {
            try
            {
                cbItemName.Items.Clear();
                cbItemID.Items.Clear();

                using (MySqlConnection conn = BPADetailConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT itemName, itemID FROM item";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int itemID = reader.GetInt32("itemID");
                                string itemName = reader.GetString("itemName");

                                cbItemName.Items.Add(itemName);
                                cbItemID.Items.Add(itemID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbItemName.SelectedIndex != -1)
                {
                    int selectedIndex = cbItemName.SelectedIndex;
                    cbItemID.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbItemID.SelectedIndex != -1)
                {
                    int selectedIndex = cbItemID.SelectedIndex;
                    cbItemName.SelectedIndex = selectedIndex;
                    tbItemName.Text = cbItemName.SelectedItem.ToString();
                    tbItemID.Text = cbItemID.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setContratDetails();
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnEdit.Visible = true;
            tbSupplierName.Visible = true;
            tbSupplierID.Visible = true;
            tbItemID.Visible = true;
            tbItemName.Visible = true;
            tbQty.ReadOnly = true;
            tbUOM.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbDiscount.ReadOnly = true;
            tbTermsCondition.ReadOnly = true;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbItemName.SelectedIndex == -1 || cbItemName.SelectedIndex == -1 || tbQty.Text == "" || tbContactNumber.Text == "" || tbUOM.Text == "" || tbPrice.Text == "" || tbDiscount.Text == "" || tbTermsCondition.Text == "" || tbSignature.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            // Compare the values of dtpStartDate and dtpEndDate
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Start date should be earlier than the end date!");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure modify BPA : {tbCNumber.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string updateQuery = "UPDATE bpa " +
                        "SET StartDate = @startDate, " +
                        "ItemID = @itemID, " +
                        "SupplierID = @supplierID, " +
                        "EndDate = @endDate, " +
                        "EffectiveDay = @effectiveDay, " +
                        "Quantity = @quantity, " +
                        "UOM = @UOM, " +
                        "Price = @price, " +
                        "Discounts = @discounts, " +
                        "TermsAndCondition = @termsCondition " +
                        "WHERE ContractNumber = @contractNumber";

                    using (MySqlConnection connection = new MySqlConnection(BPADetailConn.conndb.ConnectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                            command.Parameters.AddWithValue("@endDate", dtpEndDate.Value);
                            command.Parameters.AddWithValue("@effectiveDay", lblDisplayEffectDate.Text);
                            command.Parameters.AddWithValue("@itemID", tbItemID.Text);
                            command.Parameters.AddWithValue("@supplierID", tbSupplierID.Text);
                            command.Parameters.AddWithValue("@quantity", tbQty.Text);
                            command.Parameters.AddWithValue("@UOM", tbUOM.Text);
                            command.Parameters.AddWithValue("@price", tbPrice.Text);
                            command.Parameters.AddWithValue("@discounts", tbDiscount.Text);
                            command.Parameters.AddWithValue("@termsCondition", tbTermsCondition.Text);
                            command.Parameters.AddWithValue("@contractNumber", contractNumber);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("BPA details updated successfully.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update BPA details.");
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete BPA: {tbCNumber.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM bpa WHERE ContractNumber = @contractNumber";

                    using (MySqlConnection connection = new MySqlConnection(BPADetailConn.conndb.ConnectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@contractNumber", contractNumber);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("BPA deleted successfully.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete BPA.");
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void CalculateEffectDate()
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            TimeSpan duration = endDate - startDate;
            int totalDays = duration.Days;
            if (totalDays < 0)
            {
                MessageBox.Show("End date cannot be earlier than start date");
                return;
            }
            lblDisplayEffectDate.Text = totalDays.ToString();
        }


        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateEffectDate();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateEffectDate();
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
