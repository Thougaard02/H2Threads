using System;
using System.Threading;

namespace ThreadLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Threprog tp = new Threprog();
            //Opgave 0-2
            //Thread thread = new Thread(tp.WorkThreadFunction);
            //thread.Name = "WorkTheadFunction";
            //thread.Start();
            //Thread.Sleep(1000);

            //Thread thread1 = new Thread(tp.WorkThreadFunctionSecond);
            //thread1.Name = "WorkTheadFunctionSecond";
            //thread1.Start();

            //Opgave 3
            Thread CalTemp = new Thread(tp.GenerateTemp);
            CalTemp.Start();
            CalTemp.Join();
            if (!CalTemp.IsAlive)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Alarm-tråd termineret!");
            }


            //Opgave 4
            //Thread printer = new Thread(tp.Printer);
            //printer.Start();

            //Thread reader = new Thread(tp.Reader);
            //reader.Start();
        }
    }
}
