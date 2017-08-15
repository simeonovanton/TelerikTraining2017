using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double inputX = double.Parse(Console.ReadLine());
            double inputY = double.Parse(Console.ReadLine());

            // Check for Circle
            bool isInCircle = false;
            double checkCircle = Math.Sqrt((inputX - 1) * (inputX - 1) + (inputY - 1) * (inputY - 1));

            if (checkCircle <= 1.5)
            {
                isInCircle = true;
            }

            // Check for Rectangle
            bool isInRectangle = false;
            if ((inputX >= -1 && inputX <= 5) && (inputY >= -1 && inputY <= 1))
            {
                isInRectangle = true;
            }

            Console.WriteLine("{0} {1}", isInCircle ? "inside circle" : "outside circle", isInRectangle ? "inside rectangle" : "outside rectangle");
       }
    }
}
