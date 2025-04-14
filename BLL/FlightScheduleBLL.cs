using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FlightScheduleBLL
    {
        private FlightScheduleDAO flightScheduleDAO;
        public FlightScheduleBLL()
        {
            flightScheduleDAO = new FlightScheduleDAO();
        }

        public DataTable GetAllFlightSchedules()
        {
            return flightScheduleDAO.GetAllFlightSchedules();
        }
        public bool AddFlightSchedule(int routeId, DateTime departureTime, DateTime arrivalTime,
                                      int ticket1Quantity, int ticket2Quantity,
                                      int ticket1BookedQuantity, int ticket2BookedQuantity,
                                      decimal ticket1Price, decimal ticket2Price)
        
        {
            try
            {
                return flightScheduleDAO.AddFlightSchedule(routeId, departureTime, arrivalTime,
                                                            ticket1Quantity, ticket2Quantity,
                                                            ticket1BookedQuantity, ticket2BookedQuantity,
                                                            ticket1Price, ticket2Price);

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm chuyến bay: " + ex.Message, ex);
            }
        }
        public bool DeleteFlightSchedule(int id)
        {
            try
            {
                return flightScheduleDAO.DeleteFlightSchedule(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa chuyến bay: " + ex.Message, ex);
            }
        }




        public bool UpdateFlightSchedule(int id,int routeId, DateTime departureTime, DateTime arrivalTime,
                                      int ticket1Quantity, int ticket2Quantity,
                                      int ticket1BookedQuantity, int ticket2BookedQuantity,
                                      decimal ticket1Price, decimal ticket2Price)
        
        {
                return flightScheduleDAO.UpdateFlightSchedule(id,routeId, departureTime, arrivalTime,
                                                            ticket1Quantity, ticket2Quantity,
                                                            ticket1BookedQuantity, ticket2BookedQuantity,
                                                            ticket1Price, ticket2Price);
        }
        
        public bool IsFlightScheduleExists(int id)
        {
            return flightScheduleDAO.IsFlightScheduleExists(id);
        }

    }
}
