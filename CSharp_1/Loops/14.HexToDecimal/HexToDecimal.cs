using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int n = input.Length;
            long dec = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                switch (input[i])
                {
                    case 'A' : dec += 10 * (long)Math.Pow(16, n - 1 - i); break;
                    case 'B' : dec += 11 * (long)Math.Pow(16, n - 1 - i); break;
                    case 'C' : dec += 12 * (long)Math.Pow(16, n - 1 - i); break;
                    case 'D' : dec += 13 * (long)Math.Pow(16, n - 1 - i); break;
                    case 'E' : dec += 14 * (long)Math.Pow(16, n - 1 - i); break;
                    case 'F' : dec += 15 * (long)Math.Pow(16, n - 1 - i); break; 
                    default:
                        dec += (input[i] - 48) * (long)Math.Pow(16, n - 1 - i);
                        break;
                }
            }
            Console.WriteLine(dec);
        }
    }
}
