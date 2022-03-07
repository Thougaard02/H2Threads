using System;
using System.Threading;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tpd = new Tasks();

            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(tpd.Task1);
                ThreadPool.QueueUserWorkItem(tpd.Task2);

            }
            Console.Read();
        }
    }
}
