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
using UI.Staff_Restaurant_Info;

namespace UI
{
    public partial class RequestForm : Form
    {
        // Define the ConfirmedItems property to receive the confirmed items from formRequestManagement
        public List<UI.Confirmed_Item.ConfirmedItem> ConfirmedItems { get; set; }

        private readonly Connection_class requestConn = new Connection_class();


        private int userID;
        private int lastInsertId;


        public RequestForm()
        {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            userID = Int32.Parse(User.UserID);
            RetrieveRestaurantInfo();
            FillDefaultRestauratnInfo();

            if (ConfirmedItems != null)
            {
                foreach (UI.Confirmed_Item.ConfirmedItem confirmedItem in ConfirmedItems)
                {
                    int rowIndex = dgvConfirmtList.Rows.Add();
                    dgvConfirmtList.Rows[rowIndex].Cells[0].Value = confirmedItem.VirtualItemId;
                    dgvConfirmtList.Rows[rowIndex].Cells[1].Value = confirmedItem.ItemName;
                    dgvConfirmtList.Rows[rowIndex].Cells[2].Value = confirmedItem.ItemType;
                    dgvConfirmtList.Rows[rowIndex].Cells[3].Value = confirmedItem.Category;
                    dgvConfirmtList.Rows[rowIndex].Cells[4].Value = confirmedItem.brand;
                    dgvConfirmtList.Rows[rowIndex].Cells[5].Value = confirmedItem.Quantity;
                    dgvConfirmtList.Rows[rowIndex].Cells[6].Value = confirmedItem.Unit;
                }
            }
        }

        private void RetrieveRestaurantInfo()
        {
            string query = $@"SELECT r.restaurantName, rt.restaurantTypeName, r.phone, r.address
                  FROM restaurant r
                  JOIN restaurant_type rt ON r.restaurantTypeID = rt.restaurantTypeID
                  JOIN restaurant_staff_mapping rsm ON r.restaurantID = rsm.restaurantID
                  WHERE rsm.userID = @UserID";

            try
            {
                requestConn.conndb.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, requestConn.conndb))
                {
                    cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = userID;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User.RestaurantInfo = new RestaurantInfo(
                                name: reader["restaurantName"].ToString(),
                                type: reader["restaurantTypeName"].ToString(),
                                content: reader["phone"].ToString(),
                                address: reader["address"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to retrieve restaurant information!");
            }
            finally
            {
                requestConn.conndb.Close();
            }


        }
        private void FillDefaultRestauratnInfo()
        {
            /*         StaffRestaurantInfo restaurantInfo = new StaffRestaurantInfo();*/

            tbRName.Text = User.RestaurantInfo.Name;
            tbRType.Text = User.RestaurantInfo.Type;
            tbRContent.Text = User.RestaurantInfo.Content;
            tbRAdress.Text = User.RestaurantInfo.Address;
            tbRStaffID.Text = User.UserID;
            tbStaffPosition.Text = User.Position;
        }

        private void BtnSubmitRequest_Click(object sender, EventArgs e)
        {

            if (dtpPickUpDate.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Invalid pickup date. Pickup date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }

            var confirmResult = MessageBox.Show("Are you sure to send the request?",
                                    "Confirm send!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    requestConn.conndb.Open();
                    string query = "INSERT INTO request_record (requestID, userID, requestDateTime, pickUpDate, remark, status) VALUES (@RequestID,@UserID,@CURRENT_TIMESTAMP,@PickUpTime,@Remark,@Status); SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd = new MySqlCommand(query, requestConn.conndb))
                    {
                        cmd.Parameters.Add("@RequestID", MySqlDbType.VarChar).Value = "";
                        cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = userID;
                        cmd.Parameters.Add("@CURRENT_TIMESTAMP", MySqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@PickUpTime", MySqlDbType.Date).Value = dtpPickUpDate.Value.Date;
                        cmd.Parameters.Add("@Remark", MySqlDbType.VarChar).Value = tbRemark.Text;
                        cmd.Parameters.Add("@Status", MySqlDbType.Int32).Value = 1;
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            //get the mysql auto generate id and store it
                            lastInsertId = Convert.ToInt32(result);
                            MessageBox.Show("Request ID is: "+lastInsertId.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve the last inserted ID!");
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + " Failed to submit the request!");
                }

                if (ConfirmedItems != null)
                {
                    string query = "INSERT INTO request_item (requestItemRecordID, requestItemVID, requestID, requestItemName, requestItemTypeName, requestItemCategory,requestBrand, requestQty,unit,itemStatus) VALUES (@RequestItemRecordID, @RequestItemVID,@RequestID,@RequestItemName,@requestItemTypeName,@RequestItemCategory,@RequestBrand,@RequestQty,@Unit,@itemStatus);";
                    using (MySqlCommand cmd = new MySqlCommand(query, requestConn.conndb))
                    {
                        try
                        {
                            foreach (UI.Confirmed_Item.ConfirmedItem confirmedItem in ConfirmedItems)
                            {
                                // Access the confirmed item properties
                                int virtualItemId = Convert.ToInt32(confirmedItem.VirtualItemId);
                                string itemName = confirmedItem.ItemName;
                                string itemType = confirmedItem.ItemType;
                                string category = confirmedItem.Category;
                                string brand = confirmedItem.brand;
                                int quantity = confirmedItem.Quantity;
                                string unit = confirmedItem.Unit;

                                cmd.Parameters.Add("@RequestItemRecordID", MySqlDbType.VarChar).Value = "";
                                cmd.Parameters.Add("@RequestItemVID", MySqlDbType.Int32).Value = virtualItemId;
                                cmd.Parameters.Add("@RequestID", MySqlDbType.Int32).Value = lastInsertId;
                                cmd.Parameters.Add("@RequestItemName", MySqlDbType.VarChar).Value = itemName;
                                cmd.Parameters.Add("@requestItemTypeName", MySqlDbType.VarChar).Value = itemType;
                                cmd.Parameters.Add("@RequestItemCategory", MySqlDbType.VarChar).Value = category;
                                cmd.Parameters.Add("@RequestBrand", MySqlDbType.VarChar).Value = brand;
                                cmd.Parameters.Add("@RequestQty", MySqlDbType.Int32).Value = quantity;
                                cmd.Parameters.Add("@Unit", MySqlDbType.VarChar).Value = unit;
                                cmd.Parameters.Add("@itemStatus", MySqlDbType.Enum).Value = 1;

                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Failed to submit the request!" + err.Message);

                        }

                        finally
                        {
                            MessageBox.Show("Request send successful!");
                            requestConn.conndb.Close();
                            this.Close();
                        }

                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel the request form?",
                                    "Confirm cancel!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DgvConfirmtList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Set the desired font for the column header
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }
    }
}

