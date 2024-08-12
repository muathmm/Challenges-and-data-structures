using TreeImplementation;

namespace TreeImplementationtest
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrderTest()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new Node(1)
            {
                Left = new Node(2)
                {
                    Left = new Node(4),
                    Right = new Node(5)
                },
                Right = new Node(3)
            };

            // Act
            var output = new StringWriter();
            Console.SetOut(output);
            tree.PreOrder(tree.Root);

            // Assert
            Assert.Equal("1 2 4 5 3 ", output.ToString());
        }

        [Fact]
        public void InOrderTest()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new Node(1)
            {
                Left = new Node(2)
                {
                    Left = new Node(4),
                    Right = new Node(5)
                },
                Right = new Node(3)
            };

            // Act
            var output = new StringWriter();
            Console.SetOut(output);
            tree.InOrder(tree.Root);

            // Assert
            Assert.Equal("4 2 5 1 3 ", output.ToString());
        }

        [Fact]
        public void PostOrderTest()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new Node(1)
            {
                Left = new Node(2)
                {
                    Left = new Node(4),
                    Right = new Node(5)
                },
                Right = new Node(3)
            };

            // Act
            var output = new StringWriter();
            Console.SetOut(output);
            tree.PostOrder(tree.Root);

            // Assert
            Assert.Equal("4 5 2 3 1 ", output.ToString());
        }
        [Fact]
        public void AddTest()
        {
            // Arrange
            var bst = new BinarySearchTree();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Assert
            Assert.True(bst.Contains(7));
            Assert.False(bst.Contains(20));
        }

        [Fact]
        public void RemoveTest()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Act
            bst.Remove(5);

            // Assert
            Assert.False(bst.Contains(5));
        }
        [Fact]
        public void Contains_NodeExists_ReturnsTrue()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Act
            bool contains = bst.Contains(7);

            // Assert
            Assert.True(contains, "The tree should contain the node with data 7.");
        }

        [Fact]
        public void Contains_NodeDoesNotExist_ReturnsFalse()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act
            bool contains = bst.Contains(8);

            // Assert
            Assert.False(contains, "The tree should not contain the node with data 8.");
        }

    }
}