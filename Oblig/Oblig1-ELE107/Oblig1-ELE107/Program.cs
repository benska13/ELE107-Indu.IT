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
            Random random = new Random();
            List<ISensor> sensorList=new List<ISensor>();
            int antall = 10;

            //opprette en tabell med 5 tempmålere og 5 trykkmålere
            for (int i = 0; i < antall; i++)
            {
                if (i<5)
                {
                    sensorList.Add(new Temperaturmaaler(i+1));
                }
                else
                {
                    sensorList.Add(new Trykkmaaler(i+1));
                }
            }

            //Oppdatere posisjonene
            int x = 0;
            for (int i = 0; i < 5; i++)
            {
                //temperatur
                sensorList[i].PosisjonX = 1;
                sensorList[i].PosisjonY = i+1;

                //trykk
                sensorList[i + 5].PosisjonX = i+1+x;
                sensorList[i + 5].PosisjonY = 1;
                x++;
            }

            //Tillføre verdi
            for (int i = 0; i < antall; i++)
            {
                sensorList[i].Maal(random);
            }

            //Printe ut navn og verdi
            foreach (var sensor in sensorList)
            {
                switch (sensor)
                {
                    case Temperaturmaaler temp:
                        Console.WriteLine($"ID: {temp.Id}, Verdi: {temp.Temperatur}");
                        break;
                    case Trykkmaaler trykk:
                        Console.WriteLine($"ID: {trykk.Id}, Verdi: {trykk.Trykk}");
                        break;
                }
            }

            Console.WriteLine("\n\n");

            foreach (var sensor in sensorList)
            {
                Console.WriteLine(sensor);
            }
            

            Console.ReadKey();

        }
    }
}
