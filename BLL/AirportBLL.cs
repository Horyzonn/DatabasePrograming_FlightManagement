using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class AirportBLL
    {
        private AirportDAO airportDAO;

        public AirportBLL()
        {
            airportDAO = new AirportDAO();
        }

        public DataTable GetAllAirports()
        {
            return airportDAO.GetAllAirports();
        }

        public bool AddNewAirport(string code, string name, string location)
        {
            try
            {
                return airportDAO.AddNewAirport(code, name, location);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new airport: " + ex.Message, ex);
            }
        }

        public bool IsAirportCodeExists(string code)
        {
            return airportDAO.IsAirportCodeExists(code);
        }

        public bool DeleteAirport(string code)
        {
            try
            {
                return airportDAO.DeleteAirport(code);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sân bay trong BLL: " + ex.Message, ex);
            }
        }

       
    }
}
