using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace O1_adiz

{
    class Program
    {

        static bool ferdig;

        static void Main(string[] args)
        {
            ferdig = false;

            ThreadStart ts = new ThreadStart(BeeperMetode);
            Thread hjelpetraad = new Thread(ts);
            // hjelpetraad.IsBackground = true; // - dersom ønskelig
            hjelpetraad.Start();

            Thread hjelpetraad2 = new Thread(BeeperMetode2);
            hjelpetraad2.Start();

            ThreadPool.QueueUserWorkItem(BeeperMetode3);

            while (!ferdig)
            {
                Console.Write("Oppgi en streng (tom streng avslutter programmet): ");
                string data = Console.ReadLine();
                Console.WriteLine("Du har oppgitt: " + data);
                if (data == "") ferdig = true;
            }

            Console.WriteLine("Venter på at hjelpetrådene avslutter ...");
            hjelpetraad.Join(); // main venter på at hjelpetraad har avsluttet
            hjelpetraad2.Join(); // main venter på at hjelpetraad2 har avsluttet
            Console.WriteLine("Hjelpetrådene 1 og 2 har avsluttet!");

            Console.ReadKey(true);


        }

        static void BeeperMetode()
        {
            while (!ferdig)
            {
                Console.Beep(800, 200);
                Console.Beep(1200, 200);
                Console.Beep(1500, 200);
                Thread.Sleep(2000);
            }
        }

        static void BeeperMetode2()
        {
            while (!ferdig)
            {
                Console.Beep(1000, 300);
                Console.Beep(1400, 300);
                Console.Beep(1800, 300);
                Thread.Sleep(3000);
            }
        }

        static void BeeperMetode3(object o)
        {
            while (!ferdig)
            {
                Console.Beep(1100, 100);
                Console.Beep(1350, 100);
                Console.Beep(1600, 100);
                Thread.Sleep(3000);
            }
        }

    }
}


