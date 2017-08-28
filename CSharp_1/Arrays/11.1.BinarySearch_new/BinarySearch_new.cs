using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1.BinarySearch_new
{
    class BinarySearch_new
    {
        static void Main()
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
              arr[i] = int.Parse(Console.ReadLine());
            }

            int numX = int.Parse(Console.ReadLine());
            int beginInd = 0;
            int endInd = n - 1;
            int midInd = n / 2;
            bool matchFound = false;


            // Search
            while (beginInd <= endInd) 
            {
                midInd = (beginInd + endInd) / 2;
                if (numX > arr[midInd])
                {
                    beginInd = midInd + 1;
                }
                else if (numX < arr[midInd])
                {
                    endInd = midInd - 1;
                }
                else // numX == arr[midInd]
                {
                    matchFound = true;
                    break;
                }
            }
            // Printing

            if (matchFound)
            {
                Console.WriteLine(midInd);
            }
            else
            {
                Console.WriteLine("-1");
            }
          
        }
    }
}
