using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node() { }

        public Node(int data, Node node)
        {
            this.data = data;
            this.next = node;
        }
    }
}
