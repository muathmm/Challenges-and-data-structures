using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(int rootValue)
        {
            Root = new Node(rootValue);
        }

        public void Insert(int value)
        {
            Insert(Root, value);
        }

        private void Insert(Node node, int value)
        {
            if (value < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
        }

        // Method to Mirror the Binary Tree
        public void MirrorTree()
        {
            Mirror(Root);
        }

        // Helper method for MirrorTree using recursion
        private void Mirror(Node node)
        {
            if (node == null) return;

            // Swap the left and right nodes
            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            // Recurse for left and right subtrees
            Mirror(node.Left);
            Mirror(node.Right);
        }

        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Data + " ");
                InOrder(node.Right);
            }
        }

        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Data + " ");
            }
        }



        public void Print()
        {
            Print(Root, 0);
        }

        private void Print(Node node, int level)
        {
            if (node == null) return;

            Print(node.Right, level + 1);

            Console.WriteLine(new string(' ', level * 4) + node.Data);

            Print(node.Left, level + 1);
        }
        public int? FindSecondMax()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            Node current = Root;
            Node parent = null;

            // Traverse to the maximum node (rightmost node)
            while (current.Right != null)
            {
                parent = current;
                current = current.Right;
            }

            // Case 1: If the maximum node has a left subtree, the second max is the largest value in that subtree
            if (current.Left != null)
            {
                return FindMax(current.Left);
            }

            // Case 2: If there is no left subtree, the second max is its parent
            if (parent != null)
            {
                return parent.Data;
            }

            // Case 3: Only one node in the tree
            throw new InvalidOperationException("Tree does not contain a second maximum value.");
        }

        // Helper method to find the maximum value in a subtree
        private int FindMax(Node node)
        {
            Node current = node;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Data;
        }
        // Method to sum the leaf nodes
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        // Helper method to sum the leaf nodes recursively
        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return node.Data;
            }

            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }

        // Method to find the largest value at each level
        public List<int> LargestLevelValue()
        {
            List<int> result = new List<int>();
            if (Root == null) return result;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxLevelValue = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    maxLevelValue = Math.Max(maxLevelValue, currentNode.Data);

                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                result.Add(maxLevelValue);
            }

            return result;
        }

        public void PrintRightView(Node node)
        {
            if (node == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // Print the rightmost element at the current level
                    if (i == levelSize - 1)
                    {
                        Console.Write(currentNode.Data + " ");
                    }

                    // Add left and right children to the queue
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

            }
        }

        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                return -1; // Return -1 for empty tree
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            int level = 0;
            int maxNodes = 0;
            int maxLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = level;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                level++;
            }

            return maxLevel;
        }
    }
}
 