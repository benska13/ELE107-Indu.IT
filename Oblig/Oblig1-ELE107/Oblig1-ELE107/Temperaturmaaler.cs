using System;

namespace Oblig1_ELE107
{
    [System.Serializable]
    class Temperaturmaaler : ISensor
    {
        private double _posisjonX;
        private double _posisjonY;

        

        public Temperaturmaaler()
        {
            Temperatur = 0;
            PosisjonX = 0;
            PosisjonY = 0;
            Id = 0;
        }

        public Temperaturmaaler(double id)
        {
            Temperatur = 0;
            PosisjonX = 0;
            PosisjonY = 0;
            Id = id;
        }

        public double Id { get; set; }
        public double Temperatur { get; set; }

        public double PosisjonX
        {
            get => _posisjonX;
            set
            {
                if (value < -180)
                {
                    _posisjonX = 180;
                }
                else if (value > 179)
                {
                    _posisjonX = 179;
                }
                else
                {
                    _posisjonX = value;
                }
            }
        }

        public double PosisjonY
        {
            get => _posisjonY;
            set
            {
                if (value < -90)
                {
                    _posisjonY = -90;
                }
                else if (value >
 90)
                {
                    _posisjonY = 90;
                }
                else
                {
                    _posisjonY = value;
                }
            }
        }

        public void Maal(Random random)
        {
            double tall = random.Next(12731);
            Temperatur =tall/10;

        }

        public override string ToString()
        {
            return $"{Id}-({PosisjonX},{PosisjonY})";
        }
    }
}