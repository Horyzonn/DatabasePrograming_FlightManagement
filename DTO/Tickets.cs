using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tickets
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FlightScheduleId { get; set; }
        public int PassengerId { get; set; }
        public int Type { get; set; }
        public decimal Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ExtraPackage { get; set; }
    }
}
