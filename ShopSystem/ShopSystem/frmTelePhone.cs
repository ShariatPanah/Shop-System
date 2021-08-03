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
    public partial class frmTelePhone : Form
    {
        public frmTelePhone()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = ShopDAL.GetPhoneBook();
            dgvPhone.DataSource = null;
            dgvPhone.DataSource = Table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtHome.Text = string.Empty;
            txtAddress.Text = string.Empty;

            txtName.Focus();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView Data = (DataRowView)dgvPhone.SelectedRows[0].DataBoundItem;
            int id = (int)Data.Row["ID"];
            ShopDAL.DeletePhoneRow(id);

            FillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHome.Text == "")
            {
                txtHome.Text = "ندارد";
            }
            PhoneBook oPhoneBook = new PhoneBook();
            oPhoneBook.Name = txtName.Text.Trim();
            oPhoneBook.Family = txtFamily.Text.Trim();
            oPhoneBook.Mobile = txtMobile.Text.Trim();
            oPhoneBook.Home = txtHome.Text.Trim();
            oPhoneBook.Address = txtAddress.Text.Trim();

            ShopDAL.NewPhonePerson(oPhoneBook);

            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtHome.Text = string.Empty;
            txtAddress.Text = string.Empty;

            txtName.Focus();
            FillGrid();
        }

        private void frmTelePhone_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvPhone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhone.SelectedRows.Count > 0)
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
