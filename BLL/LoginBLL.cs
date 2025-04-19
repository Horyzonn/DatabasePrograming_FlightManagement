using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL 
{
    public class LoginBLL
    {
       private LoginDAO loginDAO;
       public LoginBLL() {
            loginDAO = new LoginDAO();
       }
        
        public bool Login(Users user)
        {
            try
            {
                return loginDAO.Login(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng nhập: " + ex.Message, ex);
            }
        }
    }

}
