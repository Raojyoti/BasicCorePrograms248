using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Largest classis created to Find the Largest Among Three Numbers
    /// </summary>
    public class Largest
    {
        static int number1,number2,number3;
        public static void FindLargestAmongThreeNumbers()
        {
            Console.WriteLine("Please enter first number");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number");
            number3=Convert.ToInt32(Console.ReadLine());
            if(number1>number2 && number1 > number3)
            {
                Console.WriteLine("{0} is greatest number ", number1);
            }
            else if(number2 > number1 && number2> number3)
            {
                Console.WriteLine("{0} is greatest number", number2);
            }
            else
            {
                Console.WriteLine("{0} is greatest number", number3);
            }
        }
    }
}
