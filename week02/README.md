# Week02 - methods, C# specific types, source control systems #

During the second week you'll get acquainted with the C# specific ways of defining
methods and passing arguments, some of the core framework types as well as the
most commonly used source control systems - git and TFS.

## Methods in C# ##

* [Defining methods in C#](http://www.tutorialspoint.com/csharp/csharp_methods.htm)
* [Value and reference types](https://msdn.microsoft.com/en-us/library/4d43ts61%28v=vs.90%29.aspx)
* Passing arguments
  * [`ref` keyword](https://msdn.microsoft.com/en-us/library/14akc2c7.aspx)
  * [`out` keyword](https://msdn.microsoft.com/en-us/library/t3c3bfhx.aspx)
  * [`params` keyword](https://msdn.microsoft.com/en-us/library/w5zay9db.aspx)
* Recursion and yield keyword
  * [Recursion](https://www.khanacademy.org/computing/computer-science/algorithms/recursive-algorithms/a/recursion)
  * [`yield` keyword](https://msdn.microsoft.com/en-us/library/9k7k7cf0.aspx)

## Useful built-in C# types ##

* [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime%28v=vs.110%29.aspx)
  * [DateTime.Parse](https://msdn.microsoft.com/en-us/library/system.datetime.parse%28v=vs.110%29.aspx)
  * [Formatting dates](https://msdn.microsoft.com/en-us/library/8kb3ddd4%28v=vs.110%29.aspx)
  * [TimeSpan](https://msdn.microsoft.com/en-us/library/system.timespan%28v=vs.110%29.aspx)
* [CultureInfo](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo%28v=vs.110%29.aspx)
  * [CurrentCulture](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.currentculture%28v=vs.110%29.aspx)
* [String.Format()](https://msdn.microsoft.com/en-us/library/system.string.format%28v=vs.110%29.aspx)
  * [Formatting numbers](https://msdn.microsoft.com/en-us/library/dwhawy9k%28v=vs.110%29.aspx)
* TryParse/TryGet
  * [DateTime.TryParse](https://msdn.microsoft.com/en-us/library/ch92fbc1%28v=vs.110%29.aspx)
  * [Dictionary.TryGetValue](https://msdn.microsoft.com/en-us/library/bb347013%28v=vs.110%29.aspx)
* [Math](https://msdn.microsoft.com/en-us/library/system.math%28v=vs.110%29.aspx)
* [Random](https://msdn.microsoft.com/en-us/library/system.random%28v=vs.110%29.aspx)

## Working with Git

* Download and install [Git for Windows](https://git-for-windows.github.io/)
* Git resources:
 * http://guides.github.com/
 * http://scotch.io/bar-talk/git-cheat-sheet
 * http://stackoverflow.com/questions/7076164/terminology-used-by-git
 * http://git-scm.com/book/en/v2/Getting-Started-Git-Basics
 * Most commonly used commands: `add`, `commit`, `merge`, `clone`, `fetch`, `push`
* Configure Visual Studio as a merge tool for Git:
 * Open `C:\users\<username>\.gitconfig` and add the following:
 ```
[diff]
	tool = vsdiffmerge
[difftool]
	prompt = true
	keepBackup = false
[difftool "vsdiffmerge"]
	cmd = \"C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE\\vsdiffmerge.exe\" \"$LOCAL\" \"$REMOTE\" //t
	keepBackup = false
	trustexistcode = true
[merge]
	tool = vsdiffmerge
[mergetool]
	prompt = true
	keepBackup = false
[mergetool "vsdiffmerge"]
	cmd = \"C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE\\vsdiffmerge.exe\" \"$REMOTE\" \"$LOCAL\" \"$BASE\" \"$MERGED\" //m
	keepBackup = false
	trustexistcode = true
 ```

## Working with TFS
* Create a free account at [Visual Studio Online](https://www.visualstudio.com/products/visual-studio-team-services-vs) - there you can create a TFS repository to work with
* TFS resources:
 * [Getting to know TFS source control](https://www.youtube.com/watch?v=u93XS_39YAA)
 * [Exploring Team Foundation Version Control](https://msdn.microsoft.com/en-us/library/ms181280%28v=vs.90%29.aspx)
 * https://msdn.microsoft.com/en-us/Library/vs/alm/code/overview
