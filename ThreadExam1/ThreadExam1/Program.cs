using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExam1and2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var randomizer = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(randomizer.Next(0, 50));
            }
            var smallerThan = list.Where(i => i < 10);
            var devide = list.Where(i => i % 3 == 0);
            var biggerthan = list.Where(i => i > 20 & i % 2 == 0);
            var sortFromBiggerToSmall = list.OrderByDescending(i => i);

            Console.WriteLine("smaller than 10");
            foreach (var item in smallerThan)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("devide on 3");
            foreach (var item in devide)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("bigger than 20 and devided by 2");
            foreach (var item in biggerthan)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("sort from big to small");
            foreach (var item in sortFromBiggerToSmall)
            {
                Console.WriteLine(item);
            }


            List<string> names = new List<string>() { "Sam", "lucy" , "sarah", "luna", "luke", "ron", "harry", "tanjiro", "charlie", "freddy", };

            Console.WriteLine("order by abc");
            var alphabetical  = names.OrderBy(x => x);
            foreach (var item in alphabetical)
            {
                Console.WriteLine(item);
            }
            var letters = names.Where(x => x.Contains("a" ));
            Console.WriteLine("names with the letter A");
            foreach (var item in letters)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            var fourLetters = names.Where(x => x.Length > 4);
            Console.WriteLine("names with more than 4 letters");
            foreach (var item in fourLetters)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
