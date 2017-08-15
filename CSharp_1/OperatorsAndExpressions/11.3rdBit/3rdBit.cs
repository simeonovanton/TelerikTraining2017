    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _11._3rdBit
    {
        class PThirdBit
        {
            static void Main()
            {
                uint input = uint.Parse(Console.ReadLine());
                uint mask = 1 << 3;
                Console.WriteLine((input & mask) >> 3);
            }
        }
    }
