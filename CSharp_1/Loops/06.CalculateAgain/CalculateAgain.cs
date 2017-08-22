using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger Nfqrl = 1;
            BigInteger Kfqrl = 1;

            for (int i = 1; i <= n; i++)
            {
                Nfqrl *= i;
                if (i > k)
                {
                    continue;
                }
                Kfqrl *= i;
            }
            Console.WriteLine(Nfqrl / Kfqrl);

        }
    }
}
