using System;
using System.Collections.Generic;
using System.Text;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    public class LuggageSorting
    {
        public static Luggage[] CopenhagenLuggages { get; set; }
        public static Luggage[] TexasLuggages { get; set; }
        public static Luggage[] EgyptenLuggages { get; set; }

        public LuggageSorting()
        {
            CopenhagenLuggages = new Luggage[20];
            TexasLuggages = new Luggage[20];
            EgyptenLuggages = new Luggage[20];
        }

        public void LuggageDestinationSorting()
        {
            for (int i = 0; i < CheckIn.Luggages.Length; i++)
            {
                if (CheckIn.Luggages[i].Reservation.Destinations == Destinations.Copenhagen)
                {
                    CopenhagenLuggages[i] = new Luggage(CheckIn.Luggages[i].Reservation);
                    CheckIn.Luggages[i] = null;
                    Console.WriteLine($"Luggages has been sorted to {CopenhagenLuggages[i].Reservation.Destinations}");
                }
                else if (CheckIn.Luggages[i].Reservation.Destinations == Destinations.Texas)
                {
                    TexasLuggages[i] = new Luggage(CheckIn.Luggages[i].Reservation);
                    CheckIn.Luggages[i] = null;
                    Console.WriteLine($"Luggages has been sorted to {TexasLuggages[i].Reservation.Destinations}");
                }
                else if (CheckIn.Luggages[i].Reservation.Destinations == Destinations.Egypten)
                {
                    EgyptenLuggages[i] = new Luggage(CheckIn.Luggages[i].Reservation);
                    CheckIn.Luggages[i] = null;
                    Console.WriteLine($"Luggages has been sorted to {EgyptenLuggages[i].Reservation.Destinations}");
                }
            }
        }
    }
}
