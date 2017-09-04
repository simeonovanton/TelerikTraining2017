using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1MergeSortAnotherTry
{
    class MergeSortTry
    {
        static void Main()
        {
            //Read input length and the input array
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];
            int[] temp = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            MergeAndSort(arr, temp, 0, arrLength / 2, arrLength);
        }

        static void MergeAndSort(int[] input, int[] temporary, int iL, int iM, int iR )
        {

            

        }

        static void Devide(int[] incomming, int iL, int iM, int iR)
        {
            int[] input = incomming;
            int indL = iL;
            int indM = iM;
            int indR = iR;
            while (indL < indR)
            {
                Devide(input, ind)
            }
        }
    }
}
