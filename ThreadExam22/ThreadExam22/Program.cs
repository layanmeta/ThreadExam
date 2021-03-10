using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam22
{
    class Program
    {
       //static ManualResetEvent host = new ManualResetEvent(false);
        static AutoResetEvent autohost = new AutoResetEvent(false);
        public static void EnterClub()
        {
            Console.WriteLine("waiting to enter...");
            //host.WaitOne();
            autohost.WaitOne();
            Console.WriteLine("entered the club");
            
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                new Thread(() =>
                {
                    EnterClub();
                }).Start();
            }
            Thread.Sleep(3000);
            Console.WriteLine("gate open");
            //host.Set();
            autohost.Set();
        }
    }
}
