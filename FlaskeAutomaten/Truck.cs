using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlaskeAutomaten
{
    public class Truck
    {
        public void TransferØl()
        {

            for (int i = 0; i < Splitter.øl.Length; i++)
            {
                if (Splitter.øl[i] != null)
                {
                    Splitter.øl[i] = null;
                    Console.WriteLine("Øl is being transported");
                }
            }
            Monitor.PulseAll(Manager.drinks);
        }

        public void TransferVand()
        {
            for (int i = 0; i < Splitter.vand.Length; i++)
            {
                if (Splitter.vand[i] != null)
                {
                    Splitter.vand[i] = null;
                    Console.WriteLine("Vand is being transported");
                }
            }
            Monitor.PulseAll(Manager.drinks);
        }

        public void TransportDrinks()
        {
            while (true)
            {
                lock (Manager.drinks)
                {
                    TransferØl();
                    TransferVand();
                }
            }
        }
    }
}
