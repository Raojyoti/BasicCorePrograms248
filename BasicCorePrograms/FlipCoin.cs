using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// FlipCoin class create to calculate Percentage of Flip Coin
    /// </summary>
    public class FlipCoin
    {
        // static variables
        static int tailCount = 0;
        static int headCount=0;

        public static void FindPercentageOfFlipCoin()
        {
            Console.WriteLine("Please enter number for flip coin ");
            int number=Convert.ToInt32(Console.ReadLine()); 
            Random random=new Random();
            for ( int i=0;i<number;i++)
            {
                double randomInput = random.NextDouble();
                if (randomInput < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("TailCount: {0} HeadCount: {1}",tailCount,headCount);
            double tailPercentage=(double)(tailCount *100)/number;
            double headPercentage = (double)(headCount * 100) / number;
            Console.WriteLine("Tail Percentage: {0}%",tailPercentage);
            Console.WriteLine("Head Percentage: {0}%", headPercentage);
        }
    }
}
