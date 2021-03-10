using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam14
{
    class Program
    {
        
        public static void lamda()
        {
            new Thread(() => { downloadFile(); }).Start();
            ThreadPool.QueueUserWorkItem(state => Multiply(2,2));
        }
        private static void downloadFile()
        {
            Console.WriteLine("Downloading the file...");
            Thread.Sleep(10000);
            Console.WriteLine("Downloading Complete!");
        }
        private static void Multiply(int a, int b)
        {

            Console.WriteLine(a * b);
        }
            
        static void Main(string[] args)
        {
            lamda();
        }
    }
}
