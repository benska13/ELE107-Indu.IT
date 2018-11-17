using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace O2
{
    class Program
    {
        static Random r;
        static Mutex m1;
        static Mutex m2;
        static void Main(string[] args)
        {
            m1 = new Mutex();
            // i P1: m1 = new Mutex(false, "mitt-sync-objekt");
            // i P2: Mutex.OpenExisting("mitt-sync-objekt");

            m2 = new Mutex();
            r = new Random();

            ThreadPool.QueueUserWorkItem(Utskrift_B);
            ThreadPool.QueueUserWorkItem(Utskrift_B);
            ThreadPool.QueueUserWorkItem(Utskrift_S);
            ThreadPool.QueueUserWorkItem(Utskrift_H);

            Console.ReadKey(true);
        }

        static void Utskrift_B(object o)
        {
            m1.WaitOne();

            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(r.Next(500, 1001));
                Console.Write((char)(((int)'a') + i));
            }

            m1.ReleaseMutex();
        }

        static void Utskrift_S(object o)
        {
            m1.WaitOne();

            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(r.Next(500, 1001));
                Console.Write(i);
            }

            m1.ReleaseMutex();
        }

        static void Utskrift_H(object o)
        {
            m2.WaitOne();

            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(r.Next(2000, 3001));
                Console.Write('#');
            }

            m2.ReleaseMutex();
        }
    }
}

