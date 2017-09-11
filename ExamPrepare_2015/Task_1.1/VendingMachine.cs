using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class VendingMachine
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double sum = 0.05 * n1 + 0.1 * n2 + 0.2 * n3 + 0.5 * n4 + n5;

            if ((A - P) >= 0)
            {
                if ((A - P) <= sum)
                {
                    Console.WriteLine("Yes {0:F2}", sum - A + P);
                }
                else
                {
                    Console.WriteLine("No {0:F2}", Math.Abs(sum - A + P));
                }

            }
            else
            {
                Console.WriteLine("More {0:F2}", P - A);

            }
        }
    }
}
