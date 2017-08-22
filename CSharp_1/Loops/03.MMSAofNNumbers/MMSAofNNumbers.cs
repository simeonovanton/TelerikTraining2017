using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSAofNNumbers
{
    class MMSAofNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double min = Double.MaxValue;
            double max = Double.MinValue;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input <= min)
                {
                    min = input;
                }
                if (input >= max)
                {
                    max = input;
                }

                sum += input;
            }
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", sum / n);
        }
    }
}
