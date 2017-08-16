using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));

            // Replace 3th and 24th bit
            uint littleBuffer = 1U << 3;
            uint bigBuffer = 1U << 24;
            littleBuffer &= input;
            bigBuffer &= input;
            littleBuffer = littleBuffer >> 3;
            bigBuffer = bigBuffer >> 24;

            if (littleBuffer == 0)
            {
                input = input & ~(1U << 24);
             }
            else
            {
                input = input | (1U << 24);
            }

            if (bigBuffer == 0)
            {
                input = input & ~(1U << 3);
            }
            else
            {
                input = input | (1U << 3);
            }

            // Replace 4th and 25th bit
            littleBuffer = 1U << 4;
            bigBuffer = 1U << 25;
            littleBuffer &= input;
            bigBuffer &= input;
            littleBuffer = littleBuffer >> 4;
            bigBuffer = bigBuffer >> 25;

            if (littleBuffer == 0)
            {
                input = input & ~(1U << 25);
            }
            else
            {
                input = input | (1U << 25);
            }

            if (bigBuffer == 0)
            {
                input = input & ~(1U << 4);
            }
            else
            {
                input = input | (1U << 4);
            }

            // Replace 5th and 26th bit
            littleBuffer = 1U << 5;
            bigBuffer = 1U << 26;
            littleBuffer &= input;
            bigBuffer &= input;
            littleBuffer = littleBuffer >> 5;
            bigBuffer = bigBuffer >> 26;

            if (littleBuffer == 0)
            {
                input = input & ~(1U << 26);
            }
            else
            {
                input = input | (1U << 26);
            }

            if (bigBuffer == 0)
            {
                input = input & ~(1U << 5);
            }
            else
            {
                input = input | (1U << 5);
            }

            //Console.WriteLine(Convert.ToString(input, 2).PadLeft(32, '0'));
            Console.WriteLine(input);
        }
    }
}
