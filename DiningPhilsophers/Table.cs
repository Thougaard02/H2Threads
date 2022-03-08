using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilsophers
{
    class Table
    {
        public static Fork[] Forks { get; set; }
        public Philosopher[] Philosophers { get; set; }
        public Table()
        {
            Philosophers = new Philosopher[5];
            Forks = new Fork[5];
        }
    }
}
