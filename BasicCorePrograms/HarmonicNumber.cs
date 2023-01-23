using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// HarmonicNumber class is create to print Nth harmonic numbers
    /// </summary>
    public class HarmonicNumber
    {
        static int number;
        static double result = 0,value=0,i;
        public static void PrintHarmonicNumber()
        {
            System.Console.WriteLine("Please Enter number until you want to print Harmonic Values");
            number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Harmonic number series are: ");
            for (i=1; i<=number; i++)
            {
                value=1/i;
                result = result + (1 / i);
                Console.WriteLine("1/{0}  => {1} ",i,value);
            }
            Console.WriteLine("\nSum of Nth Harmonic Numbers: " + result);
        }
    }
}
