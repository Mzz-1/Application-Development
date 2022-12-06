using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class OddEven
    {
        public static void OddEvenNum()
        {
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
