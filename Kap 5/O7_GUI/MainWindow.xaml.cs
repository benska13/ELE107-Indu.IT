using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace O7_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool avslutt;
        private Random r;
        public MainWindow()
        {
            InitializeComponent();
            avslutt = false;
            r = new Random();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            BtnStart.IsEnabled = false;

        }

        private void TextBoxInndata_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inndata = TextBoxInndata.Text;
            char[] charArray = inndata.ToCharArray();
            Array.Reverse((charArray));
            string utdata = new string(charArray);
            TextBoxUtdata.Text = utdata;
        }

        private void BtnAvslutt_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
