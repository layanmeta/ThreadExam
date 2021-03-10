using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExam27And28
{
    class Program
    {

        static void Main(string[] args)
        {
            //1
            Task.Run(() =>
            {
                Console.WriteLine("welcome");
            }).ContinueWith(task =>
            {
                Console.WriteLine("goodbye");
            });
            //2
            Task.Run(() =>
            {
                Console.WriteLine("welcome");
            }).ContinueWith(task =>
            {
                Console.WriteLine("goodbye");
            });
            //3
            Task.Run(() =>
            {
                Console.WriteLine("welcome");
            }).ContinueWith(task =>
            {
                Console.WriteLine("goodbye");
            }, TaskContinuationOptions.OnlyOnFaulted);


            //28
            Task.Run(() =>
            {
                Console.WriteLine("thats the time");

            }).ContinueWith(task =>
            {
                Console.WriteLine(DateTime.Now);
              
            }, TaskContinuationOptions.OnlyOnFaulted);

        }
    }
}
