using System;
using System.Collections.Generic;
using System.Threading;
namespace Oppgave_4
{
    class Program
    {
        static List<int> tallsamling = new List<int>();
        static bool ferdig = false;
        static Random r = new Random();
        // Eventuelle andre deklarasjoner:
        // ...
        static void Main(string[] args)
        {
            while (!ferdig)
            {
                // Main skal vente her til den blir varslet om at listen
                // "tallsamling" skal skrives ut
                // ...
                string s = "Tall i listen for øyeblikket: ";
                foreach (int i in tallsamling)
                {
                    s = s + i.ToString() + " ";
                }
                UtskriftFraEnTraad(s);
                UtskriftFraEnTraad("Fjerner alle tall!");
                tallsamling.Clear();
            } // av while
            UtskriftFraEnTraad("Avslutter!");
        }
        static void TallTyv(object o)
        {
            while (!ferdig)
            {
                Thread.Sleep(5000);
                int tall = r.Next(0, 2); // 0 <= tall < 2
                if (tall == 0) // 50 % sjense for sant
                {
                    bool tallsamlingIkkeErTom = (tallsamling.Count > 0);
                    int tallSomSkalFjernes = -1;
                    if (tallsamlingIkkeErTom)
                    {
                        int indeks = r.Next(0, tallsamling.Count);
                        tallSomSkalFjernes = tallsamling[indeks];
                        tallsamling.RemoveAt(indeks);
                    }
                    if (tallSomSkalFjernes != -1)
                    {
                        UtskriftFraEnTraad("Tall " + tallSomSkalFjernes + " fjernet!");
                    }
                }
                // ellers skjer det ingenting
                
            } // av while
            UtskriftFraEnTraad("Avslutter!");
        }
        static void TallGenerator(object o)
        {
            int ventetid;
            int antallGenereteTall = 0;
            while (!ferdig)
            {
                ventetid = r.Next(1000, 5001);
                Thread.Sleep(ventetid);
                int tall = r.Next(0, 10);
                tallsamling.Add(tall);
                antallGenereteTall++;
                UtskriftFraEnTraad("Tall " + tall + " lagt til!");
                if (antallGenereteTall > 4)
                {
                    // Varsle main om at "tall"-innhold skal skrives ut
                    // ...
                    antallGenereteTall = 0;
                }
            } // av while
            UtskriftFraEnTraad("Avslutter!");
        }
        static void ConsoleInput(object o)
        {
            while (!ferdig)
            {
                int tegn = Console.ReadKey(true).KeyChar;
                if ((tegn == 'f') || (tegn == 'F'))
                {
                    ferdig = true;
                    UtskriftFraEnTraad("Avslutter programmet - sekvensen startet!");
                }
            }
        }
        static void UtskriftFraEnTraad(string s)
        {
            Console.Write("Traad {0:D2}: ", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(s);
        }
    }
}