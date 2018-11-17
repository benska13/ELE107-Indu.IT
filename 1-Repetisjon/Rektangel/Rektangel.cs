namespace Rektangel_
{
    class Rektangel : IFigur
    {
        int _lengde;
        int _bredde;

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

        public double Areal()
        {
            return _lengde * _bredde;
        }

        public int Lengde
        {
            get => _lengde;
            set
            {
                if (value < 0) _lengde = 0;
                else _lengde = value;
            }
        }

        public int Bredde
        {
            get { return _bredde; }
            set
            {
                if (value < 0) _bredde = 0;
                else _bredde = value;
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
            bool svar = this._lengde * this._bredde > denAndre.Lengde * denAndre._bredde;
            return svar;
        }

        public static bool ErStorre(Rektangel r1, Rektangel r2)
        {
            bool svar = false;
            if ((r1._lengde * r1._bredde) > (r2.Lengde * r2._bredde)) svar = true;
            return svar;
        }

        public static bool operator >(Rektangel r1, Rektangel r2)
        {
            bool svar = false;
            if ((r1._lengde * r1._bredde) > (r2.Lengde * r2._bredde)) svar = true;
            return svar;
        }

        public static bool operator <(Rektangel r1, Rektangel r2)
        {
            bool svar = true;
            if ((r1._lengde * r1._bredde) > (r2.Lengde * r2._bredde)) svar = false;
            return svar;
        }

        public override string ToString()
        {
            return "(" + Bredde.ToString() + ";" + Lengde.ToString() + ")";
        }
    }
}