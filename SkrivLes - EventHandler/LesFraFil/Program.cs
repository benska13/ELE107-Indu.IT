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
            EventWaitHandle sf = EventWaitHandle.OpenExisting("sync-sf");
            EventWaitHandle lf = EventWaitHandle.OpenExisting("sync-lf");

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

                sf.Set();
                Console.WriteLine(data);


                if (data == "ferdig")
                {
                    ferdig = true;
                }
            }
        }
    }
}
