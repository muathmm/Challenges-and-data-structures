using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stackd
    {
        public Node top { get; set; }
        //public Stack() {
        //    top = null;
        //}

        public int  push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next=top;
            top= newNode;
            return data;
        }

        public int pop()
        {
            
                if (isEmpty()) throw new Exception("the Stack is Empty");
                int rData = top.data;
            top = top.Next;
            return rData;
        }

        public int peek()
        {   if(isEmpty()) throw new Exception("the Stack is Empty");

            return top.data;

        }

        public bool isEmpty()
        {
            return top == null; 
        }
    }
}
