using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Eggcellent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = 2 * n;
        int width = 3 * n + 1;
        //int top = n - 1;
        //int bottom = n - 1;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((row == 0 || row == height - 1) && (col >= (n + 1) && col < 2 * n))
                {
                    Console.Write('*');
                }
                else if ((row >= height / 4 && row < 3 * height / 4) && (col == 1 || col == width - 2))
                {
                    Console.Write('*');
                }
                else if ((2 * row - col  == -(2 * n - 1)) || (2 * row == col + 3 * n - 3))
                {
                    Console.Write('*');
                }
                else if ((2 * row + col == n + 1) || (2 * row + col == 6 * n - 3))
                {
                    Console.Write('*');
                }
                else if ((row == n - 1 || row == n) && (col > 1 && col < width - 2)
                        && (row + col) % 2 != 0)
                {
                    Console.Write('@');
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

