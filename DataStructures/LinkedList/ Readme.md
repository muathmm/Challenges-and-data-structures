# Linked List Implementation

## Overview

This implementation of a singly linked list in C# supports basic operations such as checking for the inclusion of a value, removing a node by value, and printing the list.

## Algorithm Steps

### Includes(int data)

1. **Initialize**: Start from the head node.
2. **Traverse**: Loop through the list until the end.
3. **Check Data**: If the current node's data matches the target data, print that the data exists and return true.
4. **End of List**: If the loop ends without finding the data, print that the data does not exist and return false.

### Remove(int data)

1. **Initialize**: Start from the head node.
2. **Check Head**: If the head node's data matches the target data, update the head to the next node and return true.
3. **Traverse**: Loop through the list until the end.
4. **Check Data**: If a node's data matches the target data, update the previous node's next reference to the current node's next reference and return true.
5. **End of List**: If the loop ends without finding the data, print that the data does not exist and return false.

### PrintList()

1. **Initialize**: Start from the head node.
2. **Traverse**: Loop through the list until the end.
3. **Collect Data**: Collect each node's data into a result string.
4. **Return Result**: Return the result string.

## Complexity Analysis

- **Includes(int data)**:
  - **Time Complexity**: O(n), where n is the number of nodes in the list.
  - **Space Complexity**: O(1).

- **Remove(int data)**:
  - **Time Complexity**: O(n), where n is the number of nodes in the list.
  - **Space Complexity**: O(1).

- **PrintList()**:
  - **Time Complexity**: O(n), where n is the number of nodes in the list.
  - **Space Complexity**: O(1).


## Example

### Creating and Manipulating the List

```csharp
LinkedList list = new LinkedList();
list.Includes(5); // Output: the data :5 does not exists in the linked list
list.PrintList(); // Output: Null

list.Add(5);
list.Add(10);
list.Add(20);
list.Add(30);

list.PrintList(); // Output: Head -> 5 -> 10 -> 20 -> 30 -> Null

list.Remove(10);
list.PrintList(); // Output: Head -> 5 -> 20 -> 30 -> Null
