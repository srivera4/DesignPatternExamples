using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggablePattern
{
    class Program
    {
        //Use this method as apposed to using each individual methods at the bottom. We can calculate totals of each odd,even, and all numbers
        //by using a predicate as a selector and keeping the same core logic. Keeps us from having to change code in all methods if core
        //logic changes
        public static int GetTotal(int[] numbers, Predicate<int> selector)
        {
            int total = 0;
            foreach (int n in numbers)
            {
                if (selector(n))
                {
                    total += n;
                }
            }
            return total;
        }

        static void Main(string[] args)
        {
            //Use predicate selector
            Console.WriteLine(GetTotal(new[] { 1, 2, 3, 4, 5, 6 }, i => true));
            Console.WriteLine(GetTotal(new[] { 1, 2, 3, 4, 5, 6 }, i => i % 2 == 0));
            Console.WriteLine(GetTotal(new[] { 1, 2, 3, 4, 5, 6 }, i => i % 2 != 0));
            Console.Read();
        }

        public static int GetTotal(int[] numbers)
        {
            int total = 0;

            foreach (int n in numbers)
            {
                total += n;
            }

            return total;
        }

        public static int GetTotalEvenNumbers(int[] numbers)
        {
            int total = 0;

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    total += n;
                }
            }

            return total;
        }
    }
}
