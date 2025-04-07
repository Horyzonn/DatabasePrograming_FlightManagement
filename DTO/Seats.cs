using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Seats
    {
        public int Id { get; set; }
        public int FlightScheduleId { get; set; }
        public int TicketId { get; set; }
        public string SeatNumber { get; set; }

        public Seats(int id, int flightScheduleId, int ticketId, string seatNumber)
        {
            this.Id = id;
            this.FlightScheduleId = flightScheduleId;
            this.TicketId = ticketId;
            this.SeatNumber = seatNumber;
        }

        public Seats()
        {
            // Default constructor
        }
    }
}