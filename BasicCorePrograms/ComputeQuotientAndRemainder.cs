using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class ComputeQuotientAndRemainder
    {
        static double quotient, remainder, dividend, divisior;
        public static void FindComputeQuotientAndRemainder()
        {
            Console.WriteLine("Enter value for dividend:");
            dividend=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for divisior:");
            divisior = Convert.ToDouble(Console.ReadLine());
            quotient=dividend / divisior;
            remainder=dividend % divisior;
            Console.WriteLine("Quotient: {0} and Remainder: {1}",quotient,remainder);
        }
    }
}
