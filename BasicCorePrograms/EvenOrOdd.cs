using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// EvenOrOdd class is created to check whether a number is Even or Odd
    /// </summary>
    public class EvenOrOdd
    {
        static int number;
        public static void CheckNumberIsEvenOrOdd()
        {
            Console.WriteLine("Please enter number to check even or odd:");
            number=Convert.ToInt32(Console.ReadLine());
            if(number % 2==0)
            {
                Console.WriteLine("{0} is even number",number);
            }
            else
            {
                Console.WriteLine("{0} is odd number",number);
            }
        }
    }
}
