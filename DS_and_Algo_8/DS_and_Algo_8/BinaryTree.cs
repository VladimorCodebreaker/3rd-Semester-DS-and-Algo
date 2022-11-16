using System;

namespace DS_and_Algo_8
{
    public class BinaryTree
    {
        static Node? root;
        int count = 0;

        public BinaryTree()
        {
            root = null;
        }

        internal Node Add(Node root, int data)
        {
            var node = new Node(data);

            if (root == null)
            {
                root = node;
            }
            else if (data <= root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = new Node(data);
                }
                else
                {
                    Add(root.Left, data);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = new Node(data);
                }
                else
                {
                    Add(root.Right, data);
                }
            }

            count++;
            return node;
        }

        internal Node AddIteratively(Node root, int data)
        {
            var node = new Node(data);

            while (root != null)
            {
                if (data <= root.Data)
                {
                    if (root.Left == null)
                    {
                        root.Left = new Node(data);
                        break;
                    }
                    else
                    {
                        root = root.Left;
                        break;
                    }
                }
                else
                {
                    if (root.Right == null)
                    {
                        root.Right = new Node(data);
                    }
                    else
                    {
                        root = root.Right;
                    }
                }
            }

            return node;
        }

        internal void Print(Node root)
        {
            if (root == null)
            {
                return;
            }
            Print(root.Left);
            Console.WriteLine(root.Data + " ");
            Print(root.Right);
        }

        internal int Find(Node root, int data)
        {
            if (root.Data == data)
            {
                return data;
            }
            else if (data <= root.Data)
            {
                var element = Find(root.Left, data);
                if (element != 0) { return element; }
            }
            else
            {
                var element = Find(root.Right, data);
                if (element != 0) { return element; }
            }

            return 0;
        }

        internal int Count(Node root)
        {
            return count;
        }
    }
}

