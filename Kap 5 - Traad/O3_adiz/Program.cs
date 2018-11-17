using System;
using System.Threading;

namespace O4_adiz
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Bokstav, 'a');
            ThreadPool.QueueUserWorkItem(Bokstav, 'b');
            ThreadPool.QueueUserWorkItem(Bokstav, 'c');

            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.ReadKey(true);
        }

        static void Bokstav(object o)
        {
            char tegn = (char)o;

            for (int i = 0; i < 1000; ++i)
            {
                Console.Write(tegn);
            }
        }

    }
}
