using System;
using System.Collections.Generic;
using System.Text;

namespace ProducerConsumer
{
    public class Product2
    {
        static Product2[] products = new Product2[10];
        public string Name { get; set; }
        public int Price { get; set; }

        public void Fill()
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].Name = "John";
            }
        }
    }
}
