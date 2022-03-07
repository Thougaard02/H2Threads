using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadSync
{
    class Task1
    {
        static int sum;
        static object _lock = new object();
        public void TaskOne()
        {
            while (true)
            {
                Thread threadAddOne = new Thread(AddOne);
                Thread threadSubOne = new Thread(SubOne);
                threadAddOne.Start();
                threadSubOne.Start();
            }

        }
        void AddOne()
        {
            Monitor.Enter(_lock);
            try
            {
                sum++;
                Thread.Sleep(1000);
                Console.WriteLine(sum);
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
        void SubOne()
        {
            Monitor.Enter(_lock);
            try
            {
                sum = sum - 1;
                Thread.Sleep(1000);
                Console.WriteLine(sum);
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
    }
}
