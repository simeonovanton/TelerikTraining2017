using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            // input
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            int numX = int.Parse(Console.ReadLine());
            int result = 0;

            


            // Search
            foreach (int number in list)
            {
                if (number == numX)
                {
                    result = list.IndexOf(numX);
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            // Printing
            Console.WriteLine(result);
        }
    }
}
