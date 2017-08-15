using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NthBit
{
    class NthBit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            long mask = 1 << position;
            long result = (mask & number) >> position;
            Console.WriteLine(result);
            // Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        }
    }
}
