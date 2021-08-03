using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            frmShopping Shopping = new frmShopping();
            Shopping.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            frmSelling Selling = new frmSelling();
            Selling.ShowDialog();
        }

        private void btnTelBook_Click(object sender, EventArgs e)
        {
            frmTelePhone Tel = new frmTelePhone();
            Tel.ShowDialog();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            frmProfit Profit = new frmProfit();
            Profit.ShowDialog();
        }

        private void btnNewInstallment_Click(object sender, EventArgs e)
        {
            frmInstallment Instal = new frmInstallment();
            Instal.ShowDialog();
        }

        private void پرداختاقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments Payment = new frmPayments();
            Payment.ShowDialog();
        }

        private void btnPaymentReport_Click(object sender, EventArgs e)
        {
            frmPaymentReport Report = new frmPaymentReport();
            Report.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.ShowDialog();
        }

    }
}
