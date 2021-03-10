using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam33
{
    class Program
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        static int count = 0;
       static public void MyTimer()
        {
           
            for (int i = 0; i == count; i++)
            {
                count++;
                Thread.Sleep(1000);
                Console.WriteLine("Increased the timer. Count: " + count);
            }
            
           
        }
        static void Main(string[] args)
        {
            Task t = new Task(() =>
            {
                MyTimer();
            },cts.Token);
            Console.WriteLine("Timer is starting");
            t.Start();
            Console.ReadLine();
            cts.Cancel();
            Console.WriteLine($"timer stopped {count}" );

        }
    }
}
