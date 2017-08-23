using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main() 
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 1;
            BigInteger productOdd = 1;
            BigInteger productEven = 1;
            int digit;

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    continue;
                }
                digit = (int)(ch - '0');
              
                    if (counter % 2 != 0)
                    {
                        productOdd  *= digit;
                    }
                    else
                    {
                        productEven *= digit;
                    }
                
                counter++;
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes {0}", productOdd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }
        }
    }
}
