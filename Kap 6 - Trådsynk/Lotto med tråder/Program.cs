using System;
using System.Collections.Generic;
using System.Threading;

namespace Lotto_med_tråder
{
    class Program
    {
        static Random r = new Random();
        static List<int> alleTall = new List<int>();
        static int[] tallRekke = new int[ANTALL_TRAADER];
        private const int ANTALL_TRAADER = 7;

        static EventWaitHandle[] etab=new EventWaitHandle[ANTALL_TRAADER ];

        static void Main(string[] args)
        {
            for (int i = 1; i < 35; i++)
            {
                alleTall.Add(i);
            }

            for (int i = 0; i < ANTALL_TRAADER; i++)
            {
                etab[i]= new EventWaitHandle(false, EventResetMode.AutoReset);
            }

            for (int i = 0; i < ANTALL_TRAADER; i++)
            {
                ThreadPool.QueueUserWorkItem(LottoTall, i);
            }
            //WaitHandle.WaitAll()


           // Console.ReadKey();
            WaitHandle.WaitAll(etab);

            Console.WriteLine("\n\n følgende tall ble trukket: ");
            Array.Sort(tallRekke);
            foreach (int i in tallRekke)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        static void LottoTall(object o)
        {
            Thread.Sleep(r.Next(1000, 5001));

            Monitor.Enter(r);
            int posisjon = r.Next(0, alleTall.Count);
            int tallTrukket = alleTall[posisjon];
            alleTall.RemoveAt(posisjon);
            Monitor.Exit(r);

            int rekkePosisjon = (int)o;
            tallRekke[rekkePosisjon] = tallTrukket;

            etab[rekkePosisjon].Set(); // åpner dør

            Console.WriteLine("Tråd {0} er ferdig med arbeidet. \nTall generert: {1}",
                Thread.CurrentThread.ManagedThreadId, tallTrukket);
        }
    }
}
