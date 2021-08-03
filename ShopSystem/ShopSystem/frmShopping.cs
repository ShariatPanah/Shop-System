using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_System.BLL;
using Shop_System.DAL;

namespace ShopSystem
{
    public partial class frmShopping : Form
    {
        public frmShopping()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = ShopDAL.GetShopping();
            dgvShopping.DataSource = null;
            dgvShopping.DataSource = Table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFactorNo.Text = string.Empty;
            txtSeller.Text = string.Empty;
            mtbDate.Text = string.Empty;
            txtWareTitle.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtCount.Text = string.Empty;

            txtFactorNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shopping oShopping = new Shopping();
            oShopping.FactorNo = txtFactorNo.Text.Trim();
            oShopping.Seller = txtSeller.Text.Trim();
            oShopping.ShopDate = mtbDate.Text;
            oShopping.WareTitle = txtWareTitle.Text.Trim();
            oShopping.Price = Convert.ToInt32(txtPrice.Text.Trim());
            oShopping.Count = Convert.ToInt32(txtCount.Text.Trim());

            ShopDAL.NewShopping(oShopping);

            txtFactorNo.Text = string.Empty;
            txtSeller.Text = string.Empty;
            mtbDate.Text = string.Empty;
            txtWareTitle.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtCount.Text = string.Empty;
            txtFactorNo.Focus();

            FillGrid();
        }

        private void frmShopping_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView DataRow = (DataRowView)dgvShopping.SelectedRows[0].DataBoundItem;
            int id = (int)DataRow.Row["ID"];

            ShopDAL.DeleteShoppingRow(id);
            FillGrid();
        }

        private void dgvShopping_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShopping.SelectedRows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
            }
        }
    }
}
