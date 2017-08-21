using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());

            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else if (b >= a)
            {
                if (b >= c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
