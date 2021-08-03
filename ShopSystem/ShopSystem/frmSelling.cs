using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converting_Date;
using Shop_System.DAL;
using Shop_System.BLL;

namespace ShopSystem
{
    public partial class frmSelling : Form
    {
        public frmSelling()
        {
            InitializeComponent();
        }

        public void FillSearchGrid()
        {
            DataTable Table = ShopDAL.GetShopping();
            dgvSearch.DataSource = null;
            dgvSearch.DataSource = Table;
        }

        public void FillGrid()
        {
            DataTable Table = ShopDAL.GetSell();
            dgvSell.DataSource = null;
            dgvSell.DataSource = Table;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mtbDate.Text = Converting.PersianDate(DateTime.Now.ToString(), true, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtbDate.Text = string.Empty;
            txtWareTitle.Text = string.Empty;
            txtSellPrice.Text = string.Empty;
            txtCount.Text = string.Empty;
            txtSeller.Text = string.Empty;
            txtProfit.Text = string.Empty;
            txtShopPrice.Text = string.Empty;
            txtTotal.Text = string.Empty;

            mtbDate.Focus();
        }

        private void txtWareTitle_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ShopDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = "Select * From Shopping Where WareTitle Like @Search";
            Command.Parameters.AddWithValue("@Search", txtWareTitle.Text + "%");

            DataTable Table = new DataTable();
            SqlDataReader Reader = Command.ExecuteReader();
            Table.Load(Reader);

            dgvSearch.DataSource = null;
            dgvSearch.DataSource = Table;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvSell.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];

            ShopDAL.DeleteSellRow(id);

            FillGrid();
        }

        private void frmSelling_Load(object sender, EventArgs e)
        {
            FillSearchGrid();
            FillGrid();
        }

        private void dgvSell_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSell.SelectedRows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
            }
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                btnSelect.Enabled = true;
            }
            else
            {
                btnSelect.Enabled = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRowView Data = (DataRowView)dgvSearch.SelectedRows[0].DataBoundItem;
            int id = (int)Data.Row["ID"];

            SqlConnection Connection = new SqlConnection(ShopDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = String.Format("Select * From Shopping Where ID={0}", id);

            DataTable Table = new DataTable();
            SqlDataReader Reader = Command.ExecuteReader();
            Table.Load(Reader);

            txtWareTitle.Text = Convert.ToString(Table.Rows[0]["WareTitle"]);
            txtSeller.Text = Convert.ToString(Table.Rows[0]["Seller"]);
            txtShopPrice.Text = Convert.ToString(Table.Rows[0]["Price"]);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Count = Convert.ToInt32(txtCount.Text.Trim());
            Int64 ShopPrice = Convert.ToInt64(txtShopPrice.Text.Trim());
            Int64 SellPrice = Convert.ToInt64(txtSellPrice.Text.Trim());

            Int64 Profit = (SellPrice - ShopPrice) * Count;
            Int64 Total = SellPrice * Count;

            txtProfit.Text = Profit.ToString();
            txtTotal.Text = Total.ToString();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtTotal.Text != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sell oSell = new Sell();
            oSell.WareTitle = txtWareTitle.Text.Trim();
            oSell.ShopFrom = txtSeller.Text.Trim();
            oSell.Price = Convert.ToInt64(txtSellPrice.Text.Trim());
            oSell.Count = Convert.ToInt32(txtCount.Text.Trim());
            oSell.Profit = Convert.ToInt64(txtProfit.Text);
            oSell.SellDate = mtbDate.Text;
            oSell.Amount = Convert.ToInt64(txtTotal.Text);

            ShopDAL.NewSell(oSell);

            mtbDate.Text = string.Empty;
            txtWareTitle.Text = string.Empty;
            txtSellPrice.Text = string.Empty;
            txtSeller.Text = string.Empty;
            txtCount.Text = string.Empty;
            txtProfit.Text = string.Empty;
            txtShopPrice.Text = string.Empty;
            txtTotal.Text = string.Empty;

            mtbDate.Focus();
            FillGrid();
        }
    }
}
