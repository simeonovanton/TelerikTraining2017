using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counterX_Left = 0;
            int counterX_Right = 0;
            int counterY_Up = 0;
            int counterY_Down = 0;
            int counter = 1;
            int ii = 1;
            int jj = 1;


            Right:
            for (int j = 1 + counterX_Left; j <= n - counterX_Right; j++)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                Console.SetCursorPosition(j, ii);
                jj = j;
                Console.Write(counter);
                counter++;
                if (j == n - counterX_Right)
                {
                    counterX_Right++;
                    goto Down;
                }
            }

            Down:
            for (int i = 1 + counterY_Up; i <= n - counterY_Down; i++)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                Console.SetCursorPosition(jj, i);
                ii = i;
                Console.Write(counter);
                counter++;
                if (i == n - counterY_Down)
                {
                    counterY_Down++;
                    goto Left;
                }
            }

            Left:
            for (int j = n - counterX_Right; j >= 1 + counterX_Left; j--)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                Console.SetCursorPosition(j, ii);
                jj = j;
                Console.Write(counter);
                counter++;
                if (j == 1 + counterX_Left)
                {
                    counterX_Left++;
                    goto Up;
                }
            }

            Up:
            for (int i = n - counterY_Down; i >= 1 + counterY_Up; i--)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                Console.SetCursorPosition(jj, i);
                ii = i;
                Console.Write(counter);
                counter++;
                if (i == 1 + counterY_Up)
                {
                    counterY_Up++;
                    goto Right;
                }
            }

        }
    }
}
