using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReOpenWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConsoleColor> consoleColors = new List<ConsoleColor>();
            consoleColors.Add(ConsoleColor.Blue);
            consoleColors.Add(ConsoleColor.Green);
            consoleColors.Add(ConsoleColor.Yellow);

            Random r =new Random();
            while (true)
            {
                int x = r.Next(0, 80);
                int y = r.Next(0,20);
            
                Console.SetCursorPosition(x, y);
                char tegn = Convert.ToChar(Convert.ToInt32('A') + r.Next(0, 26));

                Console.ForegroundColor = consoleColors[r.Next(0, consoleColors.Count)];

                Console.Write(tegn);
                Thread.Sleep(1000);
            }
        }
    }
}
