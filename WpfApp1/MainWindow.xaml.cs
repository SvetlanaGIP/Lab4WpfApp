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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar=Convert.ToDouble(sum.Text);
            double resDouble=rateDollar*sumDollar;
            resSum.Text=resDouble.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEu.Text);
            double sum = Convert.ToDouble(sumEu.Text);
            double resDouble = rate * sum;
            resSumEu.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateGr.Text);
            double sum = Convert.ToDouble(sumGr.Text);
            double resDouble = rate * sum;
            resSumGr.Text = resDouble.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateAr.Text);
            double sum = Convert.ToDouble(sumAr.Text);
            double resDouble = rate * sum;
            resSumAr.Text = resDouble.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(quantity.Text);
            double resDouble = rate / 39.37;
            resD.Text = resDouble.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(quantityF.Text);
            double resDouble = rate / 3.28;
            resF.Text = resDouble.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(quantityM.Text);
            double resDouble = rate * 1609.34;
            resM.Text = resDouble.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(quantityV.Text);
            double resDouble = rate * 1066.8;
            resV.Text = resDouble.ToString();
        }
    }
}
