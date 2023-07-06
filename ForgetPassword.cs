using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UI.connMySql;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class ForgetPassword : Form
    {
        Connection_class forgetConn = new Connection_class();

        Random rd = new Random();
        static int code;
        public ForgetPassword()
        {
            InitializeComponent();

        }
        private void mail()
        {
            code = rd.Next(100000, 999999);
            const string password = "bgqneehcsfjdtojz";

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("jason199754@gmail.com");
            message.To.Add(new MailAddress("jason199754@gmail.com"));
            message.Subject = "Yummy Restaurant Group Limited - change password";
            message.Body = "Please copy the code in forgetPassword application\n" + code + "\nThank you!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("jason199754@gmail.com", password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Email has been sent");
            tbCode.ReadOnly = false;
        }

        private void btnForgetPasswordSendMail_Click(object sender, EventArgs e)
        {
            if (tbtforgetUserID.Text == "" || txtForgetEmail.Text == "")
            {
                MessageBox.Show("Missing input!");
                return;
            }
            try
            {
                using (var conn = new MySqlConnection(forgetConn.conndb.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT userID, email FROM staff WHERE userID = @UserID AND email = @Email";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", tbtforgetUserID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtForgetEmail.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Connect to the database successful!" + tbtforgetUserID.Text + " " + txtForgetEmail.Text);
                                mail();
                            }
                            else
                            {
                                MessageBox.Show("Failed to connect to the database!" + tbtforgetUserID.Text + " " + txtForgetEmail.Text);
                                clearBox();
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to connect to the database!");
                clearBox();
            }
        }


        public void clearBox()
        {
            tbtforgetUserID.Text = String.Empty;
            txtForgetEmail.Text = String.Empty;
        }
        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (tbCode.Text == code.ToString())
            {
                lblVerifyMessage.Text = "Your Code is valid, please add the new password on below!";
                lblVerifyMessage.ForeColor = Color.Green;
                tbNewPassword.ReadOnly = false;
                txConfirmPassword.ReadOnly = false;
            }
            else
            {
                lblVerifyMessage.Text = "Your Code is invalid, please input again!" + code.ToString();
                lblVerifyMessage.ForeColor = Color.Red;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            if (Regex.Match(tbNewPassword.Text, "^(?=.*[a-z])(?=.*[0-9])[A-Z].{7,}$").Success)
            {
                if (tbNewPassword.Text == txConfirmPassword.Text)
                {
                    var confirmResult = MessageBox.Show("Are you sure to change this new password ??",
                                     "Confirm Change!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        updatePassword(tbNewPassword.Text);
                        closeForm();
                    }
                }
                else
                {
                    MessageBox.Show("The confirm password doest not match!");
                }
            }
        }

        public void updatePassword(string newPassword)
        {
            try
            {
                forgetConn.conndb.Open();
                string query = "UPDATE staff SET password = SHA1(@Password) WHERE userID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, forgetConn.conndb);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@UserID", tbtforgetUserID.Text);
                cmd.ExecuteNonQuery();
                forgetConn.conndb.Close();
                MessageBox.Show("The password change was successful!");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to update the password!");
            }
        }


        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(tbNewPassword.Text, "^(?=.*[a-z])(?=.*[0-9])[A-Z].{7,}$").Success)
            {
                lblVerifyPassword.Text = "The password format is valid!";
                lblVerifyPassword.ForeColor = Color.Green;
            }
            else
            {
                lblVerifyPassword.Text = "The password format is invalid!";
                lblVerifyPassword.ForeColor = Color.Red;
            }

        }

        private void btnReturnLgoin_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        public void closeForm()
        {
            this.Hide();
            fmLogoin fl = new fmLogoin();
            fl.ShowDialog();
            this.Close();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }
    }



}



