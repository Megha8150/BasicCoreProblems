using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class PowerOfTwo
    {
        public static void powerOfTwo()
        {
            Console.WriteLine("Enter vthe value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0 && n <31)
            {
                for (int i = 0; i < n; i++)
                    Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
