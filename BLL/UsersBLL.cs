using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class UsersBLL
    {
        private UsersDAO usersDAO;
        public UsersBLL()
        {
            usersDAO = new UsersDAO();
        }
        public DataTable GetAllUsers()
        {
            return usersDAO.GetAllUsers();
        }

        public bool AddUser(Users user)
        {
            try
            {
                return usersDAO.AddUser(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm người dùng: " + ex.Message, ex);
            }
        }
        public bool DeleteUser(int id)
        {
            try
            {
                return usersDAO.DeleteUser(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa người dùng: " + ex.Message, ex);
            }
        }
        public bool UpdateUser(Users user)
        {
            try
            {
                return usersDAO.UpdateUser(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật người dùng: " + ex.Message, ex);
            }
        }
        public bool IsUserExists(int id)
        {
            return usersDAO.IsUserExists(id);
        }

        public DataTable GetUsersByRole(string role)
        {
            try
            {
                return usersDAO.GetUsersByRole(role);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lọc người dùng theo vai trò: " + ex.Message, ex);
            }
        }
    }
}
