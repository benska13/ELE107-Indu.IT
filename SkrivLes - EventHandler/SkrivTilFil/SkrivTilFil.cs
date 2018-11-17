using System;
using System.IO;
using System.Threading;

namespace SkrivTilFil
{
    class SkrivTilFil
    {
        static void Main(string[] args)
        {
            EventWaitHandle lf = new EventWaitHandle(false, EventResetMode.AutoReset, "sync-lf");
            EventWaitHandle sf = new EventWaitHandle(true, EventResetMode.AutoReset, "sync-sf");

            bool ferdig = false;


            while (!ferdig)
            {
                string data = Console.ReadLine();

                sf.WaitOne();

                StreamWriter sw = null;

                try
                {
                    sw = File.CreateText(@"C:\temp\txt.txt");
                    sw.WriteLine(data);

                }
                catch (Exception e)
                {

                    Console.WriteLine("feil" + e.Message);

                }
                finally
                {
                    if (sw != null) sw.Close();

                }
                lf.Set();


                if (data == "ferdig")
                {
                    ferdig = true;

                }
            }
        }
    }
}