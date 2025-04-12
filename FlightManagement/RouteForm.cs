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
    public partial class RouteForm : Form
    {
        private RouteBLL routeBLL;
        private AirportBLL airportBLL;


        public RouteForm()
        {
            InitializeComponent();
            routeBLL = new RouteBLL();
            airportBLL = new AirportBLL();

            LoadAirports();
            LoadRouteList();
        }

        private void LoadAirports()
        {
            DataTable airports = airportBLL.GetAllAirports();
            cbDeparture.DataSource = airports.Copy();
            cbDeparture.DisplayMember = "Name";
            cbDeparture.ValueMember = "Code";

            cbArrival.DataSource = airports.Copy();
            cbArrival.DisplayMember = "Name";
            cbArrival.ValueMember = "Code";
        }

        private void LoadRouteList()
        {
            DataTable dt = routeBLL.GetAllRoutes();
            dgvRouteList.DataSource = dt;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string departure = cbDeparture.SelectedValue.ToString();
            string arrival = cbArrival.SelectedValue.ToString();
            DateTime? createdDate = dtDate.Value;

            if (departure == arrival)
            {
                MessageBox.Show("Sân bay đi và đến không được trùng nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Routes route = new Routes(0, departure, arrival, createdDate);
            bool success = routeBLL.AddNewRoute(route);

            if (success)
            {
                MessageBox.Show("Thêm chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRouteList();
            }
            else
            {
                MessageBox.Show("Thêm chuyến bay thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRouteList.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvRouteList.CurrentRow.Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tuyến bay này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = routeBLL.DeleteRoute(id);
                    if (success)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        LoadRouteList();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRouteList.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvRouteList.CurrentRow.Cells["Id"].Value);
                string departure = cbDeparture.SelectedValue.ToString();
                string arrival = cbArrival.SelectedValue.ToString();
                DateTime? date = dtDate.Value;

                Routes route = new Routes(id, departure, arrival, date);
                bool success = routeBLL.UpdateRoute(route);
                if (success)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    LoadRouteList();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi");
                }
            }
        }
    }
}
