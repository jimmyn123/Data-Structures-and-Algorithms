using System;
using Day06_LinkedList.Classes;

namespace ll_Kth_From_End
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList(new Node(1));
            list.Add(new Node(2));
            list.Add(new Node(3));
            list.Add(new Node(4));

            Console.WriteLine("2nd element from the end is: " + Kth_From_End(list, 2).Value);
        }

        /// <summary>
        /// Returns the kth element from the end
        /// </summary>
        /// <param name="input">input a linked list source</param>
        /// <param name="k">the kth element from the end</param>
        /// <returns></returns>
        public static Node Kth_From_End(LList input, int k)
        {
            try
            {
                // looks into the future to see if there is a null
                Node returnNode = input.Head;
                Node current = input.Head;
                for(int i = 0; i < k; i++)
                {
                    current = current.Next;
                }

                // if it's perfectly spaced, that means the kth element is the first element
                if(current.Next == null)
                {
                    return returnNode;
                }
                current = current.Next;

                // iterate while there is still an element in the current's next
                while(returnNode.Next != null)
                {
                    returnNode = returnNode.Next;
                    if(current.Next == null)
                    {
                        return returnNode;
                    }
                    current = current.Next;
                }

                // this should never hit
                return null;
            }
            catch (Exception e)
            {
                throw new Exception("K is bigger than the length of the list!", e);
            }
        }
    }
}
