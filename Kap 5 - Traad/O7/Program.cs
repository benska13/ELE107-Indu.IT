using System;
using System.Threading;
using static System.Console;

namespace O7
{
    class Program
    {
        static bool _ferdig;
        private static object sync = "";
        static void Main(string[] args)
        {
            try
            {
                _ferdig = false;
                ThreadPool.QueueUserWorkItem(TallGenerator);
                string inndata;
                string utdata;
                while (!_ferdig)
                {
                    SkrivUt($"Oppgi" + $" tekst: ");

                    inndata = "";
                    bool inndataMottatt = false;
                    while (!inndataMottatt)
                    {

                        ConsoleKeyInfo tast = ReadKey(true);
                        if (tast.Key == ConsoleKey.Enter)
                        {
                            inndataMottatt = true;
                        }
                        else
                        {
                            inndata += tast.KeyChar;
                            SkrivUt(inndata);
                        }
                    }

                    if (inndata == "")
                    {
                        _ferdig = true;
                    }
                    char[] charArray = inndata.ToCharArray();
                    Array.Reverse((charArray));
                    utdata =new string(charArray);

                    SkrivUt(utdata);
                    SkrivUt("Trykk en tast for å fortsette..:");

                    ReadKey(true);

                    Monitor.Enter(sync);
                    SetCursorPosition(0, 0);
                    WriteLine("                                           ");
                    WriteLine("                                           ");
                    WriteLine("                                           ");
                    SetCursorPosition(0, 0);
                    Monitor.Exit(sync);
                }
            }
            catch (Exception e)
            {
                WriteLine(e);
                throw;
            }
        }

        static void SkrivUt(string t)
        {
            Monitor.Enter(sync);
            Console.Write(t);
            Monitor.Exit(sync);
        }
        static void TallGenerator(object o)
        {
            Random r = new Random();
            int data;
            while (!_ferdig)
            {
                Thread.Sleep(1000);
                data = r.Next(10, 100);
                VisData(data);
            }
        }

        private static void VisData(int tall)
        {
            Monitor.Enter(sync);
            int x = CursorLeft;
            int y = CursorTop;
            SetCursorPosition(10,10);
            Thread.Sleep(200);
            Write("Sensordata: {0}", tall);
            SetCursorPosition(x,y);
            Monitor.Exit(sync);
        }
    }

  
}

