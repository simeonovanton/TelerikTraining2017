using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Trailing0InN
{
    class Trailing0InN
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            int result = 0;
            while (n >= 1)
            {
                result += (int)(n / 5);
                n = n / 5;
            }
            Console.WriteLine(result);
        }
    }
}
