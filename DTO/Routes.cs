﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Routes
    {
        public int Id { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Routes(int id, string departureAirport, string arrivalAirport, DateTime? createdDate)
        {
            this.Id = id;
            this.DepartureAirport = departureAirport;
            this.ArrivalAirport = arrivalAirport;
            this.CreatedDate = createdDate;
        }

        public Routes()
        {
            // Default constructor
        }
    }
}
