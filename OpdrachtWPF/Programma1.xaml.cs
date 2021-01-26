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

namespace OpdrachtWPF
{
    /// <summary>
    /// Interaction logic for Programma1.xaml
    /// </summary>
    public partial class Programma1 : Window
    {
        public Programma1()
        {
            InitializeComponent();
        }

        private void Maal(object sender, RoutedEventArgs e)
        {
            int getal1, getal2, som;
            getal1 = Convert.ToInt32(txt_getal1.Text);
            getal2 = Convert.ToInt32(txt_getal2.Text);
            som = getal1 * getal2;
            lbl_uitkomst.Content = som; //content = inhoud van het vakje
        }
        private void Gedeeld(object sender, RoutedEventArgs e)
        {
            int getal1, getal2, gedeeld;
            getal1 = Convert.ToInt32(txt_getal1.Text);
            getal2 = Convert.ToInt32(txt_getal2.Text);
            gedeeld = getal1 / getal2;
            lbl_uitkomst.Content = gedeeld;
        }
        private void Plus(object sender, RoutedEventArgs e)
        {
            int getal1, getal2, plus;
            getal1 = Convert.ToInt32(txt_getal1.Text);
            getal2 = Convert.ToInt32(txt_getal2.Text);
            plus = getal1 + getal2;
            lbl_uitkomst.Content = plus;
        }

        private void Min(object sender, RoutedEventArgs e)
        {
            int getal1, getal2, min;
            getal1 = Convert.ToInt32(txt_getal1.Text);
            getal2 = Convert.ToInt32(txt_getal2.Text);
            min = getal1 - getal2;
            lbl_uitkomst.Content = min;
        }
        
        private void Home(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
