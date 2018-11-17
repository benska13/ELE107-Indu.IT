using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace O2_Watchdog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Watchdog startet!");
            
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Users\ado\Desktop\ELE107\O2\O2\bin\Debug\O2.exe";
            p.Start();

            while (true)
            {
                Thread.Sleep(500);
                if (p.HasExited)
                {
                    Console.WriteLine("Programmet som overvåkes har stoppet - starter det på nytt.");
                    p.Start();
                }
            }
        
        }
    }
}
