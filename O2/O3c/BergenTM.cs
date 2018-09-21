using System;

namespace O3c
{
    public enum Tilstand { TOM, B, BE, BER, BERG, BERGE }
   public enum Hendelse { B, E, R, G, N, ANNET }
   public enum Aksjon { VIS_BERGEN }

    public class BergenTM : ITilstandsmaskin
    {
        private Tilstand minTilstand;

        public BergenTM()
        {
            minTilstand = Tilstand.TOM;
        }

        public List<Aksjon> HaandterHendelse(Hendelse minHendelse)
        {
            List<Aksjon> aksjonerSomSkalUtfores = new List<Aksjon>();

            switch (minTilstand)
            {
                case Tilstand.TOM: // TOM
                    switch (minHendelse)
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
                            aksjonerSomSkalUtfores = Aksjon.VIS_BERGEN;
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
}
