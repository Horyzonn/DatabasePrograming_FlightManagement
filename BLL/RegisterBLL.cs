using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RegisterBLL
    {
        private RegisterDAO registerDAO;

        public RegisterBLL()
        {
            registerDAO = new RegisterDAO();
        }

        public bool IsStrongPassword(string password)
        {
            return PasswordHelper.IsStrongPassword(password);
        }

        public bool Register(Users user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                throw new Exception("Tên đăng nhập và mật khẩu không được để trống.");
            }

            if (registerDAO.IsEmailTaken(user.Email))
            {
                throw new Exception("Email đã tồn tại.");
            }

            if (registerDAO.IsUsernameTaken(user.Username))
            {
                throw new Exception("Tên đăng nhập đã tồn tại.");
            }

            if (registerDAO.IsPhoneNumberTaken(user.PhoneNumber))
            {
                throw new Exception("Số điện thoại đã tồn tại.");
            }
            return registerDAO.RegisterUser(user);
        }
    }
}
