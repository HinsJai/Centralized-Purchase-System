using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI
{
    public partial class UserDetails : Form
    {
        Connection_class userDetailConn = new Connection_class();
        private int userID;
        private int deptID;
        private string userStatus;

        public UserDetails(int userID, int deptID,string userStatus)
        {
            InitializeComponent();
            this.userID = userID;
            this.deptID = deptID;
            this.userStatus = userStatus;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            if (deptID == 1)
            {
                lblRestaurantID.Visible = true;
                tbRestaurantID.Visible = true;
                lblRestaurantName.Visible = true;
                tbRestaurantName.Visible = true;
            }
            else
            {
                lblRestaurantID.Visible = false;
                tbRestaurantID.Visible = false;
                lblRestaurantName.Visible = false;
                tbRestaurantName.Visible = false;

            }

            if (userStatus == "Locked")
            {
                btnLock.Visible=false;
                btnUnlock.Visible = true;
            }
            else
            {
                btnLock.Visible = true;
                btnUnlock.Visible = false;
            }

            setUserDetails();
        }

        private void setUserDetails()
        {
            string detailsQuery = "SELECT  staff.userID AS 'UserID', " +
                "staff.firstName AS 'FirstName',  " +
                "staff.lastName AS 'LastName', " +
                "staff.gender AS 'Gender', " +
                "staff.contactNumber AS 'Contact Number', " +
                "staff.status AS 'Status', " +
                "staff.positionID AS 'PositionID', " +
                "position.positionName AS 'Position', " +
                "staff.departmentID AS 'DeptID', " +
                "department.deptName AS 'DeptName', " +
                "staff.email AS 'Email', " +
                "restaurant.RestaurantID, " +
                "restaurantName, " +
                "remark " +
                "FROM  staff " +
                "JOIN position ON staff.positionID = position.positionID " +
                "JOIN department ON staff.departmentID = department.deptID " +
                "LEFT JOIN restaurant_staff_mapping ON staff.userID = restaurant_staff_mapping.userID " +
                "LEFT JOIN restaurant ON restaurant_staff_mapping.restaurantID = restaurant.RestaurantID " +
                "WHERE staff.userID = @UserID";


            using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(detailsQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the data from the reader and insert in textbox
                            tbUserID.Text = reader.GetInt32("userID").ToString();
                            tbContactNumber.Text = reader.GetInt32("Contact Number").ToString();
                            tbFirstName.Text = reader.GetString("FirstName");
                            tbLastName.Text = reader.GetString("LastName");
                            tbGender.Text = reader.GetString("Gender");
                            tbPositionID.Text = reader.GetString("PositionID");
                            tbPositionName.Text = reader.GetString("Position");
                            tbDeptID.Text = reader.GetInt32("DeptID").ToString();
                            tbDeptName.Text = reader.GetString("DeptName");
                            tbEmail.Text = reader.GetString("Email");
                            lblDisplayStatus.Text = reader.GetString("Status");
                            tbUserRemark.Text = reader.IsDBNull(reader.GetOrdinal("remark")) ? string.Empty : reader.GetString("remark");

                            // If the user is a restaurant staff, display the restaurant ID and name
                            if (deptID == 1)
                            {
                                tbRestaurantID.Text = reader.IsDBNull(reader.GetOrdinal("RestaurantID")) ? string.Empty : reader.GetString("RestaurantID");
                                tbRestaurantName.Text = reader.IsDBNull(reader.GetOrdinal("restaurantName")) ? string.Empty : reader.GetString("restaurantName");
                            }
                            // Set the color of the status label
                            if (reader.GetString("Status") == "Locked")
                            {
                                lblDisplayStatus.ForeColor = Color.LightPink;
                            }
                            else
                            {
                                lblDisplayStatus.ForeColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }

        private void btnModifyUse_Click(object sender, EventArgs e)
        {
            tbContactNumber.ReadOnly = false;
            tbFirstName.ReadOnly = false;
            tbLastName.ReadOnly = false;
            tbPositionID.ReadOnly = false;
            tbDeptID.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbUserRemark.ReadOnly = false;
            btnModifyUser.Visible = false;
            btnModifyConfirm.Visible = true;
            tbRestaurantID.ReadOnly = false;
            btnDeleteItem.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnModifyConfirm_Click(object sender, EventArgs e)
        {

            if (deptID != 1)
            {
                if (tbContactNumber.Text == "" || tbFirstName.Text == "" || tbLastName.Text == ""
                || tbPositionName.Text == "" || tbDeptName.Text == "" || tbEmail.Text == "")

                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
            }
            else if (deptID == 1)
            {
                if (tbContactNumber.Text == "" || tbFirstName.Text == "" || tbLastName.Text == ""
                                   || tbPositionName.Text == "" || tbDeptName.Text == "" || tbEmail.Text == "" || tbRestaurantName.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
            }

            if (tbDeptID.Text == "1" && tbPositionID.Text != "123")
            {
                MessageBox.Show("Your department and position not match");
                return;
            }

            try
            {

                DialogResult result = MessageBox.Show($"Are you sure update user ID: {tbUserID.Text} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string modifyQuery;
                    string modifyMappingQuery;

                    modifyQuery = "UPDATE staff " +
                                                    "SET contactNumber = @ContactNumber, " +
                                                    "firstName = @FirstName, " +
                                                    "lastName = @LastName, " +
                                                    "positionID = @PositionID, " +
                                                    "departmentID = @DeptID, " +
                                                    "email = @Email, " +
                                                    "remark = @Remark " +
                                                    "WHERE userID = @UserID";

                    modifyMappingQuery = "UPDATE restaurant_staff_mapping " +
                                                                   "SET restaurantID = @RestaurantID " +
                                                                   "WHERE userID = @UserID";

                    using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
                    {
                        conn.Open();

                        using (var cmd = new MySqlCommand(modifyQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ContactNumber", tbContactNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@PositionID", tbPositionID.Text.Trim());
                            cmd.Parameters.AddWithValue("@DeptID", tbDeptID.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Remark", tbUserRemark.Text.Trim());
                            cmd.Parameters.AddWithValue("@UserID", userID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (deptID == 1) // If the user is in the restaurant department
                            {
                                using (var mappingCmd = new MySqlCommand(modifyMappingQuery, conn))
                                {
                                    mappingCmd.Parameters.AddWithValue("@RestaurantID", tbRestaurantID.Text);
                                    mappingCmd.Parameters.AddWithValue("@UserID", userID);

                                    int mappingRowsAffected = mappingCmd.ExecuteNonQuery();

                                }
                            }

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User details updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update user details.");
                            }
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbPositionID_TextChanged(object sender, EventArgs e)
        {
            string positionQuery = "SELECT positionName FROM position WHERE positionID = @PositionID";

            using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(positionQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PositionID", tbPositionID.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbPositionName.Text = reader.GetString("positionName");
                        }
                        else
                        {
                            tbPositionName.Text = "";
                        }
                    }
                }
            }
        }

        private void tbDeptID_TextChanged(object sender, EventArgs e)
        {
            string deptQuery = "SELECT deptName FROM department WHERE deptID = @DeptID";
            using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(deptQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@DeptID", tbDeptID.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbDeptName.Text = reader.GetString("deptName");
                        }
                        else
                        {
                            tbDeptName.Text = "";
                        }
                    }
                }
            }
        }

        private void tbRestaurantID_TextChanged(object sender, EventArgs e)
        {
            string restaurantQuery = "SELECT restaurantName FROM restaurant WHERE restaurantID = @RestaurantID";
            using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(restaurantQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@RestaurantID", tbRestaurantID.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbRestaurantName.Text = reader.GetString("restaurantName");
                        }
                        else
                        {
                            tbRestaurantName.Text = "";
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbContactNumber.ReadOnly = true;
            tbFirstName.ReadOnly = true;
            tbLastName.ReadOnly = true;
            tbPositionID.ReadOnly = true;
            tbDeptID.ReadOnly = true;
            tbEmail.ReadOnly = true;
            tbUserRemark.ReadOnly = true;
            btnModifyUser.Visible = true;
            btnModifyConfirm.Visible = false;
            tbRestaurantID.ReadOnly = true;
            btnDeleteItem.Visible = true;
            btnCancel.Visible = false;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string deleteMappingQuery = "DELETE FROM restaurant_staff_mapping WHERE userID = @UserID";
            string deleteQuery = "DELETE FROM staff WHERE userID = @UserID";

            try
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete user ID: {tbUserID.Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
                    {
                        conn.Open();

                        if (deptID == 1)
                        {
                            using (var mappingCmd = new MySqlCommand(deleteMappingQuery, conn))
                            {
                                mappingCmd.Parameters.AddWithValue("@UserID", userID);

                                int mappingRowsAffected = mappingCmd.ExecuteNonQuery();
                            }
                        }

                        using (var cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete user.");
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

        private void btnLock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure lock user ID: {userID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE staff SET status = 1 WHERE userID = @UserID";

                    using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
                    {
                        conn.Open();

                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"User ID:  {userID} has been locked!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to lock user!");
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

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure unlock user ID: {userID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE staff SET status = 2 WHERE userID = @UserID";

                    using (var conn = new MySqlConnection(userDetailConn.conndb.ConnectionString))
                    {
                        conn.Open();

                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"User ID:  {userID} has been unlocked!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to unlock user!");
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
    }
}
