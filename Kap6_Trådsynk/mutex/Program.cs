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
        public static Mutex m1;
        public static Mutex m2;

        static void Main(string[] args)
        {
            Mutex m1 = new Mutex();

            // i P1: m1 = new Mutex(false, "mitt-sync-objekt")
            // i P2: Mutex.OpenExisting("mitt-sync.objekt")

            Mutex m2 = new Mutex();

            r = new Random();

            ThreadPool.QueueUserWorkItem(UtskriftH);
            ThreadPool.QueueUserWorkItem(UtskriftB);
            ThreadPool.QueueUserWorkItem(UtskriftB);
            ThreadPool.QueueUserWorkItem(UtskriftS);

            Console.ReadKey();
        }

        static void UtskriftB(object o)
        {
            m1.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(r.Next(500, 1001));
                Console.Write((char)(((int)'a') + i));
            }
            m1.ReleaseMutex();
        }

        static void UtskriftS(object o)
        {
            m1.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(r.Next(500, 1001));
                Console.Write(i);
            }
            m1.ReleaseMutex();
        }

        static void UtskriftH(object o)
        {
            m1.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(r.Next(2000, 3001));
                Console.Write('#');
            }
            m1.ReleaseMutex();
        }
    }
}
