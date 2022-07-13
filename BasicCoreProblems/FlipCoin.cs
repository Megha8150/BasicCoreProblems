using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class FlipCoin
    {
        public static void flipCoin()
        {
            Console.WriteLine("Enter the number of times to flip a coin");
            int num = Convert.ToInt32(Console.ReadLine());
            double tailPercentage = 0;
            double headPercentage = 0;
            int head=0;
            int tail=0;
            

            for (int i = 0; i < num; i++)
            {
                Random random = new Random();
                int toss = random.Next(0, 2);

                if (toss < 0.5)
                {
                    Console.WriteLine("Tails");
                    tail++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    head++;
                }
            }
            tailPercentage = tail*100/num;
            headPercentage= head*100/num;

            Console.WriteLine("Percentage of tail  " +tailPercentage);
            Console.WriteLine("Percentage of head  " +headPercentage);
        }


    }
}
