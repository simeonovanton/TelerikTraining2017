using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NaBabaMiSmetalnika
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine()); //width

        // input of lines
        uint[] l = new uint[8];
        for (int i = 0; i < 8; i++)
        {
            l[i] = uint.Parse(Console.ReadLine());
        }
        string cmd = Console.ReadLine(); ;
        string cmdReset = "reset";
        string cmdRight = "right";
        string cmdLeft = "left";
        string cmdStop = "stop";

        //
        //Console.WriteLine(Convert.ToString(l[0], 2).PadLeft(32, '0'));
        //

        while (cmd != cmdStop)
        {
            if (cmd == cmdReset)
            {
                for (int red = 0; red < 8; red++)
                {
                    int marker = width - 1;
                    for (int i = width - 1; i >= 0; i--)
                    {
                        if ((l[red] & (1 << i)) != 0)
                        {
                            l[red] ^= (uint)(1 << i);
                            l[red] |= (uint)(1 << marker);
                            marker--;
                        }
                    }
                }
                cmd = Console.ReadLine();
                continue;
            }
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            //check for col( -50 to 50)
            if (col < 0)
            {
                col = 0;
            }
            else if (col > width - 1)
            {
                col = width - 1;
            }

            if (cmd == cmdRight)
            {
                int marker = 0;
                for (int i = 0; i < width - col; i++)
                {
                    if ((l[row] & (1 << i)) != 0)
                    {
                        l[row] ^= (uint)(1 << i);
                        l[row] |= (uint)(1 << marker);
                        marker++;
                    }

                }
            }
            else if (cmd == cmdLeft)
            {
                int marker = width - 1;
                for (int i = width - 1; i >= width - col - 1; i--)
                {
                    if ((l[row] & (1 << i)) != 0)
                    {
                        l[row] ^= (uint)(1 << i);
                        l[row] |= (uint)(1 << marker);
                        marker--;
                    }
                }
            }
            cmd = Console.ReadLine();
        }

        //Console.WriteLine(Convert.ToString(l[0], 2).PadLeft(32, '0'));

        // sum of the numbers in the lines
        ulong sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += l[i];
        }

        // calculate number of lines with no "topcheta"
        int zeros = 0;
        for (int i = 0; i < width; i++)
        {
            bool isLineZero = true;
            for (int j = 0; j < 8; j++)
            {
                if ((l[j] & (1 << i)) != 0)
                {
                    isLineZero = false;
                }
            }
            if (isLineZero)
            {
                zeros++;
            }
        }

        ulong result = (ulong)zeros * sum;
        Console.WriteLine(result);
    }
}

