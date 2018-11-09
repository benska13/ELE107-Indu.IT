using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI_HT
{
    // definerer formen på metoder som delegater skal kunne reprens
    public delegate void MDT(string data);


    public partial class Form1 : Form
    {
        private Socket komMedServerSocket;
        private MDT minDelegat;

        public Form1()
        {
            InitializeComponent();
            btnSend.Enabled = true;
            btnKobleTil.Enabled = true;
        }

        private void btnKobleTil_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        void SendDataTilServer(object o)
        {
            SendMelding(txtDataTilServer.Text);

            if (txtDataTilServer.Text != "exit")
            {

                string svar = MottaMelding();
                //txtDataTilServer.Text = svar;
                minDelegat = new MDT(OppdaterGUI);
                this.Invoke(minDelegat, svar);
            }
            else
            {

                komMedServerSocket.Close();
                btnKobleFra.Enabled = false;
                btnKobleTil.Enabled = true;
                btnSend.Enabled = false;
            }

        }

        void OppdaterGUI(string data)
        {
            txtDataFraServer.Text = data;
        }

        void SendMelding(string dataS)
        {
            try
            {
                komMedServerSocket.Send(Encoding.ASCII.GetBytes(dataS));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string MottaMelding()
        {
            string stringData = "";
            byte[] data = new byte[1024];

            try
            {
                int nMottatt = komMedServerSocket.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, nMottatt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return stringData;
        }

        private void btnKobleFra_Click(object sender, EventArgs e)
        {

        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {

        }
    }
}
