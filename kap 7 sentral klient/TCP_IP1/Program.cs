
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nødvendige using:
using System.Net;
using System.Net.Sockets;
using System.Threading;


// cmd
// tracert {ip-adresse}
namespace TCP_IP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            Socket lytteSokkel = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            lytteSokkel.Bind(serverEP);
            lytteSokkel.Listen(10);
            while (n-- > 0)
            {
                Console.WriteLine("Venter på en klient ...");
                Socket kommSokkel = lytteSokkel.Accept(); // blokkerende metode

                ThreadPool.QueueUserWorkItem(KlientrtTraad, kommSokkel);
            }
            lytteSokkel.Close();
        } //av main

        static void KlientrtTraad(object o)
        {
            Socket kommSokkel = o as Socket;

            IPEndPoint klientInfo = (IPEndPoint)kommSokkel.RemoteEndPoint;
            IPEndPoint serverInfo = (IPEndPoint)kommSokkel.LocalEndPoint;

            Console.WriteLine("Har forbindelse med {0} på port {1}, server bruker {2} og port {3}",
                klientInfo.Address, klientInfo.Port, serverInfo.Address, serverInfo.Port);

            int recv;
            string mottattTekst;
            string sendtTekst;
            byte[] data = new byte[1024];


            string hilsen = "Velkommen til en enkel testserver";
            data = Encoding.ASCII.GetBytes(hilsen);
            kommSokkel.Send(data, data.Length, SocketFlags.None);

            bool ferdig = false;
            while (!ferdig)
            {
                data = new byte[1024];
                recv = kommSokkel.Receive(data);

                if (recv == 0) ferdig = true;

                if (!ferdig)
                {
                    mottattTekst = Encoding.ASCII.GetString(data, 0, recv);
                    Console.WriteLine(mottattTekst);

                    if (mottattTekst == "exit") ferdig = true;
                    Char[] mottattArray = mottattTekst.ToCharArray();
                    Array.Reverse(mottattArray);
                    StringBuilder sb = new StringBuilder();

                    foreach (char ch in mottattArray)
                        sb.Append(ch);

                    sendtTekst = sb.ToString();
                    kommSokkel.Send(Encoding.ASCII.GetBytes(sendtTekst), recv, SocketFlags.None);
                }
            }

            Console.WriteLine("Forbindelsen med {0} er brutt", klientInfo.Address);
            kommSokkel.Close();
        }

    }
}
