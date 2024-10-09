using System.Xml.Linq;
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

        [Fact]
        public void MirrorTree_InOrderCheck()
        {
            // Arrange - بناء الشجرة
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Insert(2);
            Btree.Insert(1);
            Btree.Insert(3);
            Btree.Insert(6);
            Btree.Insert(5);
            Btree.Insert(7);

 
            string originalInOrder;
            using (var consoleOutput = new System.IO.StringWriter())
            {
                Console.SetOut(consoleOutput);
                Btree.InOrder(Btree.Root);
                originalInOrder = consoleOutput.ToString();
            }

       
            Btree.MirrorTree();

          
            string mirroredInOrder;
            using (var consoleOutput = new System.IO.StringWriter())
            {
                Console.SetOut(consoleOutput);
                Btree.InOrder(Btree.Root);
                mirroredInOrder = consoleOutput.ToString();
            }

          
            Assert.Equal("1 2 3 4 5 6 7 ", originalInOrder);  // Original InOrder
            Assert.Equal("7 6 5 4 3 2 1 ", mirroredInOrder);   // Mirrored InOrder
        }


        [Fact]
        public void MirrorTree_SingleNodeTree()
        {
       
            BinaryTree Btree = new BinaryTree(10);

         
            var originalInOrder = CaptureConsoleOutput(() => Btree.InOrder(Btree.Root));

      
            Btree.MirrorTree();

            var mirroredInOrder = CaptureConsoleOutput(() => Btree.InOrder(Btree.Root));

         
            Assert.Equal("10 ", originalInOrder);  // Original InOrder for single node
            Assert.Equal("10 ", mirroredInOrder);  // Mirrored InOrder for single node
        }


        [Fact]
        public void MirrorTree_EmptyTree()
        {
      
            BinaryTree Btree = new BinaryTree();

            var originalInOrder = CaptureConsoleOutput(() => Btree.InOrder(Btree.Root));

     
            Btree.MirrorTree();

            var mirroredInOrder = CaptureConsoleOutput(() => Btree.InOrder(Btree.Root));

            Assert.Equal("", originalInOrder);  // Original InOrder for empty tree
            Assert.Equal("", mirroredInOrder);  // Mirrored InOrder for empty tree
        }

        // Helper function to capture console output
        private string CaptureConsoleOutput(Action action)
        {
            using (var consoleOutput = new System.IO.StringWriter())
            {
                Console.SetOut(consoleOutput);
                action();
                return consoleOutput.ToString();
            }
        }
        [Fact]
        public void FindSecondMax_WithValidTree_ReturnsSecondMaxValue()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(4);
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(20);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(25);

            // Act
            int? result = tree.FindSecondMax();

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FindSecondMax_WithSingleNode_ThrowsInvalidOperationException()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => tree.FindSecondMax());
        }

      

        [Fact]
        public void FindSecondMax_WithNegativeValues_ReturnsSecondMaxValue()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(-15);
            tree.Insert(-10);
            tree.Insert(-20);
            tree.Insert(-5);
            tree.Insert(-15);
            tree.Insert(-25);

            // Act
            int? result = tree.FindSecondMax();

            // Assert
            Assert.Equal(-10, result); // The maximum is -5, and the second maximum is -10
        }

        [Fact]
        public void FindSecondMax_WithEmptyTree_ThrowsInvalidOperationException()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => tree.FindSecondMax());
        }

        [Fact]
        public void TestSumOfLeafNodes_PositiveValues()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(5);
            tree.Insert(18);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(20);
            // Act  


            int leafSum = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(38, leafSum); 
        }

        [Fact]
        public void TestSumOfLeafNodes_NegativeValues()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(-4);
            tree.Insert(-10);
            tree.Insert(-5);
            tree.Insert(-20);
            tree.Insert(-3);
            tree.Insert(-7);
            tree.Insert(-15);
            tree.Insert(-25);
            // Act
            int leafSum = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(-50, leafSum); // -3 + -7 + -17 + -23 = -50
        }

        [Fact]
        public void TestSumOfLeafNodes_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(0, leafSum);
        }


        [Fact]
        public void LargestLevelValue_ShouldReturnCorrectLargestValues_ForGivenTree()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree(5);
            
            binaryTree.Insert(18);
            binaryTree.Insert(3);
            binaryTree.Insert(7);
            binaryTree.Insert(20);

            // Expected largest values for each level:
            // Level 0: 5
            // Level 1: 18
            // Level 2: 20
            List<int> expected = new List<int> { 5, 18, 20 };

            // Act
            List<int> actual = binaryTree.LargestLevelValue();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LargestLevelValue_ShouldReturnEmptyList_ForEmptyTree()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            // Act
            List<int> actual = binaryTree.LargestLevelValue();

            // Assert
            Assert.Empty(actual);
        }

        [Fact]
        public void Test_PrintRightView_WithGeneralTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Act & Assert
            var output = new System.IO.StringWriter();
            Console.SetOut(output);
            Btree.PrintRightView(Btree.Root);

            Assert.Equal("2 5 6 7 ", output.ToString());
        }

        [Fact]
        public void Test_PrintRightView_WithRightOnlyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Right = new Node(2);
            Btree.Root.Right.Right = new Node(3);
            Btree.Root.Right.Right.Right = new Node(4);

            // Act & Assert
            var output = new System.IO.StringWriter();
            Console.SetOut(output);
            Btree.PrintRightView(Btree.Root);

            Assert.Equal("1 2 3 4 ", output.ToString());
        }

        [Fact]
        public void Test_PrintRightView_WithEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act & Assert
            var output = new System.IO.StringWriter();
            Console.SetOut(output);
            Btree.PrintRightView(Btree.Root);

            Assert.Equal("The tree is empty.\r\n", output.ToString());
        }
        [Fact]
        public void Test_FindMaxLevelNodes_BasicTree()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            int result = Btree.FindMaxLevelNodes();
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_FindMaxLevelNodes_MultipleLevelsWithSameMaxNodes()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(7);
            Btree.Root.Left.Left.Left = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);
            Btree.Root.Right.Right.Left = new Node(10);

            int result = Btree.FindMaxLevelNodes();
            Assert.Equal(2, result);
        }


        [Fact]
        public void Test_EmptyTree_ReturnsZero()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root = null;
            var root = Btree.Root;


            int result = Btree.MinDepth(root);

            Assert.Equal(0, result);
        }

        // Test for a tree with varying depths
        [Fact]
        public void Test_MultipleNodesWithVaryingDepths()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);

            int result = Btree.MinDepth(Btree.Root);

            Assert.Equal(2, result);
        }

        // Another test for a tree with greater depths
        [Fact]
        public void Test_MultipleNodesWithDeeperDepths()
        {
            BinaryTree Btree = new BinaryTree(1);

            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Left.Right.Right = new Node(6);
            int result = Btree.MinDepth(Btree.Root);
            Assert.Equal(2, result);
        }

    }
}