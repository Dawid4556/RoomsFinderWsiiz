﻿using System;
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
    /// Logika interakcji dla klasy Wykladowe.xaml
    /// </summary>
    public partial class Wykladowe : Window
    {
        public Wykladowe()
        {
            InitializeComponent();
        }

        private void RA3_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\ra3.MP4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA3
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            /// <summary>
            /// Przycisk dla wstecz
            /// funkcja zamyka aktualne okno co umozliwia powrot do wczesniejszego okna 
            /// </summary>

        }

        private void RA43_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\43.mp4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA43
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void RA53_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\53.MP4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA53
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void RA101_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\101.MP4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA101
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void RA104_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\104.MP4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA104
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void RA239_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\239.MP4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA239
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }

        private void RA132_Click(object sender, RoutedEventArgs e)
        {
            filmw.Source = new Uri(@"C:\Users\Dawid\source\repos\RoomsFinderWsiiz\Pliki\projekt\sale\132.MP4");
            filmw.Play();
            /// <summary>
            /// Przycisk dla sali RA132
            /// funkcja wywołuje Media Element i wyświetla przypisany film 
            /// </summary>

        }
    }
}
