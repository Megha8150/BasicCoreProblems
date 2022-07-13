using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class EvenOdd
    {
        public static void evenOdd()
        {
            Console.WriteLine("Enter the number to find it is Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine(num+ " is a even number");
            }
           // else
            {
                Console.WriteLine(num+ " is a odd number");
            }
        }

    }
}
