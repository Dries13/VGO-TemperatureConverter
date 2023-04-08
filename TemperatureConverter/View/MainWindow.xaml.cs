using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using System.Windows.Data;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class CelsiusConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var kelvin = (double)value;
                var celsius = kelvin - 273.15;

                return celsius.ToString();
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var celsius = double.Parse((string)value);
                var kelvin = celsius + 273.15;

                return kelvin;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var far = double.Parse(textboxFar.Text);
            var cel = Math.Round((far - 32) / 1.8, 2);
            textboxCel.Text = cel.ToString();
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var cel = double.Parse(textboxCel.Text);
            var far = Math.Round((1.8*cel + 32), 2);
            textboxFar.Text = far.ToString();
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var far = double.Parse(textboxFar.Text);
            var cel = Math.Round((far - 32) / 1.8, 2);
            textboxCel.Text = cel.ToString();
            var kel = cel+273.15;
            //textboxKel.Text = kel.ToString();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var cel = double.Parse(textboxCel.Text);
            var far = Math.Round((1.8 * cel + 32), 2);
            textboxFar.Text = far.ToString();
            var kel = cel+273.15;
            //textboxKel.Text = kel.ToString();
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            /*var kel = double.Parse(textboxKel.Text);
            var cel = kel - 273.15;
            textboxCel.Text = cel.ToString();
            var far = Math.Round((1.8 * cel + 32), 2);
            textboxFar.Text = far.ToString();*/
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var kel = slider.Value;
            var cel = kel - 273.15;
            var far = Math.Round((1.8 * cel + 32), 2);
            textboxFar.Text = far.ToString();
        } 
    }

}
