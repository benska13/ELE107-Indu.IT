using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Oblig1_ELE107;

namespace Oblig1_ELE107_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ISensor> _sensors = new ObservableCollection<ISensor>();
        Random _random =new Random();
        public MainWindow()
        {
            InitializeComponent();
            SensorList.ItemsSource = _sensors;
        }

     

        private void NyTemperatursensor_Click(object sender, RoutedEventArgs e)
        {
            _sensors.Add(new Temperaturmaaler(_sensors.Count+1));       //kan gi flere sensorer samme id
        }

        private void NyTrykksensor_Click(object sender, RoutedEventArgs e)
        {
            _sensors.Add(new Trykkmaaler(_sensors.Count+1));
        }

        private void NyMåling_Click(object sender, RoutedEventArgs e)
        {
            switch (SensorList.SelectedItem)
            {
                case Temperaturmaaler temp:
                    temp.Maal(_random);
                    break;
                case Trykkmaaler trykk:
                    trykk.Maal(_random);
                    break;
            }
            SensorList_SelectionChanged(null,null);
        }

        private void SensorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SensorList.SelectedItem)
            {
                case Temperaturmaaler temp:
                    textBox.Text = $"ID: {temp.Id}\nPosisjon: {temp.PosisjonX},{temp.PosisjonY}\nTemperatur: {temp.Temperatur}";
                    break;
                case Trykkmaaler trykk:
                    textBox.Text = $"ID: {trykk.Id}\nPosisjon: {trykk.PosisjonX},{trykk.PosisjonY}\nTemperatur: {trykk.Trykk}";
                    break;
            }
        }
    }
}
