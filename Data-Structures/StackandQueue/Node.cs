﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }

    }
}
