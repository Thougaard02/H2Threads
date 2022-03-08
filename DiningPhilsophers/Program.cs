using System;
using System.Threading;

namespace DiningPhilsophers
{
    class Program
    {
        static void Main(string[] args) 
        {
            Philosopher[] philosophers = new Philosopher[5];

            for (int i = 0; i < philosophers.Length; i++)
            {
                philosophers[i] = new Philosopher(i);
                Thread thread = new Thread(philosophers[i].TakeFork);
                thread.Start();
                //thread.Join();
            }
            Console.ReadKey();
        }
    }
}
