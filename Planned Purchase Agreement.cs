using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Web.UI.WebControls;


namespace UI
{
    public partial class PlannedPurchaseAgreement : Form
    {
        private readonly Connection_class PPAConn = new Connection_class();
        public PlannedPurchaseAgreement()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Planned_Purchase_Agreement_Load(object sender, EventArgs e)
        {
            GenerateNextContractNumber();
            setDefaultData();
            PopulateSupplierComboBox();
            PopulateItemComboBox();
        }

        private void GenerateNextContractNumber()
        {
            try
            {
                using (var conn = new MySqlConnection(PPAConn.conndb.ConnectionString))
                {
                    conn.Open();

                    // Retrieve the latest ContractNumber from the database
                    string query = "SELECT MAX(CONVERT(SUBSTRING(ContractNumber, 4), UNSIGNED INTEGER)) AS MaxContractNumber FROM ppa";
                    using (var command = new MySqlCommand(query, conn))
                    {
                        object result = command.ExecuteScalar();

                        // Parse the numeric part of the ContractNumber
                        int maxContractNumber = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        int nextContractNumber = maxContractNumber + 1;

                        // Generate the next ContractNumber with the format "ppa000X"
                        string nextContractNumberString = "ppa" + nextContractNumber.ToString("0000");

                        // Set the generated ContractNumber in the Contract textbox
                        tbCNumber.Text = nextContractNumberString;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process
                MessageBox.Show(ex.Message);
            }
        }

        private void setDefaultData()
        {
            tbBuyerName.Text = "Yummy Restaurant Limited";
            tbChargeAccount.Text = "54125874";
            tbShipAddress.Text = "No. 1, Yummy Road, Yummy District, Hong Kong";
        }

        private void PopulateSupplierComboBox()
        {
            try
            {
                cbSupplierName.Items.Clear();
                cbSupplierID.Items.Clear();

                using (MySqlConnection conn = PPAConn.conndb)
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

        private void cbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSupplierName.SelectedIndex != -1)
                {
                    int selectedIndex = cbSupplierName.SelectedIndex;
                    cbSupplierID.SelectedIndex = selectedIndex;
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

                    // Get the selected supplier ID
                    string selectedSupplierID = cbSupplierID.SelectedItem.ToString();

                    using (MySqlConnection conn = PPAConn.conndb)
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

        private void PopulateItemComboBox()
        {
            try
            {
                cbItemName.Items.Clear();
                cbItemID.Items.Clear();

                using (MySqlConnection conn = PPAConn.conndb)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (cbItemName.SelectedIndex == -1 || cbSupplierName.SelectedIndex == -1 || tbEffectiveDay.Text == ""  || cbWeekMonth.SelectedIndex == -1 || cbItemName.SelectedIndex == -1 || cbItemName.SelectedIndex == -1 || tbQty.Text == "" || tbContactNumber.Text == "" || tbUOM.Text == "" || tbPrice.Text == "" || tbTermsCondition.Text == "" || tbSignature.Text == "")
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


            DialogResult result = MessageBox.Show($"Are you sure you want to create PPA agreement?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //merge the day and selected month or week
                string effectiveDay = tbEffectiveDay.Text;
                string weekMonth = cbWeekMonth.SelectedItem.ToString();
                string tentativeSchedules = effectiveDay +" "+ weekMonth;

                try
                {
                    using (var conn = new MySqlConnection(PPAConn.conndb.ConnectionString))
                    {
                        conn.Open();

                        string query = @"INSERT INTO ppa (ContractNumber, TentativeSchedules, StartDate, EndDate, EffectiveDay, SupplierID, ItemID, Price, Quantity, UOM, TermsAndCondition, Status, Signatures)
                                 VALUES (@ContractNumber, @tentativeSchedules, @StartDate, @EndDate, @EffectiveDay, @SupplierID, @ItemID, @Price, @Quantity, @UOM, @TermsAndCondition, @Status, @Signatures)";

                        using (var command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@ContractNumber", tbCNumber.Text);
                            command.Parameters.AddWithValue("@tentativeSchedules", tentativeSchedules);
                            command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                            command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                            command.Parameters.AddWithValue("@EffectiveDay", Convert.ToInt32(lblDisplayEffectDate.Text));
                            command.Parameters.AddWithValue("@SupplierID", cbSupplierID.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@ItemID", Convert.ToInt32(cbItemID.SelectedItem));
                            command.Parameters.AddWithValue("@Price", Convert.ToInt32(tbPrice.Text));
                            command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(tbQty.Text));
                            command.Parameters.AddWithValue("@UOM", tbUOM.Text);
                            command.Parameters.AddWithValue("@TermsAndCondition", tbTermsCondition.Text);
                            command.Parameters.AddWithValue("@Status", "Valid");
                            command.Parameters.AddWithValue("@Signatures", tbSignature.Text);

                            command.ExecuteNonQuery();

                            MessageBox.Show("PPA agreement created successfully.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating PPA agreement: " + ex.Message);
                }
            }
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

        private void tbShipAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbContractDetails_Enter(object sender, EventArgs e)
        {

        }

        private void gbBuyInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
