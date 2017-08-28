using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int maxSum = Int32.MinValue;

            // input
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Search Max Sum
            for (int i = 0; i < n; i++)
            {
                sum = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    sum += arr[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            // Printing
            Console.WriteLine(maxSum);
        }
    }
}
