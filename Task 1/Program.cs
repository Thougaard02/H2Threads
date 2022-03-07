using System;
using System.Diagnostics;
using System.Threading;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Process);

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution");
            
            stopwatch.Start();
            ProcessWithThreadMethod();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is: " + stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();

            Console.WriteLine("Thread Execution");
            stopwatch.Start();
            ProcessWithThreadPoolMethod();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is: " + stopwatch.ElapsedTicks.ToString());
        }

        static void Process(object callback)
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                }
            }
        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
