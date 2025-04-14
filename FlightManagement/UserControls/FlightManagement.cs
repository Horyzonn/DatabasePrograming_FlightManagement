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
    public partial class FlightManagement : UserControl
    {
        private FlightScheduleBLL flightScheduleBLL;
        private RouteBLL routeBLL;
        public FlightManagement()
        {
            InitializeComponent();
            flightScheduleBLL = new FlightScheduleBLL();
            routeBLL = new RouteBLL();
        }

        private void LoadFlightSchedules()
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
        }

        private void numT1Booked_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
