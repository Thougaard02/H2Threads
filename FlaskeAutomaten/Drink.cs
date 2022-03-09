using System;
using System.Collections.Generic;
using System.Text;

namespace FlaskeAutomaten
{
    public enum Drinkvariety
    {
        øl,
        vand
    }
    public class Drink
    {
        public Drinkvariety Drinkvariety { get; set; }
        public int DrinkNumber { get; set; }

        public Drink(Drinkvariety variety, int drinkNumber)
        {
            Drinkvariety = variety;
            DrinkNumber = drinkNumber;
        }
    }
}
