using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._3
{
    class BullCows
    {
        static void Main()
        {
            int[] number = Console.ReadLine().Select(n => (Convert.ToInt32(n)) - 48).ToArray();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (b == 3 && c != 0)
            {
                Console.WriteLine("No");
                return;
            }

            int[] temp = new int[4];

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1 j < 9; j++)
                {

                    for (int k = 1; k < 9; k++)
                    {
                        for (int l = 1; l < 9; l++)
                        {

                        }
                    }
                }
            }
        }
    }
}
