# More C# features

Before we continue with more advanced OOP, we'll explore some more useful C# features

## Extension methods

[Extension methods](http://csharp.net-tutorials.com/csharp-3.0/extension-methods/) give us a way to extend the functionality of an existing class by defining methods which can be used as if they are part of the class. The most important things to remember when defining them are:
* The class they are defined in is statis
* The extension methods are static
* The argument for the extended class is prefixes with the keyword this

## Nullable types

[Nullable types](https://msdn.microsoft.com/en-us/library/1t3y8s4s.aspx) (also see [here](http://stackoverflow.com/questions/13238059/what-is-nullable-type-in-c)). As we know value types are stored in the application stack and always have a value. With nullable types we can make them behave like reference types and accept null values. All nullable types are represented by the struct [Nullable\<T>](https://msdn.microsoft.com/en-us/library/b3h38hb0%28v=vs.110%29.aspx)
```csharp
int? a = null;
if(a != null)
{
  Console.Writeline(a.Value);
}
```

## More builtin interfaces

We already came across some of the builtin .Net interfaces (e.g. [IEnumerable and IEnumerator](https://msdn.microsoft.com/en-us/library/system.collections.ienumerable%28v=vs.110%29.aspx) that give us the ability to iterate a collection with a foreach loop). There are many more useful builtin interfaces. This time we'll explore `IList` and `IComparer`
* All .Net collections that can directly access their elements by index implement [IList\<T>](https://msdn.microsoft.com/en-us/library/5y536ey6%28v=vs.110%29.aspx). Such collections are `List<T>` and the simple arrays `T[]`
* [IComparer\<T>](https://msdn.microsoft.com/en-us/library/8ehhxeaf%28v=vs.110%29.aspx) is used by many .Net algorithms to define a way to compare two objects and check which one is greater. For example in a sorting algorithm we may want to sort a number sequence so that the even ones are before the odd ones. In this case we pass a custom object of type `IComparer` to the sort algorithm.
