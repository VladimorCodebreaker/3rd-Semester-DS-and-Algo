namespace DS_and_Algo_8;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree binaryTree = new BinaryTree();

        Node root = new Node(10);

        //binaryTree.AddIteratively(root, 107);
        //binaryTree.AddIteratively(root, 4);
        //binaryTree.AddIteratively(root, 17);
        //binaryTree.AddIteratively(root, 90);
        //binaryTree.AddIteratively(root, 40);
        //binaryTree.AddIteratively(root, 1);

        //binaryTree.Print(root);

        binaryTree.Add(root, 107);
        binaryTree.Add(root, 4);
        binaryTree.Add(root, 17);
        binaryTree.Add(root, 90);
        binaryTree.Add(root, 40);
        binaryTree.Add(root, 1);

        binaryTree.Print(root);

        Console.WriteLine("\nCount: " + binaryTree.Count(root) + "\n");

        Console.WriteLine(binaryTree.Find(root, 40));
    }
}
