using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UI.connMySql;

namespace UI
{
    public partial class CreateUser : Form
    {
        private readonly Connection_class createUserConn = new Connection_class();
        private MySqlConnection conn;

        public CreateUser()
        {
            InitializeComponent();
            PopulatePositionComboBox();
            PopulateDeptComboBox();
            conn = createUserConn.conndb;
        }
        private void CreateUser_Load(object sender, EventArgs e)
        {
            GetMaxUserID();
        }


        private void GetMaxUserID()
        {
            try
            {
                using (MySqlConnection conn = createUserConn.conndb)
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(userID), 0) + 1 AS nextID FROM staff";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        tbUserID.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the next user ID: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if(tbPswd.Text == "" || tbEmail.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbContactNumber.Text == "" 
                || cbDeptID.SelectedIndex==-1 ||  cbPositionID.SelectedIndex == -1 || rbMale.Checked== false && rbFemale.Checked == false)
            {
                MessageBox.Show("Missing input!");
                return;
            }

            if(cbDeptID.SelectedIndex==0 && cbRestaurantID.SelectedIndex == -1)
            {
                MessageBox.Show("Restaurant info is miss!");
                return;
            }

            if(tbContactNumber.Text.Length < 8)
            {
                MessageBox.Show("The contact number format incorrect!");
                return;
            }


            if (!Regex.Match(tbPswd.Text, "^(?=.*[a-z])(?=.*[0-9])[A-Z].{7,}$").Success)
            {
                MessageBox.Show("The password format is invalid!");
                return;
            }

            if (!Regex.IsMatch(tbEmail.Text.Trim(), @"^.+@yummy\.com$"))
            {
                MessageBox.Show("The email format is invalid. It should end with @yummy.com!");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to create User ID: {tbUserID.Text} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string gender = "";
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (rbMale.Checked)
                    {
                        gender = "M";
                    }
                    else if (rbFemale.Checked)
                    {
                        gender = "F";
                    }

                    using (MySqlConnection conn = createUserConn.conndb)
                    {
                        conn.Open();
                        string query = "INSERT INTO staff (userID, positionID, departmentID, password, email, firstName, lastName, gender, contactNumber,status,remark,managerID) " +
                            "VALUES (@userID, @positionID, @departmentID, SHA1(@password), @email, @firstName, @lastName, @gender, @contactNumber, @status, @remark, @managerID)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userID", tbUserID.Text.Trim());
                            cmd.Parameters.AddWithValue("@positionID", cbPositionID.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@departmentID", cbDeptID.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@password", tbPswd.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@firstName", tbFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastName", tbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@contactNumber", tbContactNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Normal");
                            cmd.Parameters.AddWithValue("@remark", string.IsNullOrEmpty(tbUserRemark.Text.Trim()) ? DBNull.Value : (object)tbUserRemark.Text.Trim());
                            cmd.Parameters.AddWithValue("@managerID", string.IsNullOrEmpty(tbManagerID.Text.Trim()) ? DBNull.Value : (object)tbManagerID.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User created successfully!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to create user.");
                            }

                            if (cbDeptID.SelectedIndex == 0)
                            {
                                string restaurantQuery = "INSERT INTO restaurant_staff_mapping (restaurantID, userID) VALUES (@restaurantID, @userID)";
                                using (MySqlCommand restaurantCmd = new MySqlCommand(restaurantQuery, conn))
                                {
                                    restaurantCmd.Parameters.AddWithValue("@restaurantID", cbRestaurantID.SelectedItem.ToString());
                                    restaurantCmd.Parameters.AddWithValue("@userID", tbUserID.Text.Trim());
                                    restaurantCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error:  " + ex.Message);
                }
            }
        }

