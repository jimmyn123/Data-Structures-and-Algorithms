using System;
using System.Collections.Generic;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates new array to sort
            List<int> sorted = MergeSort(new int[] { 5, 8, 4, 7, 9, 2 });

            Console.WriteLine("Testing array: 5, 8, 4, 7, 9, 2");
            Console.WriteLine("Should return: 2, 4, 5, 7, 8, 9");

            // prints out the returned list
            foreach(int num in sorted)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// The initial mergesort without a list
        /// </summary>
        /// <param name="myArray">the array to sort</param>
        /// <returns>a sorted list of ints</returns>
        static List<int> MergeSort(int[] myArray)
        {
            List<int> returnList = new List<int>();
            MergeSort(myArray, returnList);
            return returnList;
        }

        /// <summary>
        /// The actual mergesort that adds the sorted values into the return list
        /// </summary>
        /// <param name="myArray">the array to sort</param>
        /// <param name="returnList">the return </param>
        static void MergeSort(int[] myArray, List<int> returnList)
        {
            if (myArray.Length > 1)
            {
                //establishing sizes of each half of the array
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                // put the first half in one array (left)
                int[] left = new int[leftSize];
                Array.Copy(myArray, 0, left, 0, leftSize);

                // put the second half in another array (right)
                int[] right = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, myArray);

            }
            
            // adds them to the return list
            foreach(int num in myArray)
            {
                returnList.Add(num);
            }

        }

        /// <summary>
        /// Sorts two arrays and combines then
        /// </summary>
        /// <param name="left">the left half</param>
        /// <param name="right">the right half</param>
        /// <param name="arr">the main array</param>
        /// <returns>returns an array that merged both and is sorted</returns>
        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left pointer
            int i = 0;
            // right pointer
            int j = 0;
            // end array pointer
            int k = 0;

            // confirm that each array being compared still has pointers
            while (i < left.Length && j < right.Length)
            {
                // if the value of left array is less than the value of the right array
                if (left[i] <= right[j])
                {
                    // populate the main array with lower value
                    arr[k] = left[i];
                    // immediately increment i.
                    i++;
                }
                else
                {
                    // put the value of the right array into the main array
                    arr[k] = right[j];
                    // increment the pointer of the right
                    j++;
                }
                // increment the pointer in the main array
                k++;
            }


            if (i == left.Length)
            {
                // copy right array into main array
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;

        }

    }
}
