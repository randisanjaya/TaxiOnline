using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxionline
{
    public class Taxi
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int passenggernum { get; set; }

        public void TaxiInfo ()
        {
            Console.WriteLine("Driver Name: {0}", drivername);
            Console.WriteLine("On Duty: {0}", onduty);
            Console.WriteLine("Number of Passengger: {0}", passenggernum);
            Console.WriteLine();
        }

        public void PickUpPassengger ()
        {
            Console.WriteLine("{0} sedang menjemput Penumpang", drivername);
        }

        public void DropOffPassengger ()
        {
           Console.WriteLine("{0} sedang mengantar Penumpang", drivername);
        }
    }
}
