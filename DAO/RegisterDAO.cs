using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RegisterDAO : DataProvider
    {
        public bool IsUsernameTaken(string username)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlParameter[] parameters =
            {
            new SqlParameter("@Username", username)
            };

            try
            {
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra tên đăng nhập: " + ex.Message, ex);
            }
        }

        public bool IsEmailTaken(string email)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            SqlParameter[] parameters =
            {
            new SqlParameter("@Email", email)
            };

            try
            {
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra email: " + ex.Message, ex);
            }
        }

        public bool IsPhoneNumberTaken(string phone)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE PhoneNumber = @PhoneNumber";
            SqlParameter[] parameters =
            {
            new SqlParameter("@PhoneNumber", phone)
            };

            try
            {
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra số điện thoại: " + ex.Message, ex);
            }
        }

        public bool RegisterUser(Users user)
        {
            string sql = @"INSERT INTO Users 
                        (Username, Password, DoB, Email, PhoneNumber, UserRole)
                       VALUES 
                        (@Username, @Password, @DateOfBirth, @Email, @PhoneNumber, @UserRole)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@Username", user.Username),
            new SqlParameter("@Password", user.Password),
            new SqlParameter("@DateOfBirth", SqlDbType.Date)
            {
                Value = (object)user.DateOfBirth ?? DBNull.Value
            },
            new SqlParameter("@Email", user.Email),
            new SqlParameter("@PhoneNumber", user.PhoneNumber),
            new SqlParameter("@UserRole", user.UserRole),
           
            };

            try
            {
                int rows = ExeNonQuery(sql, CommandType.Text, parameters);
                return rows > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi đăng ký người dùng: " + ex.Message, ex);
            }
        }
    }
}
