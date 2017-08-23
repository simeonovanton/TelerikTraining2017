using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string first = "";
            string second = "";
            bool isKey = false;
            int n = input.Length;

            // Extracting the numbers from the input string;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == ' ')
                {
                    isKey = true;
                    continue;
                }
                if (!isKey)
                {
                    first += input[i];
                }
                else
                {
                    second += input[i];
                }
            }

            // Ordering the numbers, so a > b;
            int a_num = int.Parse(first);
            int b_num = int.Parse(second);
            int a = a_num >= b_num ? a_num : b_num;
            int b = b_num <= a_num ? b_num : a_num;

            //Search the GCD of a and b:
            int extra = 0;
            while (b != 0)
            {
                extra = a % b;
                a = b;
                b = extra;
            }
            Console.WriteLine(a);
        }
    }
}
