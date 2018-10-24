# Stack and Queue Implementation
This is an implementation of the stack and queue which lets you pop, push, peek, enqueue, and dequeue

## Space/Time Complexity
### Peek
Time: O(1)
Space: O(1)

Shows you the element that will be returned, you don't iterate through and just peek at the first element so time and space are O(1).
### Push
Time: O(1)
Space: O(1)

Adds an element on top of the stack. Same as above, O(1).

### Pop
Time: O(1)
Space: O(1)

Returns the first element of a stack. Same as above so O(1)

### Enqueue
Time: O(1)
Space: O(1)

Adds an element to the back of the queue. Same as above, O(1).
### Dequeue
Time: O(1)
Space: O(1)

Reutrns the element at the end of the queue. Same as above, O(1).

## Visuals

A stack is a Last In First Out data structure. To picture the visual, you can take a look at a pancake. You pile pancakes on top of each other with the latest made on top. You can eat each pancake one at a time from the top all the way to the bottom.

A queue is a First In First Out data structure. You can picture a queue as a line to get into a club. The first person to arrive will be the first person to get in. Everything that arrives after lines up after and gets in after.

## Implementation
Both the stack and the queue were implemented using a Node. This node has a link to the next node. In a stack, the first node is the "top", which will get popped. Any new nodes added is added as the "top."

In a queue, there are front and rear nodes. The front node is the first in and will get "Dequeued". The rear node is the latest added, which was "enqueued".

## Uses
A common use for the stack is the callstack. That is, each call of a method gets place on a stack. Each subsequent call gets placed on top of that stack. Once the method resolves, the method is popped off and control returns to the method underneath.
A queue can be used is a line, so inside a method itself, if a command is called, it must wait for the previous commands to execute before executing itself. Declaring variables first then using them in that order.