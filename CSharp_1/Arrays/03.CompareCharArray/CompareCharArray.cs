using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArray
{
    class CompareCharArray
    {
        static void Main()
        {
            char[] firstArr = Console.ReadLine().ToArray();
            char[] secondArr = Console.ReadLine().ToArray();
            int length = Math.Min(firstArr.Length, secondArr.Length);


            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("<"); break;
                    }
                    else if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(">"); break;
                    }
                    else if (i == length - 1)
                    {
                        Console.WriteLine("=");
                    }
                }
            }
            else if (firstArr.Length > secondArr.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("<"); break;
                    }
                    else if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(">"); break;
                    }
                    else if (i == length - 1)
                    {
                        Console.WriteLine(">");
                    }
                }
            }
            else if (firstArr.Length < secondArr.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("<"); break;
                    }
                    else if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(">"); break;
                    }
                    else if (i == length - 1)
                    {
                        Console.WriteLine("<");
                    }
                }
            }
        
        }
    }
}
