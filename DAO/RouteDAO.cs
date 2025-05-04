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
                new SqlParameter("@Arrival", arrivalAirport)           
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

        public int GetRouteCount()
        {
            string sql = "SELECT COUNT(*) FROM Routes";
            try
            {
                Connect();
                return (int)ExeScalar(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đếm số lượng tuyến bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
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
        public bool HasRouteUsingAirport(string code)
        {
            string query = "SELECT COUNT(*) FROM Routes WHERE DepartureAirport = @code OR ArrivalAirport = @code";
            SqlParameter[] parameters = { new SqlParameter("@code", code) };
            int count = (int)DataProvider.Instance.ExeScalar(query, CommandType.Text, parameters);
            return count > 0;
        }

        public bool DeleteRoute(string routeID)
        {
            string sql = "DELETE FROM Routes WHERE ID=@routeID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@routeID", routeID),
                //new SqlParameter("@Arrival", arrival),
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
