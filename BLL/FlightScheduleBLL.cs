﻿using DAO;
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


        public bool UpdateFlightSchedule(FlightSchedule flight)
        {
                return flightScheduleDAO.UpdateFlightSchedule(flight);
        }
        
        public bool IsFlightScheduleExists(int id)
        {
            return flightScheduleDAO.IsFlightScheduleExists(id);
        }

    }
}
