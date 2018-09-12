using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Figur
{
    class Program
    {
        static void Main(string[] args)
        {
            var listFigur = new List<IFigur>();
            Random random=new Random();
            const int antall = 50;

            for (int i = 0; i < antall; i++)
            {
                switch (random.Next(4))
                {
                    case 1: 
                        listFigur.Add(new Frikant("Grønn",2,3 ));
                        break;
                    case 2:
                        listFigur.Add(new Sirkel("Blå",1));
                        break;
                    case 3:
                        listFigur.Add(new Trekant("Gul", 4, 5));
                        break;
                    default:
                        listFigur.Add(null);
                        break;
                }

            }
            foreach (var ithem in listFigur)
            {
                Console.WriteLine(ithem);
            }

            Console.WriteLine("SIRKLER");

            foreach (var ithem in listFigur)
            {
                if (ithem is Sirkel)
                {
                    Console.WriteLine(ithem);
                }
            }

            Console.ReadKey();
        }
    }
}
