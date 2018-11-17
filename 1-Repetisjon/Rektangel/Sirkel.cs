using System;

namespace Rektangel_
{
    class Sirkel : IFigur
    {
        private int _radius;

        public int Radius
        {
            get => _radius;
            set
            {
                if (value < 0) _radius = 0;
                else _radius = value;
            }
        }

        public Sirkel()
        {
            Radius = 0;
        }

        public double Areal()
        {
            return Radius * Radius * Math.PI;
        }
        public Sirkel(int radius)
        {
            this.Radius = radius;
        }

        public override string ToString()
        {
            return "(" + Radius + ")";
        }
    }
}