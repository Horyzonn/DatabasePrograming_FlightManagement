using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class ResetPassBLL
    {
        private ResetPassDAO resetPassDAO;

        public ResetPassBLL()
        {
            resetPassDAO = new ResetPassDAO();
        }

        public bool ValidateUserForReset(string username, string email)
        {
            return resetPassDAO.IsValidUserEmail(username, email);
        }

        public bool IsStrongPassword(string password)
        {
            return PasswordHelper.IsStrongPassword(password);
        }

        public bool ResetPassword(string username, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                throw new Exception("Mật khẩu mới không được để trống");

            return resetPassDAO.UpdatePassword(username, newPassword);
        }

        
    }
}
