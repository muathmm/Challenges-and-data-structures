using System.Collections.Generic;
using System.Xml.Linq;
using LinkedList;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void printListTest()
        {
            Node nodeHead = new Node(10, null);
            linkedList linked = new linkedList(nodeHead);
            Node node2 = new Node(20, null);
            nodeHead.next = node2;
            Node node3 = new Node(30, null);
            node2.next = node3;
            Node node4 = new Node(40, null);
            node3.next = node4;

            String resultTest= linked.PrintList();

            Assert.Equal("10->20->30->40", resultTest);
         

            


        }
        [Fact]
        public void RemoveTest()
        {
            Node nodeHead = new Node(10, null);
            linkedList linked = new linkedList(nodeHead);
            Node node2 = new Node(20, null);
            nodeHead.next = node2;
            Node node3 = new Node(30, null);
            node2.next = node3;
            Node node4 = new Node(40, null);
            node3.next = node4;

            bool resultTest = linked.RemoveNode(40);

            Assert.True( resultTest);





        }


        [Fact]
        public void RemoveDublicateTest()
        {
            Node nodeHead = new Node(10, null);
            linkedList linked = new linkedList(nodeHead);
            Node node2 = new Node(20, null);
            nodeHead.next = node2;
            Node node3 = new Node(20, null);
            node2.next = node3;
            Node node4 = new Node(30, null);
            node3.next = node4;
            Node node5 = new Node(30, null);
            node4.next = node5;

            string resultTest = linked.RemoveDuplicate();

            Assert.Equal("10->20", resultTest);





        }
    }
}