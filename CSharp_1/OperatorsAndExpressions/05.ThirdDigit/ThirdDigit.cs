using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());

            input = input / 100;
            uint rest = input % 10;

            if (rest == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", rest);
            }
        }
    }
}
