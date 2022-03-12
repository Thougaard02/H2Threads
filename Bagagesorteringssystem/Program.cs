using System;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservation[] reservations = new Reservation[20];
            CheckIn checkIn = new CheckIn(1);
            LuggageSorting luggageSorting = new LuggageSorting();
            Gates gate = new Gates(1);
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < reservations.Length; i++)
            {
                Passenger passenger = new Passenger("Rasmus", "Kristensen", "Rasmus@vinperlen.dk", "12345678", "Humlebivej 10");
                reservations[i] = new Reservation(passenger, (Destinations)random.Next(0, 3));
            }


            Console.WriteLine("Hello");
            checkIn.IsOpen = true;
            checkIn.StartCheckIn(reservations);
            luggageSorting.LuggageDestinationSorting();
            gate.IsOpen = true;
            gate.OpenTerminal();

            Console.ReadKey();
        }
    }
}
