using System;

public class MergeSort
{
    public static void MergeSortAlgorithm(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];


        for (int i = 0; i < mid; i++)
            left[i] = arr[i];
        for (int i = mid; i < arr.Length; i++)
            right[i - mid] = arr[i];

      
        MergeSortAlgorithm(left);
        MergeSortAlgorithm(right);

        Merge(left, right, arr);
    }

    public static void Merge(int[] left, int[] right, int[] arr)
    {
        int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                arr[mergedIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[mergedIndex] = right[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        while (leftIndex < left.Length)
        {
            arr[mergedIndex] = left[leftIndex];
            leftIndex++;
            mergedIndex++;
        }
        while (rightIndex < right.Length)
        {
            arr[mergedIndex] = right[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 8, 4, 23, 42, 16, 15 };

        Console.WriteLine("Original Array: ");
        PrintArray(arr);

        MergeSortAlgorithm(arr);

        Console.WriteLine("Sorted Array: ");
        PrintArray(arr);
    }

    public static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
