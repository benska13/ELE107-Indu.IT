using System;
using System.Threading;

namespace Test_av_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread traad= new Thread(Metoden);

            Console.ReadKey();
            traad.Start();

            ThreadStart ts = new ThreadStart(Metoden);
            
            Thread ht =new Thread(ts);
                    
            Console.WriteLine("MAin ferdig");
        }

        private static void Metoden()
        {
            while (true)
            {
                Console.WriteLine("hello");
                Thread.Sleep(500);
            }
        }
    }
}
