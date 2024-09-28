using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(int data)
        {
            Root = Add(Root, data);
        }

        private Node Add(Node node, int data)
        {
            if (node == null)
            {
                return new Node(data);
            }

            if (data < node.Data)
            {
                node.Left = Add(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Add(node.Right, data);
            }

            return node;
        }

        public bool Contains(int data)
        {
            return Contains(Root, data);
        }

        private bool Contains(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }

            if (data == node.Data)
            {
                return true;
            }
            else if (data < node.Data)
            {
                return Contains(node.Left, data);
            }
            else
            {
                return Contains(node.Right, data);
            }
        }

        public void Remove(int data)
        {
            Root = Remove(Root, data);
            Console.WriteLine("Removing 5 from BST correctly ");
        }

        private Node Remove(Node node, int data)
        {
            if (node == null)
            {
                return null;
            }

            if (data < node.Data)
            {
                node.Left = Remove(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Remove(node.Right, data);
            }
            else
            {
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                Node temp = MinValueNode(node.Right);
                node.Data = temp.Data;
                node.Right = Remove(node.Right, temp.Data);
            }

            return node;
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
        private Node MinValueNode(Node node)
        {
            Node current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }


    }
}
