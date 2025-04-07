using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BetweenAirports
    {
        public int Id { get; set; }
        public int FlightScheduleId { get; set; }
        public string AirportCode { get; set; }
        public double StopDuration { get; set; }
        public int OrderNumber { get; set; }

        public BetweenAirports(int id, int flightScheduleId, string airportCode, double stopDuration, int orderNumber)
        {
            this.Id = id;
            this.FlightScheduleId = flightScheduleId;
            this.AirportCode = airportCode;
            this.StopDuration = stopDuration;
            this.OrderNumber = orderNumber;
        }

        public BetweenAirports()
        {
            // Default constructor
        }
    }
}
