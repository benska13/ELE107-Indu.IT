using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;             //For å lese og skrive til seriell port

namespace FraTimen
{
    class Program
    {
        const string Port = "COM2";    // Port til sensor
        static void Main(string[] args)
        {
            SerialPort sp = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            try
            {
                sp.Open();

                if (sp.IsOpen)
                {
                    bool ferdig = false;
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
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                sp.Close();
            }


        }
    }
}

