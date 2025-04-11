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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace FlightManagement
{
    public partial class AirPortForm : Form
    {
        private AddAirportBLL addAirportBLL;
        private DeleteAirportBLL deleteAirportBLL;
        public AirPortForm()
        {
            InitializeComponent();
            addAirportBLL = new AddAirportBLL();
            deleteAirportBLL = new DeleteAirportBLL();

            LoadAirportList();
        }

        private void LoadAirportList()
        {
            DataTable dt = addAirportBLL.GetAllAirports();
            dgvAirport.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = addAirportBLL.AddNewAirport(code, name, location);
                if (success)
                {
                    MessageBox.Show("Thêm sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadAirportList(); 
                }
                else
                {
                    MessageBox.Show("Thêm sân bay thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtCode.Clear();
            txtName.Clear();
            txtLocation.Clear();
            txtCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAirport.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn ô trong dòng cần xóa.");
                return;
            }

            int rowIndex = dgvAirport.CurrentCell.RowIndex;
            string code = dgvAirport.Rows[rowIndex].Cells[0].Value.ToString();

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sân bay này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool success = deleteAirportBLL.DeleteAirport(code);
                if (success)
                {
                    MessageBox.Show("Đã xóa sân bay thành công.");
                    LoadAirportList(); // cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdminForm f = new AdminForm();
                this.Hide();
                f.Show();
            }
        }
    }
}
    

