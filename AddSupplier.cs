using System;
using UI.connMySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UI
{
    public partial class AddSupplier : Form
    {
        private readonly Connection_class createSupplierConn = new Connection_class();
        private string nextSupplierID;

        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            GetMaxSupplierID();
            tbSupplierID.Text = nextSupplierID;
        }

        // Get the next supplier ID
        private void GetMaxSupplierID()
        {
            try
            {
                using (MySqlConnection conn = createSupplierConn.conndb)
                {
                    conn.Open();
                    string query = "SELECT CONCAT('S', LPAD(COALESCE(SUBSTRING(MAX(supplierID), 2), 0) + 1, 3, '0')) AS nextID FROM supplier";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        nextSupplierID = Convert.ToString(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the next supplier ID: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbCompanyName.Text == "" || tbContactName.Text == "" || tbContactNumber.Text == "" || tbSupplierAddress.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }

            if (tbContactNumber.Text.Length < 8)
            {
                MessageBox.Show("The contact number format incorrect!");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to create Supplier ID: {nextSupplierID} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = createSupplierConn.conndb)
                    {
                        conn.Open();
                        // Insert the new supplier into the database
                        string query = "INSERT INTO supplier (supplierID, companyName, contactName, contactNumber, address) VALUES (@SupplierID, @CompanyName, @ContactName, @ContactNumber, @Address)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SupplierID", nextSupplierID);
                            cmd.Parameters.AddWithValue("@CompanyName", tbCompanyName.Text);
                            cmd.Parameters.AddWithValue("@ContactName", tbContactName.Text);
                            cmd.Parameters.AddWithValue("@ContactNumber", tbContactNumber.Text);
                            cmd.Parameters.AddWithValue("@Address", tbSupplierAddress.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Supplier added successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the supplier: " + ex.Message);
                }
            }
        }

        private void tbContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // limit the contact number to 8 digits
            else
            if (tbContactNumber.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbCompanyName.Text = "";
            tbContactName.Text = "";
            tbContactNumber.Text = "";
            tbSupplierAddress.Text = "";
        }
    }
}
