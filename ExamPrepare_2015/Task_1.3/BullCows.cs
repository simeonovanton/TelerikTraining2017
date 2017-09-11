using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._3
{
    class BullCows
    {
        static void Main()
        {
            int[] number = Console.ReadLine().Select(n => (Convert.ToInt32(n)) - 48).ToArray();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (b == 3 && c != 0)
            {
                Console.WriteLine("No");
                return;
            }

            int[] temp = new int[4];

            for (int i = 1; i <= 9; i++)
            {
                temp[0] = i;
                for (int j = 1; j <= 9; j++)
                {
                    temp[1] = j;
                    for (int k = 1; k <= 9; k++)
                    {
                        temp[2] = k;
                        for (int l = 1; l <= 9; l++)
                        {
                            temp[3] = l;
                            int currentBulls = 0;
                            int currentCows = 0;
                            if (temp[3] == number[3])
                            {
                                currentBulls++;
                            }
                            if (temp[2] == number[2])
                            {
                                currentBulls++;
                            }
                            if (temp[1] == number[1])
                            {
                                currentBulls++;
                            }
                            if (temp[0] == number[0])
                            {
                                currentBulls++;
                            }

                            //--- check for 4th digit cows
                           /* if (temp[3] == number[3])
                            {
                                currentBulls++;
                            }*/
                            if (temp[3] == number[2])
                            {
                                currentCows++;
                            }
                            else if (temp[3] == number[1])
                            {
                                currentCows++;
                            }
                            else if (temp[3] == number[0])
                            {
                                currentCows++;
                            }
                            //--- check for 3rd digit cows
                            /*if (temp[2] == number[2])
                            {
                                currentBulls++;
                            } */
                            if (temp[2] == number[3])
                            {
                                currentCows++;
                            }
                            else if (temp[2] == number[1])
                            {
                                currentCows++;
                            }
                            else if (temp[2] == number[0])
                            {
                                currentCows++;
                            }
                            //--- check for 2nd digit cows
                            if (temp[1] == number[3])
                            {
                                currentCows++;
                            }
                            else if (temp[1] == number[2])
                            {
                                currentCows++;
                            }
                            else if (temp[1] == number[0])
                            {
                                currentCows++;
                            }
                            //--- check for 1st digit cows
                            if (temp[0] == number[3])
                            {
                                currentCows++;
                            }
                            else if (temp[0] == number[2])
                            {
                                currentCows++;
                            }
                            else if (temp[0] == number[1])
                            {
                                currentCows++;
                            }                           
                            // check for total Bulls and Cows
                            if ((currentBulls == b) && (currentCows == c))
                            {
                                Console.Write("{0}{1}{2}{3} ", temp[0], temp[1], temp[2], temp[3]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
