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
    /// Interaction logic for Programma5.xaml
    /// </summary>
    public partial class Programma5 : Window
    {
        public Programma5()
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
            
            lbl_uitkomst.Content = cmb_diktePLaten.Text;
        }

        private void ComboBox(object sender, SelectionChangedEventArgs e)
        {

        }

        
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void Test()
        {
            ComboBox comboBox1 = new ComboBox();

            ComboboxItem item = new ComboboxItem();
            item.Text = "8 mm";
            item.Value = 4.80;

            comboBox1.Items.Add(item);

            comboBox1.SelectedIndex = 0;

            MessageBox.Show((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
        }
        
        /*
        private void OK(object sender, RoutedEventArgs e)
        {
            lbl_uitkomst.Content = cmb_diktePLaten.SelectedItem;
            /*
            double h, b, l, opp;
            h = Convert.ToDouble(txt_hoogte.Text);
            b = Convert.ToDouble(txt_breedte.Text);
            l = Convert.ToDouble(txt_lengte.Text);

            opp = (l * h) + (l * b) + (h * b);

            lbl_uitkomst.Content = opp;
            
        }
        */


    }
}
