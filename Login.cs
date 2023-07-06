using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UI.connMySql;
using UI.AccountingControls;

namespace UI
{
    public partial class fmLogoin : Form
    {
        private readonly Connection_class loginConn = new Connection_class();

        public fmLogoin()
        {
            InitializeComponent();
        }

        private void Logoin_Load(object sender, EventArgs e)
        {
            cbDepartment.SelectedIndex = 4;
/*            ApplyCircularPictureBoxMask(pbLogo);
*/        }

        private void lklForgotPswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword fp = new ForgetPassword();
            fp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbId.Text) || string.IsNullOrEmpty(tbPassword.Text))
                {
                    MessageBox.Show("Missing input!");
                    return;
                }

                loginConn.conndb.Open();
                string query = "SELECT staff.userID, staff.departmentID, staff.password, position.positionName, status FROM staff JOIN position ON staff.positionID = position.positionID WHERE staff.userID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, loginConn.conndb);
                cmd.Parameters.AddWithValue("@UserID", tbId.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string userID = reader["userID"].ToString();
                        string departmentID = reader["departmentID"].ToString();
                        string storedHash = reader["password"].ToString();
                        string position = reader["positionName"].ToString();
                        string status = reader["status"].ToString();

                        if (VerifyPassword(tbPassword.Text, storedHash) && tbId.Text == userID && cbDepartment.SelectedIndex.ToString() == departmentID)
                        {
                            if (status != "Locked")
                            {
                                User.UserID = userID; //store the ID to User class
                                User.DepartmentID = departmentID;
                                User.Position = position;
                                enterDepartment();
                            }
                            else
                            {
                                MessageBox.Show("Your account has been locked!");
                                clearBox();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to connect to the database!" + tbId.Text + " " + storedHash + " " + cbDepartment.SelectedIndex.ToString());
                            clearBox();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid UserID or password!");
                    clearBox();
                }

                reader.Close();
                loginConn.conndb.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect to the database!");
                clearBox();
            }
        }
        // verify the hashed password in database with the user input
        private bool VerifyPassword(string userInput, string storedHash)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] userInputBytes = Encoding.UTF8.GetBytes(userInput);
                byte[] hashedBytes = sha1.ComputeHash(userInputBytes);
                string hashedInput = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return (hashedInput == storedHash);
            }
        }

        private void clearBox()
        {
            cbDepartment.SelectedIndex = 0;
            tbId.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }

        private void enterDepartment()
        {
            if (cbDepartment.SelectedIndex == 1)
            {
                this.Hide();
                formRequestManagement rm = new formRequestManagement();
                rm.ShowDialog();
            }
            else if (cbDepartment.SelectedIndex == 2)
            {
                this.Hide();
                ItemManagement im = new ItemManagement();
                im.ShowDialog();
            }
            else if (cbDepartment.SelectedIndex == 6)
            {
                this.Hide();
                AdminManagement am = new AdminManagement();
                am.ShowDialog();
            }
            else if (cbDepartment.SelectedIndex == 3)
            {
                this.Hide();
                AgreementManagement agm = new AgreementManagement();
                agm.ShowDialog();
            }
            else if (cbDepartment.SelectedIndex == 4)
            {
                this.Hide();
                InventoryManagement itm = new InventoryManagement();
                itm.ShowDialog();
            }
            else if (cbDepartment.SelectedIndex == 5)
            {
                this.Hide();
                AccountManagement acm = new AccountManagement();
                acm.ShowDialog();
            }

        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex == 1)
            {
                tbId.Text = "20579";
                tbPassword.Text = "Rr123456";
            }
            else if (cbDepartment.SelectedIndex == 2)
            {
                tbId.Text = "54321";
                tbPassword.Text = "Rr123456";
            }
            else if (cbDepartment.SelectedIndex == 6)
            {
                tbId.Text = "1";
                tbPassword.Text = "Rr123456";
            }
            else if (cbDepartment.SelectedIndex == 3)
            {
                tbId.Text = "12345";
                tbPassword.Text = "Rr123456";
            }
            else if (cbDepartment.SelectedIndex == 4)
            {
                tbId.Text = "1004";
                tbPassword.Text = "Rr123456";
            }
            else if (cbDepartment.SelectedIndex == 5)
            {
                tbId.Text = "10101";
                tbPassword.Text = "Rr123456";
            }
        }

        private void btnShowPswd_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
            btnHidePswd.Visible = true;
            btnShowPswd.Visible = false;
        }

        private void btnHidePswd_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            btnHidePswd.Visible = false;
            btnShowPswd.Visible = true;
        }
        // Apply a circular mask to the PictureBox
        private void ApplyCircularPictureBoxMask(PictureBox pictureBox)
        {
            // Create a Bitmap with the same size as the PictureBox
            Bitmap mask = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Set the background color of the mask to transparent
            mask.MakeTransparent();

            // Create a Graphics object from the mask
            using (Graphics g = Graphics.FromImage(mask))
            {
                // Create a region in the shape of an ellipse
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, mask.Width, mask.Height);

                    // Set the PictureBox region to the ellipse shape
                    pictureBox.Region = new Region(path);

                    // Fill the mask with the ellipse shape
                    using (Brush brush = new SolidBrush(Color.White))
                    {
                        g.FillPath(brush, path);
                    }
                }
            }
        }
    }
}
