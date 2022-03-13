using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    public class Gates
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public int CountGates { get; set; }
        public LuggageSorting LuggageSorting { get; set; }
        public Gates(int id)
        {
            Id = id;
            IsOpen = false;
        }

        public void OpenTerminal()
        {
            while (LuggageSorting.CopenhagenLuggages.Length == 0 && LuggageSorting.TexasLuggages.Length == 0 && LuggageSorting.EgyptenLuggages.Length == 0)
            {
                Monitor.Wait(_lock);
                Console.WriteLine("Waits on luggages in terminal");
            }
            if (IsOpen)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (LuggageSorting.CopenhagenLuggages[i] != null)
                    {
                        LuggageSorting.CopenhagenLuggages[i] = null;
                        Console.WriteLine("Copenhagen");
                    }
                    else if (LuggageSorting.TexasLuggages[i] != null)
                    {
                        LuggageSorting.TexasLuggages[i] = null;
                        Console.WriteLine("Texas");
                    }
                    else if (LuggageSorting.EgyptenLuggages[i] != null)
                    {
                        LuggageSorting.EgyptenLuggages[i] = null;
                        Console.WriteLine("Egypten");
                    }
                }
            }
            //Monitor.PulseAll(_lock);
        }
    }
}