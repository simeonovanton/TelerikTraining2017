using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int sign = 1;
            string hex = "";
            while (true)
            {
                sign = (byte)(number % 16);
                number = number / 16;
                switch (sign)
                {
                    case 0: hex = '0' + hex; break;
                    case 1: hex = '1' + hex; break;
                    case 2: hex = '2' + hex; break;
                    case 3: hex = '3' + hex; break;
                    case 4: hex = '4' + hex; break;
                    case 5: hex = '5' + hex; break;
                    case 6: hex = '6' + hex; break;
                    case 7: hex = '7' + hex; break;
                    case 8: hex = '8' + hex; break;
                    case 9: hex = '9' + hex; break;
                    case 10: hex = 'A' + hex; break;
                    case 11: hex = 'B' + hex; break;
                    case 12: hex = 'C' + hex; break;
                    case 13: hex = 'D' + hex; break;
                    case 14: hex = 'E' + hex; break;
                    case 15: hex = 'F' + hex; break;

                    default:
                        Console.WriteLine("OOPS! SOMETHING'S WRONG!");
                        break;
                }
                if (number == 0)
                {
                    break;
                }
            }
            Console.WriteLine(hex);
        }
    }
}
