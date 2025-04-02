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
        public int RouteId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int? Ticket1Quantity { get; set; }
        public int? Ticket2Quantity { get; set; }
        public int? Ticket1BookedQuantity { get; set; }
        public int? Ticket2BookedQuantity { get; set; }
        public decimal? Ticket1Price { get; set; }
        public decimal? Ticket2Price { get; set; }
    }
}
