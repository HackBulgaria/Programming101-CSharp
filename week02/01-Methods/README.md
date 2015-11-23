# Problems which involve writing methods in C# #

## Reverse a string

Write a method which takes a List<int> as an argument
and reverses it internally.

void ReverseList(List<int> list);

The reversed result should be stored inside the same list.

## Inflate a rectangle

void Inflate(ref Rectangle rect, Size inflateSize);

## Search in a list

Write a method which takes a list of strings as an argument and a
string to search for. If any of the strings in the list contains
the searched string (as a substring) the method should return
`true`. Otherwise it should return `false`. The first index
of a string which contains the searched one should be stored
in an `out` parameter.

bool TryFindSubstring(List<string> list, string searched, out foundIndex);

## Joining strings

Write a method which takes an arbitrary number of strings and joins them
using the specified separator.

string JoinStrings(string separator, params string[] strings);

## Write a method which generates all the factorials of the integers up to n.
Use the yield operator.

## Write a method which displays the contents of a directory
and the contents of all its subdirectories. Use the yield operator