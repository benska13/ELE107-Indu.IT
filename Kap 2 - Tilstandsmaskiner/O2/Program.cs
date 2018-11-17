using System;

namespace O2
{


    enum Tilstand { TOM, B, BE, BER, BERG, BERGE }
    enum Hendelse { B, E, R, G, N, ANNET }
    class Program
    {
        static void Main(string[] args)
        {
            Tilstand minTilstand = 0;
            Hendelse minHendelse;
            while (true)
            {
                minHendelse = EnHendelse();
                switch(minTilstand)
                {
                    case Tilstand.TOM: // TOM
                        switch(minHendelse)
                        {
                            case Hendelse.B:
                                minTilstand = Tilstand.B;
                                break;
                            case Hendelse.E:
                            case Hendelse.R:
                            case Hendelse.G:
                            case Hendelse.N:
                            case Hendelse.ANNET:
                                break;
                        }
                        break;
                    case Tilstand.B: // B
                        switch (minHendelse)
                        {
                            case Hendelse.E:
                                minTilstand = Tilstand.BE;
                                break;
                            case Hendelse.B:
                                break;
                            case Hendelse.R:
                            case Hendelse.G:
                            case Hendelse.N:
                            case Hendelse.ANNET:
                                minTilstand = Tilstand.TOM;
                                break;
                        }
                        break;
                    case Tilstand.BE: // BE
                        switch (minHendelse)
                        {
                            case Hendelse.B:
                                minTilstand = Tilstand.B;
                                break;
                            case Hendelse.R:
                                minTilstand = Tilstand.BER;
                                break;
                            case Hendelse.E:
                            case Hendelse.G:
                            case Hendelse.N:
                            case Hendelse.ANNET:
                                minTilstand = Tilstand.TOM;
                                break;
                        }
                        break;
                    case Tilstand.BER: // BER
                        switch (minHendelse)
                        {
                            case Hendelse.B:
                                minTilstand = Tilstand.B;
                                break;
                            case Hendelse.G:
                                minTilstand = Tilstand.BERG;
                                break;
                            case Hendelse.E:
                            case Hendelse.R:
                            case Hendelse.N:
                            case Hendelse.ANNET:
                                minTilstand = Tilstand.TOM;
                                break;
                        }
                        break;
                    case Tilstand.BERG: // BERG
                        switch (minHendelse)
                        {
                            case Hendelse.B:
                                minTilstand = Tilstand.B;
                                break;
                            case Hendelse.E:
                                minTilstand = Tilstand.BERGE;
                                break;
                            case Hendelse.R:
                            case Hendelse.G:
                            case Hendelse.N:
                            case Hendelse.ANNET:
                                minTilstand = Tilstand.TOM;
                                break;
                        }
                        break;
                    case Tilstand.BERGE: // BERGE
                        switch (minHendelse)
                        {
                            case Hendelse.B:
                                minTilstand = Tilstand.B;
                                break;
                            case Hendelse.N:
                                Console.Write("\nBergen\n");
                                minTilstand = Tilstand.TOM;
                                break;
                            case Hendelse.E:
                            case Hendelse.R:
                            case Hendelse.G:
                            case Hendelse.ANNET:
                                minTilstand = Tilstand.TOM;
                                break;
                        }
                        break;
                }
            }
        }

        static Hendelse EnHendelse()
        {
            Hendelse svar = Hendelse.ANNET; 
            char tegn = Console.ReadKey().KeyChar;
            switch(tegn)
            {
                case 'B': svar = Hendelse.B; break;
                case 'E': svar = Hendelse.E; break;
                case 'R': svar = Hendelse.R; break;
                case 'G': svar = Hendelse.G; break;
                case 'N': svar = Hendelse.N; break;
            }
            return svar;
        }

    }
}
