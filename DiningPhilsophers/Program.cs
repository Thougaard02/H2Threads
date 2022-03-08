using System;
using System.Threading;

namespace DiningPhilsophers
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            table.GenerateForks();
            table.GeneratePhilosophers();

            for (int i = 0; i < table.Philosophers.Length; i++)
            {
                Thread thread = new Thread(table.Philosophers[i].PhilsofBeginEating);
                thread.Start();
            }
        }
    }
}
