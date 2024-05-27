using System.Windows;

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
			float input = 0f;
			float kelvin = 0f;

			try
			{
				input = (float) Convert.ToDouble(InputText.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Something went wrong. Try again.\n Error code: {ex}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				input = 0f;
			}

			switch (InputUnit.SelectedIndex)
			{
				case 0:
					kelvin = input;
					break;
				case 1:
					kelvin = CelciusToKelvin(input);
					break;
				case 2:
					kelvin = RankineToKelvin(input);
					break;
				case 3:
					kelvin = FahrenheitToKelvin(input);
					break;
			}

			OutputText.Text = KelvinToAll(kelvin)[OutputUnit.SelectedIndex].ToString();
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
			result[3] = result[2] - 459.67f;
			return result;
		}
	}
}