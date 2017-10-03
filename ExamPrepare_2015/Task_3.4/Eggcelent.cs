using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4
{
    class Eggcelent
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n - 1;
            int drawing = 3 * n + 1;
            int top = n - 1;
            int bottom = n - 1;

            //top
            for (int i = 0; i <= n; i++)
            {
                Console.Write('.');
            }
            for (int i = 0; i < (n - 1); i++)
            {
                Console.Write('*');
            }
           
            for (int i = 0; i <= n; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();

            //upper /
                // 1/3
                for (int j = 0; j < n + 1; j++) //((3n+1) - (n-1)) / 2 ====> n + 1
                {

                }
                // 2/3

                // 3/3



            //upper |
            
            //upper middle
            Console.Write(".*");
            for (int i = 0; i <= (width - 2) / 2; i++)
            {
                Console.Write('@');
                if (i == ((width - 2) / 2))
                {
                    break;
                }
                Console.Write('.');
            }
            Console.Write("*.");
            Console.WriteLine();

            //lower middle
            Console.Write(".*");
            for (int i = 0; i <= (width - 2) / 2; i++)
            {
                Console.Write('.');
                if (i == ((width - 2) / 2))
                {
                    break;
                }
                Console.Write('@');
            }
            Console.Write("*.");
            Console.WriteLine();

            //bottom
            for (int i = 0; i <= n; i++)
            {
                Console.Write('.');
            }
            for (int i = 0; i < (n - 1); i++)
            {
                Console.Write('*');
            }
            for (int i = 0; i <= n; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}
