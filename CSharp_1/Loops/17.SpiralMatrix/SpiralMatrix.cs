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
            int counterY_Up = 1;
            int counterY_Down = 0;
            int counter = 1;
            int ii = 1;
            int jj = 1;
            int cursorPositionX = jj;
            int cursorPositionY = ii;
            


            Right:
            for (int j = jj + counterX_Left; j < jj + n - counterX_Right; j++)
            {
                if (counter >= n * n + 1)
                {
                    break;
                }
                cursorPositionX = j;
                Console.SetCursorPosition(cursorPositionX , cursorPositionY);
                Console.Write("{0}", counter);
                Task.Delay(100).Wait();
                counter++;
                if (j == jj + n - counterX_Right - 1)
                {
                    counterX_Right++;
                    goto Down;
                }
            }

            Down:
            for (int i = ii + counterY_Up; i < ii + n - counterY_Down; i++)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                cursorPositionY = i;
                Console.SetCursorPosition(cursorPositionX , cursorPositionY);
                Console.Write("{0}", counter);
                Task.Delay(100).Wait();
                counter++;
                if (i == ii + n - counterY_Down - 1)
                {
                    counterY_Down++;
                    goto Left;
                }
            }

            Left:
            for (int j = jj + n - counterX_Right - 1; j >= jj + counterX_Left; j--)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                cursorPositionX = j;
                Console.SetCursorPosition(cursorPositionX , cursorPositionY);
                Console.Write("{0}", counter);
                Task.Delay(100).Wait();
                counter++;
                if (j == jj + counterX_Left)
                {
                    counterX_Left++;
                    goto Up;
                }
            }

            Up:
            for (int i = ii + n - counterY_Down - 1; i >= ii + counterY_Up; i--)
            {
                if (counter == n * n + 1)
                {
                    break;
                }
                cursorPositionY = i;
                Console.SetCursorPosition(cursorPositionX , cursorPositionY);              
                Console.Write("{0}", counter);
                Task.Delay(100).Wait();
                counter++;
                if (i == ii + counterY_Up)
                {
                    counterY_Up++;
                    goto Right;
                }
            }
            Console.SetCursorPosition(0, ii + n + 1);
            Console.WriteLine();


        }
    }
}
