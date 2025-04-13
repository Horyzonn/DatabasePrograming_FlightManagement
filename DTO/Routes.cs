using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Routes
    {
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
       

        public Routes( string departureAirport, string arrivalAirport)
        {
           
            this.DepartureAirport = departureAirport;
            this.ArrivalAirport = arrivalAirport;
            
        }

        public Routes()
        {
            // Default constructor
        }
    }
}
