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
        /// <param name="newNode">The node to be added</param>
        public void Enqueue(Node newNode)
        {
            // if empty list, set front to the new node
            if(Front == null)
            {
                Front = newNode;
            }
            else
            {
                // otherwise set the new rear
                Rear.Next = newNode;
            }
            Rear = newNode;
            Size++;
        }

        /// <summary>
        /// Dequeues a node from the animal shelter
        /// </summary>
        /// <param name="pref">The type of animal to dequeue</param>
        /// <returns>Returns the node of the first animal that matches the type</returns>
        public Node Dequeue(string pref)
        {
            // set current node to front
            Node curr = Front;
            Node prev = null;

            int counter = 0;
            // while the counter is less than the size
            while (counter < Size)
            {
                // if the animal is the same as the pref
                if (((Animal)curr.Value).Name.Equals(pref.ToLower()))
                {
                    // check to see if there is a previous node
                    if (prev != null)
                    {
                        // set the previous node's next node to the next node
                        prev.Next = curr.Next;
                    } else
                    {
                        // if not then front has to be reset
                        Front = curr.Next;
                    }

                    // check to see if the current has a next
                    if(curr.Next == null)
                    {
                        // if not, then set the rear
                        Rear = prev;
                    }

                    // reset the next to null
                    curr.Next = null;
                    Size--;

                    // return the node
                    return curr;
                }

                // increment to the next nodes and counter
                prev = curr;
                curr = curr.Next;
                counter++;
            }

            // resets to the first node to return
            curr = Front;
            Front = Front.Next;
            curr.Next = null;
            Size--;
            return curr;
        }

        /// <summary>
        /// Prints out all nodes in the shelter
        /// </summary>
        public void Print()
        {
            // set current node
            Node curr = Front;
            
            int counter = 0;

            // loop through and print
            while(counter < Size)
            {
                Console.WriteLine("Shelter has a " + ((Animal)curr.Value).Name);
                curr = curr.Next;
                counter++;
            }
        }
    }
}
