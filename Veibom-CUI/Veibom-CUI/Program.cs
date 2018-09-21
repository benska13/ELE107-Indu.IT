using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VeibomLibary;

namespace Veibom_CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ferdig = false;
            VeibomTm vbTm =new VeibomTm(5);
            List<Aksjon> aksjonerSomSkalUtføres =   new List<Aksjon>();

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("------------");
            Console.WriteLine("      |     ");
            Console.WriteLine("      |     ");
            Console.WriteLine("------------");
            Console.WriteLine("myntretur: ");


            while (!ferdig)
            {
                Console.SetCursorPosition(0,0);
                VisValgmenyet();
                Console.WriteLine("                ");
                Console.WriteLine("                                   ");
                Console.SetCursorPosition(0,5);
                int valg = 0;
                try
                {
                    valg = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine( e.Message);
                    Console.ReadKey();

                }

                switch (valg)
                {
                    case 1:
                        UtforAksjoner(vbTm.HaandterHendelse(Hendelse.Kr1));
                        break;
                    case 2:
                        UtforAksjoner(vbTm.HaandterHendelse(Hendelse.Kr5));
                        break;
                    case 3:
                        UtforAksjoner(vbTm.HaandterHendelse(Hendelse.Passering));
                        break;
                    case 4:
                        Console.WriteLine("Avslutter programmet ... ");
                        ferdig = true;
                        break;
                    default:
                        //Console.WriteLine("Ugyldig valg!");
                        break;
                }
                //Console.WriteLine("Trykk en tast...");
                //Console.ReadKey();

            }
        }

        private static void UtforAksjoner(List<Aksjon> aksjonerSomSkalUtfores)
        {
            while (aksjonerSomSkalUtfores.Count>0)
            {
                Aksjon enAksjon = aksjonerSomSkalUtfores[0];
                aksjonerSomSkalUtfores.RemoveAt(0);
                switch (enAksjon)
                {
                    case Aksjon.Aapne:
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine("------|-----");
                        Console.WriteLine("            ");
                        Console.WriteLine("            ");
                        Console.WriteLine("------|-----");

                        break;
                    case Aksjon.Lukk:
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine("------------");
                        Console.WriteLine("      |     ");
                        Console.WriteLine("      |     ");
                        Console.WriteLine("------------");
                        break;
                    case Aksjon.R1:
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Myntretur: 1 Kr");
                        break;
                    case Aksjon.R5:
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Myntretur: 5 Kr");
                        break;
                }
            }
        }

        static void VisValgmenyet()
        {
            //Console.Clear();    
            Console.WriteLine("1 Kr 1\n2 Kr 5\n3 Passering\n4 Avslutt\nOppgi ditt valg: ");
            
        }
    }
}
