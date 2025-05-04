using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FlightSchedule
    {
        public int ID { get; set; }
        public int RouteID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int? Ticket1Quantity { get; set; }
        public int? Ticket2Quantity { get; set; }
        public int? Ticket1BookedQuantity { get; set; }
        public int? Ticket2BookedQuantity { get; set; }
        public decimal? Ticket1Price { get; set; }
        public decimal? Ticket2Price { get; set; }

        public FlightSchedule(int id, int routeId, DateTime departureTime, DateTime arrivalTime, int? ticket1Quantity, int? ticket2Quantity, int? ticket1BookedQuantity, int? ticket2BookedQuantity, decimal? ticket1Price, decimal? ticket2Price)
        {
            this.ID = id;
            this.RouteID = routeId;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.Ticket1Quantity = ticket1Quantity;
            this.Ticket2Quantity = ticket2Quantity;
            this.Ticket1BookedQuantity = ticket1BookedQuantity;
            this.Ticket2BookedQuantity = ticket2BookedQuantity;
            this.Ticket1Price = ticket1Price;
            this.Ticket2Price = ticket2Price;
        }

        public FlightSchedule()
        {
            // Default constructor
        }
    }
}
