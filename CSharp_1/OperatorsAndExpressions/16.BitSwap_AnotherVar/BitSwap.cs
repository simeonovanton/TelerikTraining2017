using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BitSwap_AnotherVar
{
    class BitSwap
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //uint input = n;
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            uint maskP = 0;
            uint maskQ = 0;

            for (int i = p; i <= (p + k - 1); i++, q ++)
            {
                maskP += (uint)Math.Pow(2, i);
                maskQ += (uint)Math.Pow(2, q);
            }
 
            uint nBitsP = n & maskP;
            uint nBitsQ = n & maskQ;

           
            //Reversing bits in P and Q area:
            uint newBitsP = (nBitsQ >> (q - k)) << p;
            uint newBitsQ = (nBitsP >> p) << (q - k);
 
            n = n & ~(maskP);
            n = n & ~(maskQ);

            n = n | newBitsP;
            n = n | newBitsQ;

            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            Console.WriteLine(n);
        }
    }
}
