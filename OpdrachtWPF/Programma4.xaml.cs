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
    /// Interaction logic for Programma4.xaml
    /// </summary>
    public partial class Programma4 : Window
    {
        public Programma4()
        {
            InitializeComponent();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            double h, s, p;
            h = Convert.ToDouble(txt_hoogte.Text);
            s = Convert.ToDouble(txt_straal.Text);
            p = Convert.ToDouble(txt_procent.Text);

            lbl_uitkomst.Content = (Math.PI * Math.Pow(s, 2) * p);
        }
    }
}
