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
    public partial class RulesManagement : UserControl
    {
        private RuleBLL ruleBLL;
        public RulesManagement()
        {
            InitializeComponent();
            ruleBLL = new RuleBLL();
        }

        private void LoadRules()
        {
            DataTable dt = ruleBLL.GetRules();
            if (dt.Rows.Count > 0)
            {               
                txtMinTimeFlight.Text = dt.Rows[0]["MinTimeFlight"].ToString();
                txtTimeBook.Text = dt.Rows[0]["TimeBookTicket"].ToString();
                txtTimeBuy.Text = dt.Rows[0]["TimeBuyTicket"].ToString();
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules
            {
                Id = 1, // Giả sử chỉ có 1 dòng quy định
                MinTimeFlight = double.Parse(txtMinTimeFlight.Text),
                TimeBookTicket = double.Parse(txtTimeBook.Text),
                TimeBuyTicket = double.Parse(txtTimeBuy.Text),
                //CreatedAt = DateTime.Now,
                //AuthorId = 1, // lấy từ người dùng đăng nhập
            };

            try
            {
                bool updated = ruleBLL.UpdateRules(rule);
                MessageBox.Show(updated ? "Cập nhật thành công!" : "Cập nhật thất bại.");
            }

            catch (FormatException ex)
            {
                // Lỗi khi người dùng nhập dữ liệu không hợp lệ
                MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
            }
    catch (Exception ex)
    {
                // Lỗi chung khi xảy ra bất kỳ lỗi nào
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
