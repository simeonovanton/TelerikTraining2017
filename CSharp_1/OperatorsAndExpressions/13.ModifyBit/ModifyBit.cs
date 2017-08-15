using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong number = (ulong)long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                ulong mask = ~((ulong)1L << position);
                ulong result = mask & number;
                Console.WriteLine(result);
            }
            else
            {
                ulong mask = (ulong)1L << position;
                ulong result = mask | number;
                Console.WriteLine(result);
            }
        }
    }
}
