using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_2._2
{
    class SecretsOfNumbers
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger input = n;
            BigInteger secrSum = 0;
            int position = 0;
            while (n != 0)
            {
                int digit =Math.Abs((int)( n % 10));
                position++;
                n = n / 10;
                if (position % 2 != 0)
                {
                    secrSum += digit * position * position;
                }
                else
                {
                    secrSum += digit * digit * position;
                }
            }

            Console.WriteLine(secrSum);

            if (secrSum % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", input);
            }
            else
            {
                int numOfLetters = (int)secrSum % 10;
                int r = (int)secrSum % 26;
                for (int i = 0; i < numOfLetters; i++)
                {
                    Console.Write((char)('A' + (r + i) % 26));
                  //int index = r + i;
                  //char Letter = (char)(index + 65);
                  //  if (index + 65 > 90)
                  //  {
                  //      index = 0;
                  //      for (int j = 0; j < numOfLetters - i; j++, index++)
                  //      {
                  //          Letter = (char)(index + 65);
                  //          if (index > 25)
                  //          {
                  //              index = 0;
                  //          }
                  //          Console.Write(Letter);
                  //
                  //      }
                  //      break;
                  //  }
                  //  Console.Write(Letter);
                    
                }
            }
            Console.WriteLine();
        }
    }
}
