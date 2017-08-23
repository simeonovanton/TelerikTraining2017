using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string[] binary = new string[64]; ;

            int counter = 0;

            while (n > 0)
            {
                if (n % 2 != 0)
                {
                    binary[counter] = "1";
                    n /= 2;
                }
                else
                {
                    binary[counter] = "0";
                    n /= 2;
                }
                counter++;

            }
            for (int i = counter - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }

            Console.WriteLine();
        }
    }
}
