using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._3
{
    class XExpression
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double digitFirst = 0;
            double digitSecond = 0;
            double result;
            string sign;

            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    digitFirst = symbol - '0';
                }

                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {

                }
            }
        }
    }
}
