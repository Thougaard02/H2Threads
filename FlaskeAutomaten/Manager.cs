using System;
using System.Collections.Generic;
using System.Text;

namespace FlaskeAutomaten
{
    public class Manager
    {
        Producer producer = new Producer();
        Splitter splitter = new Splitter();
        Drink[] drinks = new Drink[100];
        Truck Truck = new Truck();

        public void Refill()
        {
            producer.RefillBuffer(drinks);
        }

        public void SplitDrinks()
        {
            splitter.SplitDrinks(drinks);
        }

        public void TransferØl()
        {
            Truck.TransferØl();
        }

        public void TransferVand()
        {
            Truck.TransferVand();
        }


    }
}
