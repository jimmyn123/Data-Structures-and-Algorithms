using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public object Value { get; set; }

        public Node Next { get; set; }

        public Node(string key, object input)
        {
            Key = key;
            Value = input;
        }
    }
}
