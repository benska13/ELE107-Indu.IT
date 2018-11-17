using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace O6
{
    class Program
    {
        static bool ferdig;

        static void Main(string[] args)
        {
            ferdig = false;
            Thread ht1 = new Thread(new ParameterizedThreadStart(MPAdmin));
            // ht1.IsBackground = true;

            /* Klargjør argumenter */
            int ventetid = 2000;
            Random r = new Random();
            List<object> argumenter = new List<object>();
            argumenter.Add((object)ventetid);
            argumenter.Add(r);

            ht1.Start(argumenter);



            for (int i = 0; i < 26; i++)
            {
                char tegn = (char)(((int)'a') + i);
                Console.Write(tegn);
                Thread.Sleep(200);
            }

            ferdig = true;
            Console.ReadKey();
        }

        static void MPAdmin(object o)
        {
            List<object> argumenter = o as List<object>;
            int v = (int)(argumenter[0]);
            Random r = argumenter[1] as Random;

            while (!ferdig)
            {
                Console.SetCursorPosition(r.Next(0, 80), r.Next(0, 20));
                Thread.Sleep(v);
            }

        }
    }
}
