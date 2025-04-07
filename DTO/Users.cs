using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Users(int id, string username, string password, DateTime? dateOfBirth, string email, string phoneNumber, string userRole, string firstName, string lastName)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.UserRole = userRole;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Users()
        {
            // Default constructor
        }
    }
}
