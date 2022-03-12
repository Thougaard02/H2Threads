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
            if (IsOpen)
            {
                for (int i = 0; i < reservation.Length; i++)
                {
                    Luggages[i] = new Luggage(reservation[i]);
                }
                Console.WriteLine("Luggages is being transported on conveyor belt");
                IsOpen = false;
                Console.WriteLine($"Check in has been closed {this.Id}");
            }
        }
    }
}
