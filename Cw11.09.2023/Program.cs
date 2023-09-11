using System.Runtime.Remoting;

namespace Cw11._09._2023
{
    internal class Program
    {
        static int iter = 0;
        static void Main(string[] args)
        {
            //task1
            //Semaphore s = new Semaphore(3, 3);
            //Thread[] threads = new Thread[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    threads[i] = new Thread(Task1Method);
            //    threads[i].Start(s);
            //}
            AutoResetEvent are = new AutoResetEvent(false);
            for (int i = 0; i < 3; i++)
            {
                ThreadPool.QueueUserWorkItem(MethodToTask2, are);
            }
            Console.ReadKey();
        }
        //static void Task1Method(object obj)
        //{
        //    Semaphore s = obj as Semaphore;
        //    bool stop = false;
        //    Random rnd = new Random();
        //    int it = 0; 
        //    while (!stop)
        //    {
        //        if(s.WaitOne())
        //        {
        //            try
        //            {
        //                for (int i = 0; i < 5; i++)
        //                {
        //                    it = rnd.Next(1, 50000);
        //                    Console.WriteLine($"Number: {it}");
        //                }
        //                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} locked");
        //                Thread.Sleep(1000);
        //            }
        //            finally
        //            {
        //                stop = true;
        //                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} unlocked");
        //                s.Release();
        //            }
        //            iter++;
        //        }
        //        else
        //            Console.WriteLine($"Timeout for thread {Thread.CurrentThread.ManagedThreadId} expired. Re-waiting...");
        //    }
        //    if(iter == 10)
        //    {
        //        Console.WriteLine("Completed");
        //    }
        //}
        static void MethodToTask2(object obj)
        {
            Random rnd = new Random();
            int number = 0;
            EventWaitHandle ewh = obj as EventWaitHandle;
            string path1 = "C:\\Users\\dev\\source\\repos\\System Processes\\Cw11.09.2023\\TextFiles\\FirstThread.txt";
            string path2 = "C:\\Users\\dev\\source\\repos\\System Processes\\Cw11.09.2023\\TextFiles\\SecondThread.txt";
            string path3 = "C:\\Users\\dev\\source\\repos\\System Processes\\Cw11.09.2023\\TextFiles\\FinalThread.txt";
            if (iter == 0)
            {

                ewh.Reset();
                Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
                ewh.WaitOne();
                for (int i = 0; i < 4; i++)
                {
                    number = rnd.Next(1, 10);
                    string tmp = Convert.ToString(number);
                    File.AppendAllText(path1, tmp);
                }
                iter++;

            }
            else if (iter == 1 && Thread.CurrentThread.ManagedThreadId == 2)
            {
                ewh.WaitOne();

            }
        }
    }
}