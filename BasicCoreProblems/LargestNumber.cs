using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class LargestNumber
    {
        public static void largestNumber()
        {
            Console.WriteLine("Enter the three numbers to find the largest one");
            int num1 = Convert.ToInt32(Console.ReadLine()); 
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>=num2 && num1>=num3)
            {
                Console.WriteLine(num1 + " is largest number");
            }
            else if (num2 >= num1 && num2>=num3)
            {
                Console.WriteLine(num2+ " is largest number");
            }
            else
            {
                Console.WriteLine(num3+ "is largest number");
            }
        }

    }
}
