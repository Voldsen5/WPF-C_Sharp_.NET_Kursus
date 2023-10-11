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

namespace Lektion06_07
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

        private void OptionNew_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "New";
        }

        private void OptionOpen_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Opened";
        }

        private void OptionSave_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Saved";
        }

        private void OptionExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
