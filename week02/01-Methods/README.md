# Problems which involve writing methods in C# #

## Reverse a string

Write a method which takes a List<int> as an argument
and reverses it internally.

`void ReverseList(List<int> list)`

The reversed result should be stored inside the same list instance.

## Inflate a rectangle

Write a method which takes a rectangle as an argument and
inflates it with the specified size in all directions.
This means that if you get a rectangle (x:0,y:0,w:10,h:10) and inflate
it with a size of (2,2), the resulting rectangle should be
(x:-2,y:-2,w:14,h:14). Use the ref keyword to store the result in
the same variable.

`void Inflate(ref Rectangle rect, Size inflateSize)`

`Note:` Rectangle and Size are structs defined in the System.Drawing assembly.

## Search in a list

Write a method which takes a list of strings as an argument and a
string to search for. If any of the strings in the list contains
the searched string (as a substring), the method should return
`true`. Otherwise it should return `false`. The first index
of a string which contains the searched one should be stored
in the `out` parameter.

`bool TryFindSubstring(List<string> list, string searched, out foundIndex)`

## Joining strings

Write a method which takes an arbitrary number of strings and joins them
using the specified separator.

`string JoinStrings(string separator, params string[] strings)`

## Factorial generator

Write a method which generates all the factorials of the integers up to n.
Use the yield operator.

`IEnumerable<int> GenerateFactorials(int n)`

## Directory traversal

Write a method which iterates through the contents of a directory
and the contents of all its subdirectories. Use the yield operator
to return the name of each entry and sub-entry.

`IEnumerable<string> IterateDirectory(DirectoryInfo dir)`

* [How to create DirectoryInfo](https://msdn.microsoft.com/en-us/library/system.io.directoryinfo.directoryinfo%28v=vs.110%29.aspx)
* [DirectoryInfo methods](https://msdn.microsoft.com/en-us/library/system.io.directoryinfo%28v=vs.110%29.aspx)

`Hint`: use the GetDirectories method to get all subdirectories and the
GetFiles method to get all files in a directory.