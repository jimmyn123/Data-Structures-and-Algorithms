using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Class
{
    public class Node
    {
        public Node Next { get; set; } = null;
        public object Value { get; set; }

        public Node(object newValue)
        {
            Value = newValue;
        }
    }
}
