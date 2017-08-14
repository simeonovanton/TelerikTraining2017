using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            float inputX = float.Parse(Console.ReadLine());
            float inputY = float.Parse(Console.ReadLine());

            float circleRadius = 2f;
            float inputRadius = (float)Math.Sqrt(inputX * inputX + inputY * inputY);
            if (inputRadius <= circleRadius)
            {
                Console.WriteLine("yes {0:0.00}", inputRadius);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", inputRadius);
            }
        }
    }
}
