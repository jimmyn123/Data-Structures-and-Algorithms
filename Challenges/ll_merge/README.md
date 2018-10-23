# Queue with Stacks
This is a queue that is implemented using two stacks
## Challenge
Using two stacks, emulate the enqueue and dequeue operations of a queue.

## Approach & Efficiency
Enqueue Big O time: O(1)
We just add to the rear stack, this is O(1)

Dequeue Big O time: O(n)
We have to iterate through the rear and pop/push it into the front, that is through n elements so the big O time is O(n)

Big O space: O(1)
We will just manipulate the nodes of a list, we do not make a new list

## Solution
![LL merge whiteboard picture](../../assets/queuewithstacks.jpg).