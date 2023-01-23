using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// QuotientAndRemainder class create to compute quotient and remainder 
    /// </summary>
    public class QuotientAndRemainder
    {
        static double quotient, remainder, dividend, divisior;
        public static void ComputeQuotientAndRemainder()
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
