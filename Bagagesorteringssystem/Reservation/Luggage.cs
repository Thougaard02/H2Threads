using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class Luggage
    {
        public Reservation Reservation { get; set; }

        public Luggage(Reservation reservation)
        {
            Reservation = reservation;
        }
    }
}
