using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Simulator
{
    class Program
    {
        static bool ferdig;
        static object sync;


        static void Main(string[] args)
        {
            ferdig = false;
            sync = new object();

            ThreadPool.QueueUserWorkItem(Tallgenerator);
            string innData;
            string utData;

            while(!ferdig)
            {
                // Monitor.Enter(sync);
                // Console.Write("Oppgi kommando: ");
                // innData = Console.ReadLine();
                // Monitor.Exit(sync);

                SkrivUt("Oppgi kommando: ");

                innData = "";
                bool inndataMotatt = false;
                while (!inndataMotatt)
                {
                    ConsoleKeyInfo tast = Console.ReadKey(true);
                    if (tast.Key == ConsoleKey.Enter)
                    {
                        inndataMotatt = true;
                        SkrivUt("\n");
                    }
                    else
                    {
                        innData += tast.KeyChar;
                        SkrivUt(tast.KeyChar.ToString());
                    }
                }




                if (innData == "") ferdig = true;
                else
                {
                    char[] charArray = innData.ToCharArray();
                    Array.Reverse(charArray);
                    utData = new string(charArray);

                    Monitor.Enter(sync);
                    Console.WriteLine("Svar: " + utData);
                    Console.WriteLine("Fortsett [trykk en tast]...");
                    Monitor.Exit(sync);

                    Console.ReadKey(true);

                    // Sletter tidligere data
                    Monitor.Enter(sync);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("                                                           ");
                    Console.WriteLine("                                                           ");
                    Console.WriteLine("                                                           ");
                    Console.SetCursorPosition(0, 0);
                    Monitor.Exit(sync);
                }
            }

        }

        private static void SkrivUt(string tekst)
        {
            Monitor.Enter(sync);
            Console.Write(tekst);
            Monitor.Exit(sync);
        }

        static void Tallgenerator(object o)
        {
            Random r = new Random();
            int data;

            while(!ferdig)
            {
                Thread.Sleep(1000);
                data = r.Next(10, 100);

                VisData(data);

            }
        }

        private static void VisData(int tall)
        {
            Monitor.Enter(sync);
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            Console.SetCursorPosition(10, 10);
            Console.Write("Sensordata: {0}", tall);

            Console.SetCursorPosition(x, y);
            Monitor.Exit(sync);
        }
    }
}
