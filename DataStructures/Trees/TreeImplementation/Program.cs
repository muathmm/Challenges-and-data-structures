namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        { // Testing BinaryTree
          //  BinaryTree binaryTree = new BinaryTree(10);

            //  binaryTree.Insert(5);
            //  binaryTree.Insert(18);
            //  binaryTree.Insert(3);
            //  binaryTree.Insert(7);
            //  binaryTree.Insert(15);

            ////  Testing LargestValueEachLevel
            //  Console.WriteLine("Largest Value at Each Level:");
            //  List<int> largestValues = binaryTree.LargestLevelValue();
            //    Console.WriteLine(string.Join(", ", largestValues));  // Outputs: 10, 18, 15

            // Console.WriteLine("PreOrder Traversal:");//10 5 3 18 15
            // binaryTree.PreOrder(binaryTree.Root);
            // Console.WriteLine();

            // Console.WriteLine("InOrder Traversal:");//3 5 7 10 15 18
            // binaryTree.InOrder(binaryTree.Root);
            // Console.WriteLine();

            // Console.WriteLine("PostOrder Traversal:");
            // binaryTree.PostOrder(binaryTree.Root);
            // Console.WriteLine();

            // Console.WriteLine("Tree Structure:");
            // binaryTree.Print();
            //Console.WriteLine();

            // //// Testing BinarySearchTree
            // Console.WriteLine("Binary Search Tree Test:");
            // BinarySearchTree bst = new BinarySearchTree();
            // bst.Add(10);
            // bst.Add(5);
            // bst.Add(15);
            // bst.Add(7);

            // Console.WriteLine("Tree Structure:");
            // bst.Print(); // You might need to implement Print method for BinarySearchTree as well for consistent output
            // Console.WriteLine();

            // Console.WriteLine("Checking if 7 exists in BST:");
            // bool contains = bst.Contains(7);
            // Console.WriteLine($"Contains 7: {contains}");

            // Console.WriteLine("Removing 5 from BST:");
            // bst.Remove(5);

            // Console.WriteLine("Checking if 5 exists in BST:");
            // contains = bst.Contains(5);
            // Console.WriteLine($"Contains 5: {contains}");

            // // Miror tree
            // BinaryTree Btree = new BinaryTree();
            // Btree.Root = new Node(4);
            // Btree.Insert(8);
            // Btree.Insert(7);
            // Btree.Insert(12);
            // Btree.Insert(9);
            // Console.WriteLine("////////////////////////////Miror tree/////////////////////////////////");
            // Console.WriteLine("Original InOrder Traversal:");
            // Btree.InOrder(Btree.Root);  // Output: 12 8 9 4 7

            // // Mirroring the tree
            // Btree.MirrorTree();

            // Console.WriteLine("\nMirrored InOrder Traversal:\n");
            // Btree.InOrder(Btree.Root);  // Output: 7 4 9 8 12

            // Console.WriteLine("////////////////////////////second maximum value /////////////////////////////////");
            // BinaryTree btree = new BinaryTree();
            // btree.Root = new Node(5);
            // btree.Insert(18);
            // btree.Insert(3);
            // btree.Insert(7);
            // btree.Insert(15);
            // btree.Insert(20);
            // btree.InOrder(btree.Root);

            // int? secondMax = btree.FindSecondMax(); // Output: 20
            // Console.WriteLine($"Second Maximum Value: {secondMax}");
            // Console.WriteLine("////////////////////////////Sum of Leaf Nodes /////////////////////////////////");

            // Console.WriteLine("Tree Structure:");
            // btree.Print();
            // Console.WriteLine();
            // Console.WriteLine("Sum of Leaf Nodes:");
            // int leafSum = btree.SumOfLeafNodes();  // Should output: 38 (3 + 7 + 15+20)
            // Console.WriteLine($"Sum of leaf nodes: {leafSum}");
            BinaryTree Btree = new BinaryTree(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);
            Btree.Print();

            Btree.PrintRightView(Btree.Root);  // Output: 2 5 6 7

        }
    }
}
