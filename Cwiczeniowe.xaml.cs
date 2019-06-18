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
    }
}
