using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Class
{

    public class AnimalShelter
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public void Enqueue(Node newNode)
        {
            newNode.Next = Rear;
            Rear = newNode;
        }

        public Node Dequeue(string pref)
        {
            Node curr = Front;

            while (curr != null)
            {
                if (((Animal)curr.Value).Name.Equals(pref))
                {
                    return curr;
                }
                curr = curr.Next;
            }
            return Front;
        }
    }
}
