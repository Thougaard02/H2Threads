using System;
using System.Collections.Generic;
using System.Text;

namespace ProducerConsumer
{
    public class Product
    {
        public static Product[] Products = new Product[10];
        public string Name { get; set; }
        public Product(string name)
        {
            Name = name;
        }
    }
}
