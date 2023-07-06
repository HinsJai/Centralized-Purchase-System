using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Windows.Forms;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI
{
    public partial class SupplierDetails : Form
    {
        private string supplierID;
        private string query;
        private readonly Connection_class supplierDetailConn = new Connection_class();
        public SupplierDetails(string supplierID)
        {
            InitializeComponent();
            this.supplierID = supplierID;
        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            setSupplierDetail();
        }

        private void setSupplierDetail()
        {
            try
            {
                query = "SELECT * FROM supplier WHERE supplierID = @SupplierID";
                using (var connection = new MySqlConnection(supplierDetailConn.conndb.ConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", supplierID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data from the reader and insert in textbox
                                tbSupplierID.Text = reader.GetString("supplierID");
                                tbCompanyName.Text = reader.GetString("companyName");
                                tbContactName.Text = reader.GetString("contactName");
                                tbContactNumber.Text = reader.GetString("contactNumber");
                                tbSupplierAddress.Text = reader.GetString("address");
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


        private void btnModifyConfirm_Click(object sender, EventArgs e)
        {
            if (tbCompanyName.Text == "" || tbContactName.Text == "" || tbContactNumber.Text == "" || tbSupplierAddress.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }



            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to update supplier ID: {supplierID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        query = "UPDATE supplier SET companyName = @CompanyName, contactName = @ContactName, contactNumber = @ContactNumber, address = @Address WHERE supplierID = @SupplierID";
                        using (var connection = new MySqlConnection(supplierDetailConn.conndb.ConnectionString))
                        {
                            connection.Open();
                            using (var command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@SupplierID", supplierID);
                                command.Parameters.AddWithValue("@CompanyName", tbCompanyName.Text);
                                command.Parameters.AddWithValue("@ContactName", tbContactName.Text);
                                command.Parameters.AddWithValue("@ContactNumber", tbContactNumber.Text);
                                command.Parameters.AddWithValue("@Address", tbSupplierAddress.Text);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Supplier details update successful!");
                            btnCancel.Visible = false;
                            btnModifySupplier.Visible = true;
                            tbCompanyName.ReadOnly = true;
                            tbContactName.ReadOnly = true;
                            tbContactNumber.ReadOnly = true;
                            tbSupplierAddress.ReadOnly = true;
                            btnModifyConfirm.Visible = false;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete supplier ID: {supplierID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(supplierDetailConn.conndb.ConnectionString))
                    {
                        conn.Open();

                        // Delete items associated with the supplier from the item table
                        string updateItemsQuery = "UPDATE item SET supplierID = NULL WHERE supplierID = @SupplierID";
                        using (var updateItemsCmd = new MySqlCommand(updateItemsQuery, conn))
                        {
                            updateItemsCmd.Parameters.AddWithValue("@SupplierID", supplierID);
                            updateItemsCmd.ExecuteNonQuery();
                        }

                        // Delete the supplier from the supplier table
                        string deleteSupplierQuery = "DELETE FROM supplier WHERE supplierID = @SupplierID";
                        using (var deleteSupplierCmd = new MySqlCommand(deleteSupplierQuery, conn))
                        {
                            deleteSupplierCmd.Parameters.AddWithValue("@SupplierID", supplierID);
                            deleteSupplierCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Supplier details deleted successfully!");
                        this.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnModifySupplier_Click(object sender, EventArgs e)
        {
            tbCompanyName.ReadOnly = false;
            tbContactName.ReadOnly = false;
            tbContactNumber.ReadOnly = false;
            tbSupplierAddress.ReadOnly = false;
            btnCancel.Visible = true;
            btnModifySupplier.Visible = false;
            btnModifyConfirm.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnModifySupplier.Visible = true;
            tbCompanyName.ReadOnly = true;
            tbContactName.ReadOnly = true;
            tbContactNumber.ReadOnly = true;
            tbSupplierAddress.ReadOnly = true;
            btnModifyConfirm.Visible = false;
        }

        private void tbContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (tbContactNumber.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
