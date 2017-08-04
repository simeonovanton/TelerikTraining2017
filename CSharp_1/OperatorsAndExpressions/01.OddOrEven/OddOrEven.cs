using System;

namespace homework_01
{
    class homework_01
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            int checkBit = inputNum & 1;
            if (checkBit == 0)
            {
                Console.WriteLine("even " + inputNum);
            }
            else
            {
                Console.WriteLine("odd " + inputNum);
            }
        }
    }
}
