using System;

namespace Assignment_2
{
    public class Node
    {
        public Node(Vertex vertex, int priority)
        {
            this.Vertex = vertex;
            this.Priority = priority;
        }

        private Vertex _vertex { get; set; }
        private int _priority { get; set; }

        public int Priority
        {
            get => _priority;
            set => _priority = (value != -1 ? value : throw new ArgumentNullException());
        }

        public Vertex Vertex
        {
            get => _vertex;
            set => _vertex = (value ?? throw new ArgumentNullException());
        }
    }
}
