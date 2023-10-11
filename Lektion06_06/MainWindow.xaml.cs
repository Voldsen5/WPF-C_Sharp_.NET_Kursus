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

namespace Lektion06_06
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

        private void North_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "North";
        }

        private void South_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "South";
        }

        private void East_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "East";
        }

        private void West_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "West";
        }
    }
}
