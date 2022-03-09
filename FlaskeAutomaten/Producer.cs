using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlaskeAutomaten
{
    public class Producer
    {
        Random random = new Random();
        public void RefillBuffer(Drink[] drinks)
        {
            while (true)
            {
                lock (drinks)
                {
                    CheckIfRefillBufferIsFull(drinks);
                    GenerateDrinks(drinks);
                }
            }
        }
        private void GenerateDrinks(Drink[] drinks)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] == null)
                {
                    drinks[i] = new Drink((Drinkvariety)random.Next(0, 2), random.Next(1, 10000));
                    Console.WriteLine($"Generated {drinks[i].Drinkvariety}");
                }
            }
            Monitor.PulseAll(drinks);
        }
        private void CheckIfRefillBufferIsFull(Drink[] drinks)
        {
            if (drinks.Length == 100)
            {
                Console.WriteLine("Refill buffer is full");
                Monitor.Wait(drinks);
            }
        }
    }
}
