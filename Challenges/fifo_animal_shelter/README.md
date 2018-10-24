# FIFO Animal Shelter
An "animal" shelter that takes in Dogs and Cats.

## Challenge
Create an enqueue that will add in an animal, either a dog or a cat into the shelter.
For Dequeue, if the user prefers dog, return the dog that has been there for the longest time. Return the same for cat. For everything else, return the animal that has been in the shelter for the longest time.

## Approach & Efficiency

Big O Enqueue time: O(1)
Since you are only enqueueing to the rear, the time is O(1).
Big O Enqueue space: O(1)
We are only adding one element that is given to us in as in input so the space is also O(1).

Big O Dequeue time: O(N)
We will have to iterate through each animal to figure out if it matches the pref. If it does not, then return the first animal. That means time is O(N).
Big O Dequeue space: O(1)
The space does not grow for dequeue, we just take one out so the space is O(1)

## Solution
![LL merge whiteboard picture](../../assets/queuewithstacks.jpg).