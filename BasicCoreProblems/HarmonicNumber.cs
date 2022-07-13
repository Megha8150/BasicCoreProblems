using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class HarmonicNumber
    {
        public static void harmonicNumber()
        {
            double h = 0;
            Console.WriteLine("Enter the value of n");
            double n = Convert.ToDouble(Console.ReadLine());
            if(n!=0)
            {
                for(double i =1; i<= n; i++)
                {

                    h = h + 1 / i;
                }
            }
            Console.WriteLine(h);
        }

    }
}
