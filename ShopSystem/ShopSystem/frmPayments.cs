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
using Shop_System.BLL;
using Shop_System.DAL;

namespace ShopSystem
{
    public partial class frmPayments : Form
    {
        int myID = 0;
        public frmPayments()
        {
            InitializeComponent();
        }

        public void FillSearchGrid()
        {
            DataTable Table = ShopDAL.GetInstallmentForSearch();
            dgvSearch.DataSource = null;
            dgvSearch.DataSource = Table;
        }

        public void FillPaymentGrid(int id)
        {
            DataTable Table = ShopDAL.GetPayment(id);
            dgvPayments.DataSource = null;
            dgvPayments.DataSource = Table;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtbDate.Text = null;
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtRecievedMoney.Text = string.Empty;
            txtTotalRecieved.Text = string.Empty;
            txtRemainder.Text = string.Empty;
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            FillSearchGrid();
        }

        private void dgvPayments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ShopDAL.ConnectionString);
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();

            Connection.Open();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select * From Installment Where Name Like @Search";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@Search", txtName.Text + "%");

            DataAdapter.Fill(oDataSet, "TempTable");
            dgvSearch.DataSource = oDataSet;
            dgvSearch.DataMember = "TempTable";
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
            DataRowView oData= (DataRowView)dgvSearch.SelectedRows[0].DataBoundItem;
            myID = (int)oData.Row["ID"];
            Installment oInstallment = ShopDAL.GetOneRow(myID);

            txtName.Text = oInstallment.Name;
            txtFamily.Text = oInstallment.Family;
            txtRemainder.Text = oInstallment.Remainder.ToString("###,###,###,###");

            FillPaymentGrid(myID);
            DataTable Table = new DataTable();
            Table = (DataTable)dgvPayments.DataSource;

            if (Table.Rows.Count > 0)
            {
                Int64 Sum = ShopDAL.GetOnePersonPayment(myID);
                txtTotalRecieved.Text = Sum.ToString("###,###,###,###");
            }
            else
            {
                txtTotalRecieved.Text = string.Format("0");
            }

            if (txtRecievedMoney.Text != string.Empty)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mtbDate.Text = Converting.PersianDate(DateTime.Now.ToString(), true, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Payment oPayment = new Payment();
            oPayment.DueDate = mtbDate.Text;
            oPayment.Name = txtName.Text.Trim();
            oPayment.Family = txtFamily.Text.Trim();
            oPayment.PaymentAmount = Convert.ToInt64(txtRecievedMoney.Text.Trim());
            ShopDAL.NewPayment(oPayment, myID);

            Int64 Remainder = Convert.ToInt64(txtRemainder.Text.Replace(",", ""));
            Remainder -= oPayment.PaymentAmount;
            txtRemainder.Text = Remainder.ToString("###,###,###,###");
            ShopDAL.UpdateRemainder(myID, Remainder);
            txtTotalRecieved.Text = ShopDAL.GetOnePersonPayment(myID).ToString("###,###,###,###");

            FillPaymentGrid(myID);
            FillSearchGrid();
        }

        private void txtRecievedMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtRecievedMoney.Text != string.Empty && txtTotalRecieved.Text != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView DataRow = (DataRowView)dgvPayments.SelectedRows[0].DataBoundItem;
            int id = (int)DataRow.Row["ID"];

            ShopDAL.DeletePaymentRow(id);

            FillPaymentGrid(myID);
        }
    }
}
