# Writing High Quality Code

## Low-level improvements

* [Code Complete] (https://en.wikipedia.org/wiki/Code_Complete)
* [Coding Standards] (https://msdn.microsoft.com/en-us/library/ff926074.aspx)
* [Naming Conventions] (https://msdn.microsoft.com/en-us/library/ms229002(v=vs.110).aspx)
* [Framework Design Guidelines] (https://msdn.microsoft.com/en-us/library/ms229042.aspx)
* [Internal Coding Guidlines] (https://blogs.msdn.microsoft.com/brada/2005/01/26/internal-coding-guidelines/)

## High-level improvements

Software design and Architecture:

* [Cohesion] (https://en.wikipedia.org/wiki/Cohesion_(computer_science))
* [Coupling] (https://en.wikipedia.org/wiki/Coupling_(computer_programming))
* [UML](https://en.wikipedia.org/wiki/Unified_Modeling_Language)
* [Solid Principles](http://www.codeproject.com/Articles/703634/SOLID-architecture-principles-using-simple-Csharp)
* [Design Patterns] (https://en.wikipedia.org/wiki/Software_design_pattern)
* [Modularity] (https://msdn.microsoft.com/en-us/library/ff921069(v=pandp.20).aspx)
* [Enterprise Application Patterns] (http://martinfowler.com/eaaCatalog/)
* [Enterprise Integration Patterns] (https://en.wikipedia.org/wiki/Enterprise_Integration_Patterns)


## Automated code analysis

* [Stylecop] (https://visualstudiogallery.msdn.microsoft.com/cac2a05b-6eb6-4fa2-95b9-1f8d011e6cae)
* [Resharper] (https://www.jetbrains.com/resharper/)
* [Just Code] (http://www.telerik.com/products/justcode.aspx)

## Process improvement
* [Code Review] (https://en.wikipedia.org/wiki/Code_review)
* [Code Refactoring](https://en.wikipedia.org/wiki/Code_refactoring)
* [Pair Programming](https://en.wikipedia.org/wiki/Pair_programming)
* [Continuous Integration](https://en.wikipedia.org/wiki/Continuous_integration)
* [Unit Testing](https://en.wikipedia.org/wiki/Unit_testing)
* [Extreme Programming](https://en.wikipedia.org/wiki/Extreme_programming)
* [Test Driven Development](https://en.wikipedia.org/wiki/Test-driven_development)

# Threads and Tasks

## Threads
* [Tutorial](http://www.albahari.com/threading/)
* Creating and starting a thread
* Thread synchronization - `lock()`
* [Volatile keyword](https://msdn.microsoft.com/en-us/library/x13ttww7.aspx)
* Background threads
* .Net desktop applications have a special UI (or main) thread that updates the UI. All Ui-related stuff should be called from it. If another thread has to update the UI it should call:
  * [Control.Invoke()](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.invoke%28v=vs.110%29.aspx) in Windows Forms
  * [Dispatcher.Invoke()](https://msdn.microsoft.com/en-us/library/system.windows.threading.dispatcher.invoke%28v=vs.110%29.aspx) in WPF

## Tasks
* [Tutorial](https://stephenhaunts.com/2014/10/10/simple-async-await-example-for-asynchronous-programming/), [another tutorial](https://msdn.microsoft.com/en-us/library/hh191443.aspx)
* Creating Tasks - `Task.Run()`
* use `await` to retrieve the Task result
* use `async` for methods that use `await`
* [Task cancellation](https://msdn.microsoft.com/en-us/library/dd997396%28v=vs.110%29.aspx)
