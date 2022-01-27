// See https://aka.ms/new-console-template for more information
public static class ArrayAlgos
{
    public static void BinarySearch(int target)
    {
        int[] sortedArray = new int[] { 1, 3, 5, 7, 9, 11, 13 };

        int targetNumber = target;
        bool found = false;

        int lowestIndex = 0;
        int hightestIndex = sortedArray.Length - 1;
        int midIndex = 0;

        int iterations = 0;

        while (lowestIndex <= hightestIndex)
        {
            midIndex = (hightestIndex + lowestIndex) / 2;
            iterations++;

            if (sortedArray[midIndex] == targetNumber)
            {
                found = true;
                break;
            }
            else if (sortedArray[midIndex] > targetNumber)
            {
                hightestIndex = midIndex - 1;
            }
            else if (sortedArray[midIndex] < targetNumber)
            {
                lowestIndex = midIndex + 1;
            }
        }

        if (found)
            Console.WriteLine($"Found target number {targetNumber} after {iterations} cycle(s).");
        else
            Console.WriteLine("Not Found");
    }

    public static void SelectionSort(int[] unsortedArray)
    {
        int lowestIndex = 0;

        for (int i = 0; i < unsortedArray.Length; i++)
        {
            lowestIndex = i;

            for (int j = i + 1; j < unsortedArray.Length; j++)
            {
                if (unsortedArray[j] < unsortedArray[lowestIndex])
                {
                    lowestIndex = j;
                }
            }

            Swap(unsortedArray, i, lowestIndex);
        }

        PrintArrayContents(unsortedArray);
    }

    public static void Swap(int[] arr, int leftIndex, int rightIndex)
    {
        int temp = arr[leftIndex];
        arr[leftIndex] = arr[rightIndex];
        arr[rightIndex] = temp;
    }

    public static void PrintArrayContents(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }

    public static void BubbleSort(int[] unsortedArray)
    {
        for (int i = 0; i < unsortedArray.Length - 1; i++)
        {
            int current = 0;
            bool isSorted = true;

            while(current < unsortedArray.Length - 1)
            {
                var left = unsortedArray[current];
                var right = unsortedArray[current+1];
                
                if(left > right)
                {
                    Swap(unsortedArray, current, current+1);
                    isSorted = false;
                }

                current++;
            }

            if (isSorted)
                break;
        }

        PrintArrayContents(unsortedArray);
    }
    
    public static void InsertionSort(int[] unsortedArray)
    {
        // 5, 3, 1, 13, 7, 11, 9
        for (int j = 1; j < unsortedArray.Length; j++)
        {
            int current = j;

            while (current > 0)
            {
                var left = unsortedArray[current - 1];
                var right = unsortedArray[current];

                if (left > right)
                {
                    Swap(unsortedArray, current-1, current);
                }

                current -= 1;
            }
        }

        PrintArrayContents(unsortedArray);
    }

    public static int Fibonacci(int target)
    {
        if (target == 0) 
        { 
            return 0; 
        }
        else if (target == 1) 
        { 
            return 1; 
        }
        else
        {
            return Fibonacci(target - 1) + Fibonacci(target - 2);
        }
    }

    // Merge Sort
    public static void MergeSort(int[] unsortedArray)
    {
        if (unsortedArray.Length <= 1)
        {
            return;
        }

        int mid = unsortedArray.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[unsortedArray.Length - mid];

        for (int i = 0; i < mid; i++)
        {
            left[i] = unsortedArray[i];
        }

        for (int i = mid; i < unsortedArray.Length; i++)
        {
            right[i - mid] = unsortedArray[i];
        }

        MergeSort(left);
        MergeSort(right);

        Merge(unsortedArray, left, right);

        PrintArrayContents(unsortedArray);
    }

    public static void Merge(int[] unsortedArray, int[] left, int[] right)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int unsortedIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                unsortedArray[unsortedIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                unsortedArray[unsortedIndex] = right[rightIndex];
                rightIndex++;
            }

            unsortedIndex++;
        }

        while (leftIndex < left.Length)
        {
            unsortedArray[unsortedIndex] = left[leftIndex];
            leftIndex++;
            unsortedIndex++;
        }

        while (rightIndex < right.Length)
        {
            unsortedArray[unsortedIndex] = right[rightIndex];
            rightIndex++;
            unsortedIndex++;
        }
    }

    // Quick Sort
    public static void QuickSort(int[] unsortedArray)
    {
        QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
        PrintArrayContents(unsortedArray);
    }

    public static void QuickSort(int[] unsortedArray, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(unsortedArray, left, right);

            QuickSort(unsortedArray, left, pivot - 1);
            QuickSort(unsortedArray, pivot + 1, right);
        }
    }

    public static int Partition(int[] unsortedArray, int left, int right)
    {
        int pivot = unsortedArray[right];
        int low = left - 1;

        for (int i = left; i < right; i++)
        {
            if (unsortedArray[i] <= pivot)
            {
                low++;
                Swap(unsortedArray, i, low);
            }
        }

        Swap(unsortedArray, right, low + 1);

        return low + 1;
    }
}


