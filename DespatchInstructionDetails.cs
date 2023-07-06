using System;
using System.Windows.Forms;
using UI.connMySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Data;
using System.Security.Cryptography;

namespace UI
{
    public partial class DespatchInstructionDetails : Form
    {
        private readonly Connection_class despatchDetailConn = new Connection_class();
        private readonly DataTable despatchDetailsTable = new DataTable();
        
        public DespatchInstructionDetails()
        {
            InitializeComponent();
        }

        private void DespatchInstructionDetails_Load(object sender, EventArgs e)
        {
            displayDespatchItem();
            dgvDespatchItemList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDespatchItemList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvDespatchItemList.EnableHeadersVisualStyles = false;
        }

        public void SetData(string despatchID, string handleBy, string restaurantID, string restaurantName, string pickUpDate, string status,string requestID)
        {
            tbDespatch.Text = despatchID;
            tbHandleBy.Text = handleBy;
            tbRestaurantID.Text = restaurantID;
            tbRestaurantName.Text = restaurantName;
            tbRestaurantID.Text = restaurantID;
            dtpPickUpDate.Text = pickUpDate;
            lblDisplayStatus.Text = status;
            tbHiddenRequestID.Text = requestID;

            setResturantDetail();

            if(status != "In Progress")
            {
                btnGenerateDNote.Enabled = false;
            }
            else
            {
                btnGenerateDNote.Enabled = true;
            }
        }

        private void setResturantDetail()
        {
                       string query = "SELECT address, phone FROM restaurant WHERE restaurantID = @restaurantID";
            using (var conn = new MySqlConnection(despatchDetailConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@restaurantID", tbRestaurantID.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbShipAddress.Text = reader["address"].ToString();
                            tbRestaurantContact.Text = reader["phone"].ToString();
                        }
                    }
                }
            }
        }

        private void displayDespatchItem()
        {
            string query = "SELECT itemID,vidmapping.vName, requestQty, unit " +
                "FROM despatch_instruction_item_mapping " +
                "JOIN vidmapping ON despatch_instruction_item_mapping.itemID = vidmapping.vID " +
                "WHERE despatchID = @despatchID";
            using (var conn = new MySqlConnection(despatchDetailConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@despatchID", tbDespatch.Text);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        despatchDetailsTable.Clear();
                        despatchDetailsTable.Load(reader);
                        FillData();
                        dgvDespatchItemList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                    }
                }
            }
        }

        private void FillData()
        {
            foreach (DataRow row in despatchDetailsTable.Rows)
            {
                int n = dgvDespatchItemList.Rows.Add();
                dgvDespatchItemList.Rows[n].Cells[0].Value = row["itemID"].ToString();
                dgvDespatchItemList.Rows[n].Cells[1].Value = row["vName"].ToString();
                dgvDespatchItemList.Rows[n].Cells[2].Value = row["requestQty"].ToString();
                dgvDespatchItemList.Rows[n].Cells[3].Value = row["unit"].ToString();
            }
        }

        private void btnGenerateDNote_Click(object sender, EventArgs e)
        {
            GenerateDeliveryNote generateDeliveryNote = new GenerateDeliveryNote();
            generateDeliveryNote.SetData(tbHiddenRequestID.Text,tbDespatch.Text, tbRestaurantID.Text,tbRestaurantName.Text, tbRestaurantContact.Text, tbShipAddress.Text, despatchDetailsTable);
            generateDeliveryNote.Show();
        }
    }
}
