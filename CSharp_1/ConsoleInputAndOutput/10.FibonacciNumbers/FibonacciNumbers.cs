using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if(n == 2)
            {
                Console.WriteLine("0, 1");

            }
            else
            {
                Console.Write("0, 1");
                long first = 0;
                long second = 1;
                long third = first + second;
                for (int i = 1; i <= n - 2 ; i++)
                {
                    third = first + second;
                    Console.Write(", " + third);
                    first = second;
                    second = third;
                }
                Console.WriteLine();
            }
        }
    }
}
