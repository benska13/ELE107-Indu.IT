using System;

namespace Oblig1_ELE107
{
    class Trykkmaler:ISensor
    {
        public double Trykk { get; set; }
        public double PosisonX { get; set; }
        public double PosisonY { get; set; }
        readonly Random _random=new Random();

        public Trykkmaler(double trykk=0, double posisonX=0, double posisonY=0, double id=0)
        {
            Trykk = trykk;
            PosisonX = posisonX;
            PosisonY = posisonY;
            Id = id;
        }

        public double Id { get; set; }

        public void Maal()
        {
            double tall = _random.Next(5, 25);
            Trykk = tall / 10;
        }
    }
}