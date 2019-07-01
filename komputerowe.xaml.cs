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
    /// Logika interakcji dla klasy komputerowe.xaml
    /// </summary>
    public partial class komputerowe : Window
    {
        public komputerowe()
        {
            InitializeComponent();
        }

        private void Ra114_Click(object sender, RoutedEventArgs e)
        {
            filmk.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\104.MP4");
            filmk.Play();
            /// <summary>
            /// Przycisk dla sali RA114
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            /// <summary>
            /// Przycisk dla wstecz
            /// funkcja zamyka aktualne okno co umozliwia powrot do wczesniejszego okna 
            /// </summary>
        }

        private void Ra117_Click(object sender, RoutedEventArgs e)
        {
            filmk.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\117.MP4");
            filmk.Play();
            /// <summary>
            /// Przycisk dla sali RA117
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void Ra121_Click(object sender, RoutedEventArgs e)
        {
            filmk.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\12120.MP4");
            filmk.Play();
            /// <summary>
            /// Przycisk dla sali RA121
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void Ra145_Click(object sender, RoutedEventArgs e)
        {
            filmk.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\145.MP4");
            filmk.Play();
            /// <summary>
            /// Przycisk dla sali RA145
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void Ra250_Click(object sender, RoutedEventArgs e)
        {
            filmk.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\250.MP4");
            filmk.Play();
            /// <summary>
            /// Przycisk dla sali RA250
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void Ra236_Click(object sender, RoutedEventArgs e)
        {
            filmk.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\236.MP4");
            filmk.Play();
            /// <summary>
            /// Przycisk dla sali RA236
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }
    }
}
