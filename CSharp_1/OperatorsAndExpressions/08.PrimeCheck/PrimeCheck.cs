using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool isPrime = true;


            if (input <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= (Math.Sqrt(input) + 1); i++)
                {
                    if (input % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}
