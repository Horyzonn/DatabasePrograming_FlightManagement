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
        public bool AddRoute(Routes route)
        {
            string sql = "INSERT INTO Routes (DepartureAirport, ArrivalAirport, CreatedDate) " +
                         "VALUES (@Departure, @Arrival, @Date)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Departure", route.DepartureAirport),
            new SqlParameter("@Arrival", route.ArrivalAirport),
            new SqlParameter("@Date", (object)route.CreatedDate ?? DBNull.Value)
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

        public bool UpdateRoute(Routes route)
        {
            string sql = "UPDATE Routes SET DepartureAirport = @Departure, ArrivalAirport = @Arrival, CreatedDate = @Date WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", route.Id),
                new SqlParameter("@Departure", route.DepartureAirport),
                new SqlParameter("@Arrival", route.ArrivalAirport),
                new SqlParameter("@Date", (object)route.CreatedDate ?? DBNull.Value)
            };

            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tuyến bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteRoute(int id)
        {
            string sql = "DELETE FROM Routes WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tuyến bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
