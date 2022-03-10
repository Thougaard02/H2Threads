using System;
using System.Threading;

namespace FlaskeAutomaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            Thread producerThread = new Thread(manager.Refill);
            Thread splitterThread = new Thread(manager.SplitDrinks);
            Thread transportThread = new Thread(manager.TransportDrinks);

            producerThread.Start();
            splitterThread.Start();
            transportThread.Start();

            producerThread.Join();
            splitterThread.Join();
            transportThread.Join();

        }
    }
}
