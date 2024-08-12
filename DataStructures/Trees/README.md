# TreeImplementation

## Problem Domain
This project includes implementations of a Binary Tree and Binary Search Tree (BST) in C#. 

### Binary Tree
- **PreOrder()**: Traverses the tree in pre-order (Root, Left, Right).
- **InOrder()**: Traverses the tree in in-order (Left, Root, Right).
- **PostOrder()**: Traverses the tree in post-order (Left, Right, Root).
- **Print()**: Displays the tree in a structured way.

### Binary Search Tree (BST)
- **Add(int data)**: Adds a node with the specified data to maintain BST properties.
- **Contains(int data)**: Checks if a node with the specified data exists in the tree.
- **Remove(int data)**: Removes the node with the specified data while maintaining BST properties.

## Example
```csharp
var bst = new BinarySearchTree();
bst.Add(10);
bst.Add(5);
bst.Add(15);
bst.Add(7);

bool contains = bst.Contains(7); // contains: true

bst.Remove(5);

contains = bst.Contains(5); // contains: false
