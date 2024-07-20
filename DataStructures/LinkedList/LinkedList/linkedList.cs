using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class linkedList
    {
         public Node Head;

        public linkedList()
        {
            Head = null;
        }
        public linkedList(Node head)
        {
            Head = head;
        }
        public void AddNode(int data)
        {
            Node newNodew = new Node(data);
            {
                Node pointer = Head;
                if (Head == null)
                {
                    Head = newNodew;

                }

                else
                {
                    while (pointer.next != null)
                    {
                        pointer = pointer.next;
                    }
                    pointer.next = newNodew;

                }
            }
        }

        public void AddFirst(Node node)
        {
            if (Head == null)
            {
                Head = node;

            }
            else
            {  
                node.next = Head;
                Head= node;
            }
        }

        public bool Includes(int data)
        {
            Node current = Head;
            if (Head == null)
            {
                return false;
            }
            while (current.next != null)
            {
                if (current.data == data)
                {
                    Console.WriteLine($"the data :{data} exists in the linked list");
                    return true;
                }
                current = current.next;

            }
            if (current.data == data)
            {
                Console.WriteLine($"the data :{data} exists in the linked list");
                return true;
            }

            Console.WriteLine($"the data :{data} does not exists in the linked list");
            return false;
        }

        public bool RemoveNode(int data)
        {
            Node current = Head;
            Node prev = null;
            if (current == null)
            {
                return false;
            }

            while (current.next != null)
            {
                if (Head.data == data)
                {
                    Head = Head.next;
                 
                    Console.WriteLine($"the data :{data} deleted");
                    return true;
                }
                if (current.data == data)
                {
                    prev.next = current.next;
                    Console.WriteLine($"the data :{data} deleted");
                    return true;

                    
                }
                prev = current;
                current = current.next;


            }
            if (current.data == data)
            {
                prev.next = current.next;
                Console.WriteLine($"the data :{data} deleted");
                return true;


            }
            Console.WriteLine($"the data :{data} does not found in the linkedList");
            return false;
        }

        public  String PrintList()
        {
            String result="";
           
            Node current = Head;
            while (current != null)
            {
               
                result = result  + current.data + "->";
                current = current.next; 
            }
           
         

            return result +"null";

        }
        public String RemoveDuplicate() {
            if (Head == null) return "";

            Node current=Head;
            while (current != null)
            {
                Node index = current;
                while (index.next != null)
                {
                    if (current.data == index.next.data)
                    {
                        index.next = index.next.next;
                    }
                    else
                    {
                        index = index.next;
                    }
                }
                current = current.next;
            }
            return  PrintList();


        }

        public static linkedList MergeSortedLists(linkedList n1, linkedList n2)
        {
            Node current1 = n1?.Head;
            Node current2 = n2?.Head;

            linkedList mergeNode = new linkedList();
            Node mergeLastNode = null;

            while (current1 != null && current2 != null)
            {
                Node newNode;
                if (current1.data < current2.data)
                {
                    newNode = new Node { data = current1.data };
                    current1 = current1.next;
                }
                else
                {
                    newNode = new Node { data = current2.data };
                    current2 = current2.next;
                }

                if (mergeNode.Head == null)
                {
                    mergeNode.Head = newNode;
                    mergeLastNode = newNode;
                }
                else
                {
                    mergeLastNode.next = newNode;
                    mergeLastNode = newNode;
                }
            }

            while (current1 != null)
            {
                Node newNode = new Node { data = current1.data };
                if (mergeNode.Head == null)
                {
                    mergeNode.Head = newNode;
                    mergeLastNode = newNode;
                }
                else
                {
                    mergeLastNode.next = newNode;
                    mergeLastNode = newNode;
                }
                current1 = current1.next;
            }

            while (current2 != null)
            {
                Node newNode = new Node { data = current2.data };
                if (mergeNode.Head == null)
                {
                    mergeNode.Head = newNode;
                    mergeLastNode = newNode;
                }
                else
                {
                    mergeLastNode.next = newNode;
                    mergeLastNode = newNode;
                }
                current2 = current2.next;
            }

            return mergeNode;
        }


    }
}
