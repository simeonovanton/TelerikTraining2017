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
            bool foundNumber = false;

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
                            bool[] isMarkedTemp = new bool[4] { false, false, false, false };
                            bool[] isMarkedNumber = new bool[4] { false, false, false, false };

                            // check for Bulls
                            if (temp[3] == number[3])
                            {
                                currentBulls++;
                                isMarkedTemp[3] = true;
                                isMarkedNumber[3] = true;
                            }
                            if (temp[2] == number[2])
                            {
                                currentBulls++;
                                isMarkedTemp[2] = true;
                                isMarkedNumber[2] = true;
                            }
                            if (temp[1] == number[1])
                            {
                                currentBulls++;
                                isMarkedTemp[1] = true;
                                isMarkedNumber[1] = true;
                            }
                            if (temp[0] == number[0])
                            {
                                currentBulls++;
                                isMarkedTemp[0] = true;
                                isMarkedNumber[0] = true;
                            }

                            //--- check for 4th digit cows
                            if (temp[3] == number[2] && isMarkedTemp[3] == false && isMarkedNumber[2] == false)
                            {
                                currentCows++;
                                isMarkedTemp[3] = true;
                                isMarkedNumber[2] = true;
                            }
                            else if (temp[3] == number[1] && isMarkedTemp[3] == false && isMarkedNumber[1] == false)
                            {
                                currentCows++;
                                isMarkedTemp[3] = true;
                                isMarkedNumber[1] = true;
                            }
                            else if (temp[3] == number[0] && isMarkedTemp[3] == false && isMarkedNumber[0] == false)
                            {
                                currentCows++;
                                isMarkedTemp[3] = true;
                                isMarkedNumber[0] = true;
                            }
                            //--- check for 3rd digit cows
                            if (temp[2] == number[3] && isMarkedTemp[2] == false && isMarkedNumber[3] == false)
                            {
                                currentCows++;
                                isMarkedTemp[2] = true;
                                isMarkedNumber[3] = true;
                            }
                            else if (temp[2] == number[1] && isMarkedTemp[2] == false && isMarkedNumber[1] == false)
                            {
                                currentCows++;
                                isMarkedTemp[2] = true;
                                isMarkedNumber[1] = true;
                            }
                            else if (temp[2] == number[0] && isMarkedTemp[2] == false && isMarkedNumber[0] == false)
                            {
                                currentCows++;
                                isMarkedTemp[2] = true;
                                isMarkedNumber[0] = true;
                            }
                            //--- check for 2nd digit cows
                            if (temp[1] == number[3] && isMarkedTemp[1] == false && isMarkedNumber[3] == false)
                            {
                                currentCows++;
                                isMarkedTemp[1] = true;
                                isMarkedNumber[3] = true;
                            }
                            else if (temp[1] == number[2] && isMarkedTemp[1] == false && isMarkedNumber[2] == false)
                            {
                                currentCows++;
                                isMarkedTemp[1] = true;
                                isMarkedNumber[2] = true;
                            }
                            else if (temp[1] == number[0] && isMarkedTemp[1] == false && isMarkedNumber[0] == false)
                            {
                                currentCows++;
                                isMarkedTemp[1] = true;
                                isMarkedNumber[0] = true;
                            }
                            //--- check for 1st digit cows
                            if (temp[0] == number[3] && isMarkedTemp[0] == false && isMarkedNumber[3] == false)
                            {
                                currentCows++;
                                isMarkedTemp[0] = true;
                                isMarkedNumber[3] = true;
                            }
                            else if (temp[0] == number[2] && isMarkedTemp[0] == false && isMarkedNumber[2] == false)
                            {
                                currentCows++;
                                isMarkedTemp[0] = true;
                                isMarkedNumber[2] = true;
                            }
                            else if (temp[0] == number[1] && isMarkedTemp[0] == false && isMarkedNumber[1] == false)
                            {
                                currentCows++;
                                isMarkedTemp[0] = true;
                                isMarkedNumber[1] = true;
                            }                           
                            // check for total Bulls and Cows
                            if ((currentBulls == b) && (currentCows == c))
                            {
                                foundNumber = true;
                                Console.Write("{0}{1}{2}{3} ", temp[0], temp[1], temp[2], temp[3]);
                            }
                        }
                    }
                }
            }
            if (!foundNumber)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
