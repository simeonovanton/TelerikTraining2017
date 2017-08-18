using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.BitSwapNewTry
{
    class BitSwap
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = p; i <= (p + k - 1); i++, q++)
            {
                uint mask = 1;
                // Reading bits at position p and q
                int bitP = (int)(n & (mask << i)) >> i;
                int bitQ = (int)(n & (mask << q)) >> q;
                // Cleaning positions at positions p and q to 0;
                n = n & ~(mask << i);
                n = n & ~(mask << q);
                //Reversing bits in the number n
                n = n | (uint)(bitP << q);
                n = n | (uint)(bitQ << i);

            }
            Console.WriteLine(n);



        }
    }
}
