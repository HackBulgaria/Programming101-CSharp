## Linked List

We'll implement [Linked List data structure](https://www.cs.cmu.edu/~adamchik/15-121/lectures/Linked%20Lists/linked%20lists.html). For this purpose create a separate Class Library project LinkedList.

* Create a generic class `LinkedList<T>`
* Inside the class `LinkedList<T>` create a private nested class `Node`. For info on nested classes read [here](https://msdn.microsoft.com/en-us/library/ms173120.aspx) and [here](https://msdn.microsoft.com/en-us/library/s9f3ty7f%28v=vs.71%29.aspx)
  * In `Node` create a property `Value` of type `T`
  * In `Node` create a property `Next` of type `Node` for the next node in the list. Every node will point to the next one, only the last node won't point to anything
* In `LinkedList` create a property Head of type `Node` - it will contain the head of the list
* For the class `LinkedList` implement the operations (see the article above for details):
  * `Add(T value)` - adds element to the end of the list
  * `InsertAfter(T key, T value)` - adds an element after the specified element key
  * `InsertBefore(T key, T value)` - adds an element before the specified element key
  * `InsertAt(int index, T value)` - adds an element at the specified index
  * `Remove(T value)` - deletes the first occurence of the specified element
  * `RemoveAt(int index)` - removes the element at the specified index
  * `Clear()` - clears the elements of the list
  * Property `Count` for the cumber of elements in the list
  * Indexer `T this[int]` - gets or sets the value of the n-th element
* We should be able to iterate the `LinkedList` class with a for-loop. Hint: See [IEnumerable](https://msdn.microsoft.com/en-us/library/system.collections.ienumerable%28v=vs.110%29.aspx) and [foreach](https://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx)

After creating the linked list class library, create a Console Application that demonstrates it with various data types.
For example:

```csharp
var list = new LinkedList<string>();
list.Add("x");
list.Add("g");
list.Add("s");

Console.WriteLine(list.Count); //output: 3

list.InsertAfter("g", "a");
list.InsertAt(10, "z"); //throws an exception - IndexOutOfRangeException
list.InsertAt(2, "z");
list.Remove("z");
list[1] = "m";

foreach(string value in list)
{
 Console.WriteLine(value);
}
//output:
//x
//m
//a
//s
```

