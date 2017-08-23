using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
             long number = long.Parse(Console.ReadLine());
             byte bit = 0;
             string binary = "";
             while (true)
             {
                 bit = (byte)(number % 2);
                 number = number / 2;
                 binary = bit + binary;
                 if (number == 0)
                 {
                     break;
                 }
             }
             Console.WriteLine("{0}", binary);
             
        }
    }
}
