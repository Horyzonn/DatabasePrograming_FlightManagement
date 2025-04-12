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

        public bool AddNewRoute(Routes route)
        {
            if (string.IsNullOrWhiteSpace(route.DepartureAirport) || string.IsNullOrWhiteSpace(route.ArrivalAirport))
                throw new Exception("Sân bay đi và đến không được để trống.");
            if (route.DepartureAirport == route.ArrivalAirport)
                throw new Exception("Sân bay đi và đến không được giống nhau.");
            try
            {
                return routeDAO.AddRoute(route);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm tuyến bay: " + ex.Message, ex);
            }
        }

        public bool UpdateRoute(Routes route)
        {
            if (string.IsNullOrWhiteSpace(route.DepartureAirport) || string.IsNullOrWhiteSpace(route.ArrivalAirport))
                throw new Exception("Sân bay đi và đến không được để trống.");
            if (route.DepartureAirport == route.ArrivalAirport)
                throw new Exception("Sân bay đi và đến không được giống nhau.");

            try
            {
                return routeDAO.UpdateRoute(route);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật tuyến bay: " + ex.Message, ex);
            }
        }

        public bool DeleteRoute(int id)
        {
            try
            {
                return routeDAO.DeleteRoute(id);
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
