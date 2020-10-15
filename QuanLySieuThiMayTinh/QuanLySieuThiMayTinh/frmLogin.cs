using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiMayTinh.DTO;
using QuanLySieuThiMayTinh.DAL;
using QuanLySieuThiMayTinh.BLL;

namespace QuanLySieuThiMayTinh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // xử lý khi đăng nhập
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Text = "Username";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);

            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Text = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtUsername_Enter(Object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                Login login = new Login();

                string userName = txtUsername.Text;
                login.username = int.Parse(txtUsername.Text);
                login.password = int.Parse(txtPassword.Text);

                UserInfo.Id = int.Parse(userName);

                LoginBLL logbll = new LoginBLL();

                bool kq = logbll.KiemTraDangNhap(login);

                if (kq == true)
                {
                    MessageBox.Show("Đăng nhập thành công!!!\r\n" + login.permission.ToString());
                    if (login.permission == "QLBH")
                    {
                        this.Hide();
                        frmMain main = new frmMain(login.fullname, login.namepermision);
                        UserInfo.permission = login.permission;
                        UserInfo.FullName = login.fullname;
                        main.ShowDialog();
                        this.Close();
                    }
                    else if (login.permission == "NVBH")
                    {
                        this.Hide();
                        frmMain main = new frmMain(login.fullname, login.namepermision);
                        UserInfo.permission = login.permission;
                        UserInfo.FullName = login.fullname;
                        main.ShowDialog();
                        this.Close();
                    }
                    else if (login.permission == "NVNEW")
                    {
                        MessageBox.Show("Bạn không có quyền đăng nhập vào hệ thống!");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Username hoặc Password không đúng");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
