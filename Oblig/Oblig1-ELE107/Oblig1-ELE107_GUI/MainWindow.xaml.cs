using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Oblig1_ELE107;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Oblig1_ELE107_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [System.Serializable]
    public partial class MainWindow : Window
    {
        ObservableCollection<ISensor> _sensors = new ObservableCollection<ISensor>();   //liste for sensorer
        Random _random = new Random();          
        private const string Filnavn = "SensorFil.dat";         

        public MainWindow()
        {
            InitializeComponent();
            SensorList.ItemsSource = _sensors;      
        }
        
        private void NyTemperatursensor_Click(object sender, RoutedEventArgs e)
        {
            _sensors.Add(new Temperaturmaaler(_sensors.Count + 1));       //kan gi flere sensorer samme id hvis en blir slettet
        }

        private void NyTrykksensor_Click(object sender, RoutedEventArgs e)
        {
            _sensors.Add(new Trykkmaaler(_sensors.Count + 1));
        }

        private void NyMåling_Click(object sender, RoutedEventArgs e)
        {
            switch (SensorList.SelectedItem)        //Sjekker hvilken datatype det er og caster den til rett type for å bruke metoder
            {
                case Temperaturmaaler temp:
                    temp.Maal(_random);
                    break;
                case Trykkmaaler trykk:
                    trykk.Maal(_random);
                    break;
            }
            SensorList_SelectionChanged(null, null);            //oppdatere textbox
        }

        private void SensorList_SelectionChanged(object sender, SelectionChangedEventArgs e)        //printer til textbox
        {
            switch (SensorList.SelectedItem)
            {
                case Temperaturmaaler temp:
                    textBox.Text = $"ID: {temp.Id}\nPosisjon: {temp.PosisjonX},{temp.PosisjonY}\nTemperatur: {temp.Temperatur}";
                    break;
                case Trykkmaaler trykk:
                    textBox.Text = $"ID: {trykk.Id}\nPosisjon: {trykk.PosisjonX},{trykk.PosisjonY}\nTrykk: {trykk.Trykk}";
                    break;
            }
        }
        static void Deserialize<T>(ref ObservableCollection<T> listen, string filnavn)      //Lese/skrive til fil
        {
            listen = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(filnavn, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                listen = (ObservableCollection<T>)formatter.Deserialize(fs);

            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
        static void Serialize<T>(ref ObservableCollection<T> listen, string filnavn)        //Lese/skrive til fil
        {
            //Lagring av listen med objekter

            FileStream fs = new FileStream(filnavn, FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, listen);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


        ///Handling box,
        ///  -Endre navn og evt type for å få mer oversiktlig 
   
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SensorList.ItemsSource = _sensors;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Filnavn))
            {
                Deserialize<ISensor>(ref _sensors, Filnavn);
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Serialize(ref _sensors, Filnavn);
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            _sensors.Clear();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

}
