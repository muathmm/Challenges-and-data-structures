using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
    }
}
