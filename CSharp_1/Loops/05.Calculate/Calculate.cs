using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            long fqrl = 1;
            for (int i = 1; i <= n; i++, fqrl *= i)
            {
                sum += fqrl / Math.Pow(x, i);
            }
            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}
