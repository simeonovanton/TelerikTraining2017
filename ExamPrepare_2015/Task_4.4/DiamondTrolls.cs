using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._4
{
    class DiamondTrolls
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 6 + ((n - 3) / 2) * 3;

            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    if (c >= ((width - n) / 2) && c < ((width - n) / 2 + n) && r == 0)
                    {
                        Console.Write('*');
                    }
                    else if (r == ( n / 2 + 1))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
