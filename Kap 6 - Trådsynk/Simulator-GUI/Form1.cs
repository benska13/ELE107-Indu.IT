using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Simulator_GUI
{
    public partial class Form1 : Form
    {
        Random r;
        int sensorverdi;
        bool avslutt;

        public Form1()
        {
            InitializeComponent();

            r = new Random();
            sensorverdi = 0;
            avslutt = false;
        }

        private void btnStartSensor_Click(object sender, EventArgs e)
        {
            btnStartSensor.Enabled = false;
            bwSensor.RunWorkerAsync();
        }

        private void bwSensor_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            sensorverdi = r.Next(10, 100);           
        }

        private void bwSensor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtSensorverdi.Text = sensorverdi.ToString();
            if (!avslutt) bwSensor.RunWorkerAsync();
            else Application.Exit();
        }

        private void txtInndata_TextChanged(object sender, EventArgs e)
        {
            string inndata = txtInndata.Text;

            char[] charArray = inndata.ToCharArray();
            Array.Reverse(charArray);
            string utdata = new string(charArray);

            txtUtdata.Text = utdata;
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            if (bwSensor.IsBusy) avslutt = true;
            else Application.Exit();
        }
    }
}
