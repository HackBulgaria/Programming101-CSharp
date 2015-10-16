Идеята е да се запознаят с най-важната част от .Net технологиите и накрая да могат да дизайннат и имплементират цялостно многослойно приложение.
С **bold** са чекпойнтите където ще могат да добавят още 1 layer към приложението.

Не съм сложил никъде сорс контрол, unit testing, mobile dev - и те може би трябва да се насложат някъде.

* Intro
	* Visual Studio
	* Difference between C# and .Net; other .Net languages
	* Overview of popular .Net technologies
		* ADO.NET, Entity Framework - working with databases
		* WPF - desktop applications
		* ASP.NET - Web Forms & MVC - web applications
		* WCF -services
	* What is a N-tier application
* C# language fundamentals
	* Syntax, language structures different from other similar languages
	* Basic collections
* Algorithm problems
* OOP
	* Common concepts
	* .Net specifics
		* Value and reference types; nullable types
		* Anonymous types
		* etc
	* Into the .Net core library
		* More into collections
		* Common interfaces - IEnumerable, IDisposable etc (why foreach statement works)
* Generics
* LINQ
	* Play with the .net collections
* **Here using OOP we can create a simple 2 tier application - business layer + a console interface**
* Relational DBs & SQL
* Working with databases in .Net
	* ADO.NET - data adapters and data readers
	* Working with DB and LINQ
	* Entity framework
* **Adding a database layer to our N-tier application**
* WPF - creating desktop applications
* **Adding a desktop interface  to our N-tier application**
* Events and delegates
	* Learn how to create and consume events manually
* Asynchronous programming
	* General concepts
	* .Net specifics
		* lock(), semaphores etc
		* Thread.Start()
		* New in .Net v4 - tasks, await mechanism
	* Put it into practice - maybe create a Tetris or Pacman game in WPF
* ASP.NET
	* Web forms
	* MVC
* Learn to work with IIS
* **Adding a web interface  to our N-tier application**
* Web services
	* Web services general concepts
	* Consume and create web services with WCF
* **Adding a web services layer to our N-tier application**
* **Final result/project - create a complete N-tier application (e.g. an online shop):**
	* **Database layer - relational db**
	* **Business layer - works with DB layer and exposes classes and interfaces to the rest of the app**
	* **ASP.NET interface layer - for the clients of the shop**
	* **WPF interface layer -administrators' panel**
		* **Doesn't communicate directly with DB - consumes a web service**
	* **WCF web service - services the admin panel**
