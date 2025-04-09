using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoginDAO : DataProvider
    {
        public bool Login(string username, string password)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            try
            {
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message, ex);
            }

        }
    }
}
