using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeibomLib;

namespace Veibom_GUI
{
    public partial class Form1 : Form
    {
        VeibomTM vbTM;

        public Form1()
        {
            InitializeComponent();
            vbTM = new VeibomTM(5);
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKr1_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = vbTM.HaandterHendelse(Hendelse.Kr1);
            UtforAksjoner(aksjonerSomSkalUtfores);
        }

        private void UtforAksjoner(List<Aksjon> aksjonerSomSkalUtfores)
        {
            
        }

        private void btnKr5_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = vbTM.HaandterHendelse(Hendelse.Kr5);
            UtforAksjoner(aksjonerSomSkalUtfores);
        }

        private void btnPassering_Click(object sender, EventArgs e)
        {
            List<Aksjon> aksjonerSomSkalUtfores = vbTM.HaandterHendelse(Hendelse.Passering);
            UtforAksjoner(aksjonerSomSkalUtfores);
        }

    }
}
