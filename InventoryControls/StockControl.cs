using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UI.connMySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.InventoryControls
{
    public partial class StockControl : UserControl
    {
        private readonly Connection_class stockConn = new Connection_class();
        private readonly DataTable stockTable = new DataTable();

        string query = @"SELECT itemID as 'Item ID', itemName as 'Item Name', stockItemQty as 'Stock Qty',unit as 'Unit',remark as'Remark', stockStatus as 'Stock Status' FROM item ";

        public StockControl()
        {
            InitializeComponent();
        }

        private void StockControl_Load(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            displayStockData();
            dgvStockList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvStockList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption; ;
            dgvStockList.EnableHeadersVisualStyles = false;
        }

        private void InventoryStockUpdate_QuantityUpdated(object sender, EventArgs e)
        {
            // Refresh the stock data in the DataGridView
            displayStockData();
        }

        private void displayStockData()
        {
            using (var conn = new MySqlConnection(stockConn.conndb.ConnectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(stockTable);
                        dgvStockList.Rows.Clear(); // Clear existing rows in the DataGridView control
                        dgvStockList.DataSource = stockTable;
                    }
                }
            }
            // Update the stock status based on the quantity
            foreach (DataGridViewRow row in dgvStockList.Rows)
            {
                string unit = row.Cells["Unit"].Value.ToString();
                int stockQty = Convert.ToInt32(row.Cells["Stock Qty"].Value);
                string status = "";

                if (unit == "kilograms" && stockQty < 400 && stockQty > 0)
                {
                    status = "Low";
                }
                else if (unit == "pieces" && stockQty < 800 && stockQty > 0)
                {
                    status = "Low";
                }
                else if (unit == "dozen" && stockQty < 400 && stockQty > 0)
                {
                    status = "Low";
                }
                else if (unit == "box" && stockQty < 40 && stockQty > 0)
                {
                    status = "Low";
                }
                else if (unit == "sets" && stockQty < 200 && stockQty > 0)
                {
                    status = "Low";
                }
                else if (stockQty == 0)
                {
                    status = "Out of Stock";
                }
                else 
                {
                    status = "Normal";
                }

                // Update the stock status in the item table
                int itemID = Convert.ToInt32(row.Cells["Item ID"].Value);
                UpdateStockStatus(itemID, status);
            }
        }

        private void UpdateStockStatus(int itemID, string status)
        {
            using (var conn = new MySqlConnection(stockConn.conndb.ConnectionString))
            {
                string query = "UPDATE item SET stockStatus = @status WHERE itemID = @itemID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@itemID", itemID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dgvStockList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Set the text color of all cells to black
                e.CellStyle.ForeColor = Color.Black;
            }

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

                if (status == "Low" && unit == "kilograms" && stockQty < 400 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (status == "Low" && unit == "pieces" && stockQty < 800 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }

                if (status == "Low" && unit == "dozen" && stockQty < 400 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }

                if (status == "Low" && unit == "box" && stockQty < 40 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }

                if (status == "Low" && unit == "sets" && stockQty < 200 && stockQty > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }


                if (status == "Normal")
                {
                    if (unit == "kilograms" && stockQty >= 400)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }

                    if (unit == "pieces" && stockQty >= 800)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    if (unit == "dozen" && stockQty >= 400)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    if (unit == "box" && stockQty >= 40)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    if (unit == "sets" && stockQty >= 200)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = tbSearch.Text.Trim();
            try
            {
                if (cbSearchType.SelectedIndex == 0)
                {
                    searchItem("itemID", input);
                }
                else if (cbSearchType.SelectedIndex == 1)
                {
                    searchItem("itemName", input);
                }

                if (stockTable.Rows.Count == 0)
                {
                    MessageBox.Show("Item not found!");
                    tbSearch.Text = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void searchItem(string colName, string input)
        {
            string searchQuery = query + $" WHERE {colName} LIKE @input";
            using (var conn = new MySqlConnection(stockConn.conndb.ConnectionString))
            {
                using (var adapter = new MySqlDataAdapter(searchQuery, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@input", $"%{input}%");
                    stockTable.Clear(); // Clear the DataTable
                    adapter.Fill(stockTable);
                }
            }
            dgvStockList.DataSource = stockTable;
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
                    string status = dgvStockList.Rows[rowIndex].Cells["Stock Status"].Value.ToString();
                    string unit = dgvStockList.Rows[rowIndex].Cells["Unit"].Value.ToString();
                    int stockQty = Convert.ToInt32(dgvStockList.Rows[rowIndex].Cells["Stock Qty"].Value);

                    InventoryStockUpdate inventoryStockUpdate = new InventoryStockUpdate(itemID, itemName, status, unit, stockQty);
                    inventoryStockUpdate.ShowDialog();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
