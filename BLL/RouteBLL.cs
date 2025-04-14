using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class RouteBLL
    {
        private RouteDAO routeDAO;

        public RouteBLL()
        {
            routeDAO = new RouteDAO();
        }

        public bool AddNewRoute(string departureAirport, string arrivalAirport)
        {
            if (string.IsNullOrWhiteSpace(departureAirport) || string.IsNullOrWhiteSpace(arrivalAirport))
                throw new Exception("Sân bay đi và đến không được để trống.");
            if (departureAirport == arrivalAirport)
                throw new Exception("Sân bay đi và đến không được giống nhau.");
            if (routeDAO.IsRouteExists(departureAirport, arrivalAirport))
                throw new Exception("Tuyến bay này đã tồn tại.");
            try
            {
                return routeDAO.AddRoute(departureAirport,arrivalAirport);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm tuyến bay: " + ex.Message, ex);
            }
        }


        public bool DeleteRoute(string departureAirport, string arrivalAirport)
        {
            try
            {
                return routeDAO.DeleteRoute(departureAirport,arrivalAirport);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa tuyến bay: " + ex.Message, ex);
            }
        }
            public DataTable GetAllRoutes()
            {
                return routeDAO.GetAllRoutes();
            }
    }
}
