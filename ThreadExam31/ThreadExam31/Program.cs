using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadExam31
{
    class Program
    {
        public void devideByZero()
        {
            try
            {
                var results = Task.FromResult(DivideBy0());
               
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }

        private int DivideBy0()
        {
            var number = 2;
            return number / 0;
        }
        
        //a Yes
        //b still crashes
        //D = System.Threading.Tasks.UnobservedTaskExceptionEventArgs
        static void Main(string[] args)
        {
            
        }

    }
}
