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
            if (double.TryParse(txtMinTimeFlight.Text, out double minTimeFlight) &&
                 double.TryParse(txtTimeBook.Text, out double timeBook) &&
                 double.TryParse(txtTimeBuy.Text, out double timeBuy))
            {
                Rules rule = new Rules
                {
                    //Id = 1,
                    MinTimeFlight = minTimeFlight,
                    TimeBookTicket = timeBook,
                    TimeBuyTicket = timeBuy,
                    AuthorId=CurrentUser.Id
                };

                try
                {
                    bool updated = ruleBLL.UpdateRules(rule);
                    MessageBox.Show(updated ? "Cập nhật thành công!" : "Cập nhật thất bại.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số.");
            }
        }
    }
}
