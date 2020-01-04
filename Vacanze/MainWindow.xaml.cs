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

namespace Vacanze
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txta.Text);
            lbla.Content = $"a+1 = {a + 1}";
            int b = int.Parse(txtb.Text);
            lblb.Content = $"binario = {Convert.ToString(b, 2)}";
            lblc.Content = $"binario = {Convert.ToString(-b, 2)}";
            int value = int.Parse(txtvalue.Text);
            lblvalue.Content = $"~value+1 = {~value + 1}; somma = {value + (~value + 1)}";
            long number = long.Parse(txta.Text);
            lblnumber.Content = $"{Convert.ToString(number, 2)}";
        }

        private void Txtb_TextChanged(object sender, TextChangedEventArgs e)
        {
            int b = int.Parse(txtb.Text);
            txtc.Text = (-b).ToString();
        }

        private void Txtnumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            long number = long.Parse(txtnumber.Text);
            short number1 = (short)number;
            txtnumber1.Text = number1.ToString();
        }
    }
}
