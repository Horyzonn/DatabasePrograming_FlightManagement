﻿using System;
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
    }
}
