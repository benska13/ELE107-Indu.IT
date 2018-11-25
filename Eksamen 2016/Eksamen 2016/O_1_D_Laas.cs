using System;
using System.Collections.Generic;

namespace Eksamen_2016
{
    enum Tilstand { T1, T11, T111, T4, T45, T454, TOM }

    public enum Hendelse { H1, H3, H4, H5, Hx }

    public enum Aksjon { Aapne, Lukk }

    public class O_1_D_Laas
    {
        private static Tilstand _minTilstand;

        public O_1_D_Laas()
        {
            _minTilstand= Tilstand.TOM;
        }

        public static List<Aksjon> TilstandsMaskin(Hendelse h)
        {
            List<Aksjon> svar = new List<Aksjon>();

            switch (h)
            {
                case Hendelse.H1:
                    switch (_minTilstand)
                    {
                        case Tilstand.T1:
                            _minTilstand = Tilstand.T11;
                            break;
                        case Tilstand.T11:
                            _minTilstand = Tilstand.T111;
                            break;
                        case Tilstand.T111:
                            _minTilstand = Tilstand.TOM;
                            svar.Add(Aksjon.Lukk);
                            break;
                        case Tilstand.T4:
                            _minTilstand = Tilstand.T1;
                            break;
                        case Tilstand.T45:
                            _minTilstand = Tilstand.T1;
                            break;
                        case Tilstand.T454:
                            _minTilstand = Tilstand.T1;
                            break;
                        case Tilstand.TOM:
                            _minTilstand = Tilstand.T1;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case Hendelse.H3:
                    switch (_minTilstand)
                    {
                        case Tilstand.T1:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T11:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T111:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T4:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T45:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T454:
                            _minTilstand = Tilstand.TOM;
                            svar.Add(Aksjon.Aapne);
                            break;
                        case Tilstand.TOM:
                            _minTilstand = Tilstand.TOM;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case Hendelse.H4:
                    switch (_minTilstand)
                    {
                        case Tilstand.T1:
                            _minTilstand = Tilstand.T4;
                            break;
                        case Tilstand.T11:
                            _minTilstand = Tilstand.T4;
                            break;
                        case Tilstand.T111:
                            _minTilstand = Tilstand.T4;
                            break;
                        case Tilstand.T4:
                            _minTilstand = Tilstand.T4;
                            break;
                        case Tilstand.T45:
                            _minTilstand = Tilstand.T454;
                            break;
                        case Tilstand.T454:
                            _minTilstand = Tilstand.T4;
                            break;
                        case Tilstand.TOM:
                            _minTilstand = Tilstand.T4;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case Hendelse.H5:
                    switch (_minTilstand)
                    {
                        case Tilstand.T1:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T11:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T111:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T4:
                            _minTilstand = Tilstand.T45;
                            break;
                        case Tilstand.T45:
                            _minTilstand = Tilstand.TOM;
                            break;
                        case Tilstand.T454:
                            _minTilstand = Tilstand.T45;
                            break;
                        case Tilstand.TOM:
                            _minTilstand = Tilstand.TOM;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case Hendelse.Hx:
                    _minTilstand = Tilstand.TOM;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(h), h, null);
            }


            return svar;
        }
    }
}