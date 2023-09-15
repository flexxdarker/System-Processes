namespace Cw15._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Parallel.For(1, 20, Factorial);
            //Task 2
            //Parallel.Invoke(()=>CountNums(658214782), () => CountSumm(658214782));
            //Task 3
            Parallel.For(1, 3, MultInFile);
            //Task 4
            string path = "C:/Users/dev/source/repos/System Processes/Cw15.09.2023/Factorial.txt";
            List<int> numbers = new List<int>();//File.ReadLines(path).;
            if(File.Exists(path))
            {
                string[] nums = File.ReadAllLines(path);
                for (int i = 0; i < nums.Length; i++)
                {
                    numbers.Add(int.Parse(nums[i]));
                }
            }
            //Parallel.ForEach(numbers, FactorialFromFile);
            //Task 5
            var summ = numbers.AsParallel().Sum();
            var min = numbers.AsParallel().Min();
            var max = numbers.AsParallel().Max();
            Console.WriteLine($"Summ of all numbers: {summ}");
            Console.WriteLine($"Max of all numbers: {max}");
            Console.WriteLine($"Min of all numbers: {min}");
        }
        public static void FactorialFromFile(int x)
        {
            int result = 1;
            for (int i = 1; i < x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial of {x} : {result}");
        }
        public static void MultInFile(int a)
        {
            string path = "C:/Users/dev/source/repos/System Processes/Cw15.09.2023/FileToSave.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < a; j++)
                    {
                        int mult = j * i;
                        string res = $"{i} * {j} = {mult}";
                        sw.WriteLine(res);
                    }
                }
                sw.Close();
            }
        }
        public static void CountNums(int num)
        {
            int numbers = 0;
            while (num > 0)
            {
                numbers++;
                int n = num % 10;
                num /= 10;
            }
            Console.WriteLine($"Count of numbers: {numbers}");
        }
        public static void CountSumm(int num)
        {
            int summOfNums = 0;
            while (num > 0)
            {
                int n = num % 10;
                summOfNums += n;
                num /= 10;
            }
            Console.WriteLine($"Sum of numbers: {summOfNums}");
        }
        public static void Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i < x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial of {x} : {result}");
        }
    }
}