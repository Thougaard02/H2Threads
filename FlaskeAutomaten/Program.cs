using System;

namespace FlaskeAutomaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer producer = new Producer();

            producer.Refill();
            Console.ReadKey();
        }
    }
}
