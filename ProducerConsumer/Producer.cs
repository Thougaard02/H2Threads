using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProducerConsumer
{
    public class Producer
    {
        public void RefillProducts()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Adds products to array");
                    Product.Products[i] = new Product("John");
                }
                Monitor.PulseAll(this);

                while (Product.Products.Length >= 10)
                {
                    Console.WriteLine(Product.Products.Length);
                    Console.WriteLine("Producer waits");
                    Monitor.Wait(this);
                }
            }
        }
    }
}
