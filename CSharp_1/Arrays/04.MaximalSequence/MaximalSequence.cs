using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    counter++;
                    if (counter >= maxCount)
                    {
                        maxCount = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
