using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// LeapYear class is create to check year is leap year or not
    /// </summary>
    public class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Please Enter four digit number for year");
            int year=Convert.ToInt32(Console.ReadLine());
            if(year % 4==0)
            {
                Console.WriteLine("{0} is Leap year", year);
            }
            else if(year % 400==0)
            {
                Console.WriteLine("{0} is Leap year", year);
            }
            else if(year % 100==0)
            {
                Console.WriteLine("{0} is not a Leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap year", year);
            }
        }
    }
}
