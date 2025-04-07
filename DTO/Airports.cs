using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Airports
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Airports(string code, string name, string location)
        {
            this.Code = code;
            this.Name = name;
            this.Location = location;
        }

        public Airports()
        {
            // Default constructor
        }
    }
    
}
