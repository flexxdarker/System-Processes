using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Cw18._09._2023._2
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

        private void to_Click(object sender, RoutedEventArgs e)
        {
            FileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            copyTo.Text = ofd.FileName;
        }

        private void from_Click(object sender, RoutedEventArgs e)
        {
            FileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            copyFrom.Text = ofd.FileName;
        }

        private async void startCopy_Click(object sender, RoutedEventArgs e)
        {
            string fileFrom = copyFrom.Text;
            string fileTo = copyTo.Text;
            await CopyFileAsync(fileFrom, fileTo);
        }
        private Task CopyFileAsync(string from, string to)
        {
            return Task.Run(() =>
            {
                File.Copy(from, to);
            });
        }
    }
}
