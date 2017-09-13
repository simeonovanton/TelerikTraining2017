using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._4
{
    class FireInMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // Part 1:
            /*
                ...##...
                ..#..#..
                .#....#.
                #......#
                #......#
                .#....#.
             */


            for (int row = 0; row < n / 2; row++)
            {
                for (int frow = n / 2 - 1 - row; frow > 0; frow--)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int i = 0; i < row * 2; i++)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int frow = n / 2 - 1 - row; frow > 0; frow--)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }
            for (int row = n / 2 + 1; row <= n * 3 / 4; row++)
            {
                for (int srow = row - n / 2 - 1; srow > 0 ; srow--)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int srow = n - 2 - 2 * (row - n / 2 - 1); srow > 0 ; srow -- )
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int srow = row - n / 2 - 1; srow > 0; srow--)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
            

            // Part 2:
            // --------
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            //Part 3:
            /*
            \\\\////
            .\\\///.
            ..\\//..
            ...\/...
             */
            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write('.');
                }
                for (int i = n / 2 - row; i > 0; i--)
                {
                    Console.Write('\\');
                }
                for (int i = n / 2 - row; i > 0; i--)
                {
                    Console.Write('/');
                }
                for (int i = 0; i < row; i++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }

        }
    }
}
