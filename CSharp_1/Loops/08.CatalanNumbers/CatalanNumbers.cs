using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger Nfqrl = 1;
            BigInteger N1fqrl = 1;
            BigInteger N2fqrl = 1;

            for (int i = 1; i <= 2 * n; i++)
            {
                N2fqrl *= i;
                if (i > n)
                {
                    continue;
                }
                Nfqrl *= i;
            }
            N1fqrl = Nfqrl * (n + 1);

            BigInteger result = N2fqrl / (N1fqrl * Nfqrl);
            Console.WriteLine(result);
        }
    }
}
