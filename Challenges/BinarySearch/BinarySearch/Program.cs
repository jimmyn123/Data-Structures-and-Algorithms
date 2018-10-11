using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// A binary search that halves the amount to search each time.
        /// </summary>
        /// <param name="inArray">An array of sorted integers.</param>
        /// <param name="search">The search value.</param>
        /// <returns></returns>
        public static int binarySearch(int[] inArray, int search)
        {
            // sets intial start and end points
            int start = 0;
            int end = inArray.Length;
            // does it first before testing conditon
            do
            {
                // calculates the mid by adding both and dividing
                int mid = (start + end) / 2;
                if (inArray[mid] == search)
                {
                    // found the number, returns the index
                    return mid;
                }
                else if (inArray[mid] > search)
                {
                    // set the new end point to mid - 1 since the value at mid is less than the search value
                    end = mid - 1;
                }
                else
                {
                    // set new start otherwise
                    start = mid + 1;
                }
            // do this while start is the same as end, which is one number, or start is less than end
            } while (start <= end);

            // didn't find it otherwise
            return -1;
        }
    }
}
