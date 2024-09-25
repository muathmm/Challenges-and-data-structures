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
            Node nodeHead = new Node(10);
            linkedList linked = new linkedList(nodeHead);
            Node node2 = new Node(20);
            nodeHead.next = node2;
            Node node3 = new Node(30);
            node2.next = node3;
            Node node4 = new Node(40);
            node3.next = node4;

            String resultTest= linked.PrintList();

            Assert.Equal("10->20->30->40->null", resultTest);
         

            


        }
        [Fact]
        public void RemoveTest()
        {
            Node nodeHead = new Node(10);
            linkedList linked = new linkedList(nodeHead);
            Node node2 = new Node(20);
            nodeHead.next = node2;
            Node node3 = new Node(30);
            node2.next = node3;
            Node node4 = new Node(40);
            node3.next = node4;

            bool resultTest = linked.RemoveNode(40);

            Assert.True( resultTest);





        }


        [Fact]
        public void RemoveDublicateTest()
        {
            Node nodeHead = new Node(10);
            linkedList linked = new linkedList(nodeHead);
            Node node2 = new Node(20);
            nodeHead.next = node2;
            Node node3 = new Node(20);
            node2.next = node3;
            Node node4 = new Node(30);
            node3.next = node4;
            Node node5 = new Node(30);
            node4.next = node5;

            string resultTest = linked.RemoveDuplicate();

            Assert.Equal("10->20->30->null", resultTest);





        }

        [Fact]
        public void Rotate_By_Zero_Should_Not_Change_List()
        {
            // Arrange
            linkedList list = new linkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("1->2->3->4->5->null", list.PrintList());
        }

        [Fact]
        public void Rotate_By_K_Greater_Than_List_Length()
        {
            // Arrange
            linkedList list = new linkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);

            // Act
            list.RotateLeft(7);  // Equivalent to rotating by 2 places

            // Assert
            Assert.Equal("3->4->5->1->2->null", list.PrintList());
        }

        [Fact]
        public void Rotate_By_K_Within_List_Length()
        {
            // Arrange
            linkedList list = new linkedList();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(50);

            // Act
            list.RotateLeft(3);

            // Assert
            Assert.Equal("40->50->10->20->30->null", list.PrintList());
        }
    }
}