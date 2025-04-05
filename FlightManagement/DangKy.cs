using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement
{
    public partial class DangKy : Form
    {
        private DataProvider provider;
        public DangKy()
        {
            InitializeComponent();
            provider = new DataProvider();
        }

        public bool RegisterUser(UserDto user)
        {
            string query = @"INSERT INTO KhachHang (Username, Password, FirstName, LastName, DateOfBirth, Email, PhoneNumber, UserRole)
                         VALUES (@Username, @Password, @FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @UserRole)";


            SqlCommand cmd = new SqlCommand(query, provider.getCN());
            cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password); // có thể mã hóa ở đây
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName ?? "");
                cmd.Parameters.AddWithValue("@LastName", user.LastName ?? "");
                cmd.Parameters.AddWithValue("@DateOfBirth", (object)user.DateOfBirth ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", user.Email ?? "");
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? "");
                cmd.Parameters.AddWithValue("@UserRole", user.UserRole ?? "");
            provider.Connect();
            int row = cmd.ExecuteNonQuery();
            provider.Disconnect();
            return (row > 0);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string email = txtEmail.Text.Trim();
            string phone = txtSDT.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserDto u = new UserDto
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dob,
                Email = email,
                PhoneNumber = phone,
                UserRole = role
            };

            if (RegisterUser(u)==true)
            {
                MessageBox.Show("Bạn đã đăng ký thông tin thành công!!!", "Thông báo", MessageBoxButtons.OK);
                FLogin f = new FLogin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Có thể username đã tồn tại hoặc lỗi hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FLogin f = new FLogin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
