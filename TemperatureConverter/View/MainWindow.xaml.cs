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
            var far = double.Parse(textbox.Text);
            var cel = Math.Round((far - 32) / 1.8, 2);
            textbox.Text = cel.ToString();
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var cel = double.Parse(textbox.Text);
            var far = Math.Round((1.8*cel + 32), 2);
            textbox.Text = far.ToString();
        }
    }
}
