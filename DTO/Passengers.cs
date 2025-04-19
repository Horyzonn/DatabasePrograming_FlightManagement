using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Passengers
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Gender { get; set; }
        public int? PassportNumber { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        
        public Passengers()
        {
            // Default constructor
        }

        public Passengers(int id,string fullName, DateTime dayOfBirth, string gender, int? passportNumber, string nationality, string email, string phoneNumber) 
        {
            Id = id;
            DayOfBirth = dayOfBirth;
            Gender = gender;
            PassportNumber = passportNumber;
            Nationality = nationality;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
   
}
