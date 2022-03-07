using System;
using System.Threading;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadOutput thread = new ThreadOutput();

            Thread star = new Thread(thread.PrintStar);
            Thread hashtag = new Thread(thread.PrintHashTag);

            star.Start();
            hashtag.Start();

            star.Join();
            hashtag.Join();
        }
    }
}
