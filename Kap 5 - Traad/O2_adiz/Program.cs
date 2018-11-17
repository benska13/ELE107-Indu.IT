using System;
using System.Threading;

namespace O2_adiz
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Foo_A);
            ThreadPool.QueueUserWorkItem(Foo_B);

            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.ReadKey(true);
        }

        static void Foo_A(object o)
        {
            for (int i = 0; i < 1000; ++i)
            {
                Console.Write('a');
            }
        }

        static void Foo_B(object o)
        {
            for (int i = 0; i < 1000; ++i)
            {
                Console.Write('b');
            }
        }

    }
}
