using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI
{
    public partial class RestaurantStockControl : UserControl
    {

        private string query;
        private readonly Connection_class rStock = new Connection_class();
        private readonly DataTable rStockTable = new DataTable();
        public RestaurantStockControl()
        {
            InitializeComponent();
        }

        private void RestaurantStockControl_Load(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            displayStockData();

        }

        private void displayStockData()
        {

            rStockTable.Clear(); // Clear the DataTable
            rStockTable.Columns.Clear(); // Remove existing columns
            using (var conn = new MySqlConnection(rStock.conndb.ConnectionString))
            {

                query = @"SELECT restaurant_stock.restaurantID as 'Restaurant ID', restaurant_stock.itemID as 'Item ID',vidmapping.vName as 'Item Name' , stockQty as 'Stock Qty',item.unit as 'Unit', restaurant_stock.stockStatus as 'Stock Status' 
                                    FROM restaurant_stock 
                                    JOIN vidmapping ON restaurant_stock.itemID = vidmapping.vid
                                      JOIN item ON vidmapping.aID = item.itemID
                	                JOIN staff ON restaurant_stock.restaurantID = staff.restaurantID";


                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(rStockTable);
                        dgvStockList.DataSource = rStockTable;
                    }
                }
            }
        }

        private void dgvStockList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvStockList.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStockList.Columns["Stock Status"].Index)
            {

                string status = dgvStockList.Rows[e.RowIndex].Cells["Stock Status"].Value.ToString();
                string unit = dgvStockList.Rows[e.RowIndex].Cells["Unit"].Value.ToString();
                int stockQty = Convert.ToInt32(dgvStockList.Rows[e.RowIndex].Cells["Stock Qty"].Value);

                if (status == "Low" && unit == "kilograms" && stockQty < 100 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                    if (status == "Low" && unit == "pieces" && stockQty < 200 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }

                    if(status == "Low" && unit == "dozen" && stockQty < 100&& stockQty >0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }

                    if(status == "Low" && unit == "box" && stockQty < 10 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }

                    if(status == "Low" && unit == "sets" && stockQty < 50 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }


                    if(status == "Normal")
                {
                    if(unit == "kilograms" && stockQty >=100)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }

                    if(unit == "pieces" && stockQty >=200)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    if(unit == "dozen" && stockQty >=100)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    if(unit == "box" && stockQty >=10)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    if(unit == "sets" && stockQty >=50)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                }


                if (status == "Out of Stock" && stockQty == 0)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dgvStockList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStockList.CurrentCell != null)
            {
                try
                {
                    // Get the selected row index
                    int rowIndex = dgvStockList.CurrentCell.RowIndex;
                    int itemID = Convert.ToInt32(dgvStockList.Rows[rowIndex].Cells["Item ID"].Value);
                    string itemName = dgvStockList.Rows[rowIndex].Cells["Item Name"].Value.ToString();
                    int restaurantID = Convert.ToInt32(dgvStockList.Rows[rowIndex].Cells["Restaurant ID"].Value);
                    string status = dgvStockList.Rows[rowIndex].Cells["Stock Status"].Value.ToString();
                    string unit = dgvStockList.Rows[rowIndex].Cells["Unit"].Value.ToString();
                    int stockQty = Convert.ToInt32(dgvStockList.Rows[rowIndex].Cells["Stock Qty"].Value);

                    RestaurantStock restaurantStock = new RestaurantStock(restaurantID, itemID, itemName, status, unit, stockQty);
                    restaurantStock.ShowDialog();

                    }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }


        private void searchstock(string colName, string input)
        {

            string searchQuery = " SELECT restaurant_stock.restaurantID as 'Restaurant ID', restaurant_stock.itemID as 'Item ID',vidmapping.vName as 'Item Name' " +
                                                ", stockQty as 'Stock Qty',item.unit as 'Unit', restaurant_stock.stockStatus as 'Stock Status' " +
                                                " FROM restaurant_stock " +
                                                "JOIN vidmapping ON restaurant_stock.itemID = vidmapping.vid" +
                                                " JOIN item ON vidmapping.aID = item.itemID " +
                                                "JOIN staff ON restaurant_stock.restaurantID = staff.restaurantID " +
                                                $"WHERE {colName} LIKE  @input ";

            using (var adapter = new MySqlDataAdapter(searchQuery, rStock.conndb))
            {
        
                adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                rStockTable.Clear();
                adapter.Fill(rStockTable);
                dgvStockList.DataSource = rStockTable;
            }

        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();

            try
            {

                if (cbSearchType.SelectedIndex == 0)
                {
                    searchstock("staff.restaurantID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchstock("vidmapping.vID", input);
                }
                else if (cbSearchType.SelectedIndex == 2)
                {
                    searchstock("vidmapping.vName", input);
                }
                else if (cbSearchType.SelectedIndex == 3)
                {
                    searchstock("restaurant_stock.stockStatus", input);
                }
               

                if (dgvStockList.Rows.Count == 0)
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

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}

