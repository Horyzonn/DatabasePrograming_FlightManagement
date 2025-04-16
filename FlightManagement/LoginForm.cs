using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlightManagement
{
    public partial class LoginForm : Form
    {
        private LoginBLL loginBLL;
        public LoginForm()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private bool UserLogin(string username, string password)
        {
            try
            {
                return loginBLL.Login(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //Xử lí đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                              "Cảnh báo",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserLogin(username, password))
            {
                if(cbRole.Text == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if (cbRole.Text == "Nhân viên")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbRole.Text == "Khách hàng")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Quyền truy cập không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtUsername.SelectAll();
                txtUsername.Focus();
            }

        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPassword = new ResetPasswordForm();
            this.Hide();
            resetPassword.Show();
        }
    }
}
