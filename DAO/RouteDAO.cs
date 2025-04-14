using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class RouteDAO:DataProvider
    {
        public bool AddRoute(string departureAirport, string arrivalAirport)
        {
            string sql = "INSERT INTO Routes ( DepartureAirport, ArrivalAirport) " +
                         "VALUES ( @Departure, @Arrival)";
            SqlParameter[] parameters = new SqlParameter[]
            {
               
            new SqlParameter("@Departure", departureAirport),
            new SqlParameter("@Arrival", arrivalAirport),
            
            };

            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm chuyến bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public DataTable GetAllRoutes()
        {
            string sql = "SELECT * FROM Routes";
            return ExeQuery(sql, CommandType.Text);
        }

        public bool IsRouteExists(string departure, string arrival)
        {
            string sql = "SELECT COUNT(*) FROM Routes WHERE DepartureAirport = @Departure AND ArrivalAirport = @Arrival";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Departure", departure),
                new SqlParameter("@Arrival", arrival)
            };

            try
            {
                Connect();
                return (int)ExeScalar(sql, CommandType.Text, parameters) > 0;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteRoute(string departure, string arrival)
        {
            string sql = "DELETE FROM Routes WHERE DepartureAirport = @departure AND ArrivalAirport = @arrival";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Departure", departure),
                new SqlParameter("@Arrival", arrival),
            };

            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa tuyến bay: " + ex.Message, ex);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
