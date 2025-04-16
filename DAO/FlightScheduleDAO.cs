using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FlightScheduleDAO : DataProvider
    {
        public DataTable GetAllFlightSchedules()
        {
            string sql = "SELECT * FROM FlightSchedule";
            return ExeQuery(sql, CommandType.Text);
        }
        public bool AddFlightSchedule(FlightSchedule flight)
        {

            string sql = @"INSERT INTO FlightSchedule 
                        (RouteId, DepartureTime, ArrivalTime, Ticket1Quantity, Ticket2Quantity, 
                         Ticket1BookedQuantity, Ticket2BookedQuantity, Ticket1Price, Ticket2Price)
                        VALUES 
                        (@RouteId, @DepartureTime, @ArrivalTime, @Ticket1Quantity, @Ticket2Quantity, 
                         @Ticket1BookedQuantity, @Ticket2BookedQuantity, @Ticket1Price, @Ticket2Price)";

            SqlParameter[] parameters = new SqlParameter[]
            {                
                new SqlParameter("@RouteId", flight.RouteId),
                new SqlParameter("@DepartureTime",flight.DepartureTime),
                new SqlParameter("@ArrivalTime", flight.ArrivalTime),
                new SqlParameter("@Ticket1Quantity", flight.Ticket1Quantity ),
                new SqlParameter("@Ticket2Quantity", flight.Ticket2Quantity),
                new SqlParameter("@Ticket1BookedQuantity",flight.Ticket1BookedQuantity ),
                new SqlParameter("@Ticket2BookedQuantity",flight.Ticket1BookedQuantity),
                new SqlParameter("@Ticket1Price", flight.Ticket1Price ),
                new SqlParameter("@Ticket2Price", flight.Ticket2Price )
            };
            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm chuyến bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteFlightSchedule(int id)
        {
            string sql = "DELETE FROM FlightSchedule WHERE Id = @Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id", id)
            };

            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi xóa lịch bay: " + ex.Message, ex);
            }
            finally
            {
                Disconnect();
            }
        }

        public bool UpdateFlightSchedule(FlightSchedule flight)
        {
            string sql = @"UPDATE FlightSchedule SET                          
                            RouteId = @RouteId,
                            DepartureTime = @DepartureTime,
                            ArrivalTime = @ArrivalTime,
                            Ticket1Quantity = @Ticket1Quantity,
                            Ticket2Quantity = @Ticket2Quantity,
                            Ticket1BookedQuantity = @Ticket1BookedQuantity,
                            Ticket2BookedQuantity = @Ticket2BookedQuantity,
                            Ticket1Price = @Ticket1Price,
                            Ticket2Price = @Ticket2Price
                        WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {              
                new SqlParameter("@RouteId", flight.RouteId),
                new SqlParameter("@DepartureTime",flight.DepartureTime),
                new SqlParameter("@ArrivalTime", flight.ArrivalTime),
                new SqlParameter("@Ticket1Quantity", flight.Ticket1Quantity ),
                new SqlParameter("@Ticket2Quantity", flight.Ticket2Quantity),
                new SqlParameter("@Ticket1BookedQuantity",flight.Ticket1BookedQuantity ),
                new SqlParameter("@Ticket2BookedQuantity",flight.Ticket1BookedQuantity),
                new SqlParameter("@Ticket1Price", flight.Ticket1Price ),
                new SqlParameter("@Ticket2Price", flight.Ticket2Price )
            };

            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật lịch bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public bool IsFlightScheduleExists(int id)
        {
            string sql = "SELECT COUNT(*) FROM FlightSchedule WHERE Id = @Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id", id)
            };

            try
            {
                Connect();
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra lịch bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
