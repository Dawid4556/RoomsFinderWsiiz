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


namespace RoomsFinderWsiiz
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            /// <summary>
            /// Przycisk "Exit"
            /// funkcja zamyka cały program
            /// </summary>

        }

        private void It_Click(object sender, RoutedEventArgs e)
        {
            komputerowe komputerowe= new komputerowe();
            komputerowe.Show();
            /// <summary>
            /// Przycisk dla kategorii sal komputerowych
            /// funkcja otwiera nowe onkno programu z wyborem sal komputerowych
            /// </summary>

        }

        private void Cwi_Click(object sender, RoutedEventArgs e)
        {
            Cwiczeniowe cwiczeniowe = new Cwiczeniowe();
            cwiczeniowe.Show();
            /// <summary>
            /// Przycisk dla kategorii sal ćwiczeniowych
            /// funkcja otwiera onkno z wyborem sal ćwiczeniowych
            /// </summary>

        }

        private void Wyk_Click(object sender, RoutedEventArgs e)
        {
            Wykladowe wykladowe = new Wykladowe();
            wykladowe.Show();
            /// <summary>
            /// Przycisk dla kategorii sal wykładowych
            /// funkcja otwiera onkno z wyborem sal wykładowych
            /// </summary>

        }

        private void Dzie_Click(object sender, RoutedEventArgs e)
        {
            Dziekanat dziekanat = new Dziekanat();
            dziekanat.Show();
            /// <summary>
            /// Przycisk dla kategorii sal dziekanat i samorząd studencki
            /// funkcja otwiera onkno z wyborem sali samorządu studenckiego/dziekanatu
            /// </summary>

        }
    }
}
