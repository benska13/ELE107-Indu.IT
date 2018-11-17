using System;
using System.IO;
using System.Threading;

namespace SkrivTilFil
{
    class SkrivTilFil
    {
        static void Main(string[] args)
        {
            Semaphore lf = new Semaphore(0, 1, "sync-lf"); // låst dør
            Semaphore sf = new Semaphore(1, 1, "sync-sf");

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
                lf.Release();


                if (data == "ferdig")
                {
                    ferdig = true;

                }
            }
        }
    }
}