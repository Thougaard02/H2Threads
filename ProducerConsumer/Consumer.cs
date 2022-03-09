using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProducerConsumer
{
    public class Consumer
    {
        public void GetProducts()
        {
            lock (this)
            {
                while (Product.Products.Length <= 0)
                {
                    Console.WriteLine("Consumer waits");
                    Monitor.Wait(this);
                }
                for (int i = 0; i < Product.Products.Length; i++)
                {
                    Product.Products = Product.Products.Where((source, index) => index != i).ToArray();
                    Console.WriteLine("Consumer clearing array");
                    Console.WriteLine(Product.Products.Count());
                }
                Monitor.PulseAll(this);
            }
        }
    }
}
