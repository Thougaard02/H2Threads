using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    public class CheckIn
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public static Luggage[] Luggages;

        public CheckIn(int id)
        {
            Id = id;
            IsOpen = false;
            Luggages = new Luggage[20];
        }

        public void StartCheckIn(Reservation[] reservation)
        {
            while (reservation.Length == 0)
            {
                Monitor.Wait(_lock);
                Console.WriteLine("Waiting on new reservations");
            }

            lock (_lock)
            {
                if (IsOpen)
                {
                    for (int i = 0; i < reservation.Length; i++)
                    {
                        Luggages[i] = new Luggage(reservation[i]);
                        Console.WriteLine($"{Luggages[i].Reservation.Passenger.FirstName} has checked in");
                        Console.WriteLine($"Destination: {Luggages[i].Reservation.Destinations} ");
                        Console.WriteLine($"{i} Luggages is being transported on conveyor belt");
                    }
                    //IsOpen = false;
                    //Console.BackgroundColor = ConsoleColor.Red;
                    //Console.WriteLine($"Check in {this.Id} is closed ");
                    //Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            Monitor.PulseAll(_lock);
        }
    }
}
