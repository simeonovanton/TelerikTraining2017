using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DevideBy7And5
{
    class DevideBy7And5
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            if ((input % 7 == 0) && (input % 5 == 0))
            {
                Console.WriteLine("true " + input);
            }
            else
            {
                Console.WriteLine("false " + input);
            }
        }
    }
}
