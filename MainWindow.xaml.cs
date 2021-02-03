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

namespace _2021._02._01_wpf_app
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


        private void MygtukasSudetisClick(object sender, RoutedEventArgs e)
        {
            var pirmas = int.TryParse(pirmasSkaicius.Text, out int pirmasSk);
            var antras = int.TryParse(antrasSkaicius.Text, out int antrasSk);

            if (pirmas & antras)
            {
                rezultatas.Text = $"{pirmasSk + antrasSk}";
            }
            else
            {
                rezultatas.Text = "Įveskite skaičius";
            }

        }

        private void MygtukasAtimtisClick(object sender, RoutedEventArgs e)
        {
            var pirmas = int.TryParse(pirmasSkaicius.Text, out int pirmasSk);
            var antras = int.TryParse(antrasSkaicius.Text, out int antrasSk);

            if (pirmas & antras)
            {
                rezultatas.Text = $"{pirmasSk - antrasSk}";
            }
            else
            {
                rezultatas.Text = "Įveskite skaičius";
            }

        }
        private void MygtukasDalybaClick(object sender, RoutedEventArgs e)
        {
            var pirmas = double.TryParse(pirmasSkaicius.Text, out double pirmasSk);
            var antras = double.TryParse(antrasSkaicius.Text, out double antrasSk);

            if (pirmas & antras)
            {
                rezultatas.Text = $"{pirmasSk / antrasSk}";
            }
            else
            {
                rezultatas.Text = "Įveskite skaičius";
            }

        }
        private void MygtukasDaugybaClick(object sender, RoutedEventArgs e)
        {
            var pirmas = double.TryParse(pirmasSkaicius.Text, out double pirmasSk);
            var antras = double.TryParse(antrasSkaicius.Text, out double antrasSk);

            if (pirmas & antras)
            {
                rezultatas.Text = $"{pirmasSk * antrasSk}";
            }
            else
            {
                rezultatas.Text = "Įveskite skaičius";
            }

        }

        private void MygtukasIšvalytiClick(object sender, RoutedEventArgs e)
        {
            pirmasSkaicius.Text = "";
            antrasSkaicius.Text = "";
            rezultatas.Text = "";
        }


      
    }
}
