using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class SwapNumbers
    {
        public static void Swap() {
            Console.WriteLine("Enter a number");
            var num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            var num2 = Convert.ToInt32(Console.ReadLine());
            var numT = num1;
            num1 = num2;
            num2 = numT;
            Console.WriteLine($"The numbers after swap:{num1},{num2}");
        } 
    }
}
