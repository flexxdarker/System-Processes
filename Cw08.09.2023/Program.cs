namespace Cw08._09._2023
{
    internal class Program
    {
        public static class Result
        {
            public static int Words = 0;
            public static int Lines = 0;
            public static int Punctuations = 0;
        }
        public static void Counts(object text)
        {
            string text2 = Convert.ToString(text);
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i] == ' ')
                {
                    Interlocked.Increment(ref Result.Words);
                }
            }
            Console.WriteLine($"\tWords: {Result.Words}");
            Result.Lines = text2.Split('\n').Length;
            Console.WriteLine($"Lines: {Result.Lines}");
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i] == '!' || text2[i] == ';' || text2[i] == ',' ||
                   text2[i] == ':' || text2[i] == '?' || text2[i] == '.')
                {
                    Interlocked.Increment(ref Result.Punctuations);
                }
            }
            Console.WriteLine($"Punctuations: {Result.Punctuations}");
        }
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("C:/Users/ksenz/Source/Repos/System-Processes/Cw08.09.2023/Text.txt");
            foreach(string file in files)
            {
                string text = File.ReadAllText(file);
                Thread thread = new Thread(Counts);
                thread.Start(text);
            }
        }
    }
}