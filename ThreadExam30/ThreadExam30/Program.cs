using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam30
{
    class Program
    {
        static void Main(string[] args)
        {
            //WaitAny - waits the task you choose to finish before continuing 
            var random = new Random();
            Task t1 = new Task(() =>
            {  
                Thread.Sleep(random.Next(5, 10) * 1000);
                Console.WriteLine("1");
            });
            Task t2 = new Task(() =>
            {
                Thread.Sleep(random.Next(5, 10) * 1000);
                Console.WriteLine("2");
            });
            Task t3 = new Task(() =>
            { 
                Thread.Sleep(random.Next(5, 10) * 1000);
                Console.WriteLine("3");
            });

            t1.Start();
            t2.Start();
            t3.Start();
            Task.WaitAny(t1);
            Console.WriteLine("Task One is done!");
        }
    }
}
