using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLearning
{
    public class Threprog
    {
        //Opgave 0-2
        public void WorkThreadFunction()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde …");
            }
        }

        public void WorkThreadFunctionSecond()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }

        //Opgave 3

        private int countWarning;
        public void GenerateTemp()
        {
            Random random = new Random();
            while (true)
            {
                int temp = random.Next(-20, 120);

                Console.WriteLine($"Celsius: {temp}");
                Console.WriteLine($"Warning Count: {countWarning}");
                if (countWarning >= 3)
                {
                    break;
                }
                if (temp < 0 || temp > 100)
                {
                    Console.WriteLine("Warning!");
                    countWarning++;
                }
                Thread.Sleep(1000);
            }
        }

        //

        private char ch;
        public void Printer()
        {
            ch = '*';
            while (true)
            {
                Console.Write(this.ch);
                Thread.Sleep(100);
            }
        }
        public void Reader()
        {
            while (true)
            {

                bool isChar = char.TryParse(Console.ReadLine(), out this.ch);
                if (isChar == false)
                {
                    ch = '*';
                }
            }
        }
    }
}
