using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week3
{
    internal class CheckElementInArray
    {

        public static void FindElement()
        {
            string[] elements = { "2", "3", "5", "8", "7", "a", "c" };
            Console.WriteLine("Enter a value");
            var value = Console.ReadLine();
            int count=0;
            
            for (int i = 0; i < elements.Length; i++) {
              
                if (value == elements[i])
                {
                    count++;
                }
            }
            if (count >= 1)
            {
                Console.WriteLine($"The value {value} is present in the array");
            }
            else {
                Console.WriteLine($"The value {value} is not present in the array");
            }
        } 
    }
}
