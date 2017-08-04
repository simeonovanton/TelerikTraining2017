using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float inputW = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", inputW * 0.17F );
        }
    }
}