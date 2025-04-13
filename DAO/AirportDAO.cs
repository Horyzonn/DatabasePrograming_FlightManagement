using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AirportDAO : DataProvider
    {
        public bool AddNewAirport(string code, string name, string location)
        {
            string sql = "INSERT INTO Airports (Code, Name, Location) VALUES (@Code, @Name, @Location)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Code", code),
                new SqlParameter("@Name", name),
                new SqlParameter("@Location", location)
            };
            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0; // Return true if the insert was successful
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new airport: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable GetAllAirports()
        {
            string sql = "SELECT * FROM Airports";
            return ExeQuery(sql, CommandType.Text); // Dùng từ DataProvider
        }

        public bool IsAirportCodeExists(string code)
        {
            string sql = "SELECT COUNT(*) FROM Airports WHERE Code = @Code";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Code", code)
            };

            try
            {
                Connect();
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra mã sân bay: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteAirport(string code)
        {
            string sql = "DELETE FROM Airports WHERE Code = @Code";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Code", code)
            };

            try
            {
                Connect();
                int result = ExeNonQuery(sql, CommandType.Text, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi xóa sân bay: " + ex.Message, ex);
            }
            finally
            {
                Disconnect();
            }
        }

        
    }
}
