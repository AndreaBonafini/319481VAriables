/*Andrea Bonafini
 * feb 21,2019
    */
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

namespace _319481Variables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Variable Examples
            bool booWantIceCream;
            booWantIceCream = true;
            MessageBox.Show(booWantIceCream.ToString());

            //int example
            int x;
            x = 3;
            x = x + 1;
            x = x * 2;
            double y;
            y = (double)x / 3;
            MessageBox.Show(y.ToString());
            x = x / 3;
            MessageBox.Show(x.ToString());

            //double - decimal numbers

            double num1 =0.7;
            double num2 =0.025;
            double answer = num1 / num2;            
            MessageBox.Show(answer.ToString());
        }

        private void chkWantIceCream_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)chkWantIceCream.IsChecked)
            {
                MessageBox.Show("You owe me $4,85");
            }
            else
            {
                MessageBox.Show("Smart,too cold for Ice cream");
            }
        }
    }     
}
