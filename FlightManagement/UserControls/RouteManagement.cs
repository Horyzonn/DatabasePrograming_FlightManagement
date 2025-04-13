using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL; 

namespace FlightManagement.User_Control
{
    public partial class RouteManagement : UserControl
    {
        private AirportBLL airportBLL;
        private RouteBLL routeBLL;
        public RouteManagement()
        {
            InitializeComponent();
            airportBLL = new AirportBLL();
            routeBLL = new RouteBLL();

            LoadAirports();

            LoadAirportList();
            LoadRouteList();

            dgvAirports.CellClick += DgvAirports_CellClick;
            dgvRoutes.CellClick += DgvRoutes_CellClick;
            dgvAirports.UserDeletingRow += DgvAirports_UserDeletingRow;
            dgvRoutes.UserDeletingRow += DgvRoutes_UserDeletingRow;

            CleanInput();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadAirportList()
        {
            dgvAirports.DataSource = airportBLL.GetAllAirports();
        }

        private void LoadRouteList()
        {
            dgvRoutes.DataSource = routeBLL.GetAllRoutes();
        } 

        private bool AddNewAirport(string code, string name, string location)
        {
            try
            {
                // Call the BLL method to add a new airport
                return airportBLL.AddNewAirport(code, name, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new airport: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            string airportCode = txtAirportCode.Text.Trim();
            string airportName = txtAirportName.Text.Trim();
            string airportLocation = txtAirportLoc.Text.Trim();
            if (string.IsNullOrEmpty(airportCode) || string.IsNullOrEmpty(airportName) || string.IsNullOrEmpty(airportLocation))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (airportBLL.IsAirportCodeExists(airportCode))
                {
                    MessageBox.Show("Mã sân bay đã tồn tại. Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = airportBLL.AddNewAirport(airportCode, airportName, airportLocation);
                if (success)
                {
                    MessageBox.Show("Thêm sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanInput();
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


        private void LoadAirports()
        {
            DataTable airports = airportBLL.GetAllAirports();
            cbDepAirport.DataSource = airports.Copy();
            cbDepAirport.DisplayMember = "Name";
            cbDepAirport.ValueMember = "Code";

            cbArrAirport.DataSource = airports.Copy();
            cbArrAirport.DisplayMember = "Name";
            cbArrAirport.ValueMember = "Code";
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            string departure = cbDepAirport.SelectedValue.ToString();
            string arrival = cbArrAirport.SelectedValue.ToString();

            if (departure == arrival)
            {
                MessageBox.Show("Sân bay đi và đến không được trùng nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool success = routeBLL.AddNewRoute(departure, arrival);

            if (success)
            {
                MessageBox.Show("Thêm chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               LoadRouteList();
               CleanInput();
            }
            else
            {
                MessageBox.Show("Thêm chuyến bay thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvAirports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAirports.Rows[e.RowIndex];

            }
        }

        private void DgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoutes.Rows[e.RowIndex];

            }
        }

        private void DgvAirports_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var airportCode = e.Row.Cells["Code"].Value.ToString();
            var confirm = MessageBox.Show("Xóa sân bay này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool success = airportBLL.DeleteAirport(airportCode);
                if (!success)
                {
                    MessageBox.Show("Xóa sân bay thất bại.");
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DgvRoutes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string departure = e.Row.Cells["DepartureAirport"].Value.ToString();
            string arrival = e.Row.Cells["ArrivalAirport"].Value.ToString();

            var confirm = MessageBox.Show($"Xóa tuyến bay từ {departure} đến {arrival}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool success = routeBLL.DeleteRoute(departure, arrival);
                if (!success)
                {
                    MessageBox.Show("Xóa tuyến bay thất bại.");
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void CleanInput()
        {
            
            txtAirportCode.Clear();
            txtAirportName.Clear();
            txtAirportLoc.Clear();
   
            if (cbDepAirport.Items.Count > 0)
                cbDepAirport.SelectedIndex = 0;
            if (cbArrAirport.Items.Count > 0)
                cbArrAirport.SelectedIndex = 0;
           
        }
    }
}
