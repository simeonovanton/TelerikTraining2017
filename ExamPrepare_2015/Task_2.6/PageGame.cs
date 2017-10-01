using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._6
{
    class PageGame
    {
        static void Main()
        {
            string cmdWhatIs = "what is";
            string cmdBuy = "buy";
            string cmdPaypal = "paypal";

            int cookiesNumber = 0;
            double cookiePrice = 1.79;

            int[] rows = new int[16];
            for (int i = 0; i < 16; i++)
            {
                rows[i] = Convert.ToInt32(Console.ReadLine(), 2);
            }

            int rowUpper = 0;
            int rowMiddle = 0;
            int rowLower = 0;

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == cmdPaypal)
                {
                    break;
                }

                int row = int.Parse(Console.ReadLine());
                int col = 15 - int.Parse(Console.ReadLine());

                switch (row)
                {
                    case 0: rowUpper = 0; rowMiddle = rows[0]; rowLower = rows[1]; break;
                    case 1: rowUpper = rows[0]; rowMiddle = rows[1]; rowLower = rows[2]; break;
                    case 2: rowUpper = rows[1]; rowMiddle = rows[2]; rowLower = rows[3]; break;
                    case 3: rowUpper = rows[2]; rowMiddle = rows[3]; rowLower = rows[4]; break;
                    case 4: rowUpper = rows[3]; rowMiddle = rows[4]; rowLower = rows[5]; break;
                    case 5: rowUpper = rows[4]; rowMiddle = rows[5]; rowLower = rows[6]; break;
                    case 6: rowUpper = rows[5]; rowMiddle = rows[6]; rowLower = rows[7]; break;
                    case 7: rowUpper = rows[6]; rowMiddle = rows[7]; rowLower = rows[8]; break;
                    case 8: rowUpper = rows[7]; rowMiddle = rows[8]; rowLower = rows[9]; break;
                    case 9: rowUpper = rows[8]; rowMiddle = rows[9]; rowLower = rows[10]; break;
                    case 10: rowUpper = rows[9]; rowMiddle = rows[10]; rowLower = rows[11]; break;
                    case 11: rowUpper = rows[10]; rowMiddle = rows[11]; rowLower = rows[12]; break;
                    case 12: rowUpper = rows[11]; rowMiddle = rows[12]; rowLower = rows[13]; break;
                    case 13: rowUpper = rows[12]; rowMiddle = rows[13]; rowLower = rows[14]; break;
                    case 14: rowUpper = rows[13]; rowMiddle = rows[14]; rowLower = rows[15]; break;
                    case 15: rowUpper = rows[14]; rowMiddle = rows[15]; rowLower = 0; break;

                    default:
                        break;
                }

                bool isCookieCrumb = (rowMiddle & (1 << col)) != 0;

                bool isCookieBroken = 
                    // center
                    ((rowMiddle & (1 << col)) != 0) &&
                  // upper
                  (
                        (   ((rowUpper & (1 << (col + 1))) != 0) || ((rowUpper & (1 << col)) != 0) || ((rowUpper & (1 << (col - 1))) != 0)  ) ||
                     //middle
                        (   ((rowMiddle & (1 << (col + 1))) != 0) || ((rowMiddle & (1 << (col - 1))) != 0)  ) ||
                     //lower
                        (((rowLower & (1 << (col + 1))) != 0) || ((rowLower & (1 << col)) != 0) || ((rowLower & (1 << (col - 1))) != 0))
                    );

                bool isCookie =
                    //center
                    ((rowMiddle & (1 << col)) != 0) &&
                        //upper
                        (((rowUpper & (1 << (col + 1))) != 0) && ((rowUpper & (1 << col)) != 0) && ((rowUpper & (1 << (col - 1))) != 0)) &&
                        //middle
                        (((rowMiddle & (1 << (col + 1))) != 0) && ((rowMiddle & (1 << (col - 1))) != 0)) &&
                        //lower
                        (((rowLower & (1 << (col + 1))) != 0) && ((rowLower & (1 << col)) != 0) && ((rowLower & (1 << (col - 1))) != 0))
                    ;

                if (cmd == cmdWhatIs)
                {
                    if (isCookie)
                    {
                        Console.WriteLine("cookie");
                    }
                    else if (isCookieBroken)
                    {
                        Console.WriteLine("broken cookie");
                    }
                    else if (isCookieCrumb)
                    {
                        Console.WriteLine("cookie crumb");
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                }
                else if (cmd == cmdBuy)
                {
                    if (isCookie)
                    {
                        // TODO
                        cookiesNumber++;
                        // zero cookie
                        rowUpper ^= (1 << (col + 1));
                        rowUpper ^= (1 << col);
                        rowUpper ^= (1 << (col - 1));
                        rowMiddle ^= (1 << (col + 1));
                        rowMiddle ^= (1 << col);
                        rowMiddle ^= (1 << (col - 1));
                        rowLower ^= (1 << (col + 1));
                        rowLower ^= (1 << col);
                        rowLower ^= (1 << (col - 1));

                        rows[row - 1] = rowUpper;
                        rows[row] = rowMiddle;
                        rows[row + 1] = rowLower;
                        // zero cookie
                    }
                    else if (isCookieBroken)
                    {
                        Console.WriteLine("page");
                    }
                    else if (isCookieCrumb)
                    {
                        Console.WriteLine("page");
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                }




            }
            Console.WriteLine("{0:0.00}", cookiesNumber * cookiePrice);
        }
    }
}
