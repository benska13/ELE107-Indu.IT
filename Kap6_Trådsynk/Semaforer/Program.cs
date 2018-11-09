using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semaforer
{
    class Program
    {
        private static Semaphore s;
        private static Random r;
        static void Main(string[] args)
        {
            s=new Semaphore(2,8);
            r=new Random();
            for (int i = 0; i < 8; i++)
            {
                ThreadPool.QueueUserWorkItem(Utskrift, r.Next(1000, 3001));
            }
            Thread.Sleep(10000);
            s.Release(6);


            Console.ReadKey();
        }

        private static void Utskrift(object state)
        {
            int ventetid = (int) state;

            s.WaitOne();
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(ventetid);
                Console.Write((char)(((int)'a')+i));
            }

            s.Release();
        }
    }
}
