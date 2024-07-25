using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queued
    {
        public Node Front  { get; set; }
        public Node Back { get; set; }

        //public Queue() {
        //    Front = null;
        //    Back = null;  

        //}

        public int enqueue(int data)
        {
            Node newNode = new Node(data);
            if(isEmpty())
                Front =Back = newNode;
            else
            {
                Back.Next = newNode;
                Back=newNode;

            }
            return data;

        }

        public int dequeue() {
            if (isEmpty())
                throw new Exception("the queue is empty");

            int rData = Front.data;
            Front=Front.Next;
            return rData;
        }

        public int peek() { 
            if(isEmpty())
                throw new Exception("the queue is empty");
            
            return Front.data; }
     
        public bool isEmpty()
        {
            return Front==null;    
        }

    }
}
