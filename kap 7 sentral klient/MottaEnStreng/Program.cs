using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

//For å lese og skrive til seriell port

namespace FraTimen
{
    class Program
    {
        const string Port = "COM1";    // Port til sensor
        private static bool ferdig = false;

        static void Main(string[] args)
        {
            SerialPort sp = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            try
            {
                ThreadPool.QueueUserWorkItem(GetAvslutt);

                sp.Open();

                if (sp.IsOpen)
                {

                    while (!ferdig)
                    {
                        char tegn = Convert.ToChar(sp.ReadChar());
                        if (tegn == '*')
                        {
                            ferdig = true;
                            sp.Close();
                        }
                        else
                        {
                            Console.Write(tegn);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            finally
            {
                sp.Close();
            }


        }

        private static void GetAvslutt(object state)
        {
            Console.ReadKey();
            ferdig = true;
        }


    }
}

