using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            if ( D > 0 )
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("{0:0.00}", x1 < x2 ? x1 : x2);
                Console.WriteLine("{0:0.00}", x1 < x2 ? x2 : x1);

            }
            else if (D == 0)
            {
                Console.WriteLine("{0:0.00}", (-b / (2 * a)));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
