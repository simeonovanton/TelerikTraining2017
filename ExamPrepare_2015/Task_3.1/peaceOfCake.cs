using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1
{
    class peaceOfCake
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());


            if ( (a * d + c * b) >= (b * d) )
            {
                Console.WriteLine((a * d + c * b) / (b * d));
            }
            else
            {
                decimal result = (decimal)(a * d + c * b) / (b * d);
                Console.WriteLine(format: "{0:F22}", arg0: result);
            }

            Console.WriteLine("{0}/{1}", (a * d + c * b), (b * d));
        }
    }
}
