using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rektangel
{
    class Rektangel
    {
        int lengde;
        int bredde;

        public Rektangel(int initB, int initL)
        {
            Bredde = initB;
            Lengde = initL;
        }

        public Rektangel()
        {
            Bredde = 0;
            Lengde = 0;
        }

        public int Areal()
        {
            return lengde * bredde;
        }

        public int Lengde
        {
            get { return lengde; }
            set
            {
                if (value < 0) lengde = 0;
                else lengde = value;
            }
        }

        public int Bredde
        {
            get { return bredde; }
            set
            {
                if (value < 0) bredde = 0;
                else bredde = value;
            }
        }

        public static void Skaler(int faktor, Rektangel r)
        {
            r.Lengde = r.Lengde * faktor;
            r.Bredde = r.Bredde * faktor;
            faktor = 0;
        }

        public bool HarStorreArealEnn(Rektangel denAndre)
        {
            bool svar = false;
            if (this.lengde * this.bredde > denAndre.Lengde * denAndre.bredde) svar = true;
            return svar;
        }

        public static bool ErStorre(Rektangel r1, Rektangel r2)
        {
            bool svar = false;
            if ((r1.lengde * r1.bredde) > (r2.Lengde * r2.bredde)) svar = true;
            return svar;
        }

        public static bool operator > (Rektangel r1, Rektangel r2)
        {
            bool svar = false;
            if ((r1.lengde * r1.bredde) > (r2.Lengde * r2.bredde)) svar = true;
            return svar;
        }

        public static bool operator < (Rektangel r1, Rektangel r2)
        {
            bool svar = true;
            if ((r1.lengde * r1.bredde) > (r2.Lengde * r2.bredde)) svar = false;
            return svar;
        }
    }
}
