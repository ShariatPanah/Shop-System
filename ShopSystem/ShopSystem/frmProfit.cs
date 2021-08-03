using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converting_Date;
using Shop_System.BLL;
using Shop_System.DAL;

namespace ShopSystem
{
    public partial class frmProfit : Form
    {
        string StartDate = string.Empty;
        string EndDate = string.Empty;
        public frmProfit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StartDate = mtbStartDate.Text + " 01:01";
            EndDate = mtbEndDate.Text+" 23:59";
            DataTable Table = new DataTable();
            Table = ShopDAL.DueSell(StartDate, EndDate);
            dgvProfit.DataSource = Table;

            Int64 Profit = 0, TotalSell = 0;
            for (int Counter = 0; Counter < Table.Rows.Count; Counter++)
            {
                Profit += Convert.ToInt64(Table.Rows[Counter]["Profit"]);
                TotalSell += Convert.ToInt64(Table.Rows[Counter]["Amount"]);
            }
            if (Profit < 0)
            {
                txtProfit.ForeColor = Color.Red;
            }
            else
            {
                txtProfit.ForeColor = Color.Blue;
            }
            txtProfit.Text = Profit.ToString("###,###,###,###");
            txtTotalSell.Text = TotalSell.ToString("###,###,###,###");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mtbStartDate.Text = mtbEndDate.Text = Converting.PersianDate(DateTime.Now.ToString(), false, true);
        }

        private void frmProfit_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
