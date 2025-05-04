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
            string sql = @"
                                SELECT 
                                    fs.ID AS Id,
                                    fs.RouteID,
                                    da.Name AS DepartureAirport,
                                    aa.Name AS ArrivalAirport,
                                    fs.DepartureTime,
                                    fs.ArrivalTime
                                FROM 
                                    FlightSchedule fs
                                JOIN 
                                    Routes r ON fs.RouteID = r.ID
                                JOIN 
                                    Airports da ON r.DepartureAirport = da.Code
                                JOIN 
                                    Airports aa ON r.ArrivalAirport = aa.Code";
            return ExeQuery(sql, CommandType.Text);
        }

        public Dictionary<string, int> GetFlightScheduleCountByRoute()
        {
            string sql = @"
        SELECT 
            r.DepartureAirport,
            r.ArrivalAirport,
            COUNT(*) AS FlightCount
        FROM FlightSchedule fs
        JOIN Routes r ON fs.RouteId = r.ID
        GROUP BY r.DepartureAirport, r.ArrivalAirport";

            Dictionary<string, int> flightCounts = new Dictionary<string, int>();

            try
            {
                Connect();
                DataTable dt = ExeQuery(sql, CommandType.Text);

                foreach (DataRow row in dt.Rows)
                {
                    string departure = row["DepartureAirport"].ToString();
                    string arrival = row["ArrivalAirport"].ToString();
                    string routeLabel = $"{departure} → {arrival}";

                    int count = Convert.ToInt32(row["FlightCount"]);
                    flightCounts[routeLabel] = count;
                }

                return flightCounts;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy số chuyến bay theo tuyến (tên sân bay): " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }


        public int GetFlightScheduleCount()
        {
            string sql = "SELECT COUNT(*) FROM FlightSchedule";
            try
            {
                Connect();
                return (int)ExeScalar(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đếm số lượng lịch bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public bool AddFlightSchedule(FlightSchedule flight)
        {

            string sql = @"INSERT INTO FlightSchedule 
                        (RouteID, DepartureTime, ArrivalTime, Ticket1Quantity, Ticket2Quantity, 
                          Ticket1Price, Ticket2Price)
                        VALUES 
                        (@RouteID, @DepartureTime, @ArrivalTime, @Ticket1Quantity, @Ticket2Quantity, 
                         @Ticket1Price, @Ticket2Price)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RouteID", flight.RouteID),
                new SqlParameter("@DepartureTime",flight.DepartureTime),
                new SqlParameter("@ArrivalTime", flight.ArrivalTime),
                new SqlParameter("@Ticket1Quantity", flight.Ticket1Quantity ),
                new SqlParameter("@Ticket2Quantity", flight.Ticket2Quantity),
                
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
            string sql = "DELETE FROM FlightSchedule WHERE ID = @ID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", id)
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

       

        public bool IsFlightScheduleExists(int id)
        {
            string sql = "SELECT COUNT(*) FROM FlightSchedule WHERE ID = @ID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", id)
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

        public DataTable GetFlightStandard(string dep, string arr, DateTime date)
        {
            string sql = "SELECT fs.* FROM FlightSchedule fs JOIN Routes r ON fs.RouteID = r.ID WHERE r.DepartureAirport = @dep  AND r.ArrivalAirport = @arr  AND CAST(fs.DepartureTime AS DATE) = @date;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dep", dep),
                new SqlParameter("@arr", arr),
                new SqlParameter("@date", date)
            };
            return ExeQuery(sql, CommandType.Text, parameters);
        }

        public bool HasFlightUsingRoute(string routeID)
        {
            string query = "SELECT COUNT(*) FROM FlightSchedule WHERE RouteID=@routeID";
            SqlParameter[] parameters = { new SqlParameter("@routeID", routeID) };
            int count = (int)DataProvider.Instance.ExeScalar(query, CommandType.Text, parameters);
            return count > 0;
        }

    }
}
