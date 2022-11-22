using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{

    partial class Substract
    {
        public void Sub()
        {
            int ans = num1 - num2;
            Console.WriteLine($"Substraction={ans}");
        }
    }



    public class Substraction
    {
        public static void DisplaySub()
        {
            Substract substract = new Substract();
            substract.Assign();
            substract.Sub();

        }
    }

    public class Overloading {
        public static void Area(int l) {
            Console.WriteLine($"Area = {l * l}");
        }

        public static void Area(int l, int b)
        {
            Console.WriteLine($"Area = {l * b}");
        }
    }
}
