using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || ((year % 400 == 0)))
            {
                Console.WriteLine("Leap Year");
            }
            //else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }


    }
}
