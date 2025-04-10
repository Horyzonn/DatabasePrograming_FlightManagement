using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AddAirportDAO : DataProvider
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
    }
}
