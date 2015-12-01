# Week03 - Introduction to Object Oriented Programming

This week we will get familiar with the basic OOP concepts in .Net and C#.

## Introduction to OOP

* [OOP in general](https://www.youtube.com/watch?v=lbXsrHGhBAU)
* [OOP on MSDN](https://msdn.microsoft.com/en-us/library/dd460654.aspx)
* [Introduction to OOP](http://www.codeproject.com/Articles/22769/Introduction-to-Object-Oriented-Programming-Concep)

## Value and reference types, classes and structs

* [Value and reference types](https://msdn.microsoft.com/en-us/library/4d43ts61%28v=vs.90%29.aspx)
* [Classes and structs](http://stackoverflow.com/questions/13049/whats-the-difference-between-struct-and-class-in-net/13275#13275)
* [Classes](https://msdn.microsoft.com/en-us/library/x9afc042.aspx)
* [Structs](https://msdn.microsoft.com/en-us/library/saxz13w4.aspx)
* [Objects](https://msdn.microsoft.com/en-us/library/ms173110.aspx)

## More on classes in .Net

* [Constructors](https://msdn.microsoft.com/en-us/library/ms173115.aspx)
* [Access modifiers](https://msdn.microsoft.com/en-us/library/wxh6fsc7.aspx)
* [The Object type](https://msdn.microsoft.com/en-us/library/system.object.aspx) - all .net objects inherit it and its methods. Most important methods - `ToString()`, `GetHashCode()`, `Equals()`
  * When overriding 'Equals()' and overloading operator==, always override `GetHashCode()` if you intend to use the class as a key in a Dictionary, otherwise you'll get unexpected results: [Why is it important to override GetHashCode() when Equals() method is overriden](http://stackoverflow.com/questions/371328/why-is-it-important-to-override-gethashcode-when-equals-method-is-overridden/371348#371348)
* Properties and Indexers
  * [Properties](https://msdn.microsoft.com/en-us/library/65zdfbdt.aspx)
  * [Indexers](https://msdn.microsoft.com/en-us/library/2549tw02.aspx)
  * [Choosing Between Properties and Methods](https://msdn.microsoft.com/library/ms229054%28v=vs.100%29.aspx)
* [.Net equality](http://www.codeproject.com/Articles/18714/Comparing-Values-for-Equality-in-NET-Identity-and) - `Equals()` vs `ReferenceEquals()` vs `==`
* [Operator overloading](http://www.codeproject.com/Articles/178309/Operator-Overloading-in-C-NET)
* [Static members](https://msdn.microsoft.com/en-us/library/aa645629%28v=vs.71%29.aspx)

## Other

* [Namespaces](https://msdn.microsoft.com/en-us/library/dfb3cx8s.aspx)
* [Enums](https://msdn.microsoft.com/en-us/library/sbbt4032.aspx)
