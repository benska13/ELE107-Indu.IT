    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeibomLib
{
    public enum Aksjon { Aapne, Lukk, R1, R5 }
    public enum Hendelse { Kr1, Kr5, Passering }
    enum Tilstand { Aapen, Lukket }

    public class VeibomTM : Tilstandsmaskin
    {
        Tilstand minTilstand;
        int betaltBelop;
        int passeringspris;

        public VeibomTM(int initPris)
        {
            minTilstand = Tilstand.Lukket;
            betaltBelop = 0;
            passeringspris = initPris;
        }

        public List<Aksjon> HaandterHendelse(Hendelse h)
        {
            List<Aksjon> svar = new List<Aksjon>();

            switch(minTilstand)
            {
                case Tilstand.Lukket:
                    switch(h)
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
                                svar.Add(Aksjon.Aapne);
                                betaltBelop = betaltBelop - passeringspris;
                                
                                while (betaltBelop > 0)
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
