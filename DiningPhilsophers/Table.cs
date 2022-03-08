using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DiningPhilsophers
{
    class Table
    {
        private Fork[] Forks { get; set; }
        public Philosopher[] Philosophers { get; set; }
        public Table()
        {
            Philosophers = new Philosopher[5];
            Forks = new Fork[5];
        }
        public void GenerateForks()
        {
            for (int i = 0; i < Forks.Length; i++)
            {
                Forks[i] = new Fork();
            }
        }
        public void GeneratePhilosophers()
        {
            for (int i = 0; i < Philosophers.Length; i++)
            {
                Philosophers[i] = new Philosopher(i, Forks);
            }
        }
    }
}
