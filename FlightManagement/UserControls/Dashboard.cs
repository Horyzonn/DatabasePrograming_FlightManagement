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
using System.Windows.Forms.DataVisualization.Charting;

namespace FlightManagement.UserControls
{
    public partial class Dashboard : UserControl
    {

        private FlightScheduleBLL flightScheduleBLL;
        private RouteBLL routeBLL;
        private TicketBLL ticketBLL;
        public Dashboard()
        {
            InitializeComponent();
            flightScheduleBLL = new FlightScheduleBLL();
            routeBLL = new RouteBLL();
            ticketBLL = new TicketBLL();
        }

        public void LoadFlightScheduleChart(Dictionary<string, int> flightCounts)
        {
            // Xóa dữ liệu cũ
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Tạo ChartArea
            chart1.ChartAreas.Add("MainArea");

            // Tạo Series
            Series series = new Series("Số chuyến bay theo tuyến");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu từ dictionary
            foreach (var item in flightCounts)
            {
                string route = item.Key;
                int flightCount = item.Value;

                series.Points.AddXY("Tuyến " + route, flightCount);
            }

            chart1.Series.Add(series);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblFlightCount.Text = flightScheduleBLL.GetFlightScheduleCount().ToString();
            lblRouteCount.Text = routeBLL.GetRouteCount().ToString();
            lblIncome.Text = ticketBLL.GetIncome().ToString("C0");
            Dictionary<string, int> flightCounts = flightScheduleBLL.GetFlightScheduleCountByRoute();
            LoadFlightScheduleChart(flightCounts);

        }
    }
}
