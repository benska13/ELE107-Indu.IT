using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "notepad.exe";
            p.Start();
        }

        private void btnNettleser_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "iexplore.exe";
            p.StartInfo.Arguments = txtNettleserArgument.Text;
            p.Start();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            // Koden må muligens justeres
            Process p = new Process();
            p.StartInfo.FileName = "WinWord.exe";
            p.StartInfo.Arguments = @txtNettleserArgument.Text;
            p.Start();
        }
    }
}
