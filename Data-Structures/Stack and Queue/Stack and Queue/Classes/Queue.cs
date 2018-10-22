namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Creates a new Queue with the node
        /// </summary>
        /// <param name="node">the new node value</param>
        public Queue(Node node)
        {
            // sets front and rear to the node that was passed in
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// The peek, shows what node will be de-queue
        /// </summary>
        /// <returns>returns the front node</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds a new node to the end of the line
        /// </summary>
        /// <param name="node">The node to put placed at the rear</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// The node that gets removed from the front of the queue
        /// </summary>
        /// <returns>The node that was de-queued</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
