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

            // Console.WriteLine(Convert.ToString(a | b, 2).PadLeft(32, '0'));

            long input = 0;
            //  List<int> list = new List<int>();
            //  List<int> output = new List<int>();

            while (true)
            {
                input = long.Parse(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                // list.Add(input);

                long result = 0;
                int mostLeftIndex = -1;
                int mostRightIndex = -1;

                for (int i = 0; i < 32; i++)
                {
                    long mask = 1 << i;
                    long checkFor_1 = (input & mask) >> i;

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
                    //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));

                    if ((mask & input) == 0)
                    {
                        // set j index of resut to 1
                        result |= mask;
                    }
                    


                }
                Console.WriteLine(result);
            }

            // foreach (int num in list)
            // {
            //     int result = 0;
            //     int mostLeftIndex = -1;
            //     int mostRightIndex = -1;
            //
            //     for (int i = 0; i < 32; i++)
            //     {
            //         int mask = 1 << i;
            //         int checkFor_1 = (num & mask) >> 1;
            //
            //         if (checkFor_1 == 1)
            //         {
            //             if (mostRightIndex == -1)
            //             {
            //                 mostRightIndex = i;
            //             }
            //             mostLeftIndex = i;
            //         }
            //     }
            //     for (int j = mostRightIndex + 1; j < mostLeftIndex; j++)
            //     {
            //         int mask = 1 << j;
            //         Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            //
            //         if ((num & mask) == 0)
            //         {
            //             // set j index of resut to 1
            //             result |= mask;
            //         }
            //         
            //     }
            //     output.Add(result);
            //
            // }
            //
            // foreach (int result in output)
            // {
            //     Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            // }
            //
        }
    }
}
