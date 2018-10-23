namespace QueueWithStack.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor, makes a new node
        /// </summary>
        /// <param name="value">Value of new node</param>
        public Node(object value)
        {
            Value = value;
        }

    }
}
