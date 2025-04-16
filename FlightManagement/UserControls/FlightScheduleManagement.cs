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
            cbRouteId.DisplayMember = "ID";   // Hiển thị RouteId
            cbRouteId.ValueMember = "ID";      // Lấy RouteId
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
            FlightSchedule flight = new FlightSchedule()
            {               
                RouteId = Convert.ToInt32(cbRouteId.SelectedValue),
                DepartureTime = dtpDeparture.Value,
                ArrivalTime = dtpArrival.Value,
                Ticket1Quantity = (int)numTicket1Qty.Value,
                Ticket2Quantity = (int)numTicket2Qty.Value,
                Ticket1BookedQuantity = (int)numT1Booked.Value,
                Ticket2BookedQuantity = (int)numT2Booked.Value,
                Ticket1Price = numT1Price.Value,
                Ticket2Price = numT2Price.Value
            };
            

            if (cbRouteId.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tuyến bay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (flight.ArrivalTime <= flight.DepartureTime)
            {
                MessageBox.Show("Thời gian đến phải sau thời gian đi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = flightScheduleBLL.AddFlightSchedule(flight);

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
