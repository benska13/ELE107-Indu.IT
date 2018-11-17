using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rektangel
{
    class Sirkel : I_Figur
    {
        double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0) radius = 0;
                else radius = value;
            }
        }

        public Sirkel()
        {
            Radius = 0;
        }

        public Sirkel(double initRadius)
        {
            Radius = initRadius;
        }

        public double Areal()
        {
            double svar = Radius * Radius * Math.PI;
            return svar;
        }

        public override string ToString()
        {
            string svar = "(" + Radius + ")";
            return svar;
        }

        public double Omkrets()
        {
            double svar = 2 * Radius * Math.PI;
            return svar;
        }

    }
}
