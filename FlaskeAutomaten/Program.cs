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
            Thread TruckTransportØlThread = new Thread(manager.TransferØl);
            Thread TruckTransportVandThread = new Thread(manager.TransferVand);

            producerThread.Start();
            splitterThread.Start();
            //TruckTransportØlThread.Start();
            //TruckTransportVandThread.Start();

            producerThread.Join();
            splitterThread.Join();
            //TruckTransportØlThread.Join();
            //TruckTransportVandThread.Join();
        }
    }
}
