using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;


namespace TCP_IP_Klient
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            string input, stringData;
            Socket klientSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            try
            {
                klientSokkel.Connect(serverEP); // blokkerende metode
            }
            catch (SocketException e)
            {
                Console.WriteLine("Fikk ikke forbindelse med server.");
                Console.WriteLine(e.ToString());
                return;
            }
            int nMottatt = klientSokkel.Receive(data);
            stringData = Encoding.ASCII.GetString(data, 0, nMottatt);
            Console.WriteLine(stringData);

            bool ferdig = false;
            while (!ferdig)
            {
                input = Console.ReadLine();

                if (input == "exit") ferdig = true;

                klientSokkel.Send(Encoding.ASCII.GetBytes(input));

                if (!ferdig)
                {
                    data = new byte[1024];
                    nMottatt = klientSokkel.Receive(data);
                    stringData = Encoding.ASCII.GetString(data, 0, nMottatt);
                    Console.WriteLine(stringData);
                }
            }
            Console.WriteLine("Bryter forbindelsen med serveren ...");
            klientSokkel.Shutdown(SocketShutdown.Both);
            klientSokkel.Close();

        }
    }
}
