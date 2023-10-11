using Lektion08_01.DAL;
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
using Lektion08_01.MODEL;

namespace Lektion08_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BilContext bilContext = new BilContext();
        public MainWindow()
        {
            InitializeComponent();
            Bil bil1 = new Bil("Ford",2000);
            Bil bil2 = new Bil("Toyota", 1000);
            Firma firma1 = new Firma("DSB");

            bilContext.Biler.Add(bil1);
            bilContext.Biler.Add(bil2);
            bilContext.Firma.Add(firma1);
            bil1.Firma = firma1;

            bilContext.SaveChanges();
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            BilListe.Items.Clear();
            Firmaliste.Items.Clear();

            foreach (Bil bil in bilContext.Biler) 
            {
                BilListe.Items.Add(bil);
                    if (bil.Firma.Name != null)
                    {
                    Firmaliste.Items.Add(bil.Firma);
                    }
            }
        }
    }
}
