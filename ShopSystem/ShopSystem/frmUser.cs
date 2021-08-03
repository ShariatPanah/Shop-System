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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = ShopDAL.GetAllUsers();
            dgvUsers.DataSource=null;
            dgvUsers.DataSource=Table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.Name = txtName.Text.Trim();
            oUser.Family = txtFamily.Text.Trim();
            oUser.Username = txtUsername.Text.Trim();
            oUser.Password = txtPassword.Text.Trim();

            ShopDAL.NewUser(oUser);

            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtName.Focus();

            FillGrid();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView DataRow = (DataRowView)dgvUsers.SelectedRows[0].DataBoundItem;
            int id = (int)DataRow.Row["ID"];

            frmEditUser Edit = new frmEditUser(ShopDAL.GetOneUser(id));
            Edit.ShowDialog();

            FillGrid();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView DataRow = (DataRowView)dgvUsers.SelectedRows[0].DataBoundItem;
            int id = (int)DataRow.Row["ID"];

            ShopDAL.DeleteUser(id);
            FillGrid();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtFamily.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }
}
