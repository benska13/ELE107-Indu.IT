using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Klient_GUI_HT
{
    // definerer formen på metoder som delegater skal kunne representere
    // void ... (string)
    public delegate void MDT(string data); 
    public partial class Form1 : Form
    {
        Socket komMedServerSokkel;
        MDT minDelegat;

        public Form1()
        {
            InitializeComponent();
            komMedServerSokkel = null;         
        }

        private void btnKobleTil_Click(object sender, EventArgs e)
        {
            komMedServerSokkel = new Socket(AddressFamily.InterNetwork,
                                              SocketType.Stream,
                                              ProtocolType.Tcp);

            bool oppkoblet = false;
            try
            {
                string serverIP = txtServerIP.Text;
                int serverPort = Convert.ToInt32(txtServerPort.Text);
                IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
                komMedServerSokkel.Connect(serverEP);    // blokkerende metode
                oppkoblet = true;
            }
            catch (Exception u)
            {
                MessageBox.Show("Feil: " + u.Message);
            }
            if (oppkoblet)
            {
                btnKobleTil.Enabled = false;
                btnSend.Enabled = true;
                btnKobleFra.Enabled = true;

                string data = MottaMelding();
                MessageBox.Show(data);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string dataSomSkalSendes = txtDataTilServer.Text;
            if (dataSomSkalSendes.Length > 0)
            {
                ThreadPool.QueueUserWorkItem(SendDataTilServer);
            }
        }

        void SendDataTilServer(object o)
        {
            SendMelding(txtDataTilServer.Text);
            if (txtDataTilServer.Text != "avslutt")
            {
                string svar = MottaMelding();

                minDelegat = new MDT(OppdaterGUI);

                this.Invoke(minDelegat, svar);
            }
            else
            {
                komMedServerSokkel.Close();
                btnKobleFra.Enabled = false;
                btnKobleTil.Enabled = true;
                btnSend.Enabled = false;
            }
        }


        void OppdaterGUI(string data)
        {
            txtDataFraServer.Text = data;
        }

        void SendMelding(string data)
        {
            try
            {
                komMedServerSokkel.Send(Encoding.ASCII.GetBytes(data));
            }
            catch(Exception u)
            {
                MessageBox.Show("Feil: " + u.Message);
            }
        }


        string MottaMelding()
        {
            string svar = "";
            byte[] data = new byte[1024];
            try
            {
                int nMottatt = komMedServerSokkel.Receive(data);
                svar = Encoding.ASCII.GetString(data, 0, nMottatt);
            }
            catch(Exception u)
            {
                MessageBox.Show("Feil: " + u.Message);
            }
            return svar;
        }

        private void btnKobleFra_Click(object sender, EventArgs e)
        {
            SendMelding("avslutt");
            komMedServerSokkel.Close();
            btnKobleFra.Enabled = false;
            btnKobleTil.Enabled = true;
            btnSend.Enabled = false;
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            if (komMedServerSokkel != null)
            {
                if (komMedServerSokkel.Connected) SendMelding("avslutt");
                komMedServerSokkel.Close();
            }
            Application.Exit();
        }
    }
}
