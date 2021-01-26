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

namespace OpdrachtWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void CloseCommandBinding_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            if (MessageBox.Show("Close?", "Close", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                this.Close();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Programma1(object sender, RoutedEventArgs e)
        {
            Programma1 p1 = new Programma1();
            p1.Show();
            this.Close();
        }

        private void Programma2(object sender, RoutedEventArgs e)
        {
            Programma2 p2 = new Programma2();
            p2.Show();
            this.Close();
        }
        private void Programma3(object sender, RoutedEventArgs e)
        {
            Programma3 p3 = new Programma3();
            p3.Show();
            this.Close();
        }
        private void Programma4(object sender, RoutedEventArgs e)
        {
            Programma4 p4 = new Programma4();
            p4.Show();
            this.Close();
        }
        private void Programma5(object sender, RoutedEventArgs e)
        {
            Programma5 p5 = new Programma5();
            p5.Show();
            this.Close();
        }
        private void Programma6(object sender, RoutedEventArgs e)
        {
            Programma6 p6 = new Programma6();
            p6.Show();
            this.Close();
        }
    }
}
