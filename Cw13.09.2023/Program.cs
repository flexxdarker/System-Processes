using static System.Net.Mime.MediaTypeNames;

namespace Cw13._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task task1 = new Task(() => Task1());
            //task1.Start();
            //Task task1 = Task.Factory.StartNew(() => task1Lb.Content = DateTime.Now.ToString(), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

            //Task task1 = Task.Run(() => Task1());
            //Console.Write("Enter start: ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter end: ");
            //int end = Convert.ToInt32(Console.ReadLine());
            //Task task2 = Task.Run(() => Task2and3(start, end));
            //task2.Wait();
            //Task task4 = Task.Run(() => Task4());
            Task task5 = Task.Run(() => Task5Delete());
            Console.ReadKey();
        }
        public static void Task1()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static void Task2and3(object start, object end)
        {
            int sstart = Convert.ToInt32(start);
            int eend = Convert.ToInt32(end);
            bool isPrime = true;
            for (int i = 2; i <= eend; i++)
            {
                for (int j = 2; j <= sstart; j++)
                {
                    if (i!= j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }
        public static void Task4()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                int a = rnd.Next(1, 500);
                list.Add(a);
            }
            Console.WriteLine($"Max: {list.Max()}");
            Console.WriteLine($"Min: {list.Min()}");
            Console.WriteLine($"Avg: {list.Average()}");
            Console.WriteLine($"Summ: {list.Sum()}");
        }
        static List<int> numbers = new List<int>();
        public static void fill()
        {
            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                int a = rnd.Next(1, 500);
                numbers.Add(a);
            }
        }
        public static void initialize()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Num{i}: {numbers[i]}");
            }
        }
        public static void Task5Delete()
        {
            fill();
            initialize();
            for (int i = 0; i < 499; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    numbers.Remove(i);
                }
            }
            initialize();
        }
    }
}