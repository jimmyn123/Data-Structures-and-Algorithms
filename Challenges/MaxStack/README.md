# GetMax stack
A stack that returns the max integer value in a stack.

## Challenge
Implement a GetMax method that returns the max value of an integer stack.

## Approach & Efficiency

Big O time: O(1)
Since you create a property that always keeps track of the max property, all you have to do is return that. That is O(1) constant time since you do not iterate through anything. This does however change the pop method to become O(n) from O(1). That is because each time you pop, you could be popping the max, therefore you need to iterate through the list again to find a new max.
Big O space: O(1)
We aren't creating any new objects. We are using the same nodes we had before therefore space is O(n).