using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node
    {
        // left and right properties & values
        public object Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        /// <summary>
        /// constructor method
        /// </summary>
        /// <param name="value">the input object</param>
        public Node(object value)
        {
            Value = value;
        }

    }
}
