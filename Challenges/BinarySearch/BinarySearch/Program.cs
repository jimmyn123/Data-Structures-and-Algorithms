using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int binarySearch(int[] inArray, int search)
        {
            int start = 0;
            int end = inArray.Length;
            do
            {
                int mid = (start + end) / 2;
                if (inArray[mid] == search)
                {
                    return mid;
                }
                else if (inArray[mid] > search)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            } while (start < end);
            return -1;
        }
    }
}
