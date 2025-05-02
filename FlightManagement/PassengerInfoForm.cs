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

namespace FlightManagement
{
    public partial class PassengerInfoForm : Form
    {
        private PassengersBLL passengersBLL;
        public PassengerInfoForm()
        {
            InitializeComponent();
            passengersBLL = new PassengersBLL();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            DateTime DoB = dtpDoB.Value.Date;
            string gender = cbGender.SelectedItem.ToString(); 
            string passportNumber = txtCCCD.Text;
            string nationality = txtNation.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhone.Text;

            var passenger = new Passengers(
            fullName, DoB, gender, passportNumber, nationality, email, phoneNumber
             );

            if (passengersBLL.AddPassenger(passenger))
            {
                MessageBox.Show("Thêm hành khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm hành khách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
