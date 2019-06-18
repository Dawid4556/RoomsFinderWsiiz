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
using System.Windows.Shapes;

namespace RoomsFinderWsiiz
{
    /// <summary>
    /// Logika interakcji dla klasy Cwiczeniowe.xaml
    /// </summary>
    public partial class Cwiczeniowe : Window
    {
        public Cwiczeniowe()
        {
            InitializeComponent();
        }

        private void Ra17_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\17.MP4");
            filmc.Play();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Ra20_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\20.MP4");
            filmc.Play();

        }

        private void Ra44_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\44.MP4");
            filmc.Play();
        }

        private void Ra110_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\110.MP4");
            filmc.Play();
        }

        private void Ra120_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\12120.MP4");
            filmc.Play();
        }

        private void Ra129_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\129.MP4");
            filmc.Play();
        }

        private void Ra130_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\130.MP4");
            filmc.Play();
        }

        private void Ra142_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\142.MP4");
            filmc.Play();
        }

        private void Ra206_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\206.MP4");
            filmc.Play();
        }

        private void Ra305_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\305.MP4");
            filmc.Play();
        }

        private void Ra212_Click(object sender, RoutedEventArgs e)
        {
            filmc.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\212.MP4");
            filmc.Play();
        }
    }
}
