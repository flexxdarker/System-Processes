using System;
using System.Collections.Generic;
using System.IO;
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

namespace CW06._09._2023._2
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
        static void Task1()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"Number: {i}");
            }
        }
        static void Task2()
        {
            int start = 0;
            int end = 0;
            Console.Write("Enter start number: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end number: ");
            end = Convert.ToInt32(Console.ReadLine());
            if (start >= end)
            {
                int a = start;
                end = start;
                end = a;
            }
            for (; start <= end; start++)
            {
                Console.WriteLine($"Number: {start}");
            }
        }
        static void Task3()
        {
            Console.Write("Enter threads: ");
            int times = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                Thread thread = new Thread(Task1);
                thread.Start();
            }
        }
        static void Task4Max()
        {
            string path = "C:/Users/dev/source/repos/System Processes/CW06.09.2023/savefile.txt";
            List<int> ints = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                ints.Add(i);
            }
            Console.WriteLine($"Max: {ints.Max()}");
            int max = ints.Max();
            File.AppendAllText(path, Convert.ToString(max) + "\n");
        }
        static void Task4Min()
        {
            string path = "C:/Users/dev/source/repos/System Processes/CW06.09.2023/savefile.txt";
            List<int> ints = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                ints.Add(i);
            }
            Console.WriteLine($"Min: {ints.Min()}");
            int min = ints.Min();
            File.AppendAllText(path, Convert.ToString(min) + "\n");
        }
        static void Task4Avg()
        {
            string path = "C:/Users/dev/source/repos/System Processes/CW06.09.2023/savefile.txt";
            List<int> ints = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                ints.Add(i);
            }
            Console.WriteLine($"Max: {ints.Average()}");
            double avg = ints.Average();
            File.AppendAllText(path, avg.ToString() + "\n");
        }
        static void Task4()
        {
            Thread thread1 = new Thread(Task4Max);
            Thread thread2 = new Thread(Task4Min);
            Thread thread3 = new Thread(Task4Avg);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(Task3);
            thread.Start();
        }
    }
}
