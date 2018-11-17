using System;
using System.IO;
using System.Threading;

namespace LesFraFil1
{
    class LesFraFil
    {
        static void Main(string[] args)
        {
            Thread.Sleep(500); // forsinkelse med <multiple startup projects>
            Semaphore sf = Semaphore.OpenExisting("sync-sf");
            Semaphore lf = Semaphore.OpenExisting("sync-lf");
            string data = "";
            bool ferdig = false;
            while (!ferdig)
            {
                lf.WaitOne();
                StreamReader sr = null;

                try
                {
                    sr = File.OpenText(@"C:\temp\txt.txt");
                    data = sr.ReadLine();


                }
                catch (Exception e)
                {

                    Console.WriteLine("feil" + e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();


                }

                sf.Release();
                Console.WriteLine(data);


                if (data == "ferdig")
                {
                    ferdig = true;
                }
            }
        }
    }
}
    