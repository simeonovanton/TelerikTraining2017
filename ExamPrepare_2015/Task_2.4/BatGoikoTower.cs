using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._4
{
    class BatGoikoTower
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int update = 2;
            int rowByDash = 1;
            for (int i = 0; i < n; i++)
            {
                char middleChar = '.';

                if (i == rowByDash)
                {
                    middleChar = '-';
                    rowByDash += update;
                    update++;
                }

                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write('.');
                }

                Console.Write('/');

                for (int j = 0; j < i * 2; j++)
                {
                        Console.Write(middleChar);
                }
                

                Console.Write('\\');

                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }

        }
    }
}
