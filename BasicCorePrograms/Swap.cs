using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Swap class create for swap two numbers
    /// </summary>
    public class Swap
    {
        static int number1, number2,temp;
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter First and second numbers:");
            number1=Convert.ToInt32(Console.ReadLine());
            number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap numbers are: {0}  {1}",number1,number2);
            temp = number1;
            number1= number2;
            number2= temp;
            Console.WriteLine("After swap numbers are: {0}  {1}", number1, number2);
        }
    }
}
