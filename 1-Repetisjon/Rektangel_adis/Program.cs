using System;
using System.Collections.Generic;

namespace Rektangel
{
    class Program
    {
        static void Main(string[] args)
        {

            // object ro = new Rektangel();

            Rektangel r = new Rektangel(5, 10);

            Console.WriteLine("Rektangel: " + r.ToString());

            object o = r;

            Console.WriteLine("Rektangel: " + o.ToString());

            Sirkel s = new Sirkel(1);

            Console.WriteLine("Sirkel: " + s.ToString() + " har areal: " + s.Areal());

            I_Figur enFigur = new Rektangel(1, 2);

            Console.WriteLine("Figur: " + enFigur.ToString() + " har areal: " + enFigur.Areal());

            enFigur = s;

            Console.WriteLine("Figur: " + enFigur.ToString() + " har areal: " + enFigur.Areal());

            List<I_Figur> alleFigurer = new List<I_Figur>();

            int antall = 100;
            Random rand = new Random();


            for (int i = 0; i < antall; ++i)
            {

                if (rand.Next(0, 2) == 0) alleFigurer.Add(new Sirkel(rand.Next(-5, 10)));
                else
                {
                    Rektangel ro = new Rektangel(rand.Next(0, 10), rand.Next(0, 10));
                    alleFigurer.Add(ro);
                }

            }

            Console.WriteLine("\nUtskrift av listen: ");

            for (int i = 0; i < antall; ++i)
            {
                Console.WriteLine("Figur: " + alleFigurer[i].ToString() + " har areal: " + alleFigurer[i].Areal());
            }

            Console.WriteLine("\nUtskrift av listen (foreach): ");

            foreach(I_Figur fig in alleFigurer)
            {
                Console.WriteLine("Figur: " + fig.ToString() + " har areal: " + fig.Areal());
            }


            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.ReadKey(true);
        }

    }
}
