using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTests
{
    public class MergeSortedLinkedLists
    {

        [Fact]
        public void Test_Merge_When_One_List_Is_Empty()
        {
            // Arrange
            linkedList list1 = new linkedList();
            linkedList list2 = new linkedList();
            list2.AddNode(1);
            list2.AddNode(3);
            list2.AddNode(5);

            // Act
            linkedList result = linkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.NotNull(result.Head);
            Assert.Equal(1, result.Head.data);
            Assert.Equal(3, result.Head.next.data);
            Assert.Equal(5, result.Head.next.next.data);
            Assert.Null(result.Head.next.next.next);
        }

        [Fact]
        public void Test_Merge_When_Both_Lists_Are_Empty()
        {
            // Arrange
            linkedList list1 = new linkedList();
            linkedList list2 = new linkedList();

            // Act
            linkedList result = linkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Null(result.Head);
        }

        [Fact]
        public void Test_Merge_List1_And_List2_From_Example()
        {
            // Arrange
            linkedList list1 = new linkedList();
            list1.AddNode(2);
            list1.AddNode(5);
            list1.AddNode(10);

            linkedList list2 = new linkedList();
            list2.AddNode(3);
            list2.AddNode(15);
            list2.AddNode(20);

            // Act
            linkedList result = linkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.NotNull(result.Head);
            Assert.Equal(2, result.Head.data);
            Assert.Equal(3, result.Head.next.data);
            Assert.Equal(5, result.Head.next.next.data);
            Assert.Equal(10, result.Head.next.next.next.data);
            Assert.Equal(15, result.Head.next.next.next.next.data);
            Assert.Equal(20, result.Head.next.next.next.next.next.data);
            Assert.Null(result.Head.next.next.next.next.next.next);
        }
    }
}
