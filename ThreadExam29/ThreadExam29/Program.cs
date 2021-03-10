using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task.WaitAll
            Task t1 = new Task(() =>
            {
                Thread.Sleep(5000);
            });

            Task t2 = new Task(() =>
            {
                Thread.Sleep(5000);
            });

            Task t3 = new Task(() =>
            {
                Thread.Sleep(5000);
            });

            t1.Start();
            t2.Start();
            t3.Start();

            while (!t1.IsCompleted && !t2.IsCompleted && !t3.IsCompleted)
            {
               
            }
            Console.WriteLine("All tasks are done");

            // answer to c: !t.iscompleted is behind the () and not inside it
            // to fox:  while (!t1.IsCompleted) {}

        }
    }
}
