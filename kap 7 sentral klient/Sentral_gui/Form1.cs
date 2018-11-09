using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sentral_gui
{
    public partial class Form1 : Form
    {
        List<BackgroundWorker> backgroundWorkers = new List<BackgroundWorker>();
        public Form1()
        {
            InitializeComponent();

            backgroundWorkers.Add(new BackgroundWorker());

        }
    }
}
