using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class Reservation
    {
        public Passenger Passenger { get; set; }

        public Reservation(Passenger passenger)
        {
            Passenger = passenger;
        }
    }
}
