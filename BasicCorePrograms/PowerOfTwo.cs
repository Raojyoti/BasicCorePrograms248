using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// PowerOfTwo class create to find power of two
    /// </summary>
    public class PowerOfTwo
    {
        static int number, power=0;
        public static void FindPowerOfTwo()
        {
            Console.WriteLine("Please Enter number until you want find power");
            number= Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=number;i++)
            {
                power=(int)Math.Pow(2,i);
                Console.WriteLine("power of 2^{0} is power {1} ",i,power);
            }
        }
    }
}
