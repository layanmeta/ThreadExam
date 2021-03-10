using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam12
{
    class Program
    {

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Console.WriteLine("Hello world");
            }).Start();

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            Action<int> SearchNumber = inputNumber => { new Thread(() => { numbers.Where(x => x == inputNumber); }).Start();  };
            SearchNumber(3);
            
        }
    }
}
