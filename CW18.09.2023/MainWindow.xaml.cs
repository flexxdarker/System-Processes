using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CW18._09._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Solve_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(number.Text);
            double result = await FactoriallAsync(num);
            factorialList.Items.Add(result);
        }
        private Task<double> FactoriallAsync(int numb)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(2000);
                double result = 1;
                for (int i = 1; i <= numb; i++)
                {
                    result = i * result;
                }
                return result;
            });
        }
    }
}
