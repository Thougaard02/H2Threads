using System;
using System.Threading;
using static Bagagesorteringssystem.CentralServer;

namespace Bagagesorteringssystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralServer centralServer = new CentralServer();


            Thread threadCheckIn = new Thread(centralServer.MonitorCheckIn);
            Thread threadLuggageSorting = new Thread(centralServer.MonitorLuggageSorting);
            Thread threadTerminal = new Thread(centralServer.MonitorTerminal);

            threadCheckIn.Start();
            threadLuggageSorting.Start();
            threadTerminal.Start();

            threadCheckIn.Join();
            threadLuggageSorting.Join();
            threadTerminal.Join();
        }
    }
}
