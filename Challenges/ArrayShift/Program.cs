using System;
using static System.Console;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            // adds initial test
            WriteLine("Test array [2,4,6,8] with input: 5; expected: [2,4,5,6,8]");
            WriteLine($"returned: [{string.Join(",", ArrayShift(new int[] { 2, 4, 6, 8}, 5))}]");
        }
        
        // function that inserts an input into the middle of an array
        static int[] ArrayShift(int[] inArray, int input)
        {
            int[] returnArray = new int[inArray.Length + 1];

            // calculates the mid point as the middle index
            int midPoint = inArray.Length - inArray.Length / 2;

            // loops the new array to copy old array
            for(int i = 0; i < returnArray.Length; i++)
            {
                // if it's less than mid point
                if(i < midPoint)
                {
                    // copy using the same index
                    returnArray[i] = inArray[i];
                }
                // if it's the same midpoint
                else if(i == midPoint)
                {
                    // adds the input in the midpoint
                    returnArray[i] = input;
                }
                else
                {
                    // everything after midpoint, puts the old number
                    returnArray[i] = inArray[i - 1];
                }
            }

            // returns the array
            return returnArray;
        }
    }
}
