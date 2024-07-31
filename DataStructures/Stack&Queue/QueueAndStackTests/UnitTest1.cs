using StackAndQueue;
using StackAndQueue.ReverseStackUsingQueue;
using System.Collections;

namespace QueueAndStackTests
{
    public class UnitTest1
    {
        [Fact]
        public void Push_Node_Onto_Stack()
        {
            // Arrange
            Stackd stack = new Stackd();

            // Act
            int pushedValue = stack.push(10);

            // Assert
            Assert.Equal(10, pushedValue);
            Assert.False(stack.isEmpty());
            Assert.Equal(10, stack.peek());
        }

        [Fact]
        public void Pop_Node_From_Stack()
        {
            // Arrange
            Stackd stack = new Stackd();
            stack.push(10);
            stack.push(20);

            // Act
            int poppedValue = stack.pop();

            // Assert
            Assert.Equal(20, poppedValue);
            Assert.False(stack.isEmpty());
            Assert.Equal(10, stack.peek());
        }

        [Fact]
        public void Peek_Node_From_Stack()
        {
            // Arrange
            Stackd stack = new Stackd();
            stack.push(10);

            // Act
            int peekedValue = stack.peek();

            // Assert
            Assert.Equal(10, peekedValue);
        }

        [Fact]
        public void Check_If_Stack_Is_Empty()
        {
            // Arrange
            Stackd stack = new Stackd();

            // Act
            bool isEmpty = stack.isEmpty();

            // Assert
            Assert.True(isEmpty);

            // Push a node and check again
            stack.push(10);
            isEmpty = stack.isEmpty();

            Assert.False(isEmpty);
        }

        [Fact]
        public void Pop_Throws_Exception_When_Stack_Is_Empty()
        {
            // Arrange
            Stackd stack = new Stackd();

            // Act & Assert
            Exception ex = Assert.Throws<Exception>(() => stack.pop());
            Assert.Equal("the Stack is Empty", ex.Message);
        }

        [Fact]
        public void Peek_Throws_Exception_When_Stack_Is_Empty()
        {
            // Arrange
            Stackd stack = new Stackd();

            // Act & Assert
            Exception ex = Assert.Throws<Exception>(() => stack.peek());
            Assert.Equal("the Stack is Empty", ex.Message);
        }
        [Fact]
        public void Enqueue_Node_Into_Queue()
        {
            // Arrange
            Queued queue = new Queued();

            // Act
            int enqueuedValue = queue.enqueue(10);

            // Assert
            Assert.Equal(10, enqueuedValue);
            Assert.False(queue.isEmpty());
            Assert.Equal(10, queue.peek());
        }

        [Fact]
        public void Dequeue_Node_From_Queue()
        {
            // Arrange
            Queued queue = new Queued();
            queue.enqueue(10);
            queue.enqueue(20);

            // Act
            int dequeuedValue = queue.dequeue();

            // Assert
            Assert.Equal(10, dequeuedValue);
            Assert.False(queue.isEmpty());
            Assert.Equal(20, queue.peek());
        }

        [Fact]
        public void Peek_Node_From_Queue()
        {
            // Arrange
            Queued queue = new Queued();
            queue.enqueue(10);

            // Act
            int peekedValue = queue.peek();

            // Assert
            Assert.Equal(10, peekedValue);
        }

        [Fact]
        public void Check_If_Queue_Is_Empty()
        {
            // Arrange
            Queued queue = new Queued();

            // Act
            bool isEmpty = queue.isEmpty();

            // Assert
            Assert.True(isEmpty);

            // Enqueue a node and check again
            queue.enqueue(10);
            isEmpty = queue.isEmpty();

            Assert.False(isEmpty);
        }

        [Fact]
        public void Dequeue_Throws_Exception_When_Queue_Is_Empty()
        {
            // Arrange
            Queued queue = new Queued();

            // Act & Assert
            Exception ex = Assert.Throws<Exception>(() => queue.dequeue());
            Assert.Equal("the queue is empty", ex.Message);
        }

        [Fact]
        public void Peek_Throws_Exception_When_Queue_Is_Empty()
        {
            // Arrange
            Queued queue = new Queued();

            // Act & Assert
            Exception ex = Assert.Throws<Exception>(() => queue.peek());
            Assert.Equal("the queue is empty", ex.Message);
        }
        [Fact]
        public void ReverseStack_MultipleElements_StackReversed()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.peek()); // 1 at the top
            Assert.Equal(1, stack.pop()); //  1
            Assert.Equal(2, stack.pop()); //  2
            Assert.Equal(3, stack.pop()); //  3
            Assert.Equal(4, stack.pop()); //  4
        }

        [Fact]
        public void ReverseStack_OneElement_StackUnchanged()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();
            stack.push(1);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.peek()); // 
            Assert.Equal(1, stack.pop()); // 1
        }

        [Fact]
        public void ReverseStack_EmptyStack_StackRemainsEmpty()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();

            // Act
            stack.ReverseStack();

            // Assert
            Assert.True(stack.isEmpty()); 
        }
    }
}