# Hashtable
This is an implementation of a hash table. It hashes a key and then puts them into "buckets" on the table.
## Space/Time Complexity
### Add
Time: O(n)
The time complexity is O(n) as in the worst case, every value is a new key value pair that is hashed into the same bucket.
Space: O(1)
We are only creating one new node and attaching it.

### Find
Time: O(n)
The time complexity is O(n) because it may have to iterate through every key value and still not find it.
Space: O(1)
You are working with only key values that are already in the datastructure.

### Contains
Time: O(n)
The time is the same as the find because it utilizes the find function.
Space: O(1)
Nothing new is created.

### GetHash
Time: O(n)
This depends on the characters in the key to hash. If there are n characters, it will loop n times.
Space: O(1)
It does not create anything new, it just returns an integer after manipulating it.

## Visuals

## Implementation
This was implemented with a Node that has a next. The root of the node is contained in a "bucket" which is an index of an array.

## Uses
Hashtables are fast. If you need quick access to something similar to 