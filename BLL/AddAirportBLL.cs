using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class AddAirportBLL
    {
        private AddAirportDAO addAirportDAO;

        public AddAirportBLL()
        {
            addAirportDAO = new AddAirportDAO();
        }

        public bool AddNewAirport(string code, string name, string location)
        {
            try
            {
                return addAirportDAO.AddNewAirport(code, name, location);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new airport: " + ex.Message, ex);
            }
        }
    }
}
