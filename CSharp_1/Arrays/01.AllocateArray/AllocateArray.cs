using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            //Console.WriteLine("Въведете размер на масива: ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            int[] arr1 = new int[n];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i * 5;
                //Console.Write("arr[{0}]={1} ", i, arr1[i]);
                Console.WriteLine(arr1[i]);
            }
           
        }
    }
}
