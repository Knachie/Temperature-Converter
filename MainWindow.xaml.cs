﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Temperature_Converter_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] units = { "Kelvin", "Celcius", "Rankine", "Fahrenheit" };
        public MainWindow()
        {
            InitializeComponent();
            InputUnit.ItemsSource = units;
            InputUnit.SelectedIndex = 0;

            OutputUnit.ItemsSource = units;
            OutputUnit.SelectedIndex = 0;

        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(InputUnit.SelectedIndex.ToString());
        }

        private float CelciusToKelvin(float celsius)
        {
            float kelvin = celsius + 273.15f;
            return kelvin;
        }
        
        private float FahrenheitToKelvin(float fahrenheit)
        {
            float kelvin = (fahrenheit + 459.67f) / 1.8f;
            return kelvin;
        }

        private float RankineToKelvin(float rankine)
        {
            float kelvin = rankine / 1.8f;
            return kelvin;
        }
    
        private float[] KelvinToAll(float kelvin)
        {
            float[] result = new float[4];
            result[0] = kelvin;
            result[1] = kelvin - 273.15f;
            result[2] = kelvin * 1.8f;
            result[3] = result[2] + 459.67f;
            return result;
        }
    }
}