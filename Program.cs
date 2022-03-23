using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxionline
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new taxionline.Taxi();

            taxi.drivername = "Aika";
            taxi.onduty = true;
            taxi.passenggernum = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassengger();
            taxi.DropOffPassengger();
        }
    }
}
