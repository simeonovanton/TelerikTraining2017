// * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
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
    }

    static void Main()
    {
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

    }
}