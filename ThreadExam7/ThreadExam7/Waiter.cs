using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExam7
{
    class Waiter
    {
        public void OnDishReady(object sender, DishEventArgs e)
        {
            Console.WriteLine("Serving " + e.DishName + " To the customer");
        }
    }
}
