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
using DTO;


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

        private Users UserLogin(Users user)
        {
            try
            {
                return loginBLL.Login(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
            };


            //Xử lí đầu vào
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
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

            Users userFromDb = UserLogin(user);
            if (userFromDb != null)
            {
                CurrentUser.Id = userFromDb.Id;
                CurrentUser.Username = userFromDb.Username;
                if (cbRole.Text == "Admin")
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
                    GuestForm guestForm = new GuestForm();
                    guestForm.Show();
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
