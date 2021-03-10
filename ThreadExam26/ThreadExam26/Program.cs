using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam26
{
    class Program
    {
       static Task task1 = new Task(() => 
        {
            int int1 = 5;
            int int2 = 10;
            int result = 5 * 10;
            
            Console.WriteLine(result); 
        });

        static void Main(string[] args)
        {
            task1.Start();
        }
    }
}
