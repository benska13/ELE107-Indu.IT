using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace O2
{
    class Program
    {
        static Semaphore s;
             
        static void Main(string[] args)
        {
            Random r = new Random();
            s = new Semaphore(2, 8);


            for(int i = 0; i < 8; ++i)
            {
                ThreadPool.QueueUserWorkItem(Utskrift, (object)r.Next(1000, 3001));
            }

            Thread.Sleep(10000);
            s.Release(6);

            Console.ReadKey(true);
        }

        static void Utskrift(object o)
        {
            int ventetid = (int)o;

            s.WaitOne();
            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(ventetid);
                Console.Write((char)(((int)'a') + i));
            }
            s.Release();

        }
    }
}


