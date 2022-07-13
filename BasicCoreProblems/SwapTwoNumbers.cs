using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class SwapTwoNumbers
    {
        public static void swapTwoNumbers()
        {
            int temp = 0;
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First number is " +num1);
            Console.WriteLine("Second number is " +num2);

        }
    }
}
