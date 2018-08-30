using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rektangel
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface
            object ro = new Rektangel();

            Rektangel r = new Rektangel(5, 10);
            Console.WriteLine("Rektangel: " + r.ToString());

            object o = r;

            Sirkel s = new Sirkel(1);
            Console.WriteLine("sirkel" + s.ToString() + "har areal " + s.Areal());

            IFigur enFigur = new Rektangel(1, 2);

            Console.WriteLine("Figur: " + enFigur.ToString() + " har areal: " + enFigur.Areal());

            List<IFigur> alleFigurer = new List<IFigur>();

            int antall = 20;
            Random random = new Random();
            for (int i = 0; i < antall; i++)
            {
                if (random.Next(0, 2) == 0)
                {
                    alleFigurer.Add(new Sirkel(random.Next(0, 10)));
                }
                else
                {
                    Rektangel roRektangel = new Rektangel(random.Next(0, 10), random.Next(0, 20));
                    alleFigurer.Add(roRektangel);
                }
            }

            for (int i = 0; i < antall; i++)
            {
                Console.WriteLine("Figur: " + alleFigurer[i].ToString() + " har areal: " + alleFigurer[i].Areal());
            }

            Console.WriteLine("\n\n\n");
            foreach (var x in alleFigurer)
            {
                Console.WriteLine("Figur: " + x.ToString() + " har areal: " + x.Areal());
            }

            Console.WriteLine("trykk en tast...");
            Console.ReadKey(true);
        }



    }

    class Sirkel : IFigur
    {
        private int _radius;

        public int Radius
        {
            get => _radius;
            set
            {
                if (value < 0) _radius = 0;
                else _radius = value;
            }
        }

        public Sirkel()
        {
            Radius = 0;
        }

        public double Areal()
        {
            return Radius * Radius * Math.PI;
        }
        public Sirkel(int radius)
        {
            this.Radius = radius;
        }

        public override string ToString()
        {
            return "(" + Radius + ")";
        }
    }
}
