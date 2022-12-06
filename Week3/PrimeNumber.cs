using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class PrimeNumber
    {
        public static void Prime() {
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++) {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else {
                Console.WriteLine($"{num} is not a prime number");
            }
        }
    }
}
