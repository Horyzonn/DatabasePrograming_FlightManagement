using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoginDAO : DataProvider
    {
        public Users Login(Users user)
        {
            string sql = "SELECT TOP 1 * FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Username", user.Username),
        new SqlParameter("@Password", user.Password),
            };

            try
            {
                using (SqlDataReader reader = ExeReader(sql, CommandType.Text, parameters))
                {
                    if (reader.Read())
                    {
                        return new Users
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Username = reader["Username"].ToString(),
                            UserRole = reader["UserRole"].ToString()

                        };
                    }
                }

                return null; // Đăng nhập thất bại
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message, ex);
            }
        }
    }
}
