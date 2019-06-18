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
    /// Logika interakcji dla klasy Dziekanat.xaml
    /// </summary>
    public partial class Dziekanat : Window
    {
        public Dziekanat()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Dziekanat_Click(object sender, RoutedEventArgs e)
        {
            filmd.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\Dz.MP4");
            filmd.Play();
        }

        private void Samorzad_Click(object sender, RoutedEventArgs e)
        {
            filmd.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\SA.MP4");
            filmd.Play();
        }
    }
}
