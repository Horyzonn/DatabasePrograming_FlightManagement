using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL 
{
    public class LoginBLL
    {
       private LoginDAO loginDAO;
       public LoginBLL() {
            loginDAO = new LoginDAO();
       }
        
        public bool Login(string username, string password)
        {
            try
            {
                return loginDAO.Login(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng nhập: " + ex.Message, ex);
            }
        }
    }

}
