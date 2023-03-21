using System;

class BinarySearch
{
    static int binarySearch(int[] arr, int x, int low, int high)
    {
        if (high >= low)
        {
            int mid = low + (high - low) / 2;

            // If found at mid, then return it
            if (arr[mid] == x)
                return mid;

            // Search the left half
            if (arr[mid] > x)
                return binarySearch(arr, x, low, mid - 1);

            // Search the right half
            return binarySearch(arr, x, mid + 1, high);
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 3, 4, 5, 6, 7, 8, 9 };
        int x = 4;
        int n = arr.Length;
        int result = binarySearch(arr, x, 0, n - 1);
        if (result == -1)
            Console.WriteLine("Not found");
        else
            Console.WriteLine("Element is found at index " + result);
    }
}
