# Remove Duplicate Nodes from a Linked List

## Problem Domain

Use the existing linked list implementation to add a new method, `RemoveDuplicate()`, that removes duplicate nodes from the linked list.

## Example

### Input
- 5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null
### Output
- 5 -> 20 -> 10 -> Null

### Input
- 1 -> 2 -> 3 -> 2 -> 4 -> 3 -> Null
### Output
- 1 -> 2 -> 3 -> 4 -> Null

### Input
- 7 -> 7 -> 7 -> 7 -> Null
### Output
- 7 -> Null

## Edge Cases

- The list is empty (Head is null).
- The list contains only one node.
- All nodes in the list are duplicates.
- There are no duplicates in the list.

## Algorithm

1. **Initialize**: Start from the head node.
2. **Outer Loop**: Traverse the list with a pointer `current`.
3. **Inner Loop**: For each node pointed to by `current`, use another pointer `index` to traverse the rest of the list.
4. **Check for Duplicates**: If `index.next.data` is equal to `current.data`, adjust the `next` pointer of the node before the duplicate to skip over it.
5. **Continue Traversal**: Move the `index` pointer to the next node.
6. **Update Current**: Move the `current` pointer to the next node.
7. **Return**: Return the modified list.

## Complexity Analysis

- **Time Complexity**: O(n^2), where n is the number of nodes in the list. This is because for each node, we traverse the remaining list to check for duplicates.
- **Space Complexity**: O(1), as no additional data structures are used.


