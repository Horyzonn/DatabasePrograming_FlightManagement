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
    public class UsersDAO : DataProvider
    {
        public DataTable GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            
            return ExeQuery(sql, CommandType.Text);
        }
        public bool AddUser(Users user)
        {
            string sql = @"INSERT INTO Users 
                        (Username, Password, DoB, Email, PhoneNumber, UserRole )
                        VALUES 
                        (@Username, @Password, @DateOfBirth, @Email, @PhoneNumber, @UserRole )";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@DateOfBirth", user.DateOfBirth ?? (object)DBNull.Value),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@PhoneNumber", user.PhoneNumber),
                new SqlParameter("@UserRole", user.UserRole),
                
            };


            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm người dùng: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public bool UpdateUser(Users user)
        {
            string sql = @"UPDATE Users SET 
                        Username = @Username,
                        Password = @Password,
                        DoB = @DateOfBirth,
                        Email = @Email,
                        PhoneNumber = @PhoneNumber,
                        UserRole = @UserRole
                    
                        
                    WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", user.Id),
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@DateOfBirth", user.DateOfBirth ?? (object)DBNull.Value),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@PhoneNumber", user.PhoneNumber),
                new SqlParameter("@UserRole", user.UserRole)
                

            };
            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật người dùng: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public bool DeleteUser(int id)
        {
            string sql = "DELETE FROM Users WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            try
            {
                Connect();
                return ExeNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa người dùng: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public bool IsUserExists(int id)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            try
            {
                Connect();
                int count = (int)ExeScalar(sql, CommandType.Text, parameters);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra người dùng: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable GetUsersByRole(string role)
        {
            string sql = "SELECT * FROM Users WHERE UserRole = @UserRole";
           
            SqlParameter[] parameters =
            {
            new SqlParameter("@UserRole", role)
            };

            try
            {
                Connect();
                return ExeQuery(sql, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lọc người dùng theo vai trò: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

    }


}
