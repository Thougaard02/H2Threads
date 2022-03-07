using System;
using System.Threading;

namespace ThreadSync
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            task1.TaskOne();
        }
    }
}
