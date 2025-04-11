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
    public partial class ResetPasswordForm : Form
    {
        private ResetPassBLL resetPassBLL;
        public ResetPasswordForm()
        {
            InitializeComponent();
            resetPassBLL = new ResetPassBLL();
        }

        private void btnResetpass_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string newpass = txtNewpass.Text;
            string confirmpass = txtConfirmpass.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(newpass) ||
                string.IsNullOrWhiteSpace(confirmpass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!resetPassBLL.IsStrongPassword(newpass))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }

            if (newpass != confirmpass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            if (!resetPassBLL.ValidateUserForReset(username, email))
            {
                MessageBox.Show("Tên đăng nhập hoặc email không đúng!");
                return;
            }       
            bool success = resetPassBLL.ResetPassword(username, newpass);
            MessageBox.Show(success ? "Đặt lại mật khẩu thành công!" : "Đặt lại mật khẩu không thành công. Vui lòng thử lại sau.");
                
        }
    }
}
