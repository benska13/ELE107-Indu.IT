using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeibomLib;

namespace Veibom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ferdig = false;
            VeibomTM vbTM = new VeibomTM(5);
            List<Aksjon> aksjonerSomSkalUtfores;

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("---------------");
            Console.WriteLine("       |       ");
            Console.WriteLine("       |       ");
            Console.WriteLine("---------------");
            Console.WriteLine("Myntretur: ");
            Console.SetCursorPosition(0, 0);

            while (!ferdig) // while (ferdig == false)
            {
                VisValgmenyet();

                int valg;
                try
                {
                    valg = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    valg = 0;
                }

                switch (valg)
                {
                    case 1:
                        aksjonerSomSkalUtfores = vbTM.HaandterHendelse(Hendelse.Kr1);
                        UtforAksjoner(aksjonerSomSkalUtfores);
                        break;
                    case 2:
                        aksjonerSomSkalUtfores = vbTM.HaandterHendelse(Hendelse.Kr5);
                        UtforAksjoner(aksjonerSomSkalUtfores);
                        break;
                    case 3:
                        aksjonerSomSkalUtfores = vbTM.HaandterHendelse(Hendelse.Passering);
                        UtforAksjoner(aksjonerSomSkalUtfores);
                        break;
                    case 4:
                        Console.WriteLine("Avslutter programmet ... ");
                        ferdig = true;
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg!");
                        break;
                }
                Console.WriteLine("Trykk en tast for å fortsette ... ");
                Console.ReadKey(true);
            }

        }

        private static void UtforAksjoner(List<Aksjon> aksjonerSomSkalUtfores)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            while(aksjonerSomSkalUtfores.Count > 0)
            {
                Aksjon enAksjon = aksjonerSomSkalUtfores[0];
                aksjonerSomSkalUtfores.RemoveAt(0);
                switch(enAksjon)
                {
                    case Aksjon.Aapne:
                        Console.SetCursorPosition(0, 13);
                        Console.WriteLine("               ");
                        Console.WriteLine("               ");
                        break;
                    case Aksjon.Lukk:
                        Console.SetCursorPosition(0, 13);
                        Console.WriteLine("       |       ");
                        Console.WriteLine("       |       ");
                        break;
                    case Aksjon.R1:
                        // Hvis vi ikke har returnernt noen mynt fra før av, må vi flytte markøren:
                        if (Console.CursorTop != 16) Console.SetCursorPosition(12, 16);
                        Console.Write("KR1 ");
                        break;
                    case Aksjon.R5:
                        // Hvis vi ikke har returnernt noen mynt fra før av, må vi flytte markøren:
                        if (Console.CursorTop != 16) Console.SetCursorPosition(12, 16);
                        Console.Write("KR5");
                        break;
                }
            } // av while
            Console.SetCursorPosition(x, y);
        }

        static void VisValgmenyet()
        {
            // Sletter siste-valg-info
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("                              ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("                                                    ");

            // Sletter myntreturinfo
            Console.SetCursorPosition(12, 16);
            Console.Write("                                                   ");

            // Viser valgmenyet på nytt
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("1 Kr 1");
            Console.WriteLine("2 Kr 5");
            Console.WriteLine("3 Passering");
            Console.WriteLine("4 Avslutt");
            Console.WriteLine();
            Console.Write("Oppgi ditt valg: ");
        }
    }
}
