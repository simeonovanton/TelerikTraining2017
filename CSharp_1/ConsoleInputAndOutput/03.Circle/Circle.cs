using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Circle
    {
        static void Main()
        {
            float radius = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("{0:0.00} {1:0.00}", 2 * Math.PI * radius, Math.PI * Math.Pow(radius, 2));
            
        }
    }
}
