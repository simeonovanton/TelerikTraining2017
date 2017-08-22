using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] signs = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            foreach (string sign in signs)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign);
                if (sign == input)
                    break;

            }
        }
    }
}
