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

namespace FlightManagement.User_Control
{
    public partial class RouteManagement : UserControl
    {
        private AirportBLL addAirportBLL;
        public RouteManagement()
        {
            InitializeComponent();
            addAirportBLL = new AirportBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool AddNewAirport(string code, string name, string location)
        {
            try
            {
                // Call the BLL method to add a new airport
                return addAirportBLL.AddNewAirport(code, name, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new airport: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            string airportCode = txtAirportCode.Text.Trim();
            string airportName = txtAirportName.Text.Trim();
            string airportLocation = txtAirportLoc.Text.Trim();
            if(AddNewAirport(airportCode, airportName, airportLocation))
            {
                MessageBox.Show("New airport added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add new airport.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
