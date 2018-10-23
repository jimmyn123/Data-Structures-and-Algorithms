# Queue With Stacks
A queue built using only stacks
## Challenge
Emulate a queue's enqueue and dequeue using only stack operations.

## Approach & Efficiency

Big O Enqueue time: O(1)
Since you are only enqueueing to the rear, the time is O(1).
Big O Enqueue space: O(1)
We are only adding one element that is given to us in as in input so the space is also O(1).

Big O Dequeue time: O(N)
We will have to iterate through each element in the rear to flip it into the front. That means time is O(n).
Big O Dequeue space: O(1)
The space does not grow for dequeue, we just take one out so the space is O(1)

## Solution
![LL merge whiteboard picture](../../assets/queuewithstacks.jpg).