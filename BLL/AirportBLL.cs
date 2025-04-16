using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class AirportBLL
    {
        private AirportDAO airportDAO;
        private RouteDAO routeDAO;

        public AirportBLL()
        {
            airportDAO = new AirportDAO();
            routeDAO = new RouteDAO();
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
            if (!routeDAO.HasRouteUsingAirport(code))
            {
                try
                {
                    return airportDAO.DeleteAirport(code);
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi khi xóa sân bay: " + ex.Message, ex);
                }
            }
            else
            {
                throw new Exception("Sân bay đang được sử dụng, không thể xóa.");
            }
        }

       
    }
}
