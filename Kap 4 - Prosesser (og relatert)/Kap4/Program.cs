using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace Kap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Process minProcess = new Process();
            minProcess.StartInfo.FileName = "notepad.exe";

            minProcess.Start();
            Sleep(5000);
            minProcess.Kill();

            minProcess = new Process();
            minProcess.StartInfo.FileName = "calc.exe";
            minProcess.Start();

            Process[] ptab = Process.GetProcesses();

            foreach (Process process in ptab)
            {
                Console.WriteLine("Process: " + process.Id+" "+process.ProcessName);
            }
            Sleep(3000);
            Process[] minCalc = Process.GetProcessesByName("Clalculator");
            foreach (Process process in minCalc)
            {
                process.Kill();
            }
            minProcess = new Process();
           // minProcess.StartInfo;
            Console.ReadKey();
        }
    }
}
