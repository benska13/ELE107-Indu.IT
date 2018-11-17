using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process minProcess = new Process();
            minProcess.StartInfo.FileName = "notepad.exe";
            minProcess.Start();
            Thread.Sleep(3000);
            minProcess.Kill();

            minProcess = new Process();
            minProcess.StartInfo.FileName = "calc.exe";
            minProcess.Start();

            Process[] ptab = Process.GetProcesses();

            foreach (Process p in ptab)
            {
                Console.WriteLine("Process: " + p.Id + " " + p.ProcessName);
            }

            Thread.Sleep(3000);
            Process [] alleKalkulatorProcesser = Process.GetProcessesByName("Calculator");
            foreach (Process p in alleKalkulatorProcesser)
            {
                p.Kill();
            }

            minProcess = new Process();
            minProcess.StartInfo.FileName = "iexplore.exe";
            minProcess.StartInfo.Arguments = "www.bt.no";
            minProcess.Start();




            Console.ReadKey(true);
        }
    }
}
