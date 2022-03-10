using System;
using System.Collections.Generic;
using System.Text;

namespace FlaskeAutomaten
{
    public class Manager
    {
        Producer producer = new Producer();
        Splitter splitter = new Splitter();
        public static Drink[] drinks = new Drink[10];
        Truck Truck = new Truck();
        public void Refill()
        {
            producer.RefillBuffer();
        }

        public void SplitDrinks()
        {
            splitter.SplitDrinks();
        }
        public void TransportDrinks()
        {
            Truck.TransportDrinks();
        }
    }
}
