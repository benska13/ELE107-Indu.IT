using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace O1_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Avslutt_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnNotepad_Click(object sender, RoutedEventArgs e)
        {
            Process p =new Process();
            p.StartInfo.FileName = "notepad.exe";
            p.Start();
            Thread.Sleep(5000);
            p.Kill();
        }

        private void BtnNettleser_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "iexplore.exe";
            p.StartInfo.Arguments = NettleserTextBox.Text;
            p.Start();
        }
    }
}
