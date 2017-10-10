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
            double resultBrackets = 0;
            double result = 0;
            char sign = '+';
            char signBrackets = '+';
            bool inBrackets = false;

            foreach (char symbol in input)
            {
                if (symbol == '=')
                {
                    break;
                }
                else if (symbol == '(')
                {
                    inBrackets = true;
                    continue;
                }
                else if (symbol == ')')
                {
                    inBrackets = false;
                    switch (sign)
                    {
                        case '+': result += resultBrackets; break;
                        case '-': result -= resultBrackets; break;
                        case '*': result *= resultBrackets; break;
                        case '/': result /= resultBrackets; break;
                        default:
                            break;
                    }
                    //result += resultBrackets;
                    resultBrackets = 0;
                    signBrackets = '+';
                    continue;
                }

                if (char.IsDigit(symbol))
                {
                    digitFirst = symbol - '0';
                    if (inBrackets)
                    {
                        switch (signBrackets)
                        {
                            case '+': resultBrackets += digitFirst; break;
                            case '-': resultBrackets -= digitFirst; break;
                            case '*': resultBrackets *= digitFirst; break;
                            case '/': resultBrackets /= digitFirst; break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (sign)
                        {
                            case '+': result += digitFirst; break;
                            case '-': result -= digitFirst; break;
                            case '*': result *= digitFirst; break;
                            case '/': result /= digitFirst; break;
                            default:
                                break;
                        }
                    }

                }

                if (inBrackets)
                {
                    switch (symbol)
                    {
                        case '+': signBrackets = '+'; break;
                        case '-': signBrackets = '-'; break;
                        case '*': signBrackets = '*'; break;
                        case '/': signBrackets = '/'; break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (symbol)
                    {
                        case '+': sign = '+'; break;
                        case '-': sign = '-'; break;
                        case '*': sign = '*'; break;
                        case '/': sign = '/'; break;
                        default:
                            break;
                    }
                }
                

            }
            Console.WriteLine("{0:0.00}", result);
        }
    }
}
