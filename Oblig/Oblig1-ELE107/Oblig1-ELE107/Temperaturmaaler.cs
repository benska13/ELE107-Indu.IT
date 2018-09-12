using System;

namespace Oblig1_ELE107
{
    class Temperaturmaaler : ISensor
    {
        private double _posisonX;
        private double _posisonY;

        readonly Random _random=new Random();

        public Temperaturmaaler(double temperatur=0, double posisonX = 0, double posisonY = 0, double id =0)
        {
            Temperatur = temperatur;
            
            PosisonX = posisonX;
            PosisonY = posisonY;
            Id = id;
        }

        private double Id { get; set; }
        private double Temperatur
        {
            get;
            set;
        }


        public double PosisonX
        {
            get
            {
                return _posisonX;
            }

            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                if (value <= 179 && value >= -180)
                {
                    PosisonX = value;
                }
                else
                {
                    value = 0;
                }
            }
        }

        public double PosisonY
        {
            get => _posisonY;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                if (value <= 90 && value >= -90)
                {
                    PosisonY = value;
                }
            }
        }

        public void Maal()
        {
            double tall = _random.Next(12731);
            Temperatur= tall / 10;

        }

        public override string ToString()
        {
            return $"{Id}-({PosisonX},{PosisonY})";
        }
    }
}