<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

/* Write a program that sorts an array of integers
 * using the merge sort algorithm (find it in Wikipedia). */

class MergeSortAlgorithm
{
    public static int[] MergeSort(int[] array)
    {
        // If list size is 0 (empty) or 1, consider it sorted and return it
        // (using less than or equal prevents infinite recursion for a zero length array).
        if (array.Length <= 1)
        {
            return array;
        }

        // Else list size is > 1, so split the list into two sublists.
        int middleIndex = (array.Length) / 2;
        int[] left = new int[middleIndex];
        int[] right = new int[array.Length - middleIndex];

        Array.Copy(array, left, middleIndex);
        Array.Copy(array, middleIndex, right, 0, right.Length);

        // Recursively call MergeSort() to further split each sublist
        // until sublist size is 1.
        left = MergeSort(left);
        right = MergeSort(right);

        // Merge the sublists returned from prior calls to MergeSort()
        // and return the resulting merged sublist.
        return Merge(left, right);
    }

    public static int[] Merge(int[] left, int[] right)
    {
        // Convert the input arrays to lists, which gives more flexibility
        // and the option to resize the arrays dynamically.
        List<int> leftList = left.OfType<int>().ToList();
        List<int> rightList = right.OfType<int>().ToList();
        List<int> resultList = new List<int>();

        // While the sublist are not empty merge them repeatedly to produce new sublists
        // until there is only 1 sublist remaining. This will be the sorted list.
        while (leftList.Count > 0 || rightList.Count > 0)
        {
            if (leftList.Count > 0 && rightList.Count > 0)
            {
                // Compare the 2 lists, append the smaller element to the result list
                // and remove it from the original list.
                if (leftList[0] <= rightList[0])
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            else if (leftList.Count > 0)
            {
                resultList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }

            else if (rightList.Count > 0)
            {
                resultList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
        }

        // Convert the resulting list back to a static array
        int[] result = resultList.ToArray();
        return result;
=======
﻿// * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
using System;

class MergeSortAlgorithm
{
    // Sorts and combines 2 subarrays.
    static void PartialSort(int[] data, int[] temp, int startIndex, int midIndex, int endIndex)
    {
        // Start index of 1st subarray.
        int leftHead = startIndex;
        // Start index of 2nd subarray.
        int rightHead = midIndex + 1;
        // Start index at helper array.
        int tempHead = startIndex;

        // Compare the elements from the subarrays and place them into helper array in sorted order.
        // The algorithm uses the fact that the subarrays are already sorted.
        while ((leftHead <= midIndex) && (rightHead <= endIndex))
        {
            temp[tempHead++] = data[leftHead] < data[rightHead] ? data[leftHead++] : data[rightHead++];
        }

        // Copy what left from 1st subarray.
        while (leftHead <= midIndex)
        {
            temp[tempHead++] = data[leftHead++];
        }

        // Copy what left from 2nd subarray.
        while (rightHead <= endIndex)
        {
            temp[tempHead++] = data[rightHead++];
        }

        // Move the combined and sorted subarray from helper to data array.
        while (startIndex <= endIndex)
        {
            data[startIndex] = temp[startIndex++];
        }
    }

    // Divides the subarray constrained by startIndex and endIndex in 2 subarrays
    // and process them recursively.
    static void MergeSort(int[] data, int[] temp, int startIndex, int endIndex)
    {
        int middleIndex = (startIndex + endIndex) / 2;

        // If subarray is empty or has only 1 member then it is sorted.
        if (startIndex >= endIndex)
        {
            return;
        }

        MergeSort(data, temp, startIndex, middleIndex);
        MergeSort(data, temp, middleIndex + 1, endIndex);
        PartialSort(data, temp, startIndex, middleIndex, endIndex);
>>>>>>> db8951896e2ea2d324e73c43a4a16666d1ca09f8
    }

    static void Main()
    {
<<<<<<< HEAD
        int[] array = new int[] { 5, 2, 6, 4, 7, 10, 1, 9, 3, 8 };

        array = MergeSort(array);

        // Print the sorted list
        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine("element[{0}] = {1}", index, array[index]);
        }

        Console.WriteLine();
=======
        int[] someNumbers;
        int arrayLength;
        // Helper array.
        int[] tempArray;

        // Read the array.

        if ((!int.TryParse(Console.ReadLine(), out arrayLength)) || (arrayLength <= 0))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        someNumbers = new int[arrayLength];
        tempArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {

            if (!int.TryParse(Console.ReadLine(), out someNumbers[i]))
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }

        // Merge sort.
        MergeSort(someNumbers, tempArray, 0, arrayLength - 1);

        // Print the result.
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine(someNumbers[i]);
        }

>>>>>>> db8951896e2ea2d324e73c43a4a16666d1ca09f8
    }
}