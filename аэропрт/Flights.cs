using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace аэропрт
{
    [Serializable]
    public class Flights
    {
        public List<Flight> Flights_List { set; get; } = new List<Flight>();
    }
}
