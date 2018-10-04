using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Watchdog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Watchdog started!");
            Process p = new Process();
            p.StartInfo.FileName =
                @"C:\Users\benja\source\repos\ELE107-Indu.IT\Kap4\ReOpenWindow\bin\Debug\ReOpenWindow.exe";
            p.Start();

            while (true)
            {
                Thread.Sleep(500);
                if (p.HasExited)
                {
                    p.Start();
                    Console.WriteLine("Restart");
                }
            }

        }
    }
}
