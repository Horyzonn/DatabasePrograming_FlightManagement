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

namespace FlightManagement.UserControls
{
    public partial class FlightScheduleManagement : UserControl
    {
        private FlightScheduleBLL flightScheduleBLL;
        private RouteBLL routeBLL;
        public FlightScheduleManagement()
        {
            InitializeComponent();
            flightScheduleBLL = new FlightScheduleBLL();
            routeBLL = new RouteBLL();

            LoadRoutes();
            LoadFlightSchedulesList();
            
        }
        private void LoadRoutes()
        {
            DataTable routes = routeBLL.GetAllRoutes();
            cbRouteId.DataSource = routes.Copy();
            cbRouteId.DisplayMember = "RouteId";   // Hiển thị RouteId
            cbRouteId.ValueMember = "RouteId";      // Lấy RouteId
        }

        private void LoadFlightSchedulesList()
        {
            dgvFlightSchedule.DataSource = flightScheduleBLL.GetAllFlightSchedules();
        }
        private void FlightManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            int routeId = Convert.ToInt32(cbRouteId.SelectedValue);
            DateTime departure = dtpDeparture.Value;
            DateTime arrival = dtpArrival.Value;
            int t1Qty = (int)numTicket1Qty.Value;
            int t2Qty = (int)numTicket2Qty.Value;
            int t1Booked = (int)numT1Booked.Value;
            int t2Booked = (int)numT2Booked.Value;
            decimal t1Price = numT1Price.Value;
            decimal t2Price = numT2Price.Value;

            if (cbRouteId.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tuyến bay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (arrival <= departure)
            {
                MessageBox.Show("Thời gian đến phải sau thời gian đi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = flightScheduleBLL.AddFlightSchedule(routeId, departure, arrival, t1Qty, t2Qty, t1Booked, t2Booked, t1Price, t2Price);

                if (success)
                {
                    MessageBox.Show("Thêm chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlightSchedulesList();
                    
                }
                else
                {
                    MessageBox.Show("Thêm chuyến bay thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numT1Booked_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
