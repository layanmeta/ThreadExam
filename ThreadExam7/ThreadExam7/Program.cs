using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExam7
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitchenDepartment = new Kitchen();
            var waiterDepartment = new Waiter();

            kitchenDepartment.DishReady += waiterDepartment.OnDishReady;

            kitchenDepartment.PrepareDish();
            Console.WriteLine();
            
        }
    }
}
