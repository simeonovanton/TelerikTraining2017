using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1
{
    class Gardens
    {
        static void Main()
        {
            int tomatoS = int.Parse(Console.ReadLine());
            int tomatoA = int.Parse(Console.ReadLine());
            int cucumberS = int.Parse(Console.ReadLine());
            int cucumberA = int.Parse(Console.ReadLine());
            int potatoS = int.Parse(Console.ReadLine());
            int potatoA = int.Parse(Console.ReadLine());
            int carrotS = int.Parse(Console.ReadLine());
            int carrotA = int.Parse(Console.ReadLine());
            int cabbageS = int.Parse(Console.ReadLine());
            int cabbageA = int.Parse(Console.ReadLine());
            int beansS = int.Parse(Console.ReadLine());

            double totalSeedsCost =
                tomatoS * 0.5 +
                cucumberS * 0.4 +
                potatoS * 0.25 +
                carrotS * 0.6 +
                cabbageS * 0.3 +
                beansS * 0.4;
            Console.WriteLine("Total costs: {0:F2}", totalSeedsCost);

            int remainingArea = 250 - tomatoA - cucumberA - potatoA - carrotA - cabbageA;

            if (remainingArea < 0)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (remainingArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Beans area: {0}", remainingArea);
            }

        }
    }
}
