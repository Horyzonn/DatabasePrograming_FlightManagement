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

        public int GetFlightScheduleCount()
        {
            try
            {
                return flightScheduleDAO.GetFlightScheduleCount();
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting flight schedules: " + ex.Message, ex);
            }
        }

        public Dictionary<string,int> GetFlightScheduleCountByRoute()
        {
            try
            {
                return flightScheduleDAO.GetFlightScheduleCountByRoute();
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting flight schedules by route: " + ex.Message, ex);
            }
        }


        public DataTable GetAllFlightSchedules()
        {
            return flightScheduleDAO.GetAllFlightSchedules();
        }
        public bool AddFlightSchedule(FlightSchedule flight)
        
        {
            try
            {
                return flightScheduleDAO.AddFlightSchedule(flight);

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


    /*    public bool UpdateFlightSchedule(FlightSchedule flight)
        {
                return flightScheduleDAO.UpdateFlightSchedule(flight);
        }
        
        public bool IsFlightScheduleExists(int id)
        {
            return flightScheduleDAO.IsFlightScheduleExists(id);
        }
*/
        public DataTable GetFlightStandard(string dep, string arr, DateTime date)
        {
            try
            {
                return flightScheduleDAO.GetFlightStandard(dep, arr, date);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving standard ticket: " + ex.Message, ex);
            }
        }
    }
}
