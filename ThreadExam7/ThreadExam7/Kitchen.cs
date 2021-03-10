using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExam7
{
      class Kitchen
      {
        public event EventHandler<DishEventArgs> DishReady;

        public void PrepareDish()
        {
            Console.WriteLine("Preparing dish...");
            OnDishReady(new DishEventArgs());
        }
        public void OnDishReady(DishEventArgs e)
        {
            if (DishReady != null)
            {
                EventHandler<DishEventArgs> handler = DishReady;
                handler.Invoke(this, e);
            }
        }
      }
}
