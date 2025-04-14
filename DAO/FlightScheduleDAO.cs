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
        public bool AddFlightSchedule(int routeId, DateTime departureTime, DateTime arrivalTime,
                                      int ticket1Quantity, int ticket2Quantity,
                                      int ticket1BookedQuantity, int ticket2BookedQuantity,
                                      decimal ticket1Price, decimal ticket2Price)
        {

            string sql = @"INSERT INTO FlightSchedule 
                        (RouteId, DepartureTime, ArrivalTime, Ticket1Quantity, Ticket2Quantity, 
                         Ticket1BookedQuantity, Ticket2BookedQuantity, Ticket1Price, Ticket2Price)
                        VALUES 
                        (@RouteId, @DepartureTime, @ArrivalTime, @Ticket1Quantity, @Ticket2Quantity, 
                         @Ticket1BookedQuantity, @Ticket2BookedQuantity, @Ticket1Price, @Ticket2Price)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RouteId", routeId),
                new SqlParameter("@DepartureTime", departureTime),
                new SqlParameter("@ArrivalTime", arrivalTime),
                new SqlParameter("@Ticket1Quantity", ticket1Quantity ),
                new SqlParameter("@Ticket2Quantity", ticket2Quantity ),
                new SqlParameter("@Ticket1BookedQuantity", ticket1BookedQuantity ),
                new SqlParameter("@Ticket2BookedQuantity", ticket2BookedQuantity ),
                new SqlParameter("@Ticket1Price", ticket1Price ),
                new SqlParameter("@Ticket2Price", ticket2Price )
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

        public bool UpdateFlightSchedule(int id, int routeId, DateTime departureTime, DateTime arrivalTime,
                                         int ticket1Quantity, int ticket2Quantity,
                                         int ticket1BookedQuantity, int ticket2BookedQuantity,
                                         decimal ticket1Price, decimal ticket2Price)
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
                new SqlParameter("@Id", id),
                new SqlParameter("@RouteId", routeId),
                new SqlParameter("@DepartureTime", departureTime),
                new SqlParameter("@ArrivalTime", arrivalTime),
                new SqlParameter("@Ticket1Quantity", ticket1Quantity ),
                new SqlParameter("@Ticket2Quantity", ticket2Quantity ),
                new SqlParameter("@Ticket1BookedQuantity", ticket1BookedQuantity ),
                new SqlParameter("@Ticket2BookedQuantity", ticket2BookedQuantity ),
                new SqlParameter("@Ticket1Price", ticket1Price ),
                new SqlParameter("@Ticket2Price", ticket2Price )
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
