using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2
{
    class TheHorror
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int digitsNumber = 0;
            int digitsSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if ((input[i] - '0') >= 0 && (input[i] - '0') <= 9)
                    {
                        digitsSum += (input[i] - '0');
                        digitsNumber++;
                    }
                    
                }
            }
            Console.WriteLine("{0} {1}", digitsNumber, digitsSum);
        }
    }
}
