# Graph
This is an implementation of graph. It adds vertices and connects edges in between them with a weight.

## Space/Time Complexity

### Add Vertex
Time: O(1)
This adds one vertex to the dictionary, it doesn't iterate through anything.
Space: O(1)
We are only creating one new vertex and adding to the dictionary.

### Add Edge
Time: O(1)
Adding an edge is just adding a weight into the dictionary with two vertices as the key. This is instant.
Space: O(1)
You are only adding one edge.

### Get Vertices
Time: O(1)
This returns a list of the keys, the time is one.
Space: O(n)
A new list is created from the list of keys.

### Size
Time: O(1)
This just reutrns the adjacency list's size. This is constant.
Space: O(1)
It does not create anything new, it just returns an integer.

## Implementation
This was implemented with a vertex class that is used to be inserted inside the graph. The vertex contains an object.

## Uses
Graphs are used to represent the connections between objects. This includes social media networks, traffic maps, maps in general and even air traffic.