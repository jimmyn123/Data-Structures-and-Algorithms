using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Vertex
    {
        public object value { get; set; }

        // the vertex class, equivalent to a "Node"
        public Vertex(object input)
        {
            value = input;
        }
    }
}
