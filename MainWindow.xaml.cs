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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using QUANLYGIANGVIEN.Pages;

namespace QUANLYGIANGVIEN
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // InitializeMaterialDesign();
            InitializeComponent();
            PagesNavigation.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //private void InitializeMaterialDesign()
        //{
        //    // Create dummy objects to force the MaterialDesign assemblies to be loaded
        //    // from this assembly, which causes the MaterialDesign assemblies to be searched
        //    // relative to this assembly's path. Otherwise, the MaterialDesign assemblies
        //    // are searched relative to Eclipse's path, so they're not found.
        //    var card = new Card();
        //    var hue = new Hue("Dummy", Colors.Black, Colors.White);
        //}

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
           // PagesNavigation.Navigate(new HomePage());

            PagesNavigation.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/GiangVien.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdNotes_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/monhoc.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdPayment_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/khoa.xaml", UriKind.RelativeOrAbsolute));
        }

        private void github_StackPanel(object sender, RoutedEventArgs e)
        {
            // https://github.com/dopaemon
        }
    }
}
