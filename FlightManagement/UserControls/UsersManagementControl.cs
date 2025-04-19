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

namespace FlightManagement.UserControls
{
    public partial class UsersManagementControl : UserControl
    {
        private UsersBLL usersBLL = new UsersBLL();
        public UsersManagementControl()
        {
            InitializeComponent();
            LoadRoles();
            comboBoxRoles.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
        }
        private void LoadRoles()
        {
            comboBoxRoles.Items.Clear();
            comboBoxRoles.Items.Add("admin");
            comboBoxRoles.Items.Add("user");
            comboBoxRoles.Items.Add("staff");


            comboBoxRoles.SelectedIndex = -1;

        }


        private void LoadUsersByRole(string role)
        {
            DataTable users = usersBLL.GetUsersByRole(role);
            dgvUsers.DataSource = users;
            
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRoles.SelectedItem.ToString();
            LoadUsersByRole(selectedRole);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (comboBoxRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return;
            }
            // Tìm dòng hợp lệ (không phải dòng "thêm mới")
            DataGridViewRow row = null;
            foreach (DataGridViewRow r in dgvUsers.Rows)
            {
                if (!r.IsNewRow && r.Cells["Username"].Value != null)
                {
                    row = r;
                }
            }
            if (row == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin người dùng hợp lệ trong bảng.");
                return;
            }


            try
            {
                

                Users user = new Users
                {
                    Username = row.Cells["Username"].Value?.ToString(),
                    Password = row.Cells["Password"].Value?.ToString(),
                    Email = row.Cells["Email"].Value?.ToString(),
                    PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString(),
                    DateOfBirth = (row.Cells["DateOfBirth"].Value != DBNull.Value) ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value) : (DateTime?)null,


                    UserRole = row.Cells["UserRole"].Value?.ToString(),

                    
                };
                // Kiểm tra đầu vào đơn giản
                if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                {
                    MessageBox.Show("Vui lòng nhập Username và Password.");
                    return;
                }
                if (usersBLL.AddUser(user))
                {
                    MessageBox.Show("Thêm người dùng thành công!");
                    LoadUsersByRole(comboBoxRoles.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm người dùng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message);
            }
        }
        

    

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                DataGridViewRow row = dgvUsers.CurrentRow;

                Users user = new Users
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Username = row.Cells["Username"].Value?.ToString(),
                    Password = row.Cells["Password"].Value?.ToString(),
                    Email = row.Cells["Email"].Value?.ToString(),
                    PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString(),
                    DateOfBirth = row.Cells["DateOfBirth"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row.Cells["DateOfBirth"].Value),
                    
                    UserRole = comboBoxRoles.SelectedItem?.ToString()
                };
                if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Username và Password.");
                    return;
                }

                // Cập nhật người dùng vào CSDL
                if (usersBLL.UpdateUser(user))
                {
                    MessageBox.Show("Cập nhật người dùng thành công!");
                    LoadUsersByRole(comboBoxRoles.SelectedItem.ToString()); // Tải lại danh sách
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật người dùng.");
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["Id"].Value);

                // Xác nhận việc xóa người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (usersBLL.DeleteUser(id))
                    {
                        MessageBox.Show("Xóa người dùng thành công!");
                        LoadUsersByRole(comboBoxRoles.SelectedItem.ToString()); // Tải lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa người dùng.");
                    }
                }
            }
        }
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.CurrentRow != null)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                // Chọn thông tin từ DataGridView để thao tác thêm/sửa/xóa
       
            }
        }
    }
    
}
