using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public static class PasswordHelper
    {
        public static bool IsStrongPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            var hasUpper = new Regex(@"[A-Z]+");      
            var hasLower = new Regex(@"[a-z]+");     
            var hasDigit = new Regex(@"\d+");        
            var hasSpecial = new Regex(@"[\W_]+");    

            return hasUpper.IsMatch(password) &&
                   hasLower.IsMatch(password) &&
                   hasDigit.IsMatch(password) &&
                   hasSpecial.IsMatch(password);
        }
    }
}
