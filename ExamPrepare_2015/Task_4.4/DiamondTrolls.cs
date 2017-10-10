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
                     // top line
                     if (c >= ((width - n) / 2) && c < ((width - n) / 2 + n) && r == 0)
                     {
                         Console.Write('*');
                     }
                     // horizontal line
                     else if (r == ( n / 2 + 1))
                     {
                         Console.Write('*');
                     }
                     else if (c == n)
                     {
                         Console.Write('*');
                     }
                     // making lower \
                     else if (r - c == n / 2 + 1)
                     {
                         Console.Write('*');
                     }
                     // making upper \
                     else if (r - c == - ((n / 2) * 3 + (n % 2)))
                     {
                         Console.Write('*');
                     }
                     // making lower /
                     else if (r + c == 3 * n - n / 2 )
                     {
                        //Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write('*');
                        //Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    // making upper /
                    else if (r + c == n / 2 + n % 2)
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
            //Console.WriteLine(7 % 2);
        }
    }
}
