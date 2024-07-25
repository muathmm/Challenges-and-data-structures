using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
        public Node(int Data) {
            data = Data;
            Next = null;
        }
    }
}
