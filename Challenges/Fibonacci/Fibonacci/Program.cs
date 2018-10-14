using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            // loop while the number is not valid
            bool notValid = true;
            while (notValid)
            {
                Console.WriteLine("Find nth fibonacci number: ");
                int n;
                notValid = !(int.TryParse(Console.ReadLine(), out n));
                Console.WriteLine($"The number {n} ficonacci number is: {FindNth(n)}");
            }
        }

        public static int FindNth(int n)
        {
            // if it is one of the first two, return 0 for 1st num and 1 for 2nd num
            if(n < 2)
            {
                return n;
            }
            int prev = 0;
            int curr = 1;

            // loop through and calculate the nth number
            for(int i = 1; i < n; i++)
            {
                int newNum = prev + curr;
                prev = curr;
                curr = newNum;
            }
            return curr;
        }
    }
}
