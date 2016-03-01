# Linear data structures and traversal algorithms

## Linear data structures

Linear data structures represent sequences of elements which are processed
in a certain order.

### List (sometimes called Vector or Dynamic array)

You are already familiar with the List structure. It allows:

* Inserting an element at an arbitrary position
* Deleting an element at an arbitrary position
* Getting the element at an arbitrary position

### [Stack](https://en.wikipedia.org/wiki/Stack_%28abstract_data_type%29)

The Stack is a linear data structure, all operations on which are performed
at the end of the sequence called the `top` or the `peek` of the stack.
It supports the following operations:

* Push an element to the top
* Pop an element from the top
* Get the element at the top

The latest pushed element will be the first to be popped and therefore
we say that the Stack is a Last-In-First-Out (LIFO) structure.

C# has a standard implementation of the structure in the Stack<T> class.

### [Queue](https://en.wikipedia.org/wiki/Queue_%28abstract_data_type%29)

The Queue is a linear data structure, operations on which are performed
at the both ends of the sequence (the from is called the `head` the back is called the `tail`).
It supports the following operations:

* Push an element at the back (enqueue)
* Pop an element from the from (dequeue)
* Get the element at the from

The first pushed element will be the first to be popped and therefore
we say that the Queue is a First-In-First-Out (FIFO) structure.

C# has a standard implementation of the structure in the Queue<T> class.

## Graphs and traversal algorithms

### [Graphs](https://en.wikipedia.org/wiki/Graph_theory)

Graphs are abstract data structures which represent multiple relationships between multiple objects.
Usually the objects are called `nodes` and the relationships `edges`. If we go back to the
[Panda Social Network]() task, you can look at the Panda objects as `nodes` and the friendship between
any two of them as edges. Edges in graphs always connect exactly two nodes, and therefore a graph may
be looked at as a set of nodes V and a set of pair of nodes E in which each pair contains two nodes from V.

### [Graph representations](https://en.wikipedia.org/wiki/Graph_%28abstract_data_type%29#Representations)

These are the 3 most commonly used structures which represent graphs in memory. The most convenient structure for
traversing graphs is the `adjacency list`. For each node it keeps the list of its adjacet nodes (called neighbours).
In Panda terms, the structure would say: 

* Panda A has pandas B,D,F as friends
* Panda B has pandas A,F as friends
* Panda D has pandas A as friends
* Panda F has pandas A,B as friends

### Graph traversal

To traverse a graph means to iterate through all of its nodes. This is often needed to test
the graph for certain properties (e.g. if two Pandas are connected through friends of friends).
Since nodes in graphs have multiple neighbours, we must establish certain order of traversal.

### [Depth first search](https://en.wikipedia.org/wiki/Depth-first_search)

DFS starts from an initial node, gets its first neighbour, then gets the first neighbour of that neighbour and
continues to get deeper into the neighbouring tree. The second neighbour of the initial node will be traversed when
the whole subgraph starting from the first neighbour is already traversed

DFS uses the Stack structure to keep track of the nodes. The algorithm steps are as follows:

* Push the initial node to the stack
* While the stack is not empty
  * Pop the top node from the stack
  * Push to the stack all its neighbours which have not been traversed yed 
  * When pushing an element to the stack, mark it as traversed

Here is a nice [visualization](https://www.cs.usfca.edu/~galles/visualization/DFS.html) of the algorithm.

### [Breadth first search](https://en.wikipedia.org/wiki/Breadth-first_search)

BFS starts from an initial node, then traverses all of its direct neighbours, then traverses all the neighbours of
the first neighbour, all the neighbours of the second neighbour, etc. The nodes which are closer to the initial
node will be traversed first.

BFS uses the Queue structure to keep track of the nodes. The algorithm steps are as follows:

* Enqueue the initial node to the queue
* While the queue is not empty
  * Dequeue the first node from the queue
  * Add to the queue all its neighbours which have not been traversed yed 
  * When adding an element to the queue, mark it as traversed

Here is a nice [visualization](https://www.cs.usfca.edu/~galles/visualization/BFS.html) of the algorithm.
