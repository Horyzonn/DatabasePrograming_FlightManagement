using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DeleteAirportDAO:DataProvider
    {
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
                throw new Exception("Lỗi khi xóa sân bay trong DAO: " + ex.Message, ex);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
