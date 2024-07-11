using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class linkedList
    {
        Node Head;

        public linkedList(Node head)
        {
            Head = head;
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
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                result = result  + current.data + "->";
                current = current.next; 
            }
            Console.WriteLine(current.data);
            result = result  + current.data;

            return result;

        }

    }
}
