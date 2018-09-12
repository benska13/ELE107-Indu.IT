using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figur
{
    class Sirkel : IFigur
    {
        public Sirkel(string farge, double radius)
        {
            Farge = farge;
            Radius = radius;
        }

        public string Farge { get; set; }

        public double Areal => Radius * Math.PI;
        public double Radius { get; set; }
        public override string ToString()
        {
            return GetType() + " Farge: " + Farge+ Areal;
        }
    }
    class Trekant : IFigur
    {
        public Trekant(string farge, double grunnlinje, double høyde)
        {
            Farge = farge;
            Grunnlinje = grunnlinje;
            Høyde = høyde;
        }

        public string Farge { get; set; }

        public double Areal
        {
            get { return (Høyde * Grunnlinje) / 2; }
        }

        public double Grunnlinje { get; set; }

        public double Høyde { get; set; }
        public override string ToString()
        {
            return GetType() + " Farge: " + Farge;
        }
    }

    class Frikant:IFigur    
    {
        public Frikant(string farge, double bredde, double lengde)
        {
            Farge = farge;
            Bredde = bredde;
            Lengde = lengde;
        }

        public string Farge { get; set; }

        public double Areal => Lengde * Bredde;

        public double Bredde { get; set; }

        public double Lengde { get; set; }

        public override string ToString()
        {
            return GetType() + " Farge: " + Farge;
        }
    }
}
