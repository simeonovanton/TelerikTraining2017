using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program_3_6_9
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long ac = 0;

            switch (b)
            {
                case 3:
                    ac = a + c;
                    break;
                case 6:
                    ac = a * c;
                    break;
                case 9:
                    ac = a % c;
                    break;

                default:
                    break;
            }

            long r = 0;
            if (ac % 3 == 0)
            {
                r = ac / 3;
            }
            else
            {
                r = ac % 3;
            }
            Console.WriteLine(r);
            Console.WriteLine(ac);
        }
    }
}
