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
    /// Interaction logic for Programma2.xaml
    /// </summary>
    public partial class Programma2 : Window
    {
        public Programma2()
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
            int a, b;
            a = Convert.ToInt32(txt_a.Text);
            b = Convert.ToInt32(txt_b.Text);
            lbl_uitkomst.Content = Math.Pow(a, 2) + (2 * (a * b)) + Math.Pow(b, 2);
        }
    }
}
