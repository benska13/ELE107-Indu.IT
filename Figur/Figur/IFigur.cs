using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figur
{
    interface IFigur
    {
        string Farge
        {
            get;
            set;
        }

        double Areal
        {
            get;
            
        }

        string ToString();
        bool Equals(object p);
    }
}
