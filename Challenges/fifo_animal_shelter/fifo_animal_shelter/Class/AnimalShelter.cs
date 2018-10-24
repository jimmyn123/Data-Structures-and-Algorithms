using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Class
{

    public class AnimalShelter
    {
        // declares properties for an animalshelter queue
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public int Size { get; set; } = 0;

        /// <summary>
        /// Adds a node to the rear of the shelter
        /// </summary>
        /// <param name="newNode"></param>
        public void Enqueue(Node newNode)
        {
            if(Front == null)
            {
                Front = newNode;
            }
            else
            {
                Rear.Next = newNode;
            }
            Rear = newNode;
            Size++;
        }

        public Node Dequeue(string pref)
        {
            Node curr = Front;
            Node prev = null;
            Node result = Front;
            int counter = 0;
            while (counter < Size)
            {
                if (((Animal)curr.Value).Name.Equals(pref.ToLower()))
                {
                    if (prev != null)
                    {
                        prev.Next = curr.Next;
                    } else
                    {
                        Front = curr.Next;
                    }
                    if(curr.Next == null)
                    {
                        Rear = prev;
                    }
                    curr.Next = null;
                    Size--;
                    return curr;
                }
                prev = curr;
                curr = curr.Next;
                counter++;
            }
            Front = Front.Next;
            result.Next = null;
            Size--;
            return result;
        }

        public void Print()
        {
            Node curr = Front;
            
            int counter = 0;
            while(counter < Size)
            {
                Console.WriteLine("Shelter has a " + ((Animal)curr.Value).Name);
            curr = curr.Next;
            counter++;
            }
        }
    }
}
