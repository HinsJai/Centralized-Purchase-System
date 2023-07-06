using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using UI.connMySql;

namespace UI
{
    public partial class CreateNewVID : Form
    {
        private readonly Connection_class createVIDConn = new Connection_class();
        private int nextVID;
        private MySqlConnection conn;
        public CreateNewVID()
        {
            InitializeComponent();
            conn = createVIDConn.conndb;
        }

        private void CreateNewVID_Load(object sender, EventArgs e)
        {
            autoGenerateVID();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            try
            {
                cbAssignAID.Items.Clear();
                cbAssignAName.Items.Clear(); // Clear the AssignAName combobox

                using (MySqlConnection conn = createVIDConn.conndb)
                {
                    conn.Open();

                    string query = "SELECT i.itemID, i.itemName FROM item AS i LEFT JOIN vidmapping AS v ON v.aID = i.itemID WHERE v.aID IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int itemID = reader.GetInt32("itemID");
                                string itemName = reader.GetString("itemName");

                                cbAssignAID.Items.Add(itemID);
                                cbAssignAName.Items.Add(itemName); // Add item names to AssignAName combobox
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the comboboxes: " + ex.Message);
            }
        }

        private void cbAssignAID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAssignAID.SelectedIndex != -1)
                {
                    int selectedIndex = cbAssignAID.SelectedIndex;
                    cbAssignAName.SelectedIndex = selectedIndex; // Update the AssignAName combobox selection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the AssignAName combobox: " + ex.Message);
            }
        }

        private void cbAssignAName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAssignAName.SelectedIndex != -1)
                {
                    int selectedIndex = cbAssignAName.SelectedIndex;
                    cbAssignAID.SelectedIndex = selectedIndex; // Update the cbAssignAID combobox selection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the cbAssignAID combobox: " + ex.Message);
            }
        }

        private void autoGenerateVID()
        {
            try
            {
                using (MySqlConnection conn = createVIDConn.conndb)
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(vID), 0) + 1 AS nextID FROM vidmapping";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        nextVID = Convert.ToInt32(cmd.ExecuteScalar());
                        tbVID.Text = nextVID.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the next item ID: " + ex.Message);
            }
            conn.Close();
        }

        private void btnCreateVID_Click(object sender, EventArgs e)
        {
            int virtualID = Convert.ToInt32(tbVID.Text);
            DialogResult result = MessageBox.Show($"Are you sure to create Virtual Item ID: {virtualID} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tbVName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a name for the virtual item ID!");
                return;
            }

            if (result == DialogResult.Yes)
            {
                try
                {

                    using (MySqlConnection conn = createVIDConn.conndb)
                    {
                        conn.Open();

                        string insertQuery = "INSERT INTO vidmapping (vID, vName, aID) VALUES (@vID, @vName, @aID)";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            if (cbAssignAID.SelectedIndex != -1)
                            {

                                int selectedIndex = cbAssignAID.SelectedIndex;
                                int actualID = Convert.ToInt32(cbAssignAID.Items[selectedIndex]);
                                cmd.Parameters.AddWithValue("@aID", actualID);
                                cmd.Parameters.AddWithValue("@vID", virtualID);
                                cmd.Parameters.AddWithValue("@vName", tbVName.Text.Trim());
                                MessageBox.Show("Virtual ID with AID created successfully!");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@vID", virtualID);
                                cmd.Parameters.AddWithValue("@vName", tbVName.Text.Trim());
                                cmd.Parameters.AddWithValue("@aID", DBNull.Value);
                                MessageBox.Show("Virtual ID without AID created successfully!");
                            }

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
