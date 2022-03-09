using System;
using System.Collections.Generic;
using System.Text;

namespace FlaskeAutomaten
{
    public class Producer
    {
        Queue<Drink> _drinks = new Queue<Drink>();
        Random random = new Random();
        public void Refill()
        {
            lock (_drinks)
            {
                foreach (Drink drink in _drinks)
                {
                    drink.Drinkvariety = Drinkvariety.øl;
                    _drinks.Enqueue(drink);
                    Console.WriteLine(drink.Drinkvariety);
                }
            }
        }
    }
}
