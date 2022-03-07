using System;
using System.Threading;

namespace Opgave2
{
    public class ThreadOutput
    {
        static int linesum;
        static object _lock = new object();
        public void PrintStar()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(_lock);
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write("*");
                        Interlocked.Increment(ref linesum);
                    }
                    Console.Write($" {linesum}\n");
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
                Thread.Sleep(1000);
            }
        }

        public void PrintHashTag()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(_lock);
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write("#");
                        Interlocked.Increment(ref linesum);
                    }
                    Console.Write($" {linesum}\n");
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
                Thread.Sleep(1000);
            }
        }
    }
}