using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main()
        {
            string read = Console.ReadLine();
            string value = Console.ReadLine();

            switch (read)
            {
                case "integer": Console.WriteLine(int.Parse(value) + 1); break;
                case "real":  Console.WriteLine(double.Parse(value) + 1); break;

                default:
                    Console.WriteLine(value + "*");
                    break;
            }
        }
    }
}
