using System;
using System.Linq;
using System.Threading;

namespace ProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer producer = new Producer();
            Consumer consumer = new Consumer();

            while (true)
            {
                Thread threadProducer = new Thread(producer.RefillProducts);
                Thread threadConsumer = new Thread(consumer.GetProducts);

                threadProducer.Start();
                threadConsumer.Start();
            }
        }
    }
}
