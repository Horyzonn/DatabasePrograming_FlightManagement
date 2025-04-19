﻿using BLL;
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
            dgvFlightSchedule.CellClick += dgvFlightSchedule_CellClick;
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

            if (flight.Ticket1Quantity <= 0 || flight.Ticket2Quantity <= 0 || flight.Ticket1Price <= 0 || flight.Ticket2Price <= 0)
            {
                MessageBox.Show("Số lượng và giá vé phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (flight.Ticket1BookedQuantity < 0 || flight.Ticket1BookedQuantity > flight.Ticket1Quantity ||
            flight.Ticket2BookedQuantity < 0 || flight.Ticket2BookedQuantity > flight.Ticket2Quantity)
            {
                MessageBox.Show("Số vé đã đặt không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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


        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlightSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedId = Convert.ToInt32(dgvFlightSchedule.SelectedRows[0].Cells["Id"].Value);
            
            FlightSchedule flight = new FlightSchedule()
            {
                Id = selectedId,
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
            if (flight.Ticket1Quantity <= 0 || flight.Ticket2Quantity <= 0 || flight.Ticket1Price <= 0 || flight.Ticket2Price <= 0)
            {
                MessageBox.Show("Số lượng và giá vé phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (flight.Ticket1BookedQuantity < 0 || flight.Ticket1BookedQuantity > flight.Ticket1Quantity ||
                flight.Ticket2BookedQuantity < 0 || flight.Ticket2BookedQuantity > flight.Ticket2Quantity)
            {
                MessageBox.Show("Số vé đã đặt không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                bool success = flightScheduleBLL.UpdateFlightSchedule(flight);

                if (success)
                {
                    MessageBox.Show("Cập nhật chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlightSchedulesList();
                }
                else
                {
                    MessageBox.Show("Cập nhật chuyến bay thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvFlightSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFlightSchedule.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvFlightSchedule.SelectedRows[0];

                // Gán giá trị vào các control
                cbRouteId.SelectedValue = row.Cells["RouteId"].Value;
                dtpDeparture.Value = Convert.ToDateTime(row.Cells["DepartureTime"].Value);
                dtpArrival.Value = Convert.ToDateTime(row.Cells["ArrivalTime"].Value);

                numTicket1Qty.Value = Convert.ToInt32(row.Cells["Ticket1Quantity"].Value);
                numTicket2Qty.Value = Convert.ToInt32(row.Cells["Ticket2Quantity"].Value);
                numT1Booked.Value = Convert.ToInt32(row.Cells["Ticket1BookedQuantity"].Value);
                numT2Booked.Value = Convert.ToInt32(row.Cells["Ticket2BookedQuantity"].Value);

                numT1Price.Value = Convert.ToDecimal(row.Cells["Ticket1Price"].Value);
                numT2Price.Value = Convert.ToDecimal(row.Cells["Ticket2Price"].Value);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlightSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa chuyến bay này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) 
                return;
            int selectedId = Convert.ToInt32(dgvFlightSchedule.SelectedRows[0].Cells["Id"].Value);

            try
            {
                bool success = flightScheduleBLL.DeleteFlightSchedule(selectedId);

                if (success)
                {
                    MessageBox.Show("Xóa chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFlightSchedulesList();
                }
                else
                {
                    MessageBox.Show("Xóa chuyến bay thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
