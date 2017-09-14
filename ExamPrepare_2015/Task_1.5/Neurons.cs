using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._5
{
    class Neurons
    {
        static void Main()
        {
            #region variant 1
            //       long input = 0;
            //
            //       while (true)
            //       {
            //           input = long.Parse(Console.ReadLine());
            //           if (input == -1)
            //           {
            //               break;
            //           }
            //
            //           long result = 0;
            //           int mostLeftIndex = -1;
            //           int mostRightIndex = -1;
            //
            //           for (int i = 0; i < 32; i++)
            //           {
            //               long mask = 1 << i;
            //               long checkFor_1 = (input & mask) >> i;
            //
            //               if (checkFor_1 == 1)
            //               {
            //                   if (mostRightIndex == -1)
            //                   {
            //                       mostRightIndex = i;
            //                   }
            //                   mostLeftIndex = i;
            //               }
            //           }
            //
            //           for (int j = mostRightIndex + 1; j < mostLeftIndex; j++)
            //           {
            //               long mask = 1 << j;
            //
            //               if ((mask & input) == 0)
            //               {
            //                   // set j index of result to 1
            //                   result |= mask;
            //               }
            //           }
            //           Console.WriteLine(result);
            //       }
            //
            //       // Console.WriteLine(Convert.ToString(a | b, 2).PadLeft(32, '0'));
            #endregion

            #region variant 2
            List<long> list = new List<long>();
            List<long> output = new List<long>();

            while (true)
            {
                long input = long.Parse(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }

                list.Add(input);
            }

            foreach (long num in list)
            {
                long result = 0;
                int mostLeftIndex = -1;
                int mostRightIndex = -1;

                for (int i = 0; i < 32; i++)
                {
                    long mask = 1 << i;
                    long checkFor_1 = (num & mask) >> i;

                    if (checkFor_1 == 1)
                    {
                        if (mostRightIndex == -1)
                        {
                            mostRightIndex = i;
                        }
                        mostLeftIndex = i;
                    }
                }
                for (int j = mostRightIndex + 1; j < mostLeftIndex; j++)
                {
                    long mask = 1 << j;
                    if ((num & mask) == 0)
                    {
                        // set j index of resut to 1
                        result |= mask;
                    }

                }
                output.Add(result);

            }

            foreach (int result in output)
            {
                Console.WriteLine(result);
            }

            #endregion

        }
    }
}
