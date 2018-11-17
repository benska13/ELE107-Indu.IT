using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trådsynkronisering
{
    class Program
    {
        private static Random r;
        private static object sync;
        private static object sync2;
        static void Main(string[] args)
        {
            sync = new object();
            sync2 = new object();
            r = new Random();
            ThreadPool.QueueUserWorkItem(UtskriftB);
            ThreadPool.QueueUserWorkItem(UtskriftB);
            ThreadPool.QueueUserWorkItem(UtskriftS);

            ThreadPool.QueueUserWorkItem(UtskriftH);

            Console.ReadKey();

        }

        static void UtskriftB(object o)
        {
            //Monitor.Enter(sync);
            lock (sync)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(r.Next(500, 1001));
                    Console.Write((char)(((int)'a') + i));
                }
            }

            //Monitor.Exit(sync);
        }
        static void UtskriftS(object o)
        {
            lock (sync2)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(r.Next(500, 1001));
                    Console.Write(i);
                }
            }
        }
        static void UtskriftH(object o)
        {
            lock (sync)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(r.Next(2000, 3001));
                    Console.Write('#');
                }
            }
        }
    }
}
