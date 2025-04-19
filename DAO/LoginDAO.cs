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
        public bool Login(Users user)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
               
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
