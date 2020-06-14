using System;

/* This program takes a number and splits it up into smaller numbers that sum to the original number.
Then it finds the product of the smallers numbers. This program will maximize that product. */

namespace IntegerBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input a number: ");
                int inp = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(IntBrk(inp));
                Console.WriteLine("Want to see another number? ");
                string req = Console.ReadLine();
                if (req == "no")
                {
                    break;
                }
            }
        }

        // Breaking up the number into smaller numbers and maximizing the product.
        static int IntBrk(int sum)
        {
            int rem = sum%3;
            int quot = (sum-rem)/3;
            switch (rem)
            {
                case 0:
                    return Convert.ToInt16(Math.Pow(3, quot));
                case 1:
                    return Convert.ToInt16(Math.Pow(3, quot-1)*4);
                case 2:
                    return Convert.ToInt16(Math.Pow(3, quot)*2);
                default:
                    return 10;
            }
        }
    }
}
