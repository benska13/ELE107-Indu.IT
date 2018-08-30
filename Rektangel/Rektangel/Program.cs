using System;

namespace Oppgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn dimensjoner til to rektangler.");
            Console.WriteLine("Programmet skal sammenligne dem.");

            // Oppretter nødvendige variabler
            int r1Bredde; int r1Lengde; int r2Bredde; int r2Lengde;

            // Leser inn dimensjoner
            Console.Write("R1 - bredde: ");
            r1Bredde = Convert.ToInt32(Console.ReadLine());
            Console.Write("R1 - lengde: ");
            r1Lengde = Convert.ToInt32(Console.ReadLine());
            Console.Write("R2 - bredde: ");
            r2Bredde = Convert.ToInt32(Console.ReadLine());
            Console.Write("R2 - lengde: ");
            r2Lengde = Convert.ToInt32(Console.ReadLine());

            // Beregner arealer
            int a1 = BeregnAreal(r1Bredde, r1Lengde);
            int a2 = BeregnAreal(r2Bredde, r2Lengde);

            // Sammenlginer
            if (a1 < a2) Console.WriteLine("R2 er større!");
            else if (a2 < a1) Console.WriteLine("R1 er større!");
            else Console.WriteLine("Rektangler er like!");
            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.ReadKey(true);

            
        }


        static int BeregnAreal(int bredde, int lengde)
        {
            Console.WriteLine("hei");
            return bredde * lengde;
            
        }
        

        class Rektangel
        {
            public Rektangel(int lengde, int bredde)
            {
                Lengde = lengde;
                Bredde = bredde;
            }

            public int Bredde { get; set; }

            public int Lengde { get; set; }

            public int Areal
            {
           
            }
            
        }
        
    }
}