using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    class AngryFemaleGPS
    {
        static void Main()
        {
            /*
            string input = Console.ReadLine();

            int sumOdd = 0;
            int sumEven = 0;

            int[] digits = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                digits[i] = input[i] - '0';
            }

            for (int i = 0; i < digits.Length; i = i + 2)
            {
                sumEven += digits[i];
            }
            for (int i = 1; i < digits.Length; i = i + 2)
            {
                sumOdd += digits[i];
            }

            if (sumEven > sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else if (sumOdd == sumEven)
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
            */
           
            long n = long.Parse(Console.ReadLine());
            if (n < 0)
            {
                n *= -1;
            }

            long sumOdd = 0;
            long sumEven = 0;

            while (n != 0)
            {
                int digit = (int)(n % 10);

                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
                n = n / 10;
            }

            if (sumEven > sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else if (sumOdd == sumEven)
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
        }
    }
}
