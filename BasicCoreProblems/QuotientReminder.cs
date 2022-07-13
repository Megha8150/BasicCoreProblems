using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class QuotientReminder
    {
        public static void quotientReminder()
        {
            int quotient = 0;
            int remainder = 0;
            Console.WriteLine("Enter the value of divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            remainder = divident%divisor;
            quotient = divident/divisor;
            Console.WriteLine("Remainder is " +remainder);
            Console.WriteLine("Quotient is " +quotient);
        }
    }
}
