using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1_ELE107
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISensor> sensorList=new List<ISensor>();
            int antall = 10;

            for (int i = 0; i < antall; i++)
            {
                if (i<6)
                {
                    sensorList.Add(new Temperaturmaaler(id: i));
                }
                else
                {
                    sensorList.Add(new Trykkmaler(id:i));
                }
            }

            for (int i = 0; i < 6; i++)
            {
              
                    sensorList[i].PosisonX = 1;
                    sensorList[i].PosisonY = i+1;
                int x=1;

                for (int j = 0; j < 5; j++)
                {

                    sensorList[j + 6].PosisonX = x;
                    sensorList[j + 6].PosisonY = 1;
                    x+= 2;

                }
            }

            foreach (var sensor in sensorList)
            {
                sensor.Maal();
                Console.WriteLine($"ID: "{sensor.});
            }

            

        }
    }

    interface ISensor
    {
        double PosisonX
        {
            get;
            set;
        }

        double PosisonY
        {
            get;
            set;
        }

        void Maal();
        string ToString();
    }

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
            get => _posisonX;
            set
            {
                if (value <= 179 && value >= -180)
                {
                    PosisonX = value;
                }
            }
        }

        public double PosisonY
        {
            get => _posisonY;
            set
            {
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
