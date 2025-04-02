using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rules
    {
        public int Id { get; set; }
        public double MinTimeFlight { get; set; }
        public int MaxQuantityBetweenAirport { get; set; }
        public double MinTimeStayAirport { get; set; }
        public double MaxTimeStayAirport { get; set; }
        public double TimeBookTicket { get; set; }
        public double TimeBuyTicket { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int AuthorId { get; set; }
    }
}
