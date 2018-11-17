using System;
using System.Collections.Generic;
using O3c;

namespace O3c_ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BergenTM minBTM = new BergenTM();

            List<Aksjon> aksjonerSomSkalUtfores;
            Hendelse minHendelse;
            while (true)
            {
                minHendelse = EnHendelse();
                aksjonerSomSkalUtfores = minBTM.HaandterHendelse(minHendelse);
                while (aksjonerSomSkalUtfores.Count > 0)
                {
                    Aksjon enAksjon = aksjonerSomSkalUtfores[0];
                    aksjonerSomSkalUtfores.RemoveAt(0);
                    switch (enAksjon)
                    {
                        case Aksjon.VIS_BERGEN:
                            Console.Write("\nBergen\n");
                            break;
                    }
                }
            }
        } // av Main
        static Hendelse EnHendelse()
        {
            Hendelse svar = Hendelse.ANNET;
            char tegn = Console.ReadKey().KeyChar;
            switch (tegn)
            {
                case 'B': svar = Hendelse.B; break;
                case 'E': svar = Hendelse.E; break;
                case 'R': svar = Hendelse.R; break;
                case 'G': svar = Hendelse.G; break;
                case 'N': svar = Hendelse.N; break;
            }
            return svar;
        }
    } // av Program
}
