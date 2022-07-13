using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class Factors
    {
        public static void factors()
        {
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 2; i*i<= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
            }
            if (n>2)
            {
                Console.WriteLine(n);
            }
        }

    }
}
