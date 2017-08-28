using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
           
            int maxCount = 1;
            int freqNumber = 0;

            // input
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Search for the most frequent number
            for (int i = 0; i < n - 1; i++)
            {
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    freqNumber = arr[i];
                }
            }

            // Printing
            Console.WriteLine("{0} ({1} times)", freqNumber, maxCount);

        }
    }
}
