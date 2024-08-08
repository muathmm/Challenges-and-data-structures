using System;

namespace StackAndQueue.Min_Stack
{
    public class MinStack
    {
        private Node top;
        private Node minTop;

        public MinStack()
        {
            top = null;
            minTop = null;
        }

        public int Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;

            if (minTop == null || data <= minTop.data)
            {
                Node newMinNode = new Node(data);
                newMinNode.Next = minTop;
                minTop = newMinNode;
            }

            return data;
        }

        public int Pop()
        {
            if (IsEmpty()) throw new Exception("The Stack is empty");

            int poppedData = top.data;
            top = top.Next;

            if (poppedData == minTop.data)
            {
                minTop = minTop.Next;
            }

            return poppedData;
        }

        public int Peek()
        {
            if (IsEmpty()) throw new Exception("The Stack is empty");

            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int GetMin()
        {
            if (minTop == null) throw new Exception("The Stack is empty");
            return minTop.data;
        }

        public void PrintStack()
        {
            Node current = top;
            Console.Write("Top -> ");
            while (current != null)
            {
                Console.Write(current.data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public class Node
        {
            public int data;
            public Node Next;

            public Node(int data)
            {
                this.data = data;
                this.Next = null;
            }
        }
    }
}
