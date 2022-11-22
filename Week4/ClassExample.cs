using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    abstract class Add
    {
        public abstract void AddTwoNumbers(int num1, int num2);
    }

    sealed class Multiply {
        public static void MultiplyTwoNumbers(int num1, int num2) {
            Console.WriteLine($"Multiply={num1 * num2}");
        }
    }

    class DerivedClass : Add {
        public override void AddTwoNumbers(int num1, int num2) {
            Console.WriteLine($"Sum={num1 + num2}");
        }

    }

    partial class Substract{
        private int num1;
        private int num2;
        public void Assign() {
            Console.WriteLine("Enter a number");
            this.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            this.num2 = Convert.ToInt32(Console.ReadLine());
 
        }
    }

    
  

}
