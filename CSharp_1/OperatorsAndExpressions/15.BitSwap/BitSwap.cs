using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));


            for (int i = p; i <= ((p + k) - 1); i++, q++)
            {
                uint mask = 1;

                uint bitP = ((mask << i) & n) >> i;
                uint bitQ = ((mask << q) & n) >> q;

                n = n & ~(mask << i);
                n = n & ~(mask << q);
                n = n | (bitP << q);
                n = n | (bitQ << i);

            }

            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            Console.WriteLine(n);


        }
    }
}
