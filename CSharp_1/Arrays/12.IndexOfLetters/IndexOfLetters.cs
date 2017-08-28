using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            // Generate alphabet array
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(97 + i);
            }

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (ch == alphabet[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
           
        }
    }
}
