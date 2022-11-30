namespace DS_and_Algo_9.Graphs;

class Program
{
    static void Main(string[] args)
    {
        //BinaryTree binaryTree = new BinaryTree();

        //Node root = new Node(10);

        ////binaryTree.AddIteratively(root, 107);
        ////binaryTree.AddIteratively(root, 4);
        ////binaryTree.AddIteratively(root, 17);
        ////binaryTree.AddIteratively(root, 90);
        ////binaryTree.AddIteratively(root, 40);
        ////binaryTree.AddIteratively(root, 1);

        //binaryTree.Add(root, 107);
        //binaryTree.Add(root, 4);
        //binaryTree.Add(root, 17);
        //binaryTree.Add(root, 90);
        //binaryTree.Add(root, 40);
        //binaryTree.Add(root, 1);

        ////binaryTree.PrintAscending(root);
        //binaryTree.PrintDescending(root);

        Graph.Init();

        //var pathFoundRecursively = Graph.FindPath("Burgas", "Viena", new List<string>());

        //foreach (var element in pathFoundRecursively)
        //{
        //    Console.WriteLine(element);
        //}

        var pathFoundBFS = Graph.BFS("Burgas", "Viena", new List<string>());

        for (int i = pathFoundBFS.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(pathFoundBFS[i]);
        }
    }
}
