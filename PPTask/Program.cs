using System;
using System.Threading;

namespace PPTask
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5000];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(AddOne);
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine(sum);
        }

        static void AddOne()
        {
            Interlocked.Increment(ref sum);
        }
    }
}
