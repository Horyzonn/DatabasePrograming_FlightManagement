using BLL;
using DTO;
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
    public partial class RegisterForm : Form
    {
        private RegisterBLL registerBLL;
        public RegisterForm()
        {
            InitializeComponent();
            registerBLL = new RegisterBLL();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users newUser = new Users()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                DateOfBirth = dtpBirth.Value, 
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                UserRole = "", 
                FirstName = txtFirstname.Text.Trim(),
                LastName = txtLastname.Text.Trim()
            };

            if (string.IsNullOrWhiteSpace(newUser.Username) ||
                string.IsNullOrWhiteSpace(newUser.Password) ||
                string.IsNullOrWhiteSpace(newUser.Email) ||
                string.IsNullOrWhiteSpace(newUser.PhoneNumber) ||
                string.IsNullOrWhiteSpace(newUser.FirstName) ||
                string.IsNullOrWhiteSpace(newUser.LastName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (!registerBLL.IsStrongPassword(newUser.Password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }
            try
            {
                bool success = registerBLL.Register(newUser);
                if (success)
                    MessageBox.Show("Đăng ký thành công!");
                else
                    MessageBox.Show("Đăng ký thất bại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
