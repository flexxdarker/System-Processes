namespace ZhaduvannyaMunyloho
{
    internal class Program
    {
        unsafe static void FillArr()
        {
            Console.Write("Enter size of first arr: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size of second arr: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int* a = stackalloc int[m];
            int* b = stackalloc int[n];
            int* c = stackalloc int[m + n];
            Random rnd = new Random();
            Console.WriteLine($"\tFirst array with size: {m}");
            for (int i = 0; i < m; i++)
            {
                a[i] = rnd.Next(1, 255);
                Console.WriteLine($"[{i + 1}] number - {a[i]}");
            }
            Console.WriteLine($"\tSecond array with size: {n}");
            for (int i = 0; i < n; i++)
            {
                b[i] = rnd.Next(1, 255);
                Console.WriteLine($"[{i + 1}] number - {b[i]}");
            }
            for (int i = 0; i < m + n; i++)
            {
                if (i < m)
                {
                    c[i] = a[i];
                }
                else 
                {
                    c[i] = b[i - m];
                }
            }
            Console.WriteLine($"\tFinal array with size: {m+n}");
            for (int i = 0; i < m+n; i++)
            {
                Console.WriteLine($"[{i + 1}] number - {c[i]}");
            }
        }
        static void Main(string[] args)
        {
            FillArr();
        }
    }
}