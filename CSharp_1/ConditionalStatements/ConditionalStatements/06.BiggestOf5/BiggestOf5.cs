using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());
            float d = Convert.ToSingle(Console.ReadLine());
            float e = Convert.ToSingle(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine(c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine(d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine(e);
            }
        }
    }
}
