using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace FlightManagement.UserControls
{
    public partial class BookTicket : UserControl
    {

        private TicketBLL ticketBLL;
        private AirportBLL airportBLL;
        private FlightScheduleBLL flightScheduleBLL;
        private PassengersBLL passengersBLL;
        public BookTicket()
        {
            InitializeComponent();
            ticketBLL = new TicketBLL();
            airportBLL = new AirportBLL();
            flightScheduleBLL = new FlightScheduleBLL();
            passengersBLL = new PassengersBLL();

            LoadAirports();
        }

        private void LoadAirports()
        {
            DataTable airports = airportBLL.GetAllAirports();
            if (airports != null && airports.Rows.Count > 0)
            {
                cbDep.DataSource = airports.Copy();
                cbDep.DisplayMember = "Name";
                cbDep.ValueMember = "Code";
                cbArr.DataSource = airports.Copy();
                cbArr.DisplayMember = "Name";
                cbArr.ValueMember = "Code";
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string dep = cbDep.SelectedValue.ToString();
            string arr = cbArr.SelectedValue.ToString();
            DateTime date = dtDate.Value.Date;

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            DataTable flightSchedules = flightScheduleBLL.GetFlightStandard(dep, arr, date);
            DataTable flightSchedulesCustomized = new DataTable();

            // Tạo các cột mới cho bảng tuỳ chỉnh
            flightSchedulesCustomized.Columns.Add("Mã chuyến bay", typeof(string));
            flightSchedulesCustomized.Columns.Add("Giờ đi", typeof(string));
            flightSchedulesCustomized.Columns.Add("Giờ đến", typeof(string));
            flightSchedulesCustomized.Columns.Add("Giá vé loại 1", typeof(string));
            flightSchedulesCustomized.Columns.Add("Loại 1 còn", typeof(int));
            flightSchedulesCustomized.Columns.Add("Giá vé loại 2", typeof(string));
            flightSchedulesCustomized.Columns.Add("Loại 2 còn", typeof(int));

            // Lặp qua các hàng trong bảng gốc và thêm dữ liệu vào bảng tuỳ chỉnh
            foreach (DataRow row in flightSchedules.Rows)
            {
                DataRow newRow = flightSchedulesCustomized.NewRow();

                newRow["Mã chuyến bay"] = row["ID"];
                // Lấy phần giờ từ DateTime
                DateTime departure = Convert.ToDateTime(row["DepartureTime"]);
                DateTime arrival = Convert.ToDateTime(row["ArrivalTime"]);
                newRow["Giờ đi"] = departure.ToString("HH:mm");
                newRow["Giờ đến"] = arrival.ToString("HH:mm");

                // Định dạng giá vé thành chuỗi có phân cách nghìn
                decimal ticket1Price = Convert.ToDecimal(row["Ticket1Price"]);
                newRow["Giá vé loại 1"] = ticket1Price.ToString("N0", new System.Globalization.CultureInfo("vi-VN"));

                // Tính "Còn lại"
                int quantity1 = Convert.ToInt32(row["Ticket1Quantity"]);
                int booked1 = Convert.ToInt32(row["Ticket1BookedQuantity"]);
                newRow["Loại 1 còn"] = quantity1 - booked1;

                // Định dạng giá vé thành chuỗi có phân cách nghìn
                decimal ticket2Price = Convert.ToDecimal(row["Ticket2Price"]);
                newRow["Giá vé loại 2"] = ticket2Price.ToString("N0", new System.Globalization.CultureInfo("vi-VN"));
                // Tính "Còn lại"
                int quantity2 = Convert.ToInt32(row["Ticket2Quantity"]);
                int booked2 = Convert.ToInt32(row["Ticket2BookedQuantity"]);
                newRow["Loại 2 còn"] = quantity2 - booked2;
                flightSchedulesCustomized.Rows.Add(newRow);
            }


            dataGridView1.DataSource = flightSchedulesCustomized;
            

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void btnBook_Click(object sender, EventArgs e)
        {
            int quantity = (int)numQuantity.Value;
            List<int> passengerIDs = passengersBLL.GetPassengerIDList(quantity);

            // Kiểm tra số lượng hành khách
            if (passengerIDs.Count < quantity)
            {
                MessageBox.Show("Không đủ số lượng hành khách. Vui lòng nhập lại.");
                return;
            }

            for (int i = 0; i < quantity; i++)
            {
                

                int flightID = 0;
                // Kiểm tra xem giá trị có hợp lệ không
                if (dataGridView1.SelectedRows[i].Cells[0].Value != null)
                {
                    int.TryParse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString(), out flightID); // Kiểm tra giá trị flightID
                }

                int passengerID = passengerIDs[i];
                int ticketType = 0;
                // Kiểm tra giá trị ticketType
                if (cbType.SelectedItem != null)
                {
                    ticketType = int.Parse(cbType.SelectedItem.ToString());

                }

                decimal ticketPrice = 0;
                // Kiểm tra giá trị ticketPrice
                if (ticketType == 1)
                {
                    decimal.TryParse(dataGridView1.SelectedRows[i].Cells[3].Value.ToString().Replace(".", "").Replace(",", ""), out ticketPrice); // Kiểm tra giá trị ticketPrice
                }
                else
                {
                    decimal.TryParse(dataGridView1.SelectedRows[i].Cells[5].Value.ToString().Replace(".", "").Replace(",", ""), out ticketPrice);
                }

                DateTime createdDate = DateTime.Now;
                int exPackage = 0;

                // Tạo vé cho hành khách
                Tickets ticket = new Tickets(flightID, passengerID, ticketType, ticketPrice, createdDate, exPackage);
                ticketBLL.AddTicket(ticket);  // Thêm vé vào cơ sở dữ liệu

                //thanh toán
                decimal amount = ticketPrice * quantity; // Tổng số tiền thanh toán
                string orderId = Guid.NewGuid().ToString(); // Tạo mã đơn hàng duy nhất

                // Tạo yêu cầu thanh toán
                PaymentRequest paymentRequest = new PaymentRequest()
                {
                    Amount = amount,
                    OrderId = orderId
                };

                // Gửi yêu cầu thanh toán đến VNPay
                string paymentUrl = VNPayService.CreatePaymentUrl(orderId,amount,"127.0.0.1");

                // Mở trình duyệt để người dùng thực hiện thanh toán
                System.Diagnostics.Process.Start(paymentUrl);

            }


        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int quantity = (int)numQuantity.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng vé lớn hơn 0.");
                return;
            }
            for (int i = 0; i < quantity; i++)
            {
                PassengerInfoForm passengerInfoForm = new PassengerInfoForm();
                passengerInfoForm.ShowDialog();
            }
            btnBook.Enabled = true;
        }
    }
}
