using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExam3
{
    class Program
    {
        public delegate int AddNumbers(int x, int y);

        public Program()
        {
            AddNumbers SumDelegateOne = Add;
            var Result = SumDelegateOne.Invoke(1, 2);
        }
        int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            
           
        }
    }
}
