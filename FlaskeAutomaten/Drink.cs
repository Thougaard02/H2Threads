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
    class Drink
    {
        public Drinkvariety Drinkvariety { get; set; }
        static Queue<Drink> _drinks = new Queue<Drink>();

        public Drink(Drinkvariety variety)
        {
            Drinkvariety = variety;
        }
    }
}
