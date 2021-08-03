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
    public partial class frmEditUser : Form
    {
        User MyUser = new User();
        public frmEditUser(User _user)
        {
            InitializeComponent();
            MyUser = _user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            txtName.Text = MyUser.Name;
            txtFamily.Text = MyUser.Family;
            txtUsername.Text = MyUser.Username;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.ToString() == MyUser.Password) 
            {
                User ouser = new User();
                ouser.ID = MyUser.ID;
                ouser.Name = txtName.Text;
                ouser.Family = txtFamily.Text;
                ouser.Username = txtUsername.Text;

                ShopDAL.UpdateUser(ouser);
                MessageBox.Show("عملیات ویرایش با موفقیت انجام شد", "پیغام");
                this.Close();
            }
            else
            {
                MessageBox.Show("رمز عبور اشتباه است!!!", "خطا");
                txtPassword.Focus();
            }
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == MyUser.Password) 
            {
                MyUser.Password = txtNewPass.Text;
                ShopDAL.UpdateUserPassword(MyUser);

                MessageBox.Show("عملیات ویرایش رمزعبور با موفقیت انجام شد", "پیغام");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtFamily.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPass.Text != string.Empty && txtNewPass.Text != string.Empty) 
            {
                btnEditPass.Enabled = true;
            }
            else
            {
                btnEditPass.Enabled = false;
            }
        }
    }
}
