using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            bool isEqual = true;

            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isEqual = false;
                }
            }
            Console.WriteLine("{0}", isEqual ? "Equal" : "Not equal");
        }
    }
}
