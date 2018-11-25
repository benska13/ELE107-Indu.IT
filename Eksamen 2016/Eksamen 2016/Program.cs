using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace Eksamen_2016
{
    

    class Program
    {
        private static Tilstand _minTilstand;

        static void Main(string[] args)
        {
            _minTilstand = Tilstand.TOM;
            while (true)
            {
                var h = EnHendelse();
                var listaAksjon = O_1_D_Laas.TilstandsMaskin(h);

                while (listaAksjon.Count>0)
                {
                    switch (listaAksjon.First())
                    {
                        case Aksjon.Aapne:
                            Console.WriteLine("\nLåsen er åpen.");
                            break;
                        case Aksjon.Lukk:
                            Console.WriteLine("\nLåsen er lukket.");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    listaAksjon.RemoveAt(0);
                }
            }
        }
        static Hendelse EnHendelse()
        {
            Hendelse svar = Hendelse.Hx;
            char tegn = Console.ReadKey().KeyChar;
            switch (tegn)
            {
                case '1': svar = Hendelse.H1; break;
                case '3': svar = Hendelse.H3; break;
                case '4': svar = Hendelse.H4; break;
                case '5': svar = Hendelse.H5; break;
                default: svar = Hendelse.Hx; break;
            }
            return svar;
        }
       
    }
}
