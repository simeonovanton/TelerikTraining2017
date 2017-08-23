using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            long number = 0;
            string input = Console.ReadLine();
            int n = input.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                number += (long)((input[i] - 48) * Math.Pow(2, n - 1 - i));
            }
            Console.WriteLine(number);
        }
    }
}
