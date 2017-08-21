using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            int input = 0;
            for (int i = 0; i < 5; i++)
            {
                input += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(input);
        }
    }
}
