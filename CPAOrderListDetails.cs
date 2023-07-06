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

namespace UI
{
    public partial class CPAOrderListDetails : Form
    {
        private string orderID;
        private readonly Connection_class CPAOrderDetailConn = new Connection_class();
        private readonly DataTable CPAOrderDetailsTable = new DataTable();
        private string query = "SELECT * FROM order_cpa_item_mapping";
        public CPAOrderListDetails(string orderID)
        {
            InitializeComponent();
            this.orderID= orderID;
        }

        private void CPAOrderListDetails_Load(object sender, EventArgs e)
        {
            displayCPAOrderItem();
            dgvCPARequestList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvCPARequestList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvCPARequestList.EnableHeadersVisualStyles = false;
        }

        public void SetData(string orderType, string agreementID, string supplierID, string supplierName, string shipToAddress, string createDate, string pickUpDate, string status)
        {
            tbOrderID.Text = orderID;
            tbOrderType.Text = orderType;
            tbAgreementID.Text = agreementID;
            tbSupplierID.Text = supplierID;
            tbSupplierName.Text = supplierName;
            tbShipAddress.Text = shipToAddress;
            dtpCreateDate.Text = createDate;
            dtpPickUpDate.Text = pickUpDate;
            lblDisplayStatus.Text = status;
        }

        private void displayCPAOrderItem()
        {

            using (var conn = new MySqlConnection(CPAOrderDetailConn.conndb.ConnectionString))
            {

                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))

                        adapter.Fill(CPAOrderDetailsTable);
                    dgvCPARequestList.Rows.Clear();
                    FillData();
                    dgvCPARequestList.RowsDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

                }
            }
        }

        private void FillData()
        {
            foreach (DataRow row in CPAOrderDetailsTable.Rows)
            {
                int n = dgvCPARequestList.Rows.Add();
                dgvCPARequestList.Rows[n].Cells[0].Value = row["itemAID"].ToString();
                dgvCPARequestList.Rows[n].Cells[1].Value = row["itemName"].ToString();
                dgvCPARequestList.Rows[n].Cells[2].Value = row["totalQty"].ToString();
                dgvCPARequestList.Rows[n].Cells[3].Value = row["unit"].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
