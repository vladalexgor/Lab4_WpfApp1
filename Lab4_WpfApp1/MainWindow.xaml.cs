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

namespace Lab4_WpfApp1
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
            double rateDollar = Convert.ToDouble(rate_D.Text);
            double sumDollar = Convert.ToDouble(sum_D.Text);
            double resDouble = rateDollar * sumDollar;
            resSum_D.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate_E.Text);
            double sumEuro = Convert.ToDouble(sum_E.Text);
            double resEuro = rateEuro * sumEuro;
            resSum_E.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr = Convert.ToDouble(rate_G.Text);
            double sumGr = Convert.ToDouble(sum_G.Text);
            double resGr = rateGr * sumGr;
            resSum_G.Text = resGr.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate_AD.Text);
            double sumDram = Convert.ToDouble(sum_AD.Text);
            double resDram = rateDram * sumDram;
            resSum_AD.Text = resDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(inches.Text);
            double result = 0.0254 * value;
            resInches.Text = result.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(foot.Text);
            double result = 0.3048 * value;
            resFoot.Text = result.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(mile.Text);
            double result = 1609.344 * value;
            resMile.Text = result.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(verst.Text);
            double result = 1066.8 * value;
            resVerst.Text = result.ToString(); 
        }
    }
}
