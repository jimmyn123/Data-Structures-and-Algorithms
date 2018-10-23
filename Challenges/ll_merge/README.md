# Queue with Stacks
Using two stacks, emulate a 
## Challenge
Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
Big O time: O(N)
Since we will iterate through the both linked lists until one is null, the time is O(n) because it scales with the number of items in the list
Big O space: O(1)
We will just search the linked list so we don't create any new items that will take up space

## Solution
![LL merge whiteboard picture](../../assets/ll_merge.jpg).