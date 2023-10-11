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

namespace Lektion06_01
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

        private void Knap1_Click(object sender, RoutedEventArgs e)
        {
            Knap1.Content = "Wow";
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            Knap1.Visibility = Visibility.Collapsed;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Knap1.Visibility = Visibility.Visible;
        }
    }
}