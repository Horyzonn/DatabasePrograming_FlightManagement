﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using FlightManagement.User_Control;
using FlightManagement.UserControls;

namespace FlightManagement
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Admin
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Hiện lại form đăng nhập
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UsersManagementControl());
            HighlightButton(btnAccount);
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
                    btn.BackColor = Color.FromArgb(32,71,105); // Màu nền mặc định
                }
            }
            button.BackColor = Color.LightBlue; // Màu nền khi được chọn
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RouteManagement());
            HighlightButton(btnRoute);

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FlightScheduleManagement());
            HighlightButton(btnSchedule);
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RulesManagement());
            HighlightButton(btnRule);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Dashboard());
            HighlightButton(btnDashboard);
        }
    }
}
