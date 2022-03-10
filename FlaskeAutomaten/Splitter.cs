using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FlaskeAutomaten
{
    public class Splitter
    {
        public static Drink[] øl = new Drink[10];
        public static Drink[] vand = new Drink[10];

        public void SplitDrinks()
        {
            while (true)
            {
                lock (Manager.drinks)
                {
                    CheckIfSplitterIsEmpty();
                    SortDrinks();
                }
            }
        }

        private void CheckIfSplitterIsEmpty()
        {
            if (Manager.drinks.Length == 0)
            {
                Console.WriteLine("Splitter is empty");
                Monitor.Wait(Manager.drinks);
            }
        }

        private void SortDrinks()
        {
            for (int i = 0; i < Manager.drinks.Length; i++)
            {
                if (Manager.drinks[i] != null)
                {
                    if (Manager.drinks[i].Drinkvariety == Drinkvariety.øl)
                    {
                        øl[i] = Manager.drinks[i];
                        Manager.drinks[i] = null;
                        Console.WriteLine($"{øl[i].Drinkvariety} has been sorted");
                    }
                    else if (Manager.drinks[i].Drinkvariety == Drinkvariety.vand)
                    {
                        vand[i] = Manager.drinks[i];
                        Manager.drinks[i] = null;
                        Console.WriteLine($"{vand[i].Drinkvariety} has been sorted");
                    }
                }
            }
            Monitor.PulseAll(Manager.drinks);
        }


    }
}
