# Binary Tree & Binary Search Tree
This is an implementation of Binary Tree and BST. Each tree has two nodes, a left and right child node. The BST sorts according to the value.

## Space/Time Complexity
### Binary Tree PreOrder, InOrder, PostOrder
Time: O(N)

Since you have to iterate through every node, the time is O(n).

Space: O(1)

You do not have to create new nodes, so the space is O(1).

### BST Add
Time: O(log n)

The tree gets halved each time you compare values so time is O(log n).
Space: O(1)

Adds only one element so O(1), does not create a new list

### BST Search
Time: O(1)

The tree gets halved each time you compare values to search so time is O(log n).

Space: O(1)

Adds only one element so O(1), does not create a new list



## Visuals

The tree itself is like a pine cone shaped tree if you look at the root for the top. Then you have a left and right node making it a cone.

## Implementation
This was implemented with a Node that has a left and right child.

## Uses
You can probably use the BST to do a quick search for values that you need compared.