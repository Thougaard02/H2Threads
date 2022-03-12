using System;
using System.Collections.Generic;
using System.Text;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    public class Gates
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public LuggageSorting LuggageSorting { get; set; }
        public int CountGates { get; set; }
        public Gates[] gates { get; set; }

        public Gates(int id)
        {
            Id = id;
            IsOpen = false;
        }

        public void OpenTerminal()
        {
            for (int i = 0; i < 20; i++)
            {
                if (LuggageSorting.CopenhagenLuggages[i].Reservation != null)
                {
                    if (LuggageSorting.CopenhagenLuggages[i].Reservation.Destinations == Destinations.Copenhagen)
                    {
                        LuggageSorting.CopenhagenLuggages[i] = null;
                        Console.WriteLine("Copenhagen");
                    }
                }
                else if (LuggageSorting.TexasLuggages[i].Reservation != null)
                {
                    if (LuggageSorting.TexasLuggages[i].Reservation.Destinations == Destinations.Texas)
                    {
                        LuggageSorting.TexasLuggages[i] = null;
                        Console.WriteLine("Texas");
                    }
                }
                else if (LuggageSorting.EgyptenLuggages[i].Reservation != null)
                {
                    if (LuggageSorting.EgyptenLuggages[i].Reservation.Destinations == Destinations.Egypten)
                    {
                        LuggageSorting.EgyptenLuggages[i] = null;
                        Console.WriteLine("Egypten");
                    }
                }
            }
        }
    }
}
