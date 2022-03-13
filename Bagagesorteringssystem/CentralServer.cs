using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class CentralServer
    {
        public static object _lock = new object();
        public enum Destinations
        {
            Copenhagen,
            Texas,
            Egypten
        }
        public void MonitorCheckIn()
        {
            CheckIn checkIn = new CheckIn(1);
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Reservation[] reservations = new Reservation[20];
            for (int i = 0; i < reservations.Length; i++)
            {
                Passenger passenger = new Passenger("Rasmus", "Kristensen", "Rasmus@vinperlen.dk", "12345678", "Humlebivej 10");
                reservations[i] = new Reservation(passenger, (Destinations)random.Next(0, 3));
            }
            checkIn.IsOpen = true;
            checkIn.StartCheckIn(reservations);
        }

        public void MonitorLuggageSorting()
        {
            LuggageSorting luggageSorting = new LuggageSorting();
            luggageSorting.LuggageDestinationSorting();
        }

        public void MonitorTerminal()
        {
            Gates gate = new Gates(1);
            gate.IsOpen = true;
            gate.OpenTerminal();
        }
    }
}
