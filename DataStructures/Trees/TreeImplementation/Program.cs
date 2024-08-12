namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        { // Testing BinaryTree
            BinaryTree binaryTree = new BinaryTree(10);

            binaryTree.Insert(5);
            binaryTree.Insert(18);
            binaryTree.Insert(3);
            binaryTree.Insert(7);
            binaryTree.Insert(15);

            Console.WriteLine("PreOrder Traversal:");//10 5 3 18 15
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine();
            
            Console.WriteLine("InOrder Traversal:");//3 5 7 10 15 18
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Tree Structure:");
            binaryTree.Print();
           Console.WriteLine();

            //// Testing BinarySearchTree
            Console.WriteLine("Binary Search Tree Test:");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            Console.WriteLine("Tree Structure:");
            bst.Print(); // You might need to implement Print method for BinarySearchTree as well for consistent output
            Console.WriteLine();

            Console.WriteLine("Checking if 7 exists in BST:");
            bool contains = bst.Contains(7);
            Console.WriteLine($"Contains 7: {contains}");

            Console.WriteLine("Removing 5 from BST:");
            bst.Remove(5);

            Console.WriteLine("Checking if 5 exists in BST:");
            contains = bst.Contains(5);
            Console.WriteLine($"Contains 5: {contains}");
        }
    }
}
