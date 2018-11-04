# Find Max Value Binary Tree
Finds the max value of a binary tree

## Challenge
Given a binary tree, do a search on the tree to find the max value integer in the tree.

## Approach & Efficiency

Big O time: O(n)
You have to recursively go through each node. The time is O(n) depending on how many nodes you have.
Big O space: O(h)
We aren't creating any new objects, but we are creating a new frame each time we call the method recursively. That means that the space on the stack depends on the height of the tree, O(h).

## Solution
![Mult-bracket validation whiteboard picture](../../assets/maxvaluetree.jpg).