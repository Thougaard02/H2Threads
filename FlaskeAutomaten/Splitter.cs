using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FlaskeAutomaten
{
    public class Splitter
    {
        public static Drink[] øl = new Drink[100];
        public static Drink[] vand = new Drink[100];

        public void SplitDrinks(Drink[] drinks)
        {
            while (true)
            {
                lock (drinks)
                {
                    CheckIfSplitterIsEmpty(drinks);
                    SortDrinks(drinks);
                }
            }
        }

        private void CheckIfSplitterIsEmpty(Drink[] drinks)
        {
            if (drinks.Length == 0)
            {
                Monitor.Wait(drinks);
                Console.WriteLine("Splitter is empty");
            }
        }

        private void SortDrinks(Drink[] drinks)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] != null)
                {
                    if (drinks[i].Drinkvariety == Drinkvariety.øl)
                    {
                        øl[i] = drinks[i];
                        Console.WriteLine(øl[i]);
                        //drinks[i] = null;
                        Console.WriteLine($"{øl[i].Drinkvariety} has been sorted");
                    }
                    else if (drinks[i].Drinkvariety == Drinkvariety.vand)
                    {
                        vand[i] = drinks[i];
                        Console.WriteLine(vand[i]);
                        //drinks[i] = null;
                        Console.WriteLine($"{vand[i].Drinkvariety} has been sorted");
                    }
                }
            }
            Monitor.PulseAll(drinks);
        }
    }
}
