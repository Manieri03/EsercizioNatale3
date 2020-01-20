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

namespace EsercizioNatale3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private TextBox[] array;
        public MainWindow()
        {
            InitializeComponent();
            array = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6 };
        }
        
        private void btnONOFF_Click(object sender, RoutedEventArgs e)
        {
            if(btnONOFF.Content.ToString() == "ON")
            {
                for(int i=0;i<array.Length; i++)
                {
                    array[i].IsEnabled = true;
                }
                btncalcola.IsEnabled = true;
                btnONOFF.Content = "OFF";
            }
            else 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].IsEnabled = false;
                }
                btncalcola.IsEnabled = false;
                btnONOFF.Content = "ON";
            }

        }

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int c1 = 0;
                int c2 = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    int num = int.Parse(array[i].Text);
                    if (num % 2 == 0)
                    {
                        c1++;
                    }
                    else
                    {
                        c2++;
                    }
                }
                lblris.Content = $"I numeri pari sono {c1}, i numeri dispari sono {c2}";
            }
            catch
            {
                MessageBox.Show("Inserire solo numeri", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
