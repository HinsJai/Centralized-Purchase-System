using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using UI.connMySql;

namespace UI.UserControls
{
    public partial class UserManageControls : UserControl
    {
        private readonly Connection_class userConn = new Connection_class();
        private readonly DataTable userManageList = new DataTable();
        string query;
        public UserManageControls()
        {
            InitializeComponent();
        }

        private void UserManageControls_Load(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            displaySupplierData();

        }

        private void displaySupplierData()
        {

            userManageList.Clear(); // Clear the DataTable
            userManageList.Columns.Clear(); // Remove existing columns
            using (var conn = new MySqlConnection(userConn.conndb.ConnectionString))
            {

                query = "SELECT staff.userID as 'UserID', staff.firstName as 'FirstName', staff.lastName as 'LastName', staff.gender as 'Gender', " +
                             "staff.contactNumber as 'Contact Number', staff.positionID as 'PositionID', position.positionName AS 'Position', " +
                             "staff.departmentID AS 'DeptID', department.deptName as 'DeptName', staff.email as 'Email', remark, staff.status as 'Status' " +
                             "FROM staff " +
                             "JOIN position ON staff.positionID = position.positionID " +
                             "JOIN department ON staff.departmentID = department.deptID ";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(userManageList);
                        dgvUserList.DataSource = userManageList;
                    }
                }
            }
        }

        private void dgvUserList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvUserList.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvUserList.Columns["Status"].Index)
            {
                string status = dgvUserList.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                Color cellColor;

                if (status == "Normal")
                {
                    cellColor = Color.LightGreen;
                }
                else if (status == "Locked")
                {
                    cellColor = Color.Pink;
                }
                else
                {
                    cellColor = Color.White;
                }

                e.CellStyle.BackColor = cellColor;
            }

        }
        private void searchUser(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var adapter = new MySqlDataAdapter(searchQuery, userConn.conndb))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                userManageList.Clear();
                adapter.Fill(userManageList);
                dgvUserList.DataSource = userManageList;
            }
        }
        //Search User
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchUser("staff.userID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchUser("FirstName", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchUser("staff.positionID", input);
                }
                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchUser("staff.departmentID", input); 
                }
                else if (cbSearchType.SelectedIndex == 4)
                {
                    searchUser("contactNumber", input);
                }
                else if (cbSearchType.SelectedIndex == 5)
                {
                    searchUser("status", input);
                }

                if (userManageList.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                }
                tbSearch.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvUserList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentCell != null)
            {
                try
                {
                    int row = dgvUserList.CurrentCell.RowIndex;
                    int userID = (int)dgvUserList.Rows[row].Cells["UserID"].Value;
                    int deptID = (int)dgvUserList.Rows[row].Cells["DeptID"].Value;
                    string userStatus = dgvUserList.Rows[row].Cells["Status"].Value.ToString();
                    UserDetails userDetails = new UserDetails(userID,deptID, userStatus);
                    userDetails.ShowDialog();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearchItem.PerformClick();
                    // stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }
    }
}