        private void PopulatePositionComboBox()
        {
            try
            {
                cbPositionID.Items.Clear();
                cbPositionName.Items.Clear();

                using (MySqlConnection conn = createUserConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT * FROM position";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int positionID = reader.GetInt32("positionID");
                                string positionName = reader.GetString("positionName");

                                // Add position names and id to  combobox
                                cbPositionID.Items.Add(positionID);
                                cbPositionName.Items.Add(positionName);
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

        private void cbPositionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPositionID.SelectedIndex != -1)
                {
                    int selectedIndex = cbPositionID.SelectedIndex;
                    cbPositionName.SelectedIndex = selectedIndex;

                    switch (selectedIndex)
                    {
                        case 0:
                            cbDeptID.SelectedIndex = 3;
                            break;
                        case 1:
                            cbDeptID.SelectedIndex = 2;
                            break;
                        case 2:
                            cbDeptID.SelectedIndex = 1;
                            break;
                        case 3:
                            cbDeptID.SelectedIndex = 0;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    private void cbPositionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPositionName.SelectedIndex != -1)
                {
                    int selectedIndex = cbPositionName.SelectedIndex;
                    cbPositionID.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateDeptComboBox()
        {
            try
            {
                cbDeptID.Items.Clear();
                cbDeptName.Items.Clear();

                using (MySqlConnection conn = createUserConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT deptID, deptName FROM department";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int deptID = reader.GetInt32("deptID");
                                string deptName = reader.GetString("deptName");

                                // Add position names and id to  combobox
                                cbDeptID.Items.Add(deptID);
                                cbDeptName.Items.Add(deptName);
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

        private void cbDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDeptID.SelectedIndex != -1)
                {
                    int selectedIndex = cbDeptID.SelectedIndex;
                    cbDeptName.SelectedIndex = selectedIndex;

                    switch (selectedIndex)
                    {
                        case 0:
                            cbPositionID.SelectedIndex = 3;
                            break;
                        case 1:
                            cbPositionID.SelectedIndex = 2;
                            break;
                        case 2:
                            cbPositionID.SelectedIndex = 1;
                            break;
                        case 3:
                            cbPositionID.SelectedIndex = 0;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(cbDeptID.SelectedIndex == 0)
            {
                PopulateRestaurantComboBox();
                cbRestaurantID.Enabled=true;
                cbRestaurantName.Enabled = true;
            }
            else
            {
                cbRestaurantID.Enabled = false;
                cbRestaurantName.Enabled = false;
                cbRestaurantID.Items.Clear();
                cbRestaurantName.Items.Clear();
                tbRestaurantType.Text = "";
            }
        }

        private void cbDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDeptName.SelectedIndex != -1)
                {
                    int selectedIndex = cbDeptName.SelectedIndex;
                    cbDeptID.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateRestaurantComboBox()
        {
            try
            {
                cbRestaurantID.Items.Clear();
                cbRestaurantName.Items.Clear();

                using (MySqlConnection conn = createUserConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT r.RestaurantID, r.restaurantTypeID, r.restaurantName, t.restaurantTypeName " +
                                           "FROM restaurant r " +
                                           "JOIN restaurant_type t ON r.restaurantTypeID = t.restaurantTypeID;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int restaurantID = reader.GetInt32("RestaurantID");
                                string restaurantName = reader.GetString("restaurantName");

                                // Add position names and id to  combobox
                                cbRestaurantID.Items.Add(restaurantID);
                                cbRestaurantName.Items.Add(restaurantName);
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


        private void cbRestaurantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRestaurantID.SelectedIndex != -1)
                {
                    int selectedIndex = cbRestaurantID.SelectedIndex;
                    cbRestaurantName.SelectedIndex = selectedIndex;

                    using (MySqlConnection conn = createUserConn.conndb)
                    {
                        conn.Open();
                        string restaurantTypeName;
                        string query = "SELECT t.restaurantTypeName " +
                                       "FROM restaurant r " +
                                       "JOIN restaurant_type t ON r.restaurantTypeID = t.restaurantTypeID " +
                                       "WHERE r.restaurantTypeID = @restaurantTypeID;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@restaurantTypeID", selectedIndex + 1);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    restaurantTypeName = reader.GetString("restaurantTypeName");
                                    tbRestaurantType.Text = restaurantTypeName;
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

        private void cbRestaurantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRestaurantName.SelectedIndex != -1)
                {
                    int selectedIndex = cbRestaurantName.SelectedIndex;
                    cbRestaurantID.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you reset your input ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tbPswd.Text = "";
                tbLastName.Text = "";
                tbFirstName.Text = "";
                tbContactNumber.Text = "";
                tbEmail.Text = "";
                cbPositionID.SelectedIndex = -1;
                cbPositionName.SelectedIndex = -1;
                cbDeptID.SelectedIndex = -1;
                cbDeptName.SelectedIndex = -1;
                cbRestaurantID.SelectedIndex = -1;
                cbRestaurantName.SelectedIndex = -1;
                rbFemale.Checked = false;
                rbMale.Checked = false;
                tbRestaurantType.Text = "";
                tbManagerID.Text = "";
                tbUserRemark.Text = "";
            }
        }
    }
}



