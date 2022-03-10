using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlaskeAutomaten
{
    public class Producer
    {
        Random random = new Random();
        public void RefillBuffer()
        {
            while (true)
            {
                lock (Manager.drinks)
                {
                    CheckIfRefillBufferIsFull();
                    GenerateDrinks();
                }
            }
        }
        private void GenerateDrinks()
        {
            for (int i = 0; i < Manager.drinks.Length; i++)
            {
                if (Manager.drinks[i] == null)
                {
                    Manager.drinks[i] = new Drink((Drinkvariety)random.Next(0, 2), random.Next(1, 10000));
                    Console.WriteLine($"Generated {Manager.drinks[i].Drinkvariety}");
                }
            }
            Monitor.PulseAll(Manager.drinks);
        }
        private void CheckIfRefillBufferIsFull()
        {
            if (Manager.drinks.Length == 10)
            {
                Console.WriteLine("Refill buffer is full");
                Monitor.Wait(Manager.drinks);
            }
        }
    }
}
