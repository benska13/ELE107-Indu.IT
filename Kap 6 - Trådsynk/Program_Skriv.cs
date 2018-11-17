using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Skriv
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex m = new Mutex(true, "sync");
            bool ferdig = false;
            while(!ferdig)
            {
                string data = Console.ReadLine();
               
                StreamWriter sw = File.CreateText("Data.txt");
                sw.WriteLine(data);
                sw.Close();
                m.ReleaseMutex();
              
                if (data == "ferdig")
                {
                    ferdig = true;
                }
            }
        }
    }
}
