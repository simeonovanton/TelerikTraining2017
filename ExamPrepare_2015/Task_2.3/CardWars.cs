using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._3
{
    class CardWars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger score1 = 0;
            BigInteger score2 = 0;
            int games1 = 0;
            int games2 = 0;
            for (int i = 0; i < n; i++)
            {
                // 1st player
                long sum1 = 0;
                bool markerX1 = false;
                for (int j = 0; j < 3; j++)
                {
                    string read1 = Console.ReadLine();
                    int input1 = 0;
                    switch (read1)
                    {
                        case "2":  input1 = 10;  break;
                        case "3":  input1 = 9;  break;
                        case "4":  input1 = 8; break;
                        case "5":  input1 = 7; break;
                        case "6":  input1 = 6; break;
                        case "7":  input1 = 5; break;
                        case "8":  input1 = 4; break;
                        case "9":  input1 = 3; break;
                        case "10": input1 = 2; break;
                        case "A":  input1 = 1; break;
                        case "J":  input1 = 11; break;
                        case "Q":  input1 = 12; break;
                        case "K":  input1 = 13; break;
                        case "X":  markerX1 = true; break;
                        case "Y": score1 -= 200; break;
                        case "Z": score1 *= 2; break;

                        default:
                         
                            break;
                    }
                    sum1 += input1;
                }

                // 2nd player
                long sum2 = 0;
                bool markerX2 = false;
                for (int j = 0; j < 3; j++)
                {
                    string read2 = Console.ReadLine();
                    int input2 = 0;
                    switch (read2)
                    {
                        case "2": input2 = 10; break;
                        case "3": input2 = 9; break;
                        case "4": input2 = 8; break;
                        case "5": input2 = 7; break;
                        case "6": input2 = 6; break;
                        case "7": input2 = 5; break;
                        case "8": input2 = 4; break;
                        case "9": input2 = 3; break;
                        case "10": input2 = 2; break;
                        case "A": input2 = 1; break;
                        case "J": input2 = 11; break;
                        case "Q": input2 = 12; break;
                        case "K": input2 = 13; break;
                        case "X": markerX2 = true; break;
                        case "Y": score2 -= 200 ; break;
                        case "Z": score2 *= 2; break;

                        default:
                           
                            break;
                    }
                    sum2 += input2;
                }

                // check for the X card
                if (markerX1 == true && markerX2 == false)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    return;
                }
                else if (markerX1 == false && markerX2 == true)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    return;
                }

                if (sum1 > sum2)
                {
                    score1 += sum1;
                    games1++;
                }
                else if (sum1 < sum2)
                {
                    score2 += sum2;
                    games2++;
                }
                
            }
            if (score1 > score2)
            {
                Console.WriteLine("First player wins!\nScore: {0}\nGames won: {1}", score1, games1);
            }
            else if (score1 < score2)
            {
                Console.WriteLine("Second player wins!\nScore: {0}\nGames won: {1}", score2, games2);
            }
            else if (score1 == score2)
            {
                Console.WriteLine("It's a tie!\nScore: {0}", score1);
            }
        }
    }
}
