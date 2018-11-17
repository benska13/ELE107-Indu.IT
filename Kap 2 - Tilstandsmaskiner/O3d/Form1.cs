using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using O3c;

namespace O3d
{
    public partial class Form1 : Form
    {
        BergenTM minBTM;

        public Form1()
        {
            InitializeComponent();
            minBTM = new BergenTM();
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.B);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'B';
        }

        private void UtforAksjoner(List<Aksjon> aksjonerSomSkalUtfores)
        {
            if (aksjonerSomSkalUtfores.Count == 0) txtUtdata.Text = "";

            while (aksjonerSomSkalUtfores.Count > 0)
            {
                Aksjon enAksjon = aksjonerSomSkalUtfores[0];
                aksjonerSomSkalUtfores.RemoveAt(0);
                switch (enAksjon)
                {
                    case Aksjon.VIS_BERGEN:
                        txtUtdata.Text = "BERGEN";
                        break;
                }
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.E);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'E';
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.R);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'R';
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.G);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'G';
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.N);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'N';
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.ANNET);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'A';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.ANNET);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'C';
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.ANNET);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'D';
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.ANNET);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += 'F';
        }

        private void btnAnnet_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = minBTM.HaandterHendelse(Hendelse.ANNET);
            UtforAksjoner(aksjonerSomSkalUtfores);
            txtInndata.Text += '#';
        }
    }
}
