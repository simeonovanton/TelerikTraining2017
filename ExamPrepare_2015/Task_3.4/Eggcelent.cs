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
            for (int j = 0; j < (n - 2) / 2; j++)
            {   
                //first 1/3
                for (int i = 0; i < n + 1 - (j + 1) * 2; i++) //((3n+1) - (n-1)) / 2 ====> n + 1
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int i = 0; i < (2 * j + 1); i++)
                {
                    Console.Write('.');
                }
                //middle 1/3
                for (int i = 0; i < top; i++)
                {
                    Console.Write('.');
                }
                //last 1/3
                for (int i = 0; i < (2 * j + 1); i++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int i = 0; i < n + 1 - (j + 1) * 2; i++) //((3n+1) - (n-1)) / 2 ====> n + 1
                {
                    Console.Write('.');
                }
                //new line
                Console.WriteLine();
            }



            //upper |
            for (int j = 0; j < (n - 2) / 2; j++) 
            {
                Console.Write(".*");
                for (int i = 0; i < (3 * n) + 1 - 4; i++)
                {
                    Console.Write('.');
                }
                Console.Write("*.");
                Console.WriteLine();
            }

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

            //lower |
            for (int j = 0; j < (n - 2) / 2; j++) 
            {
                Console.Write(".*");
                for (int i = 0; i < (3 * n) + 1 - 4; i++)
                {
                    Console.Write('.');
                }
                Console.Write("*.");
                Console.WriteLine();
            }

            //lower \
            for (int j = (n - 2) / 2 - 1; j >= 0; j--)
            {
                //first 1/3
                for (int i = 0; i < n + 1 - (j + 1) * 2; i++) //((3n+1) - (n-1)) / 2 ====> n + 1
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int i = 0; i < (2 * j + 1); i++)
                {
                    Console.Write('.');
                }
                //middle 1/3
                for (int i = 0; i < top; i++)
                {
                    Console.Write('.');
                }
                //last 1/3
                for (int i = 0; i < (2 * j + 1); i++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int i = 0; i < n + 1 - (j + 1) * 2; i++) //((3n+1) - (n-1)) / 2 ====> n + 1
                {
                    Console.Write('.');
                }
                //new line
                Console.WriteLine();
            }

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
