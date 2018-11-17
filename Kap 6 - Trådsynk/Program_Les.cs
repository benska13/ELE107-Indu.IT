using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Les
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex m = Mutex.OpenExisting("sync");
            bool ferdig = false;
            while(!ferdig)
            {
                m.WaitOne();
                StreamReader sr = File.OpenText(@"C:\Arbeid\01-Testing-ELE107\Kap 7\Skriv\Skriv\bin\Debug\Data.txt");
                string data = sr.ReadLine();
                Console.WriteLine(data);
                sr.Close();
                m.ReleaseMutex();

                if (data == "ferdig")
                {
                    ferdig = true;
                }            
            }
        }
    }
}
