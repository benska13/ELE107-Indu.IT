using System;
using System.Collections.Generic;

namespace VeibomLibary
{
    public enum Aksjon{Aapne,
        R1,
        R5,
        Lukk
    }
    public enum Hendelse { Kr1, Kr5, Passering }
    enum Tilstand { Aapen, Lukket }


    
        
        public class VeibomTm : ITilstandsmaskin
        {
            private Tilstand minTilstand;
            private int passeringspris;
            private int betaltBelop;

            public VeibomTm(int initpris)
            {
                minTilstand = Tilstand.Lukket;
                betaltBelop = 0;
                passeringspris = initpris;
            }


            public List<Aksjon> HaandterHendelse(Hendelse h)
            {
                List<Aksjon> svar = new List<Aksjon>();

                switch (minTilstand)
                {
                    case Tilstand.Lukket:
                        switch (h)
                        {
                            case Hendelse.Kr1:
                                betaltBelop++;
                                if (betaltBelop == passeringspris)
                                {
                                    minTilstand = Tilstand.Aapen;
                                    svar.Add(Aksjon.Aapne);
                                    betaltBelop = 0;
                                }
                                break;
                            case Hendelse.Kr5:
                                betaltBelop = betaltBelop + 5;
                                if (betaltBelop >= passeringspris)
                                {
                                    minTilstand = Tilstand.Aapen;
                                    svar.Add((Aksjon.Aapne));
                                    betaltBelop = betaltBelop - passeringspris;
                                    while (betaltBelop>0)
                                    {
                                        svar.Add(Aksjon.R1);
                                        betaltBelop--;
                                    }

                                    
                                }

                                break;
                            case Hendelse.Passering:
                                break;
                        }
                        break;
                    case Tilstand.Aapen:
                        switch (h)
                        {
                            case Hendelse.Kr1:
                                svar.Add(Aksjon.R1);
                                break;
                            case Hendelse.Kr5:
                                svar.Add(Aksjon.R5);
                                break;
                            case Hendelse.Passering:
                                minTilstand = Tilstand.Lukket;
                                svar.Add(Aksjon.Lukk);
                                break;
                        }
                        break;
                }
                return svar;
            }



        }
        
    
}
