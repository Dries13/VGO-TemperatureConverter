using System;
using System.Collections.Generic;
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

namespace View
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
            textboxKel.Text = kel.ToString();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var cel = double.Parse(textboxCel.Text);
            var far = Math.Round((1.8 * cel + 32), 2);
            textboxFar.Text = far.ToString();
            var kel = cel+273.15;
            textboxKel.Text = kel.ToString();
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var kel = double.Parse(textboxKel.Text);
            var cel = kel - 273.15;
            textboxCel.Text = cel.ToString();
            var far = Math.Round((1.8 * cel + 32), 2);
            textboxFar.Text = far.ToString();
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var kel = slider.Value;
            textboxKel.Text = kel.ToString();
            var cel = kel - 273.15;
            textboxCel.Text = cel.ToString();
            var far = Math.Round((1.8 * cel + 32), 2);
            textboxFar.Text = far.ToString();
        }
    }
}
