using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_System.DAL;
using Shop_System.BLL;

namespace ShopSystem
{
    public partial class frmInstallment : Form
    {
        public frmInstallment()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = ShopDAL.GetInstallment();
            dgvInstallment.DataSource = null;
            dgvInstallment.DataSource = Table;
        }

        private void frmInstallment_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Int64 Total= Convert.ToInt64(txtFactorAmount.Text.Trim());
            Int64 PrePayment= Convert.ToInt64(txtPrePayment.Text.Trim());

            txtRemainder.Text = Convert.ToString(Total - PrePayment);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtbDate.Text = string.Empty;
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtFactorAmount.Text = string.Empty;
            txtChequeOwner.Text = string.Empty;
            txtChequeNo.Text = string.Empty;
            txtBank.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPrePayment.Text = string.Empty;
            txtRecieveDate.Text = string.Empty;
            txtRemainder.Text = string.Empty;
            txtTel.Text = string.Empty;

            mtbDate.Focus();
        }

        private void txtRemainder_TextChanged(object sender, EventArgs e)
        {
            if (txtRemainder.Text != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtFactorAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtFactorAmount.Text != string.Empty)
            {
                txtPrePayment.Enabled = true;
            }
            else
            {
                txtPrePayment.Enabled = false;
            }
        }

        private void dgvInstallment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstallment.SelectedRows.Count > 0) 
            {
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView Data = (DataRowView)dgvInstallment.SelectedRows[0].DataBoundItem;
            int id = (int)Data.Row["ID"];

            ShopDAL.DeleteInstallmentRow(id);
            FillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtbDate.Text == string.Empty || txtName.Text == string.Empty || txtFamily.Text == string.Empty ||
            txtFactorAmount.Text == string.Empty || txtChequeOwner.Text == string.Empty ||txtBank.Text == string.Empty ||
            txtChequeNo.Text == string.Empty || txtAddress.Text == string.Empty || txtPrePayment.Text == string.Empty ||
            txtRecieveDate.Text == string.Empty || txtRemainder.Text == string.Empty || txtTel.Text == string.Empty)
            {
                MessageBox.Show("لطفا تمامی فیلدها را پر کنید!!!", "خطا");
            }
            else
            {
                Installment oInstallment = new Installment();
                oInstallment.ShopDate = Convert.ToString(mtbDate.Text);
                oInstallment.Name = Convert.ToString(txtName.Text.Trim());
                oInstallment.Family = Convert.ToString(txtFamily.Text.Trim());
                oInstallment.Address = Convert.ToString(txtAddress.Text.Trim());
                oInstallment.Mobile = Convert.ToString(txtTel.Text.Trim());
                oInstallment.FactorAmount = Convert.ToInt64(txtFactorAmount.Text.Trim());
                oInstallment.ChequeNo = Convert.ToString(txtChequeNo.Text.Trim());
                oInstallment.ChequeOwner = Convert.ToString(txtChequeOwner.Text.Trim());
                oInstallment.RecieveDate = Convert.ToString(txtRecieveDate.Text.Trim());
                oInstallment.PrePayment = Convert.ToInt64(txtPrePayment.Text.Trim());
                oInstallment.Remainder = Convert.ToInt64(txtRemainder.Text.Trim());
                oInstallment.BankName = Convert.ToString(txtBank.Text.Trim());

                ShopDAL.NewInstallment(oInstallment);

                mtbDate.Text = string.Empty;
                txtName.Text = string.Empty;
                txtFamily.Text = string.Empty;
                txtFactorAmount.Text = string.Empty;
                txtChequeOwner.Text = string.Empty;
                txtChequeNo.Text = string.Empty;
                txtBank.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtPrePayment.Text = string.Empty;
                txtRecieveDate.Text = string.Empty;
                txtRemainder.Text = string.Empty;
                txtTel.Text = string.Empty;

                mtbDate.Focus();
                FillGrid();
            }
        }

        private void txtPrePayment_TextChanged(object sender, EventArgs e)
        {
            if (txtPrePayment.Text != string.Empty) 
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }
    }
}
