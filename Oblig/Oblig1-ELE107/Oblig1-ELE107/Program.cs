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
                    sensorList.Add(new Temperaturmaaler());
                }
                else
                {
                    sensorList.Add(new Trykkmaler());
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
                Console.WriteLine($"ID: {sensor.ToString()}");
            }

            

        }
    }
}
