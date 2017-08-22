using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate3
{
    class Calculate3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger Nfqrl = 1;
            BigInteger Kfqrl = 1;
            BigInteger NKfqrl = 1;
            for (int i = 1; i <= n; i++)
            {
                Nfqrl *= i;
                if (i > k)
                {
                    NKfqrl *= i - k;
                    continue;
                }
                Kfqrl *= i;
            }
            BigInteger result = Nfqrl / (Kfqrl * NKfqrl);
            Console.WriteLine(result);
        }
    }
}
