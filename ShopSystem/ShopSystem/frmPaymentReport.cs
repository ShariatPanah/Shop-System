using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Converting_Date;
using Shop_System.DAL;

namespace ShopSystem
{
    public partial class frmPaymentReport : Form
    {
        public frmPaymentReport()
        {
            InitializeComponent();
        }

        private void frmPaymentReport_Load(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mtbStartDate.Text = mtbEndDate.Text = Converting.PersianDate(DateTime.Now.ToString(), false, true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ShopDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText=string.Format(
                "Select * From Payment Where DueDate >='{0} 00:00' And DueDate <= '{1} 23:59'",
                mtbStartDate.Text, mtbEndDate.Text);
            DataTable Table = new DataTable();
            SqlDataReader Reader= Command.ExecuteReader();
            Table.Load(Reader);
            dgvPaymentReport.DataSource = Table;

            Int64 Sum = 0;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Sum += Convert.ToInt64(Table.Rows[i]["PaymentAmount"]);
            }
            txtTotalPayment.Text = Sum.ToString("###,###,###,###");
        }
    }
}
