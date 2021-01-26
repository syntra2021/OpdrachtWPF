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
using System.Linq;

namespace OpdrachtWPF
{
    /// <summary>
    /// Interaction logic for Programma3.xaml
    /// </summary>
    public partial class Programma3 : Window
    {
        public Programma3()
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
            string str = txt_textbox.Text;
            char ch = Convert.ToChar(txt_character.Text);

            int freq = str.Where(x => (x == ch)).Count();
            Convert.ToString(freq);
            lbl_uitkomst.Content = freq;
        }
    }
}
