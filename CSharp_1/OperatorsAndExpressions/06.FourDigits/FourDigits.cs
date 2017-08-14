using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int a = Console.Read() - 48;
            int b = Console.Read() - 48;
            int c = Console.Read() - 48;
            int d = Console.Read() - 48;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

        }
    }
}
