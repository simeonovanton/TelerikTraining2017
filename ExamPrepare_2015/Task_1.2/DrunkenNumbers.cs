using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class DrunkenNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if (input[i] < 0)
                {
                    input[i] = -input[i];
                }
            }

            int mitko = 0;
            int vladko = 0;

            for (int i = 0; i < n; i++)
            {               
                string temp = input[i].ToString();
                if (temp.Length % 2 == 0)
                {
                    for (int j = 0; j < temp.Length / 2; j++)
                    {
                        mitko += temp[j] - 48;
                    }

                    for (int j = temp.Length / 2 ; j < temp.Length; j++)
                    {
                        vladko += temp[j] - 48;
                    }
                }
                else
                {
                    for (int j = 0; j < temp.Length / 2 + 1; j++)
                    {
                        mitko += temp[j] - 48;
                    }

                    for (int j = temp.Length / 2 ; j < temp.Length; j++)
                    {
                        vladko += temp[j] - 48;
                    }
                }
            }

            if (mitko > vladko)
            {
                Console.WriteLine("M {0}", mitko - vladko);
            }
            else if (mitko < vladko)
            {
                Console.WriteLine("V {0}", vladko - mitko);
            }
            else
            {
                Console.WriteLine("No {0}", mitko * 2);
            }

        }
    }
}
