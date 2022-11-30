using System;

namespace DS_and_Algo_9
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        private int _data;

        public int Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public Node Left, Right;
    }
}
