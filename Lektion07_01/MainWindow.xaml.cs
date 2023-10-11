using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Lektion07_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p1 = new Person("Kristoffer",23,100,5,true);
        public MainWindow()
        {
            InitializeComponent();
            textBox_name.DataContext = p1;
            textBox_age.DataContext = p1;
            textBox_weight.DataContext = p1;
            textBox_score.DataContext = p1;
            checkBox_accepted.DataContext = p1;
        }

        public void randScore()
        {
            Random rand = new Random();
            p1.Score = rand.Next(0,20);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            randScore();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Name: " + p1.Name + ", Score: " +  p1.Score);
        }
    }
}
