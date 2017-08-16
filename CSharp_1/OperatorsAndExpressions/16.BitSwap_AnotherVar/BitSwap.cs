﻿using System;
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

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));


            uint maskP = 0;
            uint maskQ = 0;


            for (int i = p; i <= (p + k - 1); i++, q ++)
            {
                maskP += (uint)Math.Pow(2, i);
                maskQ += (uint)Math.Pow(2, q);
            }
            Console.WriteLine(Convert.ToString(maskP, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(maskQ, 2).PadLeft(32, '0'));



            uint nBitsP = n & maskP;
            uint nBitsQ = n & maskQ;

            nBitsP ^= nBitsQ;
            nBitsQ ^= nBitsP;
            nBitsP ^= nBitsQ;
            n = n & ~(maskP);
            n = n & ~(maskQ);
            n = n | nBitsP;
            n = n | nBitsQ;

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            Console.WriteLine(n);
        }
    }
}
