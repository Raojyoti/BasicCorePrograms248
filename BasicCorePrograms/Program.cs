using System;

namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Core Programs");
            while(true)
            {
                Console.WriteLine("1.FindPercentageOfFlipCoin\n2.CheckLeapYear\n3.FindPowerOfTwo\n4.PrintHarmonicNumber\n11.Exit\n");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.Clear();
                        FlipCoin.FindPercentageOfFlipCoin();
                        break;
                    case 2:
                        Console.Clear();
                        LeapYear.CheckLeapYear();
                        break;
                    case 3:
                        Console.Clear();
                        PowerOfTwo.FindPowerOfTwo();
                        break;
                    case 4:
                        Console.Clear();
                        HarmonicNumber.PrintHarmonicNumber();
                        break;
                    case 11:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please select only given options only");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
