using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.User_Control;
using FlightManagement.UserControls;

namespace FlightManagement
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HighlightButton(Button button)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(32, 71, 105); // Màu nền mặc định
                }
            }
            button.BackColor = Color.LightBlue; // Màu nền khi được chọn
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Admin
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Hiện lại form đăng nhập
        }
        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BookTicket());
            HighlightButton(btnBookTicket);
        }

        private void btnFindTicket_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FindTicket());
            HighlightButton(btnFindTicket);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Admin
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Hiện lại form đăng nhập
        }
    }
}
