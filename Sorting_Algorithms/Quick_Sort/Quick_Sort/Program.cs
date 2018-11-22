using System;

namespace Quick_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            // creates array
            Console.WriteLine("Testing with array: 9,5,8,3,1");
            int[] myArray = { 9, 5, 8, 3, 1 };

            QuickSort(myArray, 0, myArray.Length - 1);

            Console.WriteLine("Should return 1,3,5,8,9 at the end");

            // displays them
            foreach(int n in myArray)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// The recursive quicksort function
        /// </summary>
        /// <param name="arr">The original array</param>
        /// <param name="left">starting left position</param>
        /// <param name="right">starting right position</param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Partition the Algorithm
                int position = Partition(arr, left, right);
                // Sort the left
                QuickSort(arr, left, position - 1);
                // Sort the right
                QuickSort(arr, position + 1, right);

            }

        }

        /// <summary>
        /// Partition around the pivot
        /// </summary>
        /// <param name="arr">The original array</param>
        /// <param name="left">the left position</param>
        /// <param name="right">the right position</param>
        /// <returns>returns the old low</returns>
        static int Partition(int[] arr, int left, int right)
        {
            // set a pivot
            int pivot = arr[right];
            // get the index of the lower value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }

            Swap(arr, right, low + 1);

            Console.WriteLine(string.Join(",", arr));


            return low + 1;
        }

        /// <summary>
        /// Swaps the two values
        /// </summary>
        /// <param name="arr">original array</param>
        /// <param name="i">right index</param>
        /// <param name="low">left index</param>
        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
