using System;
using System.Collections.Generic;
using System.Text;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    public class Reservation
    {
        List<Reservation> ReservationsList { get; set; }
        public Passenger Passenger { get; set; }
        public bool IsCheckIn { get; set; }
        public Destinations Destinations { get; set; }

        public Reservation(Passenger passenger, Destinations destinations)
        {
            Passenger = passenger;
            IsCheckIn = false;
            Destinations = destinations;
        }
    }
}
