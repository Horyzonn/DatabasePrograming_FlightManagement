using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ResetPassDAO : DataProvider
    {
        public bool IsValidUserEmail(string username, string email)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Email = @Email";
            SqlParameter[] parameters = 
            {
            new SqlParameter("@Username", username),
            new SqlParameter("@Email", email)
            };

            try
            {
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kiểm tra tài khoản: " + ex.Message, ex);
            }
        }

        public bool UpdatePassword(string username, string newPassword)
        {
            string sql = "UPDATE Users SET Password = @Password WHERE Username = @Username";
            SqlParameter[] parameters =
            {
            new SqlParameter("@Username", username),
            new SqlParameter("@Password", newPassword) 
            };

            try
            {
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi cập nhật mật khẩu: " + ex.Message, ex);
            }
        }
    }
}
