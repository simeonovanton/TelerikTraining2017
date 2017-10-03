using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    class OnesAndZeros
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] bitsArray = new int[16];

            for (int i = 0; i < 16; i++)
            {
                int mask = (1 << i);
                bitsArray[15 - i] = ((n & mask) >> i);
            }

            //string bits = string.Join("", bitsArray);
            //Console.WriteLine(bits);

            string[] one = {".#.",
                            "##.",
                            ".#.",
                            ".#.",
                            "###" };

            string[] zero = {"###",
                             "#.#",
                             "#.#",
                             "#.#",
                             "###"};

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (bitsArray[i] == 0)
                    {
                        Console.Write(zero[j]);
                    }
                    else
                    {
                        Console.Write(one[j]);
                    }
                    if (i == 15)
                    {
                        break;
                    }
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            // row 0
            //for (int i = 0; i < 16; i++)
            //{
            //    if (bitsArray[i] == 0)
            //    {
            //        Console.Write("###");
            //    }
            //    else
            //    {
            //        Console.Write(".#.");
            //    }
            //    if (i == 15)
            //    {
            //        break;
            //    }
            //    Console.Write(".");
            //}
            //Console.WriteLine();
            //// row 1
            //for (int i = 0; i < 16; i++)
            //{
            //    if (bitsArray[i] == 0)
            //    {
            //        Console.Write("#.#");
            //    }
            //    else
            //    {
            //        Console.Write("##.");
            //    }
            //    if (i == 15)
            //    {
            //        break;
            //    }
            //    Console.Write(".");
            //}
            //Console.WriteLine();
            //// row 2
            //for (int i = 0; i < 16; i++)
            //{
            //    if (bitsArray[i] == 0)
            //    {
            //        Console.Write("#.#");
            //    }
            //    else
            //    {
            //        Console.Write(".#.");
            //    }
            //    if (i == 15)
            //    {
            //        break;
            //    }
            //    Console.Write(".");
            //}
            //Console.WriteLine();
            //// row 3
            //for (int i = 0; i < 16; i++)
            //{
            //    if (bitsArray[i] == 0)
            //    {
            //        Console.Write("#.#");
            //    }
            //    else
            //    {
            //        Console.Write(".#.");
            //    }
            //    if (i == 15)
            //    {
            //        break;
            //    }
            //    Console.Write(".");
            //}
            //Console.WriteLine();
            ////row 4
            //for (int i = 0; i < 16; i++)
            //{
            //    if (bitsArray[i] == 0)
            //    {
            //        Console.Write("###");
            //    }
            //    else
            //    {
            //        Console.Write("###");
            //    }
            //    if (i == 15)
            //    {
            //        break;
            //    }
            //    Console.Write(".");
            //}
            //Console.WriteLine();
        }
    }
}
