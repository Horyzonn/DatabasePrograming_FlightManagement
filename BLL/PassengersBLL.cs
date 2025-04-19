using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class PassengersBLL
    {
        private PassengersDAO passengersDAO;
        public PassengersBLL()
        {
            passengersDAO = new PassengersDAO();
        }
        public DataTable GetAllPassengers()
        {
            return passengersDAO.GetAllPassengers();
        }
        public bool AddPassenger(Passengers passenger)
        {
            try
            {
                return passengersDAO.AddPassenger(passenger);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm hành khách: " + ex.Message, ex);
            }
        }
        public bool UpdatePassenger(Passengers passenger)
        {
            try
            {
                return passengersDAO.UpdatePassenger(passenger);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật hành khách: " + ex.Message, ex);
            }
        }
        public bool DeletePassenger(int id)
        {
            try
            {
                return passengersDAO.DeletePassenger(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa hành khách: " + ex.Message, ex);
            }
        }
        public bool IsPassengerExists(int id)
        {
            try
            {
                return passengersDAO.IsPassengerExists(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra hành khách: " + ex.Message, ex);
            }
        }
    }
}
